
namespace QUANLITHUVIENWINFORM
{
    partial class FmYeuCau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmYeuCau));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnChitiet = new System.Windows.Forms.Button();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dTp_ngayMuon = new System.Windows.Forms.DateTimePicker();
            this.cbMathe = new System.Windows.Forms.ComboBox();
            this.lbNgaymuon = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbMaYC = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvYeucau = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeucau)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 55);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.RoyalBlue;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(224, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yêu cầu mượn sách";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnChitiet);
            this.panel2.Controls.Add(this.txtGhiChu);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dTp_ngayMuon);
            this.panel2.Controls.Add(this.cbMathe);
            this.panel2.Controls.Add(this.lbNgaymuon);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.lbMaYC);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.dgvYeucau);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 395);
            this.panel2.TabIndex = 5;
            // 
            // btnChitiet
            // 
            this.btnChitiet.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChitiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChitiet.FlatAppearance.BorderSize = 0;
            this.btnChitiet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChitiet.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitiet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChitiet.Location = new System.Drawing.Point(519, 268);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(106, 43);
            this.btnChitiet.TabIndex = 40;
            this.btnChitiet.Text = "Chi tiết";
            this.btnChitiet.UseVisualStyleBackColor = false;
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(488, 194);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(209, 24);
            this.txtGhiChu.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ghi Chú";
            // 
            // dTp_ngayMuon
            // 
            this.dTp_ngayMuon.CustomFormat = "dd/MM/yyyy";
            this.dTp_ngayMuon.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTp_ngayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTp_ngayMuon.Location = new System.Drawing.Point(489, 148);
            this.dTp_ngayMuon.Margin = new System.Windows.Forms.Padding(2);
            this.dTp_ngayMuon.Name = "dTp_ngayMuon";
            this.dTp_ngayMuon.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dTp_ngayMuon.Size = new System.Drawing.Size(208, 24);
            this.dTp_ngayMuon.TabIndex = 37;
            this.dTp_ngayMuon.Value = new System.DateTime(2022, 5, 20, 22, 14, 0, 0);
            // 
            // cbMathe
            // 
            this.cbMathe.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMathe.FormattingEnabled = true;
            this.cbMathe.Location = new System.Drawing.Point(615, 100);
            this.cbMathe.Name = "cbMathe";
            this.cbMathe.Size = new System.Drawing.Size(81, 25);
            this.cbMathe.TabIndex = 36;
            // 
            // lbNgaymuon
            // 
            this.lbNgaymuon.AutoSize = true;
            this.lbNgaymuon.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgaymuon.Location = new System.Drawing.Point(392, 154);
            this.lbNgaymuon.Name = "lbNgaymuon";
            this.lbNgaymuon.Size = new System.Drawing.Size(93, 17);
            this.lbNgaymuon.TabIndex = 35;
            this.lbNgaymuon.Text = "Ngày yêu cầu";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(563, 102);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 17);
            this.lbName.TabIndex = 34;
            this.lbName.Text = "Mã thẻ";
            // 
            // lbMaYC
            // 
            this.lbMaYC.AutoSize = true;
            this.lbMaYC.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaYC.Location = new System.Drawing.Point(405, 102);
            this.lbMaYC.Name = "lbMaYC";
            this.lbMaYC.Size = new System.Drawing.Size(79, 17);
            this.lbMaYC.TabIndex = 33;
            this.lbMaYC.Text = "Mã yêu cầu";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(489, 100);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(66, 24);
            this.txtId.TabIndex = 32;
            // 
            // dgvYeucau
            // 
            this.dgvYeucau.BackgroundColor = System.Drawing.Color.White;
            this.dgvYeucau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYeucau.Location = new System.Drawing.Point(10, 54);
            this.dgvYeucau.Name = "dgvYeucau";
            this.dgvYeucau.RowHeadersVisible = false;
            this.dgvYeucau.Size = new System.Drawing.Size(376, 331);
            this.dgvYeucau.TabIndex = 0;
            this.dgvYeucau.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvYeucau_CellMouseClick);
            // 
            // FmYeuCau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FmYeuCau";
            this.Text = "Yêu cầu mượn sách";
            this.Load += new System.EventHandler(this.FmYeuCau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeucau)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvYeucau;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dTp_ngayMuon;
        private System.Windows.Forms.ComboBox cbMathe;
        private System.Windows.Forms.Label lbNgaymuon;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMaYC;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnChitiet;
    }
}