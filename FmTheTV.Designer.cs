
namespace QUANLITHUVIENWINFORM
{
    partial class FmTheTV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmTheTV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvThe = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.ptbSearch = new System.Windows.Forms.PictureBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtGhichu = new System.Windows.Forms.TextBox();
            this.lbId = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTacgia = new System.Windows.Forms.Label();
            this.lbNXB = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lbDocgia = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTen = new System.Windows.Forms.ComboBox();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.dtpKT = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 61);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lí thẻ thư viện";
            // 
            // dgvThe
            // 
            this.dgvThe.BackgroundColor = System.Drawing.Color.White;
            this.dgvThe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThe.Location = new System.Drawing.Point(3, 61);
            this.dgvThe.Name = "dgvThe";
            this.dgvThe.RowHeadersVisible = false;
            this.dgvThe.RowHeadersWidth = 51;
            this.dgvThe.Size = new System.Drawing.Size(546, 385);
            this.dgvThe.TabIndex = 3;
            this.dgvThe.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvThe_CellMouseClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(346, 28);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(179, 24);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ptbSearch
            // 
            this.ptbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbSearch.Image = global::QUANLITHUVIENWINFORM.Properties.Resources._49116;
            this.ptbSearch.Location = new System.Drawing.Point(524, 28);
            this.ptbSearch.Margin = new System.Windows.Forms.Padding(4);
            this.ptbSearch.Name = "ptbSearch";
            this.ptbSearch.Size = new System.Drawing.Size(26, 24);
            this.ptbSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbSearch.TabIndex = 5;
            this.ptbSearch.TabStop = false;
            this.ptbSearch.Click += new System.EventHandler(this.ptbSearch_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(670, 77);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(210, 24);
            this.txtId.TabIndex = 16;
            // 
            // txtGhichu
            // 
            this.txtGhichu.Enabled = false;
            this.txtGhichu.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhichu.Location = new System.Drawing.Point(670, 209);
            this.txtGhichu.Name = "txtGhichu";
            this.txtGhichu.Size = new System.Drawing.Size(210, 24);
            this.txtGhichu.TabIndex = 19;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.Location = new System.Drawing.Point(610, 80);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(51, 17);
            this.lbId.TabIndex = 20;
            this.lbId.Text = "Mã thẻ";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(576, 125);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(91, 17);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Ngày bắt đầu";
            // 
            // lbTacgia
            // 
            this.lbTacgia.AutoSize = true;
            this.lbTacgia.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTacgia.Location = new System.Drawing.Point(568, 171);
            this.lbTacgia.Name = "lbTacgia";
            this.lbTacgia.Size = new System.Drawing.Size(96, 17);
            this.lbTacgia.TabIndex = 22;
            this.lbTacgia.Text = "Ngày kết thúc";
            // 
            // lbNXB
            // 
            this.lbNXB.AutoSize = true;
            this.lbNXB.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNXB.Location = new System.Drawing.Point(608, 212);
            this.lbNXB.Name = "lbNXB";
            this.lbNXB.Size = new System.Drawing.Size(56, 17);
            this.lbNXB.TabIndex = 23;
            this.lbNXB.Text = "Ghi chú";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThem.Location = new System.Drawing.Point(598, 371);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(69, 29);
            this.btnThem.TabIndex = 24;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSua.Location = new System.Drawing.Point(695, 371);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 29);
            this.btnSua.TabIndex = 25;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Red;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXoa.Location = new System.Drawing.Point(790, 371);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(69, 29);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lbDocgia
            // 
            this.lbDocgia.AutoSize = true;
            this.lbDocgia.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDocgia.Location = new System.Drawing.Point(581, 261);
            this.lbDocgia.Name = "lbDocgia";
            this.lbDocgia.Size = new System.Drawing.Size(79, 17);
            this.lbDocgia.TabIndex = 28;
            this.lbDocgia.Text = "Mã Độc Giả";
            // 
            // cbID
            // 
            this.cbID.Enabled = false;
            this.cbID.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(586, 292);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(63, 25);
            this.cbID.TabIndex = 29;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(667, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tên Độc Giả";
            // 
            // cbTen
            // 
            this.cbTen.Enabled = false;
            this.cbTen.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTen.FormattingEnabled = true;
            this.cbTen.Location = new System.Drawing.Point(670, 292);
            this.cbTen.Name = "cbTen";
            this.cbTen.Size = new System.Drawing.Size(210, 25);
            this.cbTen.TabIndex = 31;
            this.cbTen.SelectedIndexChanged += new System.EventHandler(this.cbTen_SelectedIndexChanged);
            // 
            // dtpBD
            // 
            this.dtpBD.CustomFormat = "dd/MM/yyyy";
            this.dtpBD.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBD.Location = new System.Drawing.Point(670, 119);
            this.dtpBD.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(210, 24);
            this.dtpBD.TabIndex = 32;
            this.dtpBD.Value = new System.DateTime(2022, 5, 21, 20, 13, 32, 0);
            // 
            // dtpKT
            // 
            this.dtpKT.CustomFormat = "dd/MM/yyyy";
            this.dtpKT.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKT.Location = new System.Drawing.Point(670, 165);
            this.dtpKT.Margin = new System.Windows.Forms.Padding(2);
            this.dtpKT.Name = "dtpKT";
            this.dtpKT.Size = new System.Drawing.Size(210, 24);
            this.dtpKT.TabIndex = 33;
            this.dtpKT.Value = new System.DateTime(2022, 5, 21, 20, 13, 32, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpKT);
            this.panel2.Controls.Add(this.dtpBD);
            this.panel2.Controls.Add(this.cbTen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbID);
            this.panel2.Controls.Add(this.lbDocgia);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Controls.Add(this.lbNXB);
            this.panel2.Controls.Add(this.lbTacgia);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Controls.Add(this.lbId);
            this.panel2.Controls.Add(this.txtGhichu);
            this.panel2.Controls.Add(this.txtId);
            this.panel2.Controls.Add(this.ptbSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.dgvThe);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 446);
            this.panel2.TabIndex = 4;
            // 
            // FmTheTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(903, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FmTheTV";
            this.Text = "Thẻ Thư Viện";
            this.Load += new System.EventHandler(this.FmTheTV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSearch)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvThe;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox ptbSearch;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtGhichu;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTacgia;
        private System.Windows.Forms.Label lbNXB;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lbDocgia;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTen;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.DateTimePicker dtpKT;
        private System.Windows.Forms.Panel panel2;
    }
}