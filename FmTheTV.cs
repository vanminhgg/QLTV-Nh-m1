using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLITHUVIENWINFORM
{
    public partial class FmTheTV : Form
    {
        QLTVContext db = new QLTVContext();


        public FmTheTV()
        {
            InitializeComponent();
        }

        private void FmTheTV_Load(object sender, EventArgs e)
        {
            txtId.Clear();
            txtGhichu.Clear();

            var listThe = from The in db.Thes
                         select new { Id = The.MaThe, timeStart = The.NgayBatDau , timeStop = The.NgayKetThuc, note = The.GhiChu, idDG = The.DocGia.TenDG};
            dgvThe.DataSource = listThe.ToList();

            dgvThe.Columns["Id"].HeaderText = "Mã Thẻ";
            dgvThe.Columns["timeStart"].HeaderText = "Ngày bắt đầu";
            dgvThe.Columns["timeStop"].HeaderText = "Ngày kết thúc";
            dgvThe.Columns["note"].HeaderText = "Ghi Chú";
            dgvThe.Columns["idDG"].HeaderText = "Tên Độc Giả";

            dgvThe.Columns["Id"].Width = 50;
            dgvThe.Columns["timeStart"].Width = 135;
            dgvThe.Columns["timeStop"].Width = 135;
            dgvThe.Columns["note"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvThe.Columns["idDG"].Width = 120;

            cbID.DataSource = (from dg in db.DocGias select dg.MaDG).Distinct().ToList();
            cbTen.DataSource = (from dg in db.DocGias select dg.TenDG).Distinct().ToList();
        }

        private void dgvThe_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                DataGridViewRow row = dgvThe.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                dtpBD.Value = DateTime.Parse(row.Cells[1].Value.ToString());
                dtpKT.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                if (row.Cells[3].Value != null) txtGhichu.Text = row.Cells[3].Value.ToString();
                cbID.Text = row.Cells[4].Value.ToString();
                int id = Convert.ToInt32(cbID.Text);
                var dg = db.DocGias.SingleOrDefault(i => i.MaDG == id);
                cbTen.Text = dg.TenDG;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGhichu.Enabled)
                {
                    
                    var theTV = new The()
                    {
                        NgayBatDau = dtpBD.Value,
                        NgayKetThuc = dtpKT.Value,
                        GhiChu = txtGhichu.Text.ToString(),
                        MaDG = Convert.ToInt32(cbID.Text),  
                    };
                    db.Thes.Add(theTV);
                    db.SaveChanges();
                    FmTheTV_Load(sender, e);
                    MessageBox.Show("Thêm thẻ thư viện mới thành công !", "Thông báo", MessageBoxButtons.OK);

                    dtpBD.Value = DateTime.Now;
                    dtpKT.Value = DateTime.Now;
                    txtGhichu.Enabled = false;
                    cbID.Enabled = false;
                    cbTen.Enabled = false;
                }
                else
                {
                    FmTheTV_Load(sender, e);
                    txtGhichu.Enabled = true;
                    cbID.Enabled = true;
                    cbTen.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGhichu.Enabled)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    var the = db.Thes.SingleOrDefault(i => i.MaThe == id);
                    the.NgayBatDau = dtpBD.Value;
                    the.NgayKetThuc = dtpKT.Value;
                    the.GhiChu = txtGhichu.Text.ToString();

                    db.SaveChanges();
                    FmTheTV_Load(sender, e);
                    MessageBox.Show("Cập nhập Thẻ Thư Viện thành công !", "Thông báo", MessageBoxButtons.OK);

                    dtpBD.Value = DateTime.Now;
                    dtpKT.Value = DateTime.Now;
                    txtGhichu.Enabled = false;
                    cbID.Enabled = false;
                    cbTen.Enabled = false;
                }
                else
                {
                    txtGhichu.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xoá thẻ mang mã số " + txtId.Text + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(txtId.Text);
                    var the = db.Thes.SingleOrDefault(i => i.MaThe == id);
                    db.Thes.Remove(the);
                    db.SaveChanges();
                    FmTheTV_Load(sender, e);
                    MessageBox.Show("Xoá thẻ thư viện thành công !", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cbID.Text);
            var dg = db.DocGias.SingleOrDefault(i => i.MaDG == id);
            cbTen.Text = dg.TenDG;
        }

        private void cbTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            var ten = cbTen.Text;
            var listID = from dg in db.DocGias where dg.TenDG == ten
                         select dg.MaDG;
            cbID.DataSource = listID.ToList();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                var listTimKiem = (from The in db.Thes
                                   where The.DocGia.TenDG.Contains(txtSearch.Text.ToString())
                                   select new { Id = The.MaThe, timeStart = The.NgayBatDau, timeStop = The.NgayKetThuc, note = The.GhiChu, idDG = The.DocGia.TenDG });

                dgvThe.DataSource = listTimKiem.ToList();
            }
            else this.FmTheTV_Load(sender, e);
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            FmTheTV_Load(sender, e);
        }

 
    }
}
