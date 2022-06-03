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
    public partial class FmTheLoai : Form
    {
        QLTVContext db = new QLTVContext();
        public FmTheLoai()
        {
            InitializeComponent();
        }

        private void FmTheLoai_Load(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            var query = from tl in db.TheLoais
                        select new { id = tl.MaTheLoai, ten = tl.TenTheLoai };
            dgvTheLoai.DataSource = query.Distinct().ToList();
            dgvTheLoai.Columns["id"].HeaderText = "Mã Thể Loại";
            dgvTheLoai.Columns["ten"].HeaderText = "Tên Thể Loại";
            dgvTheLoai.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTheLoai.Columns["ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Enabled)
                {
                    var tl = new TheLoai()
                    {
                        TenTheLoai = Convert.ToString(txtName.Text)
                    };

                    db.TheLoais.Add(tl);
                    db.SaveChanges();
                    FmTheLoai_Load(sender, e);
                    MessageBox.Show("Thêm Thể Loại Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    txtName.Enabled = false;
                }
                else
                {
                    txtName.Enabled = true;
                    txtId.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTheLoai == null) return;
            try
            {
                if (txtName.Enabled)
                {
                    int ma = int.Parse(txtId.Text); // lấy mã ID trong txtId
                    var theloai = db.TheLoais.SingleOrDefault(tl => tl.MaTheLoai == ma); // tìm tác giả có ID tương ứng
                    theloai.TenTheLoai = Convert.ToString(txtName.Text);
                    db.SaveChanges();
                    FmTheLoai_Load(sender, e);
                    MessageBox.Show("Sửa Tên Thể Loại Thành Công", "Thông Báo", MessageBoxButtons.OK);
                }
                else
                {
                    txtName.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (dgvTheLoai == null) return;
            try
            {
                
                int ma = int.Parse(txtId.Text);
                var theLoai = db.TheLoais.SingleOrDefault(tg => tg.MaTheLoai == ma);
                db.TheLoais.Remove(theLoai);
                db.SaveChanges();
                FmTheLoai_Load(sender, e);
                MessageBox.Show("Xóa Thể Loại Thành Công", "Thông Báo", MessageBoxButtons.OK);              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
  
        }

        private void dgvTheLoai_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvTheLoai.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                var listTimKiem = (from tl in db.TheLoais
                                   where tl.TenTheLoai.Contains(txtSearch.Text.ToString())
                                   select new { id = tl.MaTheLoai, ten = tl.TenTheLoai });

                dgvTheLoai.DataSource = listTimKiem.ToList();
            }
            else
            {
                this.FmTheLoai_Load(sender, e);
            }
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            FmTheLoai_Load(sender, e);
        }
    }
}
