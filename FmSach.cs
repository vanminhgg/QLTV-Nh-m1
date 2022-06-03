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
    public partial class FmSach : Form
    {
        QLTVContext db = new QLTVContext();
        public FmSach()
        {
           
            InitializeComponent();
            var tg = from c in db.TacGias select c.TenTacGia;
            cbTacGia.DataSource = tg.ToList();
            var nxb = from c in db.NXBs select c.TenNXB;
            cbNXB.DataSource = nxb.ToList();
            var tl = from c in db.TheLoais select c.TenTheLoai;
            cbTheloai.DataSource = tl.ToList();
        }

        private void FmSach_Load(object sender, EventArgs e)
        {
  
            txtId.Clear();
            txtName.Clear();
            txtNamXB.Clear();
            txtSoluong.Clear();
            var listSach = (from sach in db.Saches select new { Id = sach.MaSach, Name = sach.TenSach, Tacgia = sach.TacGia.TenTacGia,Nxb = sach.NXB.TenNXB,
                Theloai = sach.TheLoai.TenTheLoai, Namxb = sach.NamXB, Soluong = sach.SoLuong }).ToList();
            dgvSach.DataSource = listSach.Distinct().ToList();

            dgvSach.Columns["Id"].HeaderText = "Mã sách";
            dgvSach.Columns["Name"].HeaderText = "Tên sách";
            dgvSach.Columns["Tacgia"].HeaderText = "Tên tác giả";
            dgvSach.Columns["Nxb"].HeaderText = "Tên NXB";
            dgvSach.Columns["Theloai"].HeaderText = "Tên thể loại";
            dgvSach.Columns["Namxb"].HeaderText = "Năm xuất bản";
            dgvSach.Columns["Soluong"].HeaderText = "Số lượng";

            dgvSach.Columns["Id"].Width = 50;
            dgvSach.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSach.Columns["Tacgia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSach.Columns["Nxb"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSach.Columns["Theloai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvSach.Columns["Namxb"].Width = 60;
            dgvSach.Columns["Soluong"].Width = 60;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {           
            try
            {
                if (txtName.Enabled)
                {
                    var matg = db.TacGias.SingleOrDefault(tg => tg.TenTacGia == cbTacGia.Text);
                    var manxb = db.NXBs.SingleOrDefault(tg => tg.TenNXB == cbNXB.Text);
                    var matl = db.TheLoais.SingleOrDefault(tg => tg.TenTheLoai == cbTheloai.Text);
                    var sach = new Sach()
                    {
                        TenSach = txtName.Text.ToString(),
                        MaTacGia = matg.MaTacGia,
                        MaNXB = manxb.MaNXB,
                        MaTheLoai = matl.MaTheLoai,
                        NamXB = Convert.ToInt32(txtNamXB.Text),
                        SoLuong = Convert.ToInt32(txtSoluong.Text),

                    };
                    db.Saches.Add(sach);
                    db.SaveChanges();
                    FmSach_Load(sender, e);
                    MessageBox.Show("Thêm sách mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtName.Enabled = false;
                    cbTacGia.Enabled = false;
                    cbNXB.Enabled = false;
                    cbTheloai.Enabled = false;
                    txtNamXB.Enabled = false;
                    txtSoluong.Enabled = false;
                }
                else
                {
                    txtId.Clear();
                    txtName.Clear();
                    txtNamXB.Clear();
                    txtSoluong.Clear();
                    txtName.Enabled = true;
                    cbTacGia.Enabled = true;
                    cbNXB.Enabled = true;
                    cbTheloai.Enabled = true;
                    txtNamXB.Enabled = true;
                    txtSoluong.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }

        }

        private void dgvSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSach.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                cbTacGia.Text = row.Cells[2].Value.ToString();
                cbNXB.Text = row.Cells[3].Value.ToString();
                cbTheloai.Text = row.Cells[4].Value.ToString();
                txtNamXB.Text = row.Cells[5].Value.ToString();
                txtSoluong.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Enabled)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    var sach = db.Saches.SingleOrDefault(i => i.MaSach == id);
                    sach.TenSach = txtName.Text.ToString();
                    sach.MaTacGia = Convert.ToInt32(cbTacGia.SelectedIndex)+1;
                    sach.MaNXB = Convert.ToInt32(cbNXB.SelectedIndex)+1;
                    sach.MaTheLoai = Convert.ToInt32(cbTheloai.SelectedIndex)+1;
                    db.SaveChanges();
                    FmSach_Load(sender, e);
                    MessageBox.Show("Cập nhập Sách thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtName.Enabled = false;
                    cbTacGia.Enabled = false;
                    cbNXB.Enabled = false;
                    cbTheloai.Enabled = false;
                    txtNamXB.Enabled = false;
                    txtSoluong.Enabled = false;
                }
                else
                {
                    txtName.Enabled = true;
                    cbTacGia.Enabled = true;
                    cbNXB.Enabled = true;
                    cbTheloai.Enabled = true;
                    txtNamXB.Enabled = true;
                    txtSoluong.Enabled = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtId.Text);
                var sach = db.Saches.SingleOrDefault(i => i.MaSach == id);
                db.Saches.Remove(sach);
                db.SaveChanges();
                FmSach_Load(sender, e);
                MessageBox.Show("Xoá Sách thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                var listTimKiem = (from sach in db.Saches
                                   where sach.TenSach.Contains(txtSearch.Text.ToString())
                                   select new { Id = sach.MaSach, Name = sach.TenSach, Tacgia = sach.TacGia.TenTacGia, Nxb = sach.NXB.TenNXB, Theloai = sach.TheLoai.TenTheLoai, Namxb = sach.NamXB, Soluong = sach.SoLuong }).ToList();

                dgvSach.DataSource = listTimKiem.Distinct().ToList();

            }
            else
            {
                this.FmSach_Load(sender, e);

            }
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            FmSach_Load(sender, e);
        }
    }
}
