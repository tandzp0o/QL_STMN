
namespace QL_STMN
{
    partial class frm_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_NhanVien));
            this.dgv_DanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.grSearchName = new System.Windows.Forms.GroupBox();
            this.comboBox_SearchChucVu = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grSearchSDT = new System.Windows.Forms.GroupBox();
            this.grDSNhanVien = new System.Windows.Forms.GroupBox();
            this.comboBox_ChucVu = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.grThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.labGioiTinh = new System.Windows.Forms.Label();
            this.labMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.labPhanQuyen = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.labSDT = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labTenNV = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNhanVien)).BeginInit();
            this.grSearchName.SuspendLayout();
            this.grSearchSDT.SuspendLayout();
            this.grDSNhanVien.SuspendLayout();
            this.grThongTinNhanVien.SuspendLayout();
            this.grSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSachNhanVien
            // 
            this.dgv_DanhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachNhanVien.Location = new System.Drawing.Point(2, 21);
            this.dgv_DanhSachNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_DanhSachNhanVien.MultiSelect = false;
            this.dgv_DanhSachNhanVien.Name = "dgv_DanhSachNhanVien";
            this.dgv_DanhSachNhanVien.ReadOnly = true;
            this.dgv_DanhSachNhanVien.RowHeadersWidth = 51;
            this.dgv_DanhSachNhanVien.RowTemplate.Height = 24;
            this.dgv_DanhSachNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachNhanVien.Size = new System.Drawing.Size(982, 248);
            this.dgv_DanhSachNhanVien.TabIndex = 0;
            this.dgv_DanhSachNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachNhanVien_CellClick);
            this.dgv_DanhSachNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DanhSachNhanVien_CellContentClick);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(12, 19);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(181, 23);
            this.txtSearchName.TabIndex = 16;
            // 
            // grSearchName
            // 
            this.grSearchName.Controls.Add(this.txtSearchName);
            this.grSearchName.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSearchName.Location = new System.Drawing.Point(7, 22);
            this.grSearchName.Name = "grSearchName";
            this.grSearchName.Size = new System.Drawing.Size(199, 52);
            this.grSearchName.TabIndex = 18;
            this.grSearchName.TabStop = false;
            this.grSearchName.Text = "Theo tên";
            // 
            // comboBox_SearchChucVu
            // 
            this.comboBox_SearchChucVu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SearchChucVu.FormattingEnabled = true;
            this.comboBox_SearchChucVu.Location = new System.Drawing.Point(16, 19);
            this.comboBox_SearchChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_SearchChucVu.Name = "comboBox_SearchChucVu";
            this.comboBox_SearchChucVu.Size = new System.Drawing.Size(177, 23);
            this.comboBox_SearchChucVu.TabIndex = 20;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(456, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 47);
            this.btnSearch.TabIndex = 108;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grSearchSDT
            // 
            this.grSearchSDT.Controls.Add(this.comboBox_SearchChucVu);
            this.grSearchSDT.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSearchSDT.Location = new System.Drawing.Point(229, 22);
            this.grSearchSDT.Name = "grSearchSDT";
            this.grSearchSDT.Size = new System.Drawing.Size(199, 52);
            this.grSearchSDT.TabIndex = 19;
            this.grSearchSDT.TabStop = false;
            this.grSearchSDT.Text = " Theo chức vụ";
            // 
            // grDSNhanVien
            // 
            this.grDSNhanVien.BackColor = System.Drawing.Color.White;
            this.grDSNhanVien.Controls.Add(this.dgv_DanhSachNhanVien);
            this.grDSNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDSNhanVien.Location = new System.Drawing.Point(9, 236);
            this.grDSNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grDSNhanVien.Name = "grDSNhanVien";
            this.grDSNhanVien.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grDSNhanVien.Size = new System.Drawing.Size(986, 271);
            this.grDSNhanVien.TabIndex = 21;
            this.grDSNhanVien.TabStop = false;
            this.grDSNhanVien.Text = "Danh sách nhân viên";
            // 
            // comboBox_ChucVu
            // 
            this.comboBox_ChucVu.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ChucVu.FormattingEnabled = true;
            this.comboBox_ChucVu.Location = new System.Drawing.Point(296, 99);
            this.comboBox_ChucVu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_ChucVu.Name = "comboBox_ChucVu";
            this.comboBox_ChucVu.Size = new System.Drawing.Size(126, 23);
            this.comboBox_ChucVu.TabIndex = 21;
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(296, 60);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(126, 23);
            this.dateTimePicker_NgaySinh.TabIndex = 32;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(533, 51);
            this.radNu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(39, 18);
            this.radNu.TabIndex = 31;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // grThongTinNhanVien
            // 
            this.grThongTinNhanVien.BackColor = System.Drawing.Color.White;
            this.grThongTinNhanVien.Controls.Add(this.comboBox_ChucVu);
            this.grThongTinNhanVien.Controls.Add(this.dateTimePicker_NgaySinh);
            this.grThongTinNhanVien.Controls.Add(this.radNu);
            this.grThongTinNhanVien.Controls.Add(this.radNam);
            this.grThongTinNhanVien.Controls.Add(this.label5);
            this.grThongTinNhanVien.Controls.Add(this.labGioiTinh);
            this.grThongTinNhanVien.Controls.Add(this.labMaNV);
            this.grThongTinNhanVien.Controls.Add(this.txtMaNV);
            this.grThongTinNhanVien.Controls.Add(this.labPhanQuyen);
            this.grThongTinNhanVien.Controls.Add(this.txtSDT);
            this.grThongTinNhanVien.Controls.Add(this.txtDiaChi);
            this.grThongTinNhanVien.Controls.Add(this.labSDT);
            this.grThongTinNhanVien.Controls.Add(this.labDiaChi);
            this.grThongTinNhanVien.Controls.Add(this.labTenNV);
            this.grThongTinNhanVien.Controls.Add(this.txtTenNV);
            this.grThongTinNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinNhanVien.Location = new System.Drawing.Point(9, 9);
            this.grThongTinNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grThongTinNhanVien.Name = "grThongTinNhanVien";
            this.grThongTinNhanVien.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grThongTinNhanVien.Size = new System.Drawing.Size(624, 131);
            this.grThongTinNhanVien.TabIndex = 19;
            this.grThongTinNhanVien.TabStop = false;
            this.grThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(467, 51);
            this.radNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(46, 18);
            this.radNam.TabIndex = 30;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(228, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 14);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ngày sinh:";
            // 
            // labGioiTinh
            // 
            this.labGioiTinh.AutoSize = true;
            this.labGioiTinh.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGioiTinh.Location = new System.Drawing.Point(494, 23);
            this.labGioiTinh.Name = "labGioiTinh";
            this.labGioiTinh.Size = new System.Drawing.Size(46, 14);
            this.labGioiTinh.TabIndex = 28;
            this.labGioiTinh.Text = "Giới tính";
            // 
            // labMaNV
            // 
            this.labMaNV.AutoSize = true;
            this.labMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaNV.Location = new System.Drawing.Point(4, 27);
            this.labMaNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMaNV.Name = "labMaNV";
            this.labMaNV.Size = new System.Drawing.Size(72, 13);
            this.labMaNV.TabIndex = 20;
            this.labMaNV.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(92, 23);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(128, 19);
            this.txtMaNV.TabIndex = 21;
            // 
            // labPhanQuyen
            // 
            this.labPhanQuyen.AutoSize = true;
            this.labPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPhanQuyen.Location = new System.Drawing.Point(226, 103);
            this.labPhanQuyen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labPhanQuyen.Name = "labPhanQuyen";
            this.labPhanQuyen.Size = new System.Drawing.Size(47, 13);
            this.labPhanQuyen.TabIndex = 18;
            this.labPhanQuyen.Text = "Chức vụ";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(296, 23);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(126, 19);
            this.txtSDT.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(91, 99);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(128, 19);
            this.txtDiaChi.TabIndex = 16;
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSDT.Location = new System.Drawing.Point(228, 27);
            this.labSDT.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(70, 13);
            this.labSDT.TabIndex = 15;
            this.labSDT.Text = "Số điện thoại";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDiaChi.Location = new System.Drawing.Point(4, 103);
            this.labDiaChi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(40, 13);
            this.labDiaChi.TabIndex = 14;
            this.labDiaChi.Text = "Địa chỉ";
            // 
            // labTenNV
            // 
            this.labTenNV.AutoSize = true;
            this.labTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTenNV.Location = new System.Drawing.Point(4, 68);
            this.labTenNV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labTenNV.Name = "labTenNV";
            this.labTenNV.Size = new System.Drawing.Size(76, 13);
            this.labTenNV.TabIndex = 5;
            this.labTenNV.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(92, 64);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(128, 19);
            this.txtTenNV.TabIndex = 8;
            // 
            // grSearch
            // 
            this.grSearch.BackColor = System.Drawing.Color.White;
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.grSearchSDT);
            this.grSearch.Controls.Add(this.grSearchName);
            this.grSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSearch.Location = new System.Drawing.Point(9, 143);
            this.grSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grSearch.Name = "grSearch";
            this.grSearch.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grSearch.Size = new System.Drawing.Size(624, 90);
            this.grSearch.TabIndex = 20;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Tìm kiếm nhân viên";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grChucNang
            // 
            this.grChucNang.BackColor = System.Drawing.Color.White;
            this.grChucNang.Controls.Add(this.btnClose);
            this.grChucNang.Controls.Add(this.btnRefresh);
            this.grChucNang.Controls.Add(this.btnUpdate);
            this.grChucNang.Controls.Add(this.btnDelete);
            this.grChucNang.Controls.Add(this.btnAdd);
            this.grChucNang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grChucNang.Location = new System.Drawing.Point(638, 9);
            this.grChucNang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grChucNang.Size = new System.Drawing.Size(357, 224);
            this.grChucNang.TabIndex = 18;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Các chức năng";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(185, 134);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 42);
            this.btnClose.TabIndex = 107;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(84, 134);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 42);
            this.btnRefresh.TabIndex = 105;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gainsboro;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(231, 56);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 42);
            this.btnUpdate.TabIndex = 104;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(138, 56);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(82, 42);
            this.btnDelete.TabIndex = 103;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(37, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 42);
            this.btnAdd.TabIndex = 102;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1005, 516);
            this.Controls.Add(this.grDSNhanVien);
            this.Controls.Add(this.grThongTinNhanVien);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.grChucNang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_NhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNhanVien)).EndInit();
            this.grSearchName.ResumeLayout(false);
            this.grSearchName.PerformLayout();
            this.grSearchSDT.ResumeLayout(false);
            this.grDSNhanVien.ResumeLayout(false);
            this.grThongTinNhanVien.ResumeLayout(false);
            this.grThongTinNhanVien.PerformLayout();
            this.grSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_DanhSachNhanVien;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.GroupBox grSearchName;
        private System.Windows.Forms.ComboBox comboBox_SearchChucVu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grSearchSDT;
        private System.Windows.Forms.GroupBox grDSNhanVien;
        private System.Windows.Forms.ComboBox comboBox_ChucVu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.GroupBox grThongTinNhanVien;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labGioiTinh;
        private System.Windows.Forms.Label labMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label labPhanQuyen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labTenNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}

