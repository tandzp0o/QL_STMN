namespace QL_STMN
{
    partial class frm_BanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BanHang));
            this.grbDaChon = new System.Windows.Forms.GroupBox();
            this.btnTongTien = new System.Windows.Forms.Button();
            this.btnThemPGG = new System.Windows.Forms.Button();
            this.cboPGG = new System.Windows.Forms.ComboBox();
            this.dgvHangMua = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoaHangDaChonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtGTGiam = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkCoPGG = new System.Windows.Forms.CheckBox();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grbHangHoa = new System.Windows.Forms.GroupBox();
            this.txtSoLuongMua = new System.Windows.Forms.NumericUpDown();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLoaiHH = new System.Windows.Forms.TextBox();
            this.txtDVT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grbKH = new System.Windows.Forms.GroupBox();
            this.btnThenKH = new System.Windows.Forms.Button();
            this.cboMaKH = new System.Windows.Forms.ComboBox();
            this.chkKHTT = new System.Windows.Forms.CheckBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.grbThanhToan = new System.Windows.Forms.GroupBox();
            this.txtTraLai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTienNhan = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.grbDaChon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangMua)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.grbHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongMua)).BeginInit();
            this.grbKH.SuspendLayout();
            this.grbThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDaChon
            // 
            this.grbDaChon.Controls.Add(this.btnTongTien);
            this.grbDaChon.Controls.Add(this.btnThemPGG);
            this.grbDaChon.Controls.Add(this.cboPGG);
            this.grbDaChon.Controls.Add(this.dgvHangMua);
            this.grbDaChon.Controls.Add(this.txtGTGiam);
            this.grbDaChon.Controls.Add(this.txtTongTien);
            this.grbDaChon.Controls.Add(this.label14);
            this.grbDaChon.Controls.Add(this.chkCoPGG);
            this.grbDaChon.Location = new System.Drawing.Point(618, 37);
            this.grbDaChon.Name = "grbDaChon";
            this.grbDaChon.Size = new System.Drawing.Size(494, 353);
            this.grbDaChon.TabIndex = 1;
            this.grbDaChon.TabStop = false;
            this.grbDaChon.Text = "Mặt hàng đã chọn";
            // 
            // btnTongTien
            // 
            this.btnTongTien.Location = new System.Drawing.Point(348, 279);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.Size = new System.Drawing.Size(73, 27);
            this.btnTongTien.TabIndex = 15;
            this.btnTongTien.Text = "Tổng tiền";
            this.btnTongTien.UseVisualStyleBackColor = true;
            this.btnTongTien.Click += new System.EventHandler(this.btnTongTien_Click);
            // 
            // btnThemPGG
            // 
            this.btnThemPGG.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPGG.Location = new System.Drawing.Point(191, 310);
            this.btnThemPGG.Name = "btnThemPGG";
            this.btnThemPGG.Size = new System.Drawing.Size(25, 27);
            this.btnThemPGG.TabIndex = 14;
            this.btnThemPGG.Text = "+";
            this.btnThemPGG.UseVisualStyleBackColor = true;
            this.btnThemPGG.Click += new System.EventHandler(this.btnThemPGG_Click);
            // 
            // cboPGG
            // 
            this.cboPGG.FormattingEnabled = true;
            this.cboPGG.Location = new System.Drawing.Point(15, 310);
            this.cboPGG.Name = "cboPGG";
            this.cboPGG.Size = new System.Drawing.Size(170, 30);
            this.cboPGG.TabIndex = 13;
            this.cboPGG.SelectedIndexChanged += new System.EventHandler(this.cboPGG_SelectedIndexChanged);
            // 
            // dgvHangMua
            // 
            this.dgvHangMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangMua.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvHangMua.Location = new System.Drawing.Point(17, 27);
            this.dgvHangMua.Name = "dgvHangMua";
            this.dgvHangMua.RowHeadersWidth = 51;
            this.dgvHangMua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangMua.Size = new System.Drawing.Size(459, 241);
            this.dgvHangMua.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoaHangDaChonToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(199, 28);
            // 
            // xoaHangDaChonToolStripMenuItem
            // 
            this.xoaHangDaChonToolStripMenuItem.Name = "xoaHangDaChonToolStripMenuItem";
            this.xoaHangDaChonToolStripMenuItem.Size = new System.Drawing.Size(198, 24);
            this.xoaHangDaChonToolStripMenuItem.Text = "Xóa hàng đã chọn";
            this.xoaHangDaChonToolStripMenuItem.Click += new System.EventHandler(this.xoaHangDaChonToolStripMenuItem_Click);
            // 
            // txtGTGiam
            // 
            this.txtGTGiam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGTGiam.Location = new System.Drawing.Point(251, 310);
            this.txtGTGiam.Name = "txtGTGiam";
            this.txtGTGiam.Size = new System.Drawing.Size(53, 30);
            this.txtGTGiam.TabIndex = 7;
            this.txtGTGiam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongTien.Location = new System.Drawing.Point(348, 310);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(131, 30);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(111, 22);
            this.label14.TabIndex = 4;
            this.label14.Text = "Giá trị giảm:";
            // 
            // chkCoPGG
            // 
            this.chkCoPGG.AutoSize = true;
            this.chkCoPGG.Location = new System.Drawing.Point(17, 281);
            this.chkCoPGG.Name = "chkCoPGG";
            this.chkCoPGG.Size = new System.Drawing.Size(175, 26);
            this.chkCoPGG.TabIndex = 12;
            this.chkCoPGG.Text = "Có phiếu giảm giá";
            this.chkCoPGG.UseVisualStyleBackColor = true;
            this.chkCoPGG.CheckedChanged += new System.EventHandler(this.chkCoPGG_CheckedChanged);
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Location = new System.Drawing.Point(12, 325);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(588, 321);
            this.dgvHangHoa.TabIndex = 0;
            this.dgvHangHoa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellContentClick);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.Image")));
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(397, 264);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(134, 54);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimTen
            // 
            this.txtTimTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTimTen.Location = new System.Drawing.Point(92, 273);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(299, 30);
            this.txtTimTen.TabIndex = 7;
            this.txtTimTen.Tag = "";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(286, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 22);
            this.label9.TabIndex = 4;
            // 
            // grbHangHoa
            // 
            this.grbHangHoa.Controls.Add(this.txtSoLuongMua);
            this.grbHangHoa.Controls.Add(this.btnChonHang);
            this.grbHangHoa.Controls.Add(this.label9);
            this.grbHangHoa.Controls.Add(this.label3);
            this.grbHangHoa.Controls.Add(this.txtSoLuongTon);
            this.grbHangHoa.Controls.Add(this.txtGiaBan);
            this.grbHangHoa.Controls.Add(this.txtMaHH);
            this.grbHangHoa.Controls.Add(this.txtTenHH);
            this.grbHangHoa.Controls.Add(this.label5);
            this.grbHangHoa.Controls.Add(this.txtLoaiHH);
            this.grbHangHoa.Controls.Add(this.txtDVT);
            this.grbHangHoa.Controls.Add(this.label2);
            this.grbHangHoa.Controls.Add(this.label6);
            this.grbHangHoa.Controls.Add(this.label1);
            this.grbHangHoa.Controls.Add(this.label7);
            this.grbHangHoa.Controls.Add(this.label4);
            this.grbHangHoa.Location = new System.Drawing.Point(12, 37);
            this.grbHangHoa.Name = "grbHangHoa";
            this.grbHangHoa.Size = new System.Drawing.Size(588, 221);
            this.grbHangHoa.TabIndex = 1;
            this.grbHangHoa.TabStop = false;
            this.grbHangHoa.Text = "Thông tin mặt hàng";
            // 
            // txtSoLuongMua
            // 
            this.txtSoLuongMua.Location = new System.Drawing.Point(236, 173);
            this.txtSoLuongMua.Name = "txtSoLuongMua";
            this.txtSoLuongMua.Size = new System.Drawing.Size(163, 30);
            this.txtSoLuongMua.TabIndex = 16;
            this.txtSoLuongMua.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnChonHang
            // 
            this.btnChonHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnChonHang.Image = ((System.Drawing.Image)(resources.GetObject("btnChonHang.Image")));
            this.btnChonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChonHang.Location = new System.Drawing.Point(425, 151);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(114, 59);
            this.btnChonHang.TabIndex = 3;
            this.btnChonHang.Text = "Chọn";
            this.btnChonHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mã hàng hóa: ";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSoLuongTon.Location = new System.Drawing.Point(417, 111);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(94, 30);
            this.txtSoLuongTon.TabIndex = 10;
            this.txtSoLuongTon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaBan.Location = new System.Drawing.Point(236, 111);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(142, 30);
            this.txtGiaBan.TabIndex = 10;
            this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaHH.Location = new System.Drawing.Point(29, 49);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(113, 30);
            this.txtMaHH.TabIndex = 13;
            // 
            // txtTenHH
            // 
            this.txtTenHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenHH.Location = new System.Drawing.Point(236, 49);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(323, 30);
            this.txtTenHH.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Loại hàng hóa: ";
            // 
            // txtLoaiHH
            // 
            this.txtLoaiHH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtLoaiHH.Location = new System.Drawing.Point(29, 173);
            this.txtLoaiHH.Name = "txtLoaiHH";
            this.txtLoaiHH.Size = new System.Drawing.Size(167, 30);
            this.txtLoaiHH.TabIndex = 11;
            // 
            // txtDVT
            // 
            this.txtDVT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDVT.Location = new System.Drawing.Point(29, 111);
            this.txtDVT.Name = "txtDVT";
            this.txtDVT.Size = new System.Drawing.Size(114, 30);
            this.txtDVT.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên hàng hóa: ";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Nhập số lượng mua";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Số lượng tồn: ";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 7;
            this.label7.Text = "Đơn vị tính: ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giá bán: ";
            // 
            // grbKH
            // 
            this.grbKH.Controls.Add(this.btnThenKH);
            this.grbKH.Controls.Add(this.cboMaKH);
            this.grbKH.Controls.Add(this.chkKHTT);
            this.grbKH.Controls.Add(this.txtTenKH);
            this.grbKH.Controls.Add(this.label10);
            this.grbKH.Controls.Add(this.label8);
            this.grbKH.Location = new System.Drawing.Point(618, 407);
            this.grbKH.Name = "grbKH";
            this.grbKH.Size = new System.Drawing.Size(240, 188);
            this.grbKH.TabIndex = 8;
            this.grbKH.TabStop = false;
            this.grbKH.Text = "Khách hàng";
            // 
            // btnThenKH
            // 
            this.btnThenKH.Image = ((System.Drawing.Image)(resources.GetObject("btnThenKH.Image")));
            this.btnThenKH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThenKH.Location = new System.Drawing.Point(97, 133);
            this.btnThenKH.Name = "btnThenKH";
            this.btnThenKH.Size = new System.Drawing.Size(105, 49);
            this.btnThenKH.TabIndex = 13;
            this.btnThenKH.Text = "Thêm";
            this.btnThenKH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThenKH.UseVisualStyleBackColor = true;
            this.btnThenKH.Click += new System.EventHandler(this.btnThenKH_Click);
            // 
            // cboMaKH
            // 
            this.cboMaKH.FormattingEnabled = true;
            this.cboMaKH.Location = new System.Drawing.Point(81, 54);
            this.cboMaKH.Name = "cboMaKH";
            this.cboMaKH.Size = new System.Drawing.Size(145, 30);
            this.cboMaKH.TabIndex = 13;
            this.cboMaKH.SelectedIndexChanged += new System.EventHandler(this.cboMaKH_SelectedIndexChanged);
            // 
            // chkKHTT
            // 
            this.chkKHTT.AutoSize = true;
            this.chkKHTT.Location = new System.Drawing.Point(81, 25);
            this.chkKHTT.Name = "chkKHTT";
            this.chkKHTT.Size = new System.Drawing.Size(199, 26);
            this.chkKHTT.TabIndex = 12;
            this.chkKHTT.Text = "Khách hàng thân thiết";
            this.chkKHTT.UseVisualStyleBackColor = true;
            this.chkKHTT.CheckedChanged += new System.EventHandler(this.chkKHTT_CheckedChanged);
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenKH.Location = new System.Drawing.Point(81, 101);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(145, 30);
            this.txtTenKH.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 22);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tên KH:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Mã KH:";
            // 
            // grbThanhToan
            // 
            this.grbThanhToan.Controls.Add(this.txtTraLai);
            this.grbThanhToan.Controls.Add(this.label11);
            this.grbThanhToan.Controls.Add(this.txtTienNhan);
            this.grbThanhToan.Controls.Add(this.label12);
            this.grbThanhToan.Location = new System.Drawing.Point(872, 407);
            this.grbThanhToan.Name = "grbThanhToan";
            this.grbThanhToan.Size = new System.Drawing.Size(240, 127);
            this.grbThanhToan.TabIndex = 8;
            this.grbThanhToan.TabStop = false;
            this.grbThanhToan.Text = "Thanh toán";
            // 
            // txtTraLai
            // 
            this.txtTraLai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTraLai.Location = new System.Drawing.Point(80, 73);
            this.txtTraLai.Name = "txtTraLai";
            this.txtTraLai.Size = new System.Drawing.Size(145, 30);
            this.txtTraLai.TabIndex = 11;
            this.txtTraLai.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 22);
            this.label11.TabIndex = 7;
            this.label11.Text = "Tiền nhận:";
            // 
            // txtTienNhan
            // 
            this.txtTienNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTienNhan.Location = new System.Drawing.Point(80, 29);
            this.txtTienNhan.Name = "txtTienNhan";
            this.txtTienNhan.Size = new System.Drawing.Size(145, 30);
            this.txtTienNhan.TabIndex = 11;
            this.txtTienNhan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTienNhan.TextChanged += new System.EventHandler(this.txtTienNhan_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 22);
            this.label12.TabIndex = 7;
            this.label12.Text = "Trả lại:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThanhToan.Location = new System.Drawing.Point(906, 540);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(143, 55);
            this.btnThanhToan.TabIndex = 13;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(729, 597);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(129, 58);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Làm mới";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(921, 597);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 58);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(88, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(47, 22);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(12, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 22);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "Time";
            // 
            // frm_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 661);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.grbThanhToan);
            this.Controls.Add(this.grbKH);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimTen);
            this.Controls.Add(this.grbDaChon);
            this.Controls.Add(this.grbHangHoa);
            this.Controls.Add(this.dgvHangHoa);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frm_BanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_BanHang_FormClosing);
            this.Load += new System.EventHandler(this.frm_BanHang_Load);
            this.grbDaChon.ResumeLayout(false);
            this.grbDaChon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangMua)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.grbHangHoa.ResumeLayout(false);
            this.grbHangHoa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuongMua)).EndInit();
            this.grbKH.ResumeLayout(false);
            this.grbKH.PerformLayout();
            this.grbThanhToan.ResumeLayout(false);
            this.grbThanhToan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.GroupBox grbDaChon;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimTen;
        private System.Windows.Forms.DataGridView dgvHangMua;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbHangHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDVT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.TextBox txtLoaiHH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbKH;
        private System.Windows.Forms.Button btnThenKH;
        private System.Windows.Forms.CheckBox chkKHTT;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grbThanhToan;
        private System.Windows.Forms.TextBox txtTraLai;
        private System.Windows.Forms.CheckBox chkCoPGG;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTienNhan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboPGG;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xoaHangDaChonToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnThemPGG;
        private System.Windows.Forms.ComboBox cboMaKH;
        private System.Windows.Forms.TextBox txtGTGiam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown txtSoLuongMua;
        private System.Windows.Forms.Button btnTongTien;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label label1;
    }
}