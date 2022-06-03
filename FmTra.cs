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
    public partial class FmTra : Form
    {
        QLTVContext db = new QLTVContext();
        public FmTra()
        {
            InitializeComponent();
        }

        private void btnXacnhan_Click(object sender, EventArgs e)
        {
          
                if(chbTot.Checked)
                {
                    for (int i = 0; i < dgvMuon.Rows.Count; i++)
                    {
                        bool isCellChecked;
                        if (dgvMuon.Rows[i].Cells[0].Value == null) isCellChecked = false;
                        else isCellChecked = (bool)(dgvMuon.Rows[i].Cells[0].Value);
                        if (isCellChecked == true)
                        {
                            var mm = Convert.ToInt32(dgvMuon.Rows[i].Cells[1].Value);
                            var ms = Convert.ToInt32(dgvMuon.Rows[i].Cells[2].Value);
                        var sach = db.ChiTietMuons.SingleOrDefault(c => c.MaMuon == mm && c.MaSach==ms);
                            sach.DaTra = 1;
                            sach.NgayTra = dtp_ngayTra.Value;
                            sach.TinhTrangSach = chbTot.Text;
                            db.SaveChanges();
                        }
                    }
                MessageBox.Show("Trả sách thành công!!");
                this.FmTra_Load(sender, e);
                }
                if(chbNhan.Checked)
                {
                    for (int i = 0; i < dgvMuon.Rows.Count; i++)
                    {
                        bool isCellChecked;
                        if (dgvMuon.Rows[i].Cells[0].Value == null) isCellChecked = false;
                        else isCellChecked = (bool)(dgvMuon.Rows[i].Cells[0].Value);
                        if (isCellChecked == true)
                        {
                            var mm = Convert.ToInt32(dgvMuon.Rows[i].Cells[1].Value);
                            var ms = Convert.ToInt32(dgvMuon.Rows[i].Cells[2].Value);
                        var sach = db.ChiTietMuons.SingleOrDefault(c => c.MaMuon == mm && c.MaSach==ms);
                            sach.DaTra = 1;
                            sach.NgayTra = dtp_ngayTra.Value;
                            sach.TinhTrangSach = chbNhan.Text;
                            db.SaveChanges();
                        }
                    }
                    MessageBox.Show("Trả sách thành công!!");
                    this.FmTra_Load(sender, e);
                }
                if(chbRach.Checked)
                {
                    for (int i = 0; i < dgvMuon.Rows.Count; i++)
                    {
                        bool isCellChecked;
                        if (dgvMuon.Rows[i].Cells[0].Value == null) isCellChecked = false;
                        else isCellChecked = (bool)(dgvMuon.Rows[i].Cells[0].Value);
                        if (isCellChecked == true)
                        {
                            var mm = Convert.ToInt32(dgvMuon.Rows[i].Cells[1].Value);
                            var ms = Convert.ToInt32(dgvMuon.Rows[i].Cells[2].Value);
                        var sach = db.ChiTietMuons.SingleOrDefault(c => c.MaMuon == mm && c.MaSach==ms);
                            sach.DaTra = 1;
                            sach.NgayTra = dtp_ngayTra.Value;
                            sach.TinhTrangSach = chbRach.Text;
                            db.SaveChanges();
                        }
                    }
                    MessageBox.Show("Trả sách thành công!!");
                    this.FmTra_Load(sender, e);
                }
                if(chbMat.Checked)
                {
                    for (int i = 0; i < dgvMuon.Rows.Count; i++)
                    {
                        bool isCellChecked;
                        if (dgvMuon.Rows[i].Cells[0].Value == null) isCellChecked = false;
                        else isCellChecked = (bool)(dgvMuon.Rows[i].Cells[0].Value);
                        if (isCellChecked == true)
                        {
                            var mm = Convert.ToInt32(dgvMuon.Rows[i].Cells[1].Value);
                            var ms = Convert.ToInt32(dgvMuon.Rows[i].Cells[2].Value);
                        var sach = db.ChiTietMuons.SingleOrDefault(c => c.MaMuon == mm && c.MaSach==ms);
                            sach.DaTra = 1;
                            sach.NgayTra = dtp_ngayTra.Value;
                            sach.TinhTrangSach = chbMat.Text;
                            db.SaveChanges();
                        }
                    }
                    MessageBox.Show("Trả sách thành công!!");
                    this.FmTra_Load(sender, e);
                }
                if(chbTot.Checked==false && chbNhan.Checked == false && chbRach.Checked == false && chbMat.Checked == false )
                {
                    MessageBox.Show("Vui lòng chọn tình trạng sách!!");
                }
           


        }

        private void FmTra_Load(object sender, EventArgs e)
        {
            var listthe = (from l in db.Muons select l.MaThe).Distinct().ToList();
            cbMathe.DataSource = listthe;


            /*           if(cbMathe.SelectedValue==null)
                       {
                           var listmuon = (from lm in db.Muons select lm.MaMuon).Distinct().ToList();
                           cbMamuon.DataSource = listmuon;
                       }
                       else
                       {
                           var listmuon = (from lm in db.Muons where lm.MaThe ==  select lm.MaMuon).Distinct().ToList();
                           cbMamuon.DataSource = listmuon;
                       }*/

        }

        private void cbMamuon_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mm = Convert.ToInt32(cbMamuon.Text);
            var listSach = (from sach in db.ChiTietMuons
                            where sach.MaMuon == mm && sach.DaTra==0
                            select new
                            {
                                id = sach.MaMuon,
                                masach = sach.MaSach,
                                tensach = sach.Sach.TenSach

                            });
            dgvMuon.DataSource = listSach.Distinct().ToList();
        }

        private void cbMathe_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mt = Convert.ToInt32(cbMathe.Text);
            var listmuon = (from lm in db.Muons where lm.MaThe == mt select lm.MaMuon).Distinct().ToList();
            cbMamuon.DataSource = listmuon;
        }
    }
}
