
namespace QL_STMN
{
    partial class Form_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_NhanVien));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.dgv_DanhSachNhanVien = new System.Windows.Forms.DataGridView();
            this.grDSNhanVien = new System.Windows.Forms.GroupBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.grSearchName = new System.Windows.Forms.GroupBox();
            this.comboBox_SearchChucVu = new System.Windows.Forms.ComboBox();
            this.grSearchSDT = new System.Windows.Forms.GroupBox();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.comboBox_ChucVu = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.labGioiTinh = new System.Windows.Forms.Label();
            this.grThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.labMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.labPhanQuyen = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.labSDT = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labTenNV = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNhanVien)).BeginInit();
            this.grDSNhanVien.SuspendLayout();
            this.grSearchName.SuspendLayout();
            this.grSearchSDT.SuspendLayout();
            this.grSearch.SuspendLayout();
            this.grThongTinNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_DanhSachNhanVien
            // 
            this.dgv_DanhSachNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DanhSachNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DanhSachNhanVien.Location = new System.Drawing.Point(3, 24);
            this.dgv_DanhSachNhanVien.MultiSelect = false;
            this.dgv_DanhSachNhanVien.Name = "dgv_DanhSachNhanVien";
            this.dgv_DanhSachNhanVien.ReadOnly = true;
            this.dgv_DanhSachNhanVien.RowHeadersWidth = 51;
            this.dgv_DanhSachNhanVien.RowTemplate.Height = 24;
            this.dgv_DanhSachNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DanhSachNhanVien.Size = new System.Drawing.Size(1307, 268);
            this.dgv_DanhSachNhanVien.TabIndex = 0;
            // 
            // grDSNhanVien
            // 
            this.grDSNhanVien.BackColor = System.Drawing.Color.Aqua;
            this.grDSNhanVien.Controls.Add(this.dgv_DanhSachNhanVien);
            this.grDSNhanVien.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grDSNhanVien.Location = new System.Drawing.Point(4, 270);
            this.grDSNhanVien.Name = "grDSNhanVien";
            this.grDSNhanVien.Size = new System.Drawing.Size(1313, 295);
            this.grDSNhanVien.TabIndex = 21;
            this.grDSNhanVien.TabStop = false;
            this.grDSNhanVien.Text = "Danh sách nhân viên";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchName.Location = new System.Drawing.Point(16, 23);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(240, 30);
            this.txtSearchName.TabIndex = 16;
            // 
            // grSearchName
            // 
            this.grSearchName.Controls.Add(this.txtSearchName);
            this.grSearchName.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSearchName.Location = new System.Drawing.Point(9, 27);
            this.grSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.grSearchName.Name = "grSearchName";
            this.grSearchName.Padding = new System.Windows.Forms.Padding(4);
            this.grSearchName.Size = new System.Drawing.Size(265, 64);
            this.grSearchName.TabIndex = 18;
            this.grSearchName.TabStop = false;
            this.grSearchName.Text = "Theo tên";
            // 
            // comboBox_SearchChucVu
            // 
            this.comboBox_SearchChucVu.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SearchChucVu.FormattingEnabled = true;
            this.comboBox_SearchChucVu.Location = new System.Drawing.Point(21, 23);
            this.comboBox_SearchChucVu.Name = "comboBox_SearchChucVu";
            this.comboBox_SearchChucVu.Size = new System.Drawing.Size(235, 30);
            this.comboBox_SearchChucVu.TabIndex = 20;
            // 
            // grSearchSDT
            // 
            this.grSearchSDT.Controls.Add(this.comboBox_SearchChucVu);
            this.grSearchSDT.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSearchSDT.Location = new System.Drawing.Point(305, 27);
            this.grSearchSDT.Margin = new System.Windows.Forms.Padding(4);
            this.grSearchSDT.Name = "grSearchSDT";
            this.grSearchSDT.Padding = new System.Windows.Forms.Padding(4);
            this.grSearchSDT.Size = new System.Drawing.Size(265, 64);
            this.grSearchSDT.TabIndex = 19;
            this.grSearchSDT.TabStop = false;
            this.grSearchSDT.Text = " Theo chức vụ";
            // 
            // grSearch
            // 
            this.grSearch.BackColor = System.Drawing.Color.Aqua;
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.grSearchSDT);
            this.grSearch.Controls.Add(this.grSearchName);
            this.grSearch.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSearch.Location = new System.Drawing.Point(4, 153);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(832, 111);
            this.grSearch.TabIndex = 20;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Tìm kiếm nhân viên";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = global::QL_STMN.Properties.Resources.icons8_search_48;
            this.btnSearch.Location = new System.Drawing.Point(608, 33);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 55);
            this.btnSearch.TabIndex = 108;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // comboBox_ChucVu
            // 
            this.comboBox_ChucVu.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_ChucVu.FormattingEnabled = true;
            this.comboBox_ChucVu.Location = new System.Drawing.Point(395, 107);
            this.comboBox_ChucVu.Name = "comboBox_ChucVu";
            this.comboBox_ChucVu.Size = new System.Drawing.Size(166, 30);
            this.comboBox_ChucVu.TabIndex = 21;
            // 
            // dateTimePicker_NgaySinh
            // 
            this.dateTimePicker_NgaySinh.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_NgaySinh.Location = new System.Drawing.Point(395, 68);
            this.dateTimePicker_NgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker_NgaySinh.Name = "dateTimePicker_NgaySinh";
            this.dateTimePicker_NgaySinh.Size = new System.Drawing.Size(166, 27);
            this.dateTimePicker_NgaySinh.TabIndex = 32;
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.Location = new System.Drawing.Point(711, 63);
            this.radNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(47, 20);
            this.radNu.TabIndex = 31;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.Location = new System.Drawing.Point(623, 63);
            this.radNam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(57, 20);
            this.radNam.TabIndex = 30;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(304, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ngày sinh:";
            // 
            // labGioiTinh
            // 
            this.labGioiTinh.AutoSize = true;
            this.labGioiTinh.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labGioiTinh.Location = new System.Drawing.Point(659, 28);
            this.labGioiTinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labGioiTinh.Name = "labGioiTinh";
            this.labGioiTinh.Size = new System.Drawing.Size(62, 16);
            this.labGioiTinh.TabIndex = 28;
            this.labGioiTinh.Text = "Giới tính";
            // 
            // grThongTinNhanVien
            // 
            this.grThongTinNhanVien.BackColor = System.Drawing.Color.Aqua;
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
            this.grThongTinNhanVien.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grThongTinNhanVien.Location = new System.Drawing.Point(4, 5);
            this.grThongTinNhanVien.Name = "grThongTinNhanVien";
            this.grThongTinNhanVien.Size = new System.Drawing.Size(832, 141);
            this.grThongTinNhanVien.TabIndex = 19;
            this.grThongTinNhanVien.TabStop = false;
            this.grThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // labMaNV
            // 
            this.labMaNV.AutoSize = true;
            this.labMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMaNV.Location = new System.Drawing.Point(6, 33);
            this.labMaNV.Name = "labMaNV";
            this.labMaNV.Size = new System.Drawing.Size(93, 17);
            this.labMaNV.TabIndex = 20;
            this.labMaNV.Text = "Mã nhân viên";
            // 
            // txtMaNV
            // 
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(123, 28);
            this.txtMaNV.Multiline = true;
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(169, 22);
            this.txtMaNV.TabIndex = 21;
            // 
            // labPhanQuyen
            // 
            this.labPhanQuyen.AutoSize = true;
            this.labPhanQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPhanQuyen.Location = new System.Drawing.Point(304, 118);
            this.labPhanQuyen.Name = "labPhanQuyen";
            this.labPhanQuyen.Size = new System.Drawing.Size(59, 17);
            this.labPhanQuyen.TabIndex = 18;
            this.labPhanQuyen.Text = "Chức vụ";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(395, 28);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(166, 22);
            this.txtSDT.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(123, 113);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(169, 22);
            this.txtDiaChi.TabIndex = 16;
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSDT.Location = new System.Drawing.Point(304, 33);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(91, 17);
            this.labSDT.TabIndex = 15;
            this.labSDT.Text = "Số điện thoại";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDiaChi.Location = new System.Drawing.Point(8, 118);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(51, 17);
            this.labDiaChi.TabIndex = 14;
            this.labDiaChi.Text = "Địa chỉ";
            // 
            // labTenNV
            // 
            this.labTenNV.AutoSize = true;
            this.labTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTenNV.Location = new System.Drawing.Point(6, 78);
            this.labTenNV.Name = "labTenNV";
            this.labTenNV.Size = new System.Drawing.Size(99, 17);
            this.labTenNV.TabIndex = 5;
            this.labTenNV.Text = "Tên nhân viên";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft JhengHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(123, 73);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(169, 22);
            this.txtTenNV.TabIndex = 8;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // grChucNang
            // 
            this.grChucNang.BackColor = System.Drawing.Color.Aqua;
            this.grChucNang.Controls.Add(this.btnClose);
            this.grChucNang.Controls.Add(this.btnShowReport);
            this.grChucNang.Controls.Add(this.btnRefesh);
            this.grChucNang.Controls.Add(this.btnEdit);
            this.grChucNang.Controls.Add(this.btnDelete);
            this.grChucNang.Controls.Add(this.btnAdd);
            this.grChucNang.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grChucNang.Location = new System.Drawing.Point(842, 5);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Size = new System.Drawing.Size(475, 259);
            this.grChucNang.TabIndex = 18;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Các chức năng";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::QL_STMN.Properties.Resources.icons8_close_48;
            this.btnClose.Location = new System.Drawing.Point(358, 137);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 55);
            this.btnClose.TabIndex = 115;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnShowReport
            // 
            this.btnShowReport.BackColor = System.Drawing.Color.Transparent;
            this.btnShowReport.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnShowReport.FlatAppearance.BorderSize = 0;
            this.btnShowReport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowReport.Image = global::QL_STMN.Properties.Resources.icons8_print_48;
            this.btnShowReport.Location = new System.Drawing.Point(211, 137);
            this.btnShowReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(60, 55);
            this.btnShowReport.TabIndex = 113;
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefesh.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnRefesh.FlatAppearance.BorderSize = 0;
            this.btnRefesh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.Image = global::QL_STMN.Properties.Resources.icons8_refresh_48;
            this.btnRefesh.Location = new System.Drawing.Point(56, 128);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(95, 72);
            this.btnRefesh.TabIndex = 112;
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::QL_STMN.Properties.Resources.icons8_edit_48;
            this.btnEdit.Location = new System.Drawing.Point(358, 44);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 55);
            this.btnEdit.TabIndex = 111;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::QL_STMN.Properties.Resources.icons8_delete_48;
            this.btnDelete.Location = new System.Drawing.Point(211, 44);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(60, 55);
            this.btnDelete.TabIndex = 110;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkCyan;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::QL_STMN.Properties.Resources.icons8_add_48;
            this.btnAdd.Location = new System.Drawing.Point(73, 44);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(60, 55);
            this.btnAdd.TabIndex = 109;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1321, 570);
            this.Controls.Add(this.grDSNhanVien);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.grThongTinNhanVien);
            this.Controls.Add(this.grChucNang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_NhanVien";
            this.Text = "Form_NhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_NhanVien_FormClosing);
            this.Load += new System.EventHandler(this.Form_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DanhSachNhanVien)).EndInit();
            this.grDSNhanVien.ResumeLayout(false);
            this.grSearchName.ResumeLayout(false);
            this.grSearchName.PerformLayout();
            this.grSearchSDT.ResumeLayout(false);
            this.grSearch.ResumeLayout(false);
            this.grThongTinNhanVien.ResumeLayout(false);
            this.grThongTinNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.DataGridView dgv_DanhSachNhanVien;
        private System.Windows.Forms.GroupBox grDSNhanVien;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.GroupBox grSearchName;
        private System.Windows.Forms.ComboBox comboBox_SearchChucVu;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grSearchSDT;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ComboBox comboBox_ChucVu;
        private System.Windows.Forms.DateTimePicker dateTimePicker_NgaySinh;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labGioiTinh;
        private System.Windows.Forms.GroupBox grThongTinNhanVien;
        private System.Windows.Forms.Label labMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label labPhanQuyen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labTenNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}