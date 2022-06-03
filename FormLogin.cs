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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        QLTVContext db = new QLTVContext();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(txbUsername.Text) && String.IsNullOrWhiteSpace(txbPassword.Text))
                {
                    MessageBox.Show("Ô nhập không có thông tin!", "Lỗi nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (rbtnDocgia.Checked)
                {
                    int id = Convert.ToInt32(txbUsername.Text);
                    var the = db.Thes.Where(i => i.MaThe == id).Count();
                    if(the == 1)
                    {
                        AppDocGia app = new AppDocGia(txbUsername.Text);
                        app.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Mã thẻ không tồn tại!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rbtnDocgia.Checked = true;
                        txbUsername.Clear();
                    }
                }
                if (rbtnNhanvien.Checked)
                {
                    string usrname = txbUsername.Text;
                    string pass = txbPassword.Text;
                    var acc = db.TaiKhoans.Where(i => usrname == i.TenDangNhap && pass == i.MatKhau).Count();
                    if(acc == 1)
                    {
                        FmMain fmMain = new FmMain();
                        fmMain.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        rbtnNhanvien.Checked = true;
                        txbUsername.Clear();
                        txbPassword.Clear();
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void rbtnDocgia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDocgia.Checked)
            {
                txbUsername.Text = "Nhập mã thẻ";
                txbUsername.Visible = true;
                txbPassword.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                rbtnDocgia.Checked = true;
                panel2.Visible = true;
                panel3.Visible = false;
            }
            if (rbtnNhanvien.Checked)
            {
                txbUsername.Text = "Nhập tên đăng nhập";
                txbPassword.Text = " Nhập mật khẩu";
                txbUsername.Visible = true;
                txbPassword.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                rbtnNhanvien.Checked = true;
                panel2.Visible = true;
                panel3.Visible = true;
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            txbUsername.Text = "Nhập mã thẻ";
            txbUsername.Visible = true;
            txbPassword.Visible = false;
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            rbtnDocgia.Checked = true;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txbPassword_Click(object sender, EventArgs e)
        {
            txbPassword.PasswordChar = '*';
            txbPassword.Clear();
        }

        private void txbUsername_Click(object sender, EventArgs e)
        {
            txbUsername.Clear();
        }
    }
}
