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
    public partial class FmYeuCau : Form
    {
        QLTVContext db = new QLTVContext();

        public FmYeuCau()
        {
            InitializeComponent();
        }

        private void FmYeuCau_Load(object sender, EventArgs e)
        {
            var yeucaumuon = from y in db.YeuCauMuons
                             select new
                             {
                                 Id = y.MaYC,
                                 mathe = y.MaThe,
                                 Tendocgia = y.The.DocGia.TenDG,
                                 ngayyeucau = y.NgayYeuCau,
                             };
            dgvYeucau.DataSource = yeucaumuon.Distinct().ToList();

        }

        private void dgvYeucau_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvYeucau.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                cbMathe.Text = row.Cells[1].Value.ToString();
                dTp_ngayMuon.Value = DateTime.Parse(row.Cells[3].Value.ToString());
            }
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            this.Hide();
            FmChiTietYC fm = new FmChiTietYC(txtId.Text, cbMathe.Text);
            fm.Show();
        }
    }
}
