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
    public partial class FmChiTietYC : Form
    {
        QLTVContext db = new QLTVContext();
        public FmChiTietYC()
        {
            InitializeComponent();
        }

        public FmChiTietYC(string mayc, string mt) : this()
        {
            string mayeucau = mayc;
            string mathe = mt;
            txtMaYC.Text = mayeucau;
            cbMathe.Text = mt;
        }

        private void FmChiTietYC_Load(object sender, EventArgs e)
        {
            var myc = Convert.ToInt32(txtMaYC.Text);
            var listsachyc = from l in db.ChiTietYeuCaus where l.MaYC == myc
                             select new
                             {
                                 mayc = l.MaYC,
                                 masach = l.MaSach,
                                 tensach= l.Sach.TenSach,

                             };
            dgvCtYeucau.DataSource = listsachyc.Distinct().ToList();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            var muon = new Muon()
            {
                MaThe = Convert.ToInt32(cbMathe.Text),
                NgayMuon = DateTime.Now,
                
            };
            db.Muons.Add(muon);
            db.SaveChanges();
            var mamuon = db.Muons.Max(m => m.MaMuon);
            var id = mamuon;
            for (int i = 0; i < dgvCtYeucau.Rows.Count; i++)
            {
                var ct = new ChiTietMuon()
                {
                    MaMuon = id,
                    MaSach = Convert.ToInt32(dgvCtYeucau.Rows[i].Cells[1].Value),
                    DaTra = 0,
                    NgayHetHan = dtp_ngayTra.Value,
                };
                db.ChiTietMuons.Add(ct);
                db.SaveChanges();
                var my = Convert.ToInt32(dgvCtYeucau.Rows[i].Cells[0].Value);
                var ms = Convert.ToInt32(dgvCtYeucau.Rows[i].Cells[1].Value);
                var ctyeucau = db.ChiTietYeuCaus.SingleOrDefault(c => c.MaYC == my && c.MaSach == ms);
                db.ChiTietYeuCaus.Remove(ctyeucau);
                db.SaveChanges();

            };
            var myc = Convert.ToInt32(txtMaYC.Text);
            var yc = db.YeuCauMuons.SingleOrDefault(y => y.MaYC == myc);
            db.YeuCauMuons.Remove(yc);
            db.SaveChanges();
            MessageBox.Show("Mượn thành công!!");
            this.Close();
            FmYeuCau fmyc = new FmYeuCau();
            fmyc.Show();
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            FmYeuCau fmyc = new FmYeuCau();
            fmyc.Show();
        }
    }
}
