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
    public partial class FmNXB : Form
    {
        QLTVContext db = new QLTVContext();
        public FmNXB()
        {
            InitializeComponent();
        }

        private void FmNXB_Load(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtSearch.Clear();
            txtName.Enabled = false;
            txtId.Enabled = false;

        dgvNXB.DataSource = (from nxb in db.NXBs select new { Id = nxb.MaNXB, Name = nxb.TenNXB }).Distinct().ToList();

            dgvNXB.Columns["Id"].HeaderText = "Mã NXB";
            dgvNXB.Columns["Name"].HeaderText = "Tên NXB";
            dgvNXB.Columns["Id"].Width = 70;
            dgvNXB.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvNXB_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNXB.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Enabled)
                {
                    var nxb = new NXB()
                    {
                        TenNXB = txtName.Text.ToString()
                    };
                    db.NXBs.Add(nxb);
                    db.SaveChanges();
                    FmNXB_Load(sender, e);
                    MessageBox.Show("Thêm Nhà Xuất Bản mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtName.Enabled = false;
                }
                else
                {
                    FmNXB_Load(sender, e);
                    txtName.Enabled = true;
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
                    var nxb = db.NXBs.SingleOrDefault(i => i.MaNXB == id);
                    nxb.TenNXB = txtName.Text.ToString();
                    db.SaveChanges();
                    FmNXB_Load(sender, e);
                    MessageBox.Show("Cập nhập Nhà Xuất Bản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtName.Enabled = false;
                }
                else
                {
                    txtName.Enabled = true;
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
                    var nxb = db.NXBs.SingleOrDefault(i => i.MaNXB == id);
                    db.NXBs.Remove(nxb);
                    db.SaveChanges();
                    FmNXB_Load(sender, e);
                    MessageBox.Show("Xoá Nhà Xuất Bản thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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

                var listTimKiem = (from nxb in db.NXBs
                                   where nxb.TenNXB.Contains(txtSearch.Text.ToString())
                                   select new { Id = nxb.MaNXB, Name = nxb.TenNXB });

                dgvNXB.DataSource = listTimKiem.ToList();

            }
            else
            {
                this.FmNXB_Load(sender, e);

            }
        }

        private void ptbSearch_Click(object sender, EventArgs e)
        {
            FmNXB_Load(sender, e);
        }
    }
}
