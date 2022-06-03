
namespace QUANLITHUVIENWINFORM
{
    partial class AppDocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppDocGia));
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNgayYc = new System.Windows.Forms.Label();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.cbMathe = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.dtp_ngayMuon = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(590, 194);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 18);
            this.lbName.TabIndex = 56;
            this.lbName.Text = "Mã thẻ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(605, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 33);
            this.label1.TabIndex = 54;
            this.label1.Text = "Thư Viện HCMUTE";
            // 
            // lbNgayYc
            // 
            this.lbNgayYc.AutoSize = true;
            this.lbNgayYc.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayYc.Location = new System.Drawing.Point(549, 241);
            this.lbNgayYc.Name = "lbNgayYc";
            this.lbNgayYc.Size = new System.Drawing.Size(96, 18);
            this.lbNgayYc.TabIndex = 57;
            this.lbNgayYc.Text = "Ngày Yêu cầu";
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXacnhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXacnhan.FlatAppearance.BorderSize = 0;
            this.btnXacnhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacnhan.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacnhan.ForeColor = System.Drawing.Color.White;
            this.btnXacnhan.Location = new System.Drawing.Point(532, 412);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(152, 43);
            this.btnXacnhan.TabIndex = 58;
            this.btnXacnhan.Text = "Yêu cầu mượn";
            this.btnXacnhan.UseVisualStyleBackColor = false;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // cbMathe
            // 
            this.cbMathe.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMathe.FormattingEnabled = true;
            this.cbMathe.Location = new System.Drawing.Point(655, 192);
            this.cbMathe.Name = "cbMathe";
            this.cbMathe.Size = new System.Drawing.Size(212, 25);
            this.cbMathe.TabIndex = 60;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(745, 412);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(152, 43);
            this.btnHuy.TabIndex = 59;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(273, 91);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(216, 20);
            this.txtSearch.TabIndex = 64;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 40;
            // 
            // ptbSearch
            // 
            this.ptbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbSearch.Image = global::QUANLITHUVIENWINFORM.Properties.Resources._49116;
            this.ptbSearch.Location = new System.Drawing.Point(488, 91);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(26, 20);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSearch.TabIndex = 65;
            this.ptbSearch.TabStop = false;
            // 
            // dtp_ngayMuon
            // 
            this.dtp_ngayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayMuon.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayMuon.Location = new System.Drawing.Point(655, 235);
            this.dtp_ngayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngayMuon.Name = "dtp_ngayMuon";
            this.dtp_ngayMuon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_ngayMuon.Size = new System.Drawing.Size(212, 24);
            this.dtp_ngayMuon.TabIndex = 66;
            this.dtp_ngayMuon.Value = new System.DateTime(2022, 6, 3, 0, 27, 52, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(590, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 18);
            this.label2.TabIndex = 67;
            this.label2.Text = "Ghi chú";
            // 
            // txtGhichu
            // 
            this.txtGhichu.Location = new System.Drawing.Point(653, 280);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(212, 20);
            this.txtGhichu.TabIndex = 68;
            // 
            // dgvSach
            // 
            this.dgvSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dgvSach.Location = new System.Drawing.Point(2, 119);
            this.dgvSach.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.RowHeadersVisible = false;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.RowTemplate.Height = 24;
            this.dgvSach.Size = new System.Drawing.Size(511, 450);
            this.dgvSach.TabIndex = 69;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "";
            this.Column2.Name = "Column2";
            this.Column2.Width = 50;
            // 
            // AppDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 572);
            this.Controls.Add(this.dgvSach);
            this.Controls.Add(this.txtGhichu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_ngayMuon);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.ptbSearch);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.cbMathe);
            this.Controls.Add(this.lbNgayYc);
            this.Controls.Add(this.btnXacnhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppDocGia";
            this.Text = "Độc giả";
            this.Load += new System.EventHandler(this.AppDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNgayYc;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.ComboBox cbMathe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox ptbSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DateTimePicker dtp_ngayMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
    }
}