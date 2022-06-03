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
    public partial class FmThemChiTietMuon : Form
    {
        QLTVContext db = new QLTVContext();
        public FmThemChiTietMuon()
        {
            InitializeComponent();
        }
        public string cbBoxmaThe { set { cbMathe.Text = value; } }

        private void FmThemChiTietMuon_Load(object sender, EventArgs e)
        {
            var muon = db.Muons.Max(m => m.MaMuon) ;
            txtId.Text = muon.ToString();

            var listSach = (from sach in db.Saches 
                            select new { 
                                Id = sach.MaSach,
                                Name = sach.TenSach, 
                                Tacgia = sach.TacGia.TenTacGia, 
                                Nxb = sach.NXB.TenNXB, 
                                Theloai = sach.TheLoai.TenTheLoai, 
                                Namxb = sach.NamXB, 
                                Soluong = sach.SoLuong });
            dgvSach.DataSource = listSach.Distinct().ToList();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                var listTimKiem = (from sach in db.Saches
                                   where sach.TenSach.ToString().Contains(txtSearch.Text)
                                   select new
                                   {
                                       Id = sach.MaSach,
                                       Name = sach.TenSach,
                                       Tacgia = sach.TacGia.TenTacGia,
                                       Nxb = sach.NXB.TenNXB,
                                       Theloai = sach.TheLoai.TenTheLoai,
                                       Namxb = sach.NamXB,
                                       Soluong = sach.SoLuong
                                   });
                dgvSach.DataSource = listTimKiem.Distinct().ToList();
            }
            else
            {
                this.FmThemChiTietMuon_Load(sender, e);
            }
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvSach.Rows.Count; i++)
                {
                    bool isCellChecked;
                    if (dgvSach.Rows[i].Cells[0].Value == null) isCellChecked = false;
                    else isCellChecked = (bool)(dgvSach.Rows[i].Cells[0].Value);
                    if (isCellChecked == true)
                    {
                        var ctMuon = new ChiTietMuon()
                        {
                            MaMuon = Convert.ToInt32(txtId.Text),
                            MaSach = Convert.ToInt32(dgvSach.Rows[i].Cells[1].Value),
                            DaTra = 0,
                            NgayHetHan = dtp_ngayTra.Value,
                        };
                        db.ChiTietMuons.Add(ctMuon);
                        db.SaveChanges();
                    }
                }
                MessageBox.Show("Mượn thành công !!!");
                this.Hide();
                FmMuon fmMuon = new FmMuon();
                fmMuon.Show();
            }
            catch(Exception err)
            {
                MessageBox.Show("Lỗi!!! " + err);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txtId.Text);
            var muon = db.Muons.SingleOrDefault(m => m.MaMuon == ma);
            db.Muons.Remove(muon);
            db.SaveChanges();
            this.Hide();

            FmMuon fmMuon = new FmMuon();
            fmMuon.Show();
        }
    }
}
