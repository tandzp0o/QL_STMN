using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_STMN
{
    
    public partial class frm_NhanVien : Form
    {
        DataSet ds_NhanVien = new DataSet();
        SqlDataAdapter da_NhanVien;
        SqlDataAdapter da_ChucVu;
        DataSet ds_ChucVu=new DataSet();
        private List<NhanVienSTMN> danhSachNhanVien = new List<NhanVienSTMN>();
        public frm_NhanVien()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        public void LoadData()
        {
            if (ds_NhanVien != null)
            {
                ds_NhanVien = new DataSet();
            }
            if (!ds_NhanVien.Tables.Contains("NhanVien"))
            {
                ds_NhanVien.Tables.Add("NhanVien");
            }
            else
            {
                ds_NhanVien.Tables["NhanVien"].Clear();
            }
            string query = "SELECT NhanVien.*, ChucVu.TenCV FROM NhanVien " +
                   "JOIN ChucVu ON NhanVien.MaCV = ChucVu.MaCV";
            da_NhanVien = new SqlDataAdapter(query, KetNoiDB.strconn);
            da_NhanVien.Fill(ds_NhanVien, "NhanVien");
            dgv_DanhSachNhanVien.DataSource = ds_NhanVien.Tables["NhanVien"];
            dgv_DanhSachNhanVien.Columns[0].HeaderText = "Mã nhân viên";
            dgv_DanhSachNhanVien.Columns[1].HeaderText = "Tên";
            dgv_DanhSachNhanVien.Columns[2].HeaderText = "Giới tính";
            dgv_DanhSachNhanVien.Columns[3].HeaderText = "Năm sinh";
            dgv_DanhSachNhanVien.Columns[4].HeaderText = "SĐT";
            dgv_DanhSachNhanVien.Columns[5].HeaderText = "Địa chỉ";
            dgv_DanhSachNhanVien.Columns[6].HeaderText = "Mã chức vụ";
            dgv_DanhSachNhanVien.Columns[7].HeaderText = "Tên chức vụ";
            DataColumn[] key = new DataColumn[1];
            key[0] = ds_NhanVien.Tables["NhanVien"].Columns[0];
            ds_NhanVien.Tables["NhanVien"].PrimaryKey = key;
        }
        void LoadCombbChucVu()
        {
            using (SqlConnection connection = new SqlConnection(KetNoiDB.strconn))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("select TenCV from ChucVu", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string chucvu = reader["TenCV"].ToString();


                            // Add the item to the ComboBox
                            comboBox_ChucVu.Items.Add(chucvu);
                        }
                    }
                }
            }
        }
        void LoadCombbSearchChucVu()
        {
            string strSel = "select*from ChucVu";
            da_ChucVu = new SqlDataAdapter(strSel, KetNoiDB.strconn);
            da_ChucVu.Fill(ds_ChucVu, "ChucVu");
            comboBox_SearchChucVu.DataSource = ds_ChucVu.Tables["ChucVu"];
            comboBox_SearchChucVu.DisplayMember = "TenCV";
            comboBox_SearchChucVu.ValueMember = "MacV";
        }
        public bool KiemTraKhoaChinh(string maCV)
        {
            DataTable table = new DataTable();

            string selectString = "SELECT * FROM ChucVu WHERE MaChucVu = '" + maCV + "'";
            SqlDataAdapter daKTKC = new SqlDataAdapter(selectString, KetNoiDB.strconn);
            daKTKC.Fill(table);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }
        private bool kiemTraDuLieuSua()
        {
            bool check = true;
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDiaChi.Text == "" ||
                txtSDT.Text == "" || dateTimePicker_NgaySinh.Value == null ||
                comboBox_ChucVu.Text == "" || (radNam.Checked == false && radNu.Checked == false))
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông Tin !", "Error", MessageBoxButtons.OK);
                check = false;
            }
            return check;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCombbChucVu();
            LoadCombbSearchChucVu();
            LoadData();
        }
        private void ClearInputFields()
        {
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            comboBox_ChucVu.SelectedIndex = -1;
        }
        private List<NhanVienSTMN> GetDataFromDatabase()
        {
            List<NhanVienSTMN> data = new List<NhanVienSTMN>();

            try
            {
                using (SqlConnection connection = new SqlConnection(KetNoiDB.strconn))
                {
                    connection.Open();

                    string selectQuery = "SELECT * FROM NhanVien";

                    using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                NhanVienSTMN nhanVien = new NhanVienSTMN(
                                    reader["MaNV"].ToString(),
                                    reader["TenNV"].ToString(),
                                    reader["GioiTinh"].ToString(),
                                    Convert.ToDateTime(reader["NamSinh"]),
                                    reader["SDT_NV"].ToString(),
                                    reader["DiaChi_NV"].ToString(),
                                    reader["MaCV"].ToString()
                                );

                                data.Add(nhanVien);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thông tin từ database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return data;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchName = txtSearchName.Text.Trim();
            string searchChucVu = comboBox_SearchChucVu.SelectedValue?.ToString().Trim();

            // Kiểm tra nhập ít nhất một thông tin cần thiết để tìm 
            if (!string.IsNullOrEmpty(searchName) || !string.IsNullOrEmpty(searchChucVu))
            {
                // Filter the DataView based on the entered product name
                DataView dv = new DataView(ds_NhanVien.Tables["NhanVien"]);
                string filterExpression = $"TenNV LIKE '%{searchName}%'";

                if (!string.IsNullOrEmpty(searchChucVu))
                {
                    filterExpression += $" AND MaCV = '{searchChucVu}'";
                }

                dv.RowFilter = filterExpression;

                // Check if any rows match the filter
                if (dv.Count > 0)
                {
                    // Display the filtered results in the DataGridView
                    dgv_DanhSachNhanVien.DataSource = dv.ToTable();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ít nhất một tiêu chí tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private List<NhanVienSTMN> SearchNhanVienInDatabase(string name, string chucVu)
        {
            List<NhanVienSTMN> searchResults = new List<NhanVienSTMN>();

            try
            {
                using (SqlConnection connection = new SqlConnection(KetNoiDB.strconn))
                {
                    connection.Open();

                    string searchQuery = "SELECT * FROM NhanVien WHERE (@TenNV IS NULL OR TenNV LIKE @TenNV) AND (@MaCV IS NULL OR MaCV = @MaCV)";

                    using (SqlCommand cmd = new SqlCommand(searchQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@TenNV", string.IsNullOrEmpty(name) ? (object)DBNull.Value : $"%{name}%");
                        cmd.Parameters.AddWithValue("@MaCV", string.IsNullOrEmpty(chucVu) ? (object)DBNull.Value : chucVu);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                NhanVienSTMN nhanVien = new NhanVienSTMN(
                                    reader["MaNV"].ToString(),
                                    reader["TenNV"].ToString(),
                                    reader["GioiTinh"].ToString(),
                                    Convert.ToDateTime(reader["NamSinh"]),
                                    reader["SDT_NV"].ToString(),
                                    reader["DiaChi_NV"].ToString(),
                                    reader["MaCV"].ToString()
                                );

                                searchResults.Add(nhanVien);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm trong database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return searchResults;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        public string maCV(string tenCV)
        {
            string maCV="";
            try
            {
                using (SqlConnection connection = new SqlConnection(KetNoiDB.strconn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT MaCV FROM ChucVu WHERE TenCV = @tencv", connection))
                    {
                        command.Parameters.AddWithValue("@tencv", tenCV);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               maCV = reader["MaCV"].ToString();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                // Ví dụ: Log lỗi, hiển thị thông báo cho người dùng, hoặc thực hiện hành động khác.
                // Ở đây tôi chỉ in lỗi ra màn hình để gỡ lỗi.
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return maCV;
        }
        public string tenCV(string maCV)
        {
            string tenCV = "";
            try
            {
                using (SqlConnection connection = new SqlConnection(KetNoiDB.strconn))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT TenCV FROM ChucVu WHERE MaCV = @macv", connection))
                    {
                        command.Parameters.AddWithValue("@macv", maCV);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                tenCV = reader["TenCV"].ToString();
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                // Ví dụ: Log lỗi, hiển thị thông báo cho người dùng, hoặc thực hiện hành động khác.
                // Ở đây tôi chỉ in lỗi ra màn hình để gỡ lỗi.
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            return tenCV;
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (kiemTraDuLieuSua())
            {
                string maNV = txtMaNV.Text;
                string tenNV = txtTenNV.Text;
                string diaChi = txtDiaChi.Text;
                string sdt = txtSDT.Text;
                DateTime namSinh = dateTimePicker_NgaySinh.Value;
                string maChucVu = maCV(comboBox_ChucVu.Text);
                string gioiTinh = radNam.Checked ? "Nam" : "Nữ";

                // Tạo nhân viên mới vào NhanVienSTMN
                NhanVienSTMN newNhanVien = new NhanVienSTMN(maNV, tenNV, gioiTinh, namSinh, sdt, diaChi, maChucVu);

                // Thêm nhân viên mới vào danh sách nhân viên
                danhSachNhanVien.Add(newNhanVien);

                // Thêm nhân viên mới vào database
                AddNhanVienToDatabase(newNhanVien);

                // Cập nhật dữ liệu thêm vào ListView
                LoadData();

                ClearInputFields();
            }
        }

        private void AddNhanVienToDatabase(NhanVienSTMN nhanVien)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(KetNoiDB.strconn))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO NhanVien (MaNV, TenNV, GioiTinh, NamSinh, SDT_NV, DiaChi_NV, MaCV) " +
                                         "VALUES (@MaNV, @TenNV, @GioiTinh, @NamSinh, @SDT_NV, @DiaChi_NV, @MaCV)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", nhanVien.MaNhanVien);
                        cmd.Parameters.AddWithValue("@TenNV", nhanVien.TenNhanVien);
                        cmd.Parameters.AddWithValue("@GioiTinh", nhanVien.GioiTinh);
                        cmd.Parameters.AddWithValue("@NamSinh", nhanVien.NamSinh);
                        cmd.Parameters.AddWithValue("@SDT_NV", nhanVien.SoDienThoai);
                        cmd.Parameters.AddWithValue("@DiaChi_NV", nhanVien.DiaChi);
                        cmd.Parameters.AddWithValue("@MaCV", nhanVien.MaChucVu);

                        // Thực thi truy vấn
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm nhân viên vào database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgv_DanhSachNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_DanhSachNhanVien.SelectedRows[0];

                string maNVToDelete = selectedRow.Cells["MaNV"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn xóa nhân viên có Mã NV: {maNVToDelete}?",
                                                      "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Xoá nhân viên khỏi database
                    DeleteNhanVienFromDatabase(maNVToDelete);

                    // Xoá thông tin nhân viên khỏi ListView
                    dgv_DanhSachNhanVien.Rows.Remove(selectedRow);

                    ClearInputFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void DeleteNhanVienFromDatabase(string maNV)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(KetNoiDB.strconn))
                {
                    connection.Open();

                    string deleteQuery = "DELETE FROM NhanVien WHERE MaNV = @MaNV";

                    using (SqlCommand cmd = new SqlCommand(deleteQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);

                        // Thực thi truy vấn
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể xoá nhân viên", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgv_DanhSachNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_DanhSachNhanVien.SelectedRows[0];
                string maNVToUpdate = selectedRow.Cells["MaNV"].Value.ToString();

                DialogResult result = MessageBox.Show($"Bạn có chắc chắn muốn cập nhật thông tin nhân viên có Mã NV: {maNVToUpdate}?",
                                                      "Xác nhận cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                string maCv = comboBox_ChucVu.Text;
 
                if (result == DialogResult.Yes && kiemTraDuLieuSua())
                {
                    string tenNV = txtTenNV.Text;
                    string diaChi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    DateTime namSinh = dateTimePicker_NgaySinh.Value;
                    string maChucVu;
                    if (maCv == "Quản lý")
                        maChucVu = "CV01";
                    else
                        maChucVu= "CV02";
                    string gioiTinh = radNam.Checked ? "Nam" : "Nữ";

                    // Update employee information in the database
                    UpdateNhanVienInDatabase(maNVToUpdate, tenNV, gioiTinh, namSinh, sdt, diaChi, maChucVu);

                    // Update the selected row in the DataGridView
                    selectedRow.Cells["TenNV"].Value = tenNV;
                    selectedRow.Cells["GioiTinh"].Value = gioiTinh;
                    selectedRow.Cells["NamSinh"].Value = namSinh.ToShortDateString();
                    selectedRow.Cells["SDT_NV"].Value = sdt;
                    selectedRow.Cells["DiaChi_NV"].Value = diaChi;
                    selectedRow.Cells["MaCV"].Value = maChucVu;

                    ClearInputFields();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadData();
        }

        private void UpdateNhanVienInDatabase(string maNV, string tenNV, string gioiTinh, DateTime namSinh, string sdt, string diaChi, string maChucVu)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(KetNoiDB.strconn))
                {
                    connection.Open();

                    string updateQuery = "UPDATE NhanVien SET TenNV = @TenNV, GioiTinh = @GioiTinh, NamSinh = @NamSinh, " +
                                         "SDT_NV = @SDT_NV, DiaChi_NV = @DiaChi_NV, MaCV = @MaCV WHERE MaNV = @MaNV";

                    using (SqlCommand cmd = new SqlCommand(updateQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@MaNV", maNV);
                        cmd.Parameters.AddWithValue("@TenNV", tenNV);
                        cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        cmd.Parameters.AddWithValue("@NamSinh", namSinh);
                        cmd.Parameters.AddWithValue("@SDT_NV", sdt);
                        cmd.Parameters.AddWithValue("@DiaChi_NV", diaChi);
                        cmd.Parameters.AddWithValue("@MaCV", maChucVu);
                        // Thực thi truy vấn
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi cập nhật thông tin trong database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            // Cập nhật dữ liệu vào database
            LoadData();
            dgv_DanhSachNhanVien.ClearSelection();
        }

        private void dgv_DanhSachNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
     

        }

        private void dgv_DanhSachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;

            i = dgv_DanhSachNhanVien.CurrentRow.Index;
            txtMaNV.Text = dgv_DanhSachNhanVien.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgv_DanhSachNhanVien.Rows[i].Cells[1].Value.ToString();
            string gt = dgv_DanhSachNhanVien.Rows[i].Cells[2].Value.ToString();
            if (string.Compare(gt, "Nam") == 0)
            {
                radNam.Checked = true;
                radNu.Checked = false;

            }
            else
            {
                radNam.Checked = false;
                radNu.Checked = true;
            }
            dateTimePicker_NgaySinh.Text = dgv_DanhSachNhanVien.Rows[i].Cells[3].Value.ToString();
            txtSDT.Text = dgv_DanhSachNhanVien.Rows[i].Cells[4].Value.ToString();
            txtDiaChi.Text = dgv_DanhSachNhanVien.Rows[i].Cells[5].Value.ToString();
            comboBox_ChucVu.Text = tenCV(dgv_DanhSachNhanVien.Rows[i].Cells[6].Value.ToString());
        }
    }
}