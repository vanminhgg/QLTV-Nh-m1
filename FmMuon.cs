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
    public partial class FmMuon : Form
    {
        QLTVContext db = new QLTVContext();
        public FmMuon()
        {
            InitializeComponent();
        }

        public string textBoxID { get { return txtId.Text; } }
        public string cbBoxmaThe { get { return cbMathe.Text; } }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                var listTimKiem = (from muon in db.Muons
                                   where muon.MaMuon.ToString().Contains(txtSearch.Text)
                                   select new { id = muon.MaMuon, mathe = muon.MaThe, ngay = muon.NgayMuon, ghichu = muon.GhiChu });
                dgvMuon.DataSource = listTimKiem.Distinct().ToList();
            }
            else
            {
                this.FmMuon_Load(sender, e);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {          
                var muon = new Muon()
                {                        
                    MaThe = Convert.ToInt32(cbMathe.Text),
                    NgayMuon = dTp_ngayMuon.Value,                        
                    GhiChu = txtGhiChu.Text.ToString(),                       
                };                  
                db.Muons.Add(muon);                   
                db.SaveChanges();                   
                FmThemChiTietMuon fmThemChiTietMuon = new FmThemChiTietMuon();
                fmThemChiTietMuon.cbBoxmaThe = cbBoxmaThe;
                fmThemChiTietMuon.Show();
                FmMuon_Load(sender, e);
                this.Hide();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btnCTMuon_Click(object sender, EventArgs e)
        {
            if (txtId.Text != null && cbMathe.Text != null && txtId.Text != "")
            {
                FmChiTietMuon fmChiTietMuon = new FmChiTietMuon();
                (fmChiTietMuon).textBoxID = textBoxID;
                fmChiTietMuon.cbBoxmaThe = cbBoxmaThe;
                fmChiTietMuon.Show();
            }
            else MessageBox.Show("Vui lòng chọn dữ iệu cần xem !!!");
        }

        private void FmMuon_Load(object sender, EventArgs e)
        {
            txtId.Clear();
            dTp_ngayMuon.Value = DateTime.Now;

            var listMuon = from muon in db.Muons
                           select new { id = muon.MaMuon, mathe = muon.MaThe, ngay = muon.NgayMuon, ghichu = muon.GhiChu };

            dgvMuon.DataSource = listMuon.Distinct().ToList();

            dgvMuon.Columns["id"].HeaderText = "Mã Mượn";
            dgvMuon.Columns["mathe"].HeaderText = "Mã Thẻ";
            dgvMuon.Columns["ngay"].HeaderText = "Ngày Mượn";
            dgvMuon.Columns["ghichu"].HeaderText = "Ghi Chú";

            dgvMuon.Columns["id"].Width = 60;
            dgvMuon.Columns["mathe"].Width = 60;
            dgvMuon.Columns["ngay"].Width = 135;
            dgvMuon.Columns["ghichu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            cbMathe.DataSource = (from the in db.Thes select the.MaThe).Distinct().ToList();
            cbMathe.Text = "";

        }

        private void dgvMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dgvMuon.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                cbMathe.Text = row.Cells[1].Value.ToString();
                dTp_ngayMuon.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                if (row.Cells[3].Value != null) txtGhiChu.Text = row.Cells[3].Value.ToString(); 
            }
        }

    }
}
