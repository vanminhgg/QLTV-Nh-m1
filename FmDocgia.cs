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
    public partial class FmDocgia : Form
    {
        QLTVContext db = new QLTVContext();
        public FmDocgia()
        {
            InitializeComponent();
        }

        private void FmDocgia_Load(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtDiachi.Clear();
            txtSDT.Clear();
            txtEmail.Clear();

            var listDG = from dg in db.DocGias
                         select new { Id = dg.MaDG, name = dg.TenDG, dc = dg.DiaChi, sdt = dg.SDT, email = dg.Email };
            dgvDocgia.DataSource = listDG.ToList();

            dgvDocgia.Columns["Id"].HeaderText = "Mã Độc Giả";
            dgvDocgia.Columns["name"].HeaderText = "Tên Độc Giả";
            dgvDocgia.Columns["dc"].HeaderText = "Địa Chỉ";
            dgvDocgia.Columns["sdt"].HeaderText = "Số Điện Thoại";
            dgvDocgia.Columns["email"].HeaderText = "Email";

            dgvDocgia.Columns["Id"].Width = 50;
            dgvDocgia.Columns["name"].Width = 100;
            dgvDocgia.Columns["dc"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDocgia.Columns["sdt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvDocgia.Columns["email"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;



        }

        private void dgvDocgia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDocgia.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtDiachi.Text = row.Cells[2].Value.ToString();
                txtSDT.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Enabled)
                {
                    var dg = new DocGia()
                    {
                        TenDG = txtName.Text.ToString(),
                        DiaChi = txtDiachi.Text.ToString(),
                        SDT = txtSDT.Text.ToString(),
                        Email = txtEmail.Text.ToString()
                    };
                    db.DocGias.Add(dg);
                    db.SaveChanges();
                    FmDocgia_Load(sender, e);
                    MessageBox.Show("Thêm Độc Giả mới thành công !", "Thông báo", MessageBoxButtons.OK);
                    txtName.Enabled = false;
                    txtDiachi.Enabled = false;
                    txtSDT.Enabled = false;
                    txtEmail.Enabled = false;
                }
                else
                {
                    FmDocgia_Load(sender, e);
                    txtName.Enabled = true;
                    txtDiachi.Enabled = true;
                    txtSDT.Enabled = true;
                    txtEmail.Enabled = true;
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
                if (txtName.Enabled)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    var dg = db.DocGias.SingleOrDefault(i => i.MaDG == id);
                    dg.TenDG = txtName.Text.ToString();
                    dg.DiaChi = txtDiachi.Text.ToString();
                    dg.SDT = txtSDT.Text.ToString();
                    dg.Email = txtEmail.Text.ToString();


                    db.SaveChanges();
                    FmDocgia_Load(sender, e);
                    MessageBox.Show("Cập nhập Độc Giả thành công !", "Thông báo", MessageBoxButtons.OK);
                    txtName.Enabled = false;
                    txtDiachi.Enabled = false;
                    txtSDT.Enabled = false;
                    txtEmail.Enabled = false;
                }
                else
                {
                    txtName.Enabled = true;
                    txtDiachi.Enabled = true;
                    txtSDT.Enabled = true;
                    txtEmail.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xoá " + txtName.Text.ToString() + " ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(txtId.Text);
                    var dg = db.DocGias.SingleOrDefault(i => i.MaDG == id);
                    db.DocGias.Remove(dg);
                    db.SaveChanges();
                    FmDocgia_Load(sender, e);
                    MessageBox.Show("Xoá Độc Giả thành công !", "Thông báo", MessageBoxButtons.OK);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                var listTimKiem = (from dg in db.DocGias
                                   where dg.TenDG.Contains(txtSearch.Text.ToString())
                                   select new { Id = dg.MaDG, name = dg.TenDG, dc = dg.DiaChi, sdt = dg.SDT, email = dg.Email });

                dgvDocgia.DataSource = listTimKiem.Distinct().ToList();

            }
            else
            {
                this.FmDocgia_Load(sender, e);

            }
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            FmDocgia_Load(sender, e);
        }
    }
}
