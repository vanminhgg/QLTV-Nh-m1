using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLITHUVIENWINFORM
{
    public partial class FmTacGia : Form
    {
        QLTVContext db = new QLTVContext();
        public FmTacGia()
        {
            InitializeComponent();
        }
    
        private void FmTacGia_Load(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            var query = from tg in db.TacGias
                        select new { id = tg.MaTacGia, ten = tg.TenTacGia };
            dgvTacgia.DataSource = query.Distinct().ToList();
            dgvTacgia.Columns["id"].HeaderText = "Mã Tác Giả";
            dgvTacgia.Columns["ten"].HeaderText = "Tên Tác Giả";
            dgvTacgia.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTacgia.Columns["ten"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Enabled)
                {
                    var tg = new TacGia()
                    {
                        TenTacGia = Convert.ToString(txtName.Text)
                    };

                    db.TacGias.Add(tg);
                    db.SaveChanges();
                    FmTacGia_Load(sender, e);
                    MessageBox.Show("Thêm Tác Giả Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    txtName.Enabled = false;
                }
                else
                {
                    txtName.Enabled = true;
                    txtId.Clear();
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }

 
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTacgia == null) return;
            try
            {
                if (txtName.Enabled)
                {
                    int ma = int.Parse(txtId.Text); // lấy mã ID trong txtId
                    var tacgia = db.TacGias.SingleOrDefault(tg => tg.MaTacGia == ma); // tìm tác giả có ID tương ứng
                    tacgia.TenTacGia = Convert.ToString(txtName.Text);
                    db.SaveChanges();
                    FmTacGia_Load(sender, e);
                    MessageBox.Show("Sửa Tác Giả Thành Công", "Thông Báo", MessageBoxButtons.OK);
                    txtName.Enabled = false;
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
            if (dgvTacgia == null) return;
            try
            {      
                    int ma = int.Parse(txtId.Text);
                    var tacgia = db.TacGias.SingleOrDefault(tg => tg.MaTacGia == ma);
                    db.TacGias.Remove(tacgia);
                    db.SaveChanges();
                    FmTacGia_Load(sender, e);
                    MessageBox.Show("Xóa Tác Giả Thành Công", "Thông Báo", MessageBoxButtons.OK);

                        
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTacgia_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //Lưu lại dòng dữ liệu vừa kích chọn
                DataGridViewRow row = this.dgvTacgia.Rows[e.RowIndex];
                //Đưa dữ liệu vào textbox
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                var listTimKiem = (from tg in db.TacGias
                                   where tg.TenTacGia.Contains(txtSearch.Text.ToString())
                                   select new { id = tg.MaTacGia, ten = tg.TenTacGia });

                dgvTacgia.DataSource = listTimKiem.ToList();

            }
            else
            {
                this.FmTacGia_Load(sender, e);

            }
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            FmTacGia_Load(sender, e);
        }


    }
}
