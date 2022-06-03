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
    public partial class FmMain : Form
    {
        QLTVContext db = new QLTVContext();
        public FmMain()
        {
            InitializeComponent();
            endDate.Value = DateTime.Now.AddDays(1);

        }


        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmSach fmSach = new FmSach();
            fmSach.Show();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            var totalBook = db.Saches.Sum(s => s.SoLuong);
            label2.Text = totalBook.ToString();
            var borrowed = db.ChiTietMuons.Where(s => s.DaTra != 1).Count();
            label3.Text = (totalBook - borrowed).ToString();
            var dateExit = db.ChiTietMuons.Where(s => DateTime.Compare(today, s.NgayHetHan) > 0 && s.DaTra == 0).Count();
            label5.Text = dateExit.ToString();
            var numDocGia = db.DocGias.Count();
            label7.Text = numDocGia.ToString();
            var sachToTheLoai = (from ct in db.ChiTietMuons
                                join s in db.Saches on ct.MaSach equals s.MaSach
                                join tl in db.TheLoais on s.MaTheLoai equals tl.MaTheLoai
                                where ct.NgayTra != null
                                group tl by tl.TenTheLoai into theloai
                                select new
                                {
                                    theloai = theloai.FirstOrDefault().TenTheLoai,
                                    soluong = theloai.Count(),
                                }).ToList();
            string[] x = (from i in sachToTheLoai
                          orderby i.theloai ascending
                          select i.theloai).ToArray();
            int[] y = (from i in sachToTheLoai
                       orderby i.theloai ascending
                       select i.soluong).ToArray();
            chart1.Series[0].Points.DataBindXY(x, y);
            chart1.Legends[0].Enabled = true;


            if (startDate.Value > endDate.Value) { MessageBox.Show("Ngày bắt đầu nhỏ hơn ngày kết thúc", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            var sachMuonTheoTime = from ct in db.ChiTietMuons
                                   join m in db.Muons on ct.MaMuon equals m.MaMuon
                                   where m.NgayMuon >= startDate.Value && m.NgayMuon < endDate.Value
                                   group m by new { y = m.NgayMuon.Year, m = m.NgayMuon.Month, d = m.NgayMuon.Day } into nm
                                   select new
                                   {
                                       ngay = nm.Key.d.ToString() + "/" + nm.Key.m.ToString() + "/" + nm.Key.y.ToString(),
                                       soluong = nm.Count(),
                                   };
            string[] x1 = (from i in sachMuonTheoTime
                           orderby i.ngay ascending
                           select i.ngay).ToArray();
            int[] y1 = (from i in sachMuonTheoTime
                       orderby i.ngay ascending
                       select i.soluong).ToArray();
            chart2.Series[0].Points.DataBindXY(x1, y1);
            chart2.Legends[0].Enabled = true;
        }

        private void đọcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmDocgia fmDocgia = new FmDocgia();
            fmDocgia.Show();
        }

        private void mượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmMuon fmMuon = new FmMuon();
            fmMuon.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmTheTV fmTheTV = new FmTheTV();
            fmTheTV.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FmTTTaiKhoan fmTTTaiKhoan = new FmTTTaiKhoan();
            fmTTTaiKhoan.Show();

        }

        private void theeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmTheLoai fmTheLoai = new FmTheLoai();
            fmTheLoai.Show();
        }

        private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmTacGia fmTacGia = new FmTacGia();
            fmTacGia.Show();
        }

        private void nXBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmNXB fmNXB = new FmNXB();
            fmNXB.Show();
        }

        private void yêuCầuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmYeuCau fmYeuCau = new FmYeuCau();
            fmYeuCau.Show();
        }

        private void trảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmTra fmTra = new FmTra();
            fmTra.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void FmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void endDate_ValueChanged(object sender, EventArgs e)
        {
            this.FmMain_Load(sender, e);
        }
    }
}
