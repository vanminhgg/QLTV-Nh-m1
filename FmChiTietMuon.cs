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
    public partial class FmChiTietMuon : Form
    {
        QLTVContext db = new QLTVContext();
        public FmChiTietMuon()
        {
            InitializeComponent();
        }
        public string textBoxID { set { txtId.Text = value; } }
        public string cbBoxmaThe { set { cbMathe.Text = value; } }

        private void FmChiTietMuon_Load(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(txtId.Text);
            var listSach = (from sach in db.ChiTietMuons.Where(i => i.MaMuon == ma) select new { ten = sach.Sach.TenSach, daTra = sach.DaTra, ngayMuon = sach.NgayTra,
                hanTra = sach.NgayHetHan, tt = sach.TinhTrangSach });
            dgvChitietmuon.DataSource = listSach.Distinct().ToList();

            dgvChitietmuon.Columns["ten"].HeaderText = "Tên sách";
            dgvChitietmuon.Columns["daTra"].HeaderText = "Đã Trả";
            dgvChitietmuon.Columns["ngayMuon"].HeaderText = "Ngày Trả";
            dgvChitietmuon.Columns["hanTra"].HeaderText = "Hạn Trả";
            dgvChitietmuon.Columns["tt"].HeaderText = "Tình Trạng Sách";

            dgvChitietmuon.Columns["ten"].Width = 100;
            dgvChitietmuon.Columns["daTra"].Width = 50;
            dgvChitietmuon.Columns["ngayMuon"].Width = 135;
            dgvChitietmuon.Columns["hanTra"].Width = 135;
            dgvChitietmuon.Columns["tt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvChitietmuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvChitietmuon.Rows[e.RowIndex];
                dtp_hanTra.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                int ma = Convert.ToInt32(txtId.Text);
                var listSach = (from sach in db.ChiTietMuons.Where(i => i.MaMuon == ma)
                                select new
                                {
                                    ten = sach.Sach.TenSach,
                                    daTra = sach.DaTra,
                                    ngayMuon = sach.NgayTra,
                                    hanTra = sach.NgayHetHan,
                                    tt = sach.TinhTrangSach
                                });
                var listTimKiem = (from tk in listSach
                                   where tk.ten.ToString().Contains(txtSearch.Text)
                                   select new 
                                   {
                                       ten = tk.ten,
                                       daTra = tk.daTra,
                                       ngayMuon = tk.ngayMuon,
                                       hanTra = tk.hanTra,
                                       tt = tk.tt
                                   });

                dgvChitietmuon.DataSource = listTimKiem.ToList();
            }
            else
            {
                this.FmChiTietMuon_Load(sender, e);
            }
        }
    }
}
