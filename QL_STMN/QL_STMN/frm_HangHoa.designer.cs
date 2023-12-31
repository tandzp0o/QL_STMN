namespace QL_STMN
{
    partial class frm_HangHoa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_HangHoa));
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.grbTTHH = new System.Windows.Forms.GroupBox();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.cboLoaiHH = new System.Windows.Forms.ComboBox();
            this.btnQLNCC = new System.Windows.Forms.Button();
            this.btnQLLoaiHH = new System.Windows.Forms.Button();
            this.txtSLuong = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaNhap = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.cboTimNCC = new System.Windows.Forms.ComboBox();
            this.cboTimLoaiHH = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbTTHH.SuspendLayout();
            this.grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDe.Location = new System.Drawing.Point(335, 9);
            this.lblTieuDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(204, 38);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "HÀNG HÓA";
            // 
            // grbTTHH
            // 
            this.grbTTHH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTTHH.Controls.Add(this.cboNCC);
            this.grbTTHH.Controls.Add(this.cboLoaiHH);
            this.grbTTHH.Controls.Add(this.btnQLNCC);
            this.grbTTHH.Controls.Add(this.btnQLLoaiHH);
            this.grbTTHH.Controls.Add(this.txtSLuong);
            this.grbTTHH.Controls.Add(this.txtGiaBan);
            this.grbTTHH.Controls.Add(this.txtGiaNhap);
            this.grbTTHH.Controls.Add(this.txtDVT);
            this.grbTTHH.Controls.Add(this.txtTenHH);
            this.grbTTHH.Controls.Add(this.txtMaHH);
            this.grbTTHH.Controls.Add(this.label6);
            this.grbTTHH.Controls.Add(this.label5);
            this.grbTTHH.Controls.Add(this.label8);
            this.grbTTHH.Controls.Add(this.label4);
            this.grbTTHH.Controls.Add(this.label3);
            this.grbTTHH.Controls.Add(this.label7);
            this.grbTTHH.Controls.Add(this.label2);
            this.grbTTHH.Controls.Add(this.label1);
            this.grbTTHH.Location = new System.Drawing.Point(12, 48);
            this.grbTTHH.Name = "grbTTHH";
            this.grbTTHH.Size = new System.Drawing.Size(841, 159);
            this.grbTTHH.TabIndex = 1;
            this.grbTTHH.TabStop = false;
            this.grbTTHH.Text = "Thông tin hàng hóa";
            // 
            // cboNCC
            // 
            this.cboNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(664, 117);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(142, 30);
            this.cboNCC.TabIndex = 2;
            // 
            // cboLoaiHH
            // 
            this.cboLoaiHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboLoaiHH.FormattingEnabled = true;
            this.cboLoaiHH.Location = new System.Drawing.Point(664, 74);
            this.cboLoaiHH.Name = "cboLoaiHH";
            this.cboLoaiHH.Size = new System.Drawing.Size(142, 30);
            this.cboLoaiHH.TabIndex = 2;
            // 
            // btnQLNCC
            // 
            this.btnQLNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLNCC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNCC.Location = new System.Drawing.Point(812, 117);
            this.btnQLNCC.Name = "btnQLNCC";
            this.btnQLNCC.Size = new System.Drawing.Size(23, 26);
            this.btnQLNCC.TabIndex = 0;
            this.btnQLNCC.Text = "+";
            this.btnQLNCC.UseVisualStyleBackColor = true;
            this.btnQLNCC.Click += new System.EventHandler(this.btnQLNCC_Click);
            // 
            // btnQLLoaiHH
            // 
            this.btnQLLoaiHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQLLoaiHH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLLoaiHH.Location = new System.Drawing.Point(812, 74);
            this.btnQLLoaiHH.Name = "btnQLLoaiHH";
            this.btnQLLoaiHH.Size = new System.Drawing.Size(23, 26);
            this.btnQLLoaiHH.TabIndex = 0;
            this.btnQLLoaiHH.Text = "+";
            this.btnQLLoaiHH.UseVisualStyleBackColor = true;
            this.btnQLLoaiHH.Click += new System.EventHandler(this.btnQLLoaiHH_Click);
            // 
            // txtSLuong
            // 
            this.txtSLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSLuong.Location = new System.Drawing.Point(125, 114);
            this.txtSLuong.Name = "txtSLuong";
            this.txtSLuong.Size = new System.Drawing.Size(114, 30);
            this.txtSLuong.TabIndex = 1;
            this.txtSLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaBan.Location = new System.Drawing.Point(382, 117);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(142, 30);
            this.txtGiaBan.TabIndex = 1;
            this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaNhap.Location = new System.Drawing.Point(382, 74);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(142, 30);
            this.txtGiaNhap.TabIndex = 1;
            this.txtGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGiaNhap.TextChanged += new System.EventHandler(this.txtGiaNhap_TextChanged);
            // 
            // txtDVT
            // 
            this.txtDVT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDVT.Location = new System.Drawing.Point(125, 74);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(114, 30);
            this.txtDVT.TabIndex = 1;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenHH.Location = new System.Drawing.Point(382, 32);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(424, 30);
            this.txtTenHH.TabIndex = 1;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaHH.Enabled = false;
            this.txtMaHH.Location = new System.Drawing.Point(125, 32);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(113, 30);
            this.txtMaHH.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(557, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhà cung cấp: ";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại hàng hóa: ";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng tồn:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giá bán: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(305, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá nhập: ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đơn vị tính: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên hàng hóa: ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng hóa: ";
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbTimKiem.Controls.Add(this.cboTimNCC);
            this.grbTimKiem.Controls.Add(this.cboTimLoaiHH);
            this.grbTimKiem.Controls.Add(this.btnTimKiem);
            this.grbTimKiem.Controls.Add(this.txtTimTen);
            this.grbTimKiem.Controls.Add(this.label9);
            this.grbTimKiem.Controls.Add(this.label10);
            this.grbTimKiem.Controls.Add(this.label11);
            this.grbTimKiem.Location = new System.Drawing.Point(12, 213);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(841, 91);
            this.grbTimKiem.TabIndex = 2;
            this.grbTimKiem.TabStop = false;
            this.grbTimKiem.Text = "Tìm kiếm";
            // 
            // cboTimNCC
            // 
            this.cboTimNCC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimNCC.FormattingEnabled = true;
            this.cboTimNCC.Location = new System.Drawing.Point(544, 46);
            this.cboTimNCC.Name = "cboTimNCC";
            this.cboTimNCC.Size = new System.Drawing.Size(142, 30);
            this.cboTimNCC.TabIndex = 2;
            // 
            // cboTimLoaiHH
            // 
            this.cboTimLoaiHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTimLoaiHH.FormattingEnabled = true;
            this.cboTimLoaiHH.Location = new System.Drawing.Point(382, 46);
            this.cboTimLoaiHH.Name = "cboTimLoaiHH";
            this.cboTimLoaiHH.Size = new System.Drawing.Size(142, 30);
            this.cboTimLoaiHH.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(703, 29);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(132, 56);
            this.btnTimKiem.TabIndex = 0;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimTen
            // 
            this.txtTimTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimTen.Location = new System.Drawing.Point(27, 47);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(319, 30);
            this.txtTimTen.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên hàng hóa: ";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 22);
            this.label10.TabIndex = 0;
            this.label10.Text = "Loại hàng hóa:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(541, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 22);
            this.label11.TabIndex = 0;
            this.label11.Text = "Nhà cung cấp:";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(11, 310);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(692, 273);
            this.dgvHangHoa.TabIndex = 3;
            this.dgvHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellContentClick);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(725, 332);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(118, 53);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(725, 431);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(118, 52);
            this.btnSua.TabIndex = 0;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(725, 520);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 50);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frm_HangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 595);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.grbTTHH);
            this.Controls.Add(this.lblTieuDe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_HangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý Hàng hóa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_QLHangHoa_FormClosing);
            this.Load += new System.EventHandler(this.frm_QLHangHoa_Load);
            this.grbTTHH.ResumeLayout(false);
            this.grbTTHH.PerformLayout();
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox grbTTHH;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSLuong;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaNhap;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.ComboBox cboLoaiHH;
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboTimNCC;
        private System.Windows.Forms.ComboBox cboTimLoaiHH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnQLNCC;
        private System.Windows.Forms.Button btnQLLoaiHH;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}