
namespace QUANLITHUVIENWINFORM
{
    partial class FmChiTietYC
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp_ngayTra = new System.Windows.Forms.DateTimePicker();
            this.cbMathe = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.lbNgaymuon = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbMaYC = new System.Windows.Forms.Label();
            this.txtMaYC = new System.Windows.Forms.TextBox();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCtYeucau = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtYeucau)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dtp_ngayTra);
            this.panel2.Controls.Add(this.cbMathe);
            this.panel2.Controls.Add(this.btnHuy);
            this.panel2.Controls.Add(this.btnDuyet);
            this.panel2.Controls.Add(this.lbNgaymuon);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.lbMaYC);
            this.panel2.Controls.Add(this.txtMaYC);
            this.panel2.Controls.Add(this.ptbSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dgvCtYeucau);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 407);
            this.panel2.TabIndex = 7;
            // 
            // dtp_ngayTra
            // 
            this.dtp_ngayTra.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngayTra.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_ngayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngayTra.Location = new System.Drawing.Point(437, 148);
            this.dtp_ngayTra.Margin = new System.Windows.Forms.Padding(2);
            this.dtp_ngayTra.Name = "dtp_ngayTra";
            this.dtp_ngayTra.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtp_ngayTra.Size = new System.Drawing.Size(228, 24);
            this.dtp_ngayTra.TabIndex = 30;
            this.dtp_ngayTra.Value = new System.DateTime(2022, 6, 3, 0, 27, 52, 0);
            // 
            // cbMathe
            // 
            this.cbMathe.Enabled = false;
            this.cbMathe.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMathe.FormattingEnabled = true;
            this.cbMathe.Location = new System.Drawing.Point(574, 96);
            this.cbMathe.Name = "cbMathe";
            this.cbMathe.Size = new System.Drawing.Size(91, 25);
            this.cbMathe.TabIndex = 28;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Red;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHuy.Location = new System.Drawing.Point(525, 246);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 43);
            this.btnHuy.TabIndex = 27;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnDuyet
            // 
            this.btnDuyet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuyet.FlatAppearance.BorderSize = 0;
            this.btnDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuyet.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDuyet.Location = new System.Drawing.Point(395, 246);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(106, 43);
            this.btnDuyet.TabIndex = 24;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.UseVisualStyleBackColor = false;
            this.btnDuyet.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // lbNgaymuon
            // 
            this.lbNgaymuon.AutoSize = true;
            this.lbNgaymuon.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaymuon.Location = new System.Drawing.Point(339, 154);
            this.lbNgaymuon.Name = "lbNgaymuon";
            this.lbNgaymuon.Size = new System.Drawing.Size(93, 17);
            this.lbNgaymuon.TabIndex = 22;
            this.lbNgaymuon.Text = "Ngày phải trả";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(522, 98);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 17);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Mã thẻ";
            // 
            // lbMaYC
            // 
            this.lbMaYC.AutoSize = true;
            this.lbMaYC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaYC.Location = new System.Drawing.Point(352, 98);
            this.lbMaYC.Name = "lbMaYC";
            this.lbMaYC.Size = new System.Drawing.Size(79, 17);
            this.lbMaYC.TabIndex = 20;
            this.lbMaYC.Text = "Mã yêu cầu";
            // 
            // txtMaYC
            // 
            this.txtMaYC.Enabled = false;
            this.txtMaYC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaYC.Location = new System.Drawing.Point(437, 96);
            this.txtMaYC.Name = "txtMaYC";
            this.txtMaYC.Size = new System.Drawing.Size(73, 24);
            this.txtMaYC.TabIndex = 16;
            // 
            // ptbSearch
            // 
            this.ptbSearch.Image = global::QUANLITHUVIENWINFORM.Properties.Resources._49116;
            this.ptbSearch.Location = new System.Drawing.Point(304, 17);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(26, 23);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSearch.TabIndex = 5;
            this.ptbSearch.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(121, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 24);
            this.txtSearch.TabIndex = 4;
            // 
            // dgvCtYeucau
            // 
            this.dgvCtYeucau.AllowUserToResizeColumns = false;
            this.dgvCtYeucau.AllowUserToResizeRows = false;
            this.dgvCtYeucau.BackgroundColor = System.Drawing.Color.White;
            this.dgvCtYeucau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCtYeucau.Location = new System.Drawing.Point(10, 46);
            this.dgvCtYeucau.Name = "dgvCtYeucau";
            this.dgvCtYeucau.RowHeadersVisible = false;
            this.dgvCtYeucau.RowHeadersWidth = 51;
            this.dgvCtYeucau.Size = new System.Drawing.Size(321, 313);
            this.dgvCtYeucau.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(707, 45);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(254, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết yêu cầu";
            // 
            // FmChiTietYC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FmChiTietYC";
            this.Text = "FmChiTietYC";
            this.Load += new System.EventHandler(this.FmChiTietYC_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCtYeucau)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtp_ngayTra;
        private System.Windows.Forms.ComboBox cbMathe;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnDuyet;
        private System.Windows.Forms.Label lbNgaymuon;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMaYC;
        private System.Windows.Forms.TextBox txtMaYC;
        private System.Windows.Forms.PictureBox ptbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvCtYeucau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}