using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_STMN
{
    public partial class frm_QLKhachHang : Form
    {
        KetNoiDB db;

        string maKH;

        string tenKH;

        string sdtKH;

        string diaChiKH;

        DataTable dt;
        private bool isEditing = false;
        private int rowIndexToEdit = -1;
        public frm_QLKhachHang()
        {
            InitializeComponent();
        }

        private void frm_QLKhachHang_Load(object sender, EventArgs e)
        {
            Load_DGV();
            Load_GRB();
            dgv_DSKH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string gettime = DateTime.Now.ToString();
            txtDateTime.Text = gettime;
        }

        // 0.2 Tắt Group Box nhập thông tin
        public void Load_GRB()
        {
            grpSanPham.Enabled = false;
        }

        // 0.3 Load Data Grid View NhaCungCap
        public void Load_DGV()
        {
            string sql = "SELECT * FROM KhachHang";

            dt = DBConnect.Instance.ExecuteReader(sql);

            dgv_DSKH.DataSource = dt;
        }// 1.2 Kiểm tra dữ liệu đầu vào
        private bool IsValidInput()
        {
            if (string.IsNullOrEmpty(txtTenKH.Text) || string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin bắt buộc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // 1.3 Load textbox vào các đối tượng
        public void Load_Input_Data(string maKH_)
        {
            maKH = txtMaKH.Text;
            tenKH = txtTenKH.Text;
            diaChiKH = txtDiaChi.Text;
            sdtKH = txtSDT.Text;
        }

        // 1.4 Thêm dữ liệu vào DataTable
        private void AddDataToDataTable()
        {
            DataRow newRow = dt.NewRow();

            newRow["MaKH"] = maKH;
            newRow["TenKH"] = tenKH;
            newRow["SDT_KH"] = sdtKH;
            newRow["DiaChi_KH"] = diaChiKH;

            dt.Rows.Add(newRow);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH_ = "";
            if (grpSanPham.Enabled == false)
            {
                grpSanPham.Enabled = true;
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtSDT.Clear();
                txtDiaChi.Clear();

                string sql = "SELECT SUBSTRING(MAX(MaKH), 3, 3) FROM KHACHHANG";

                String st = (String)DBConnect.Instance.getScalar(sql);
                int stt = Int32.Parse(st);
                stt++;
                String strStt = stt.ToString("000");
                String maKH = "KH" + strStt;

                txtMaKH.Text = maKH;
            }
            else if (IsValidInput())
            {
                Load_Input_Data(maKH_);
                int kq = DBConnect.Instance.ExcuteNonQuery("INSERT INTO KhachHang (MaKH, TenKH, SDT_KH, DiaChi_KH) " + $"VALUES ('{maKH}', N'{tenKH}', '{sdtKH}', N'{diaChiKH}')");


                if (kq == 0)
                {
                    MessageBox.Show("Thêm không thành công!");
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công!");
                    Load_DGV();
                }
                if (grpSanPham.Enabled == true)
                {
                    grpSanPham.Enabled = false;
                    txtMaKH.Clear();
                    txtTenKH.Clear();
                    txtSDT.Clear();
                    txtDiaChi.Clear();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgv_DSKH.SelectedRows.Count > 0)
            {
                string maKHToDelete = dgv_DSKH.SelectedRows[0].Cells["MaKHH"].Value.ToString();
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        string deleteSql = $"DELETE FROM KhachHang WHERE MaKH = '{maKHToDelete}'";
                        DBConnect.Instance.ExcuteNonQuery(deleteSql);
                        dgv_DSKH.Rows.RemoveAt(dgv_DSKH.SelectedRows[0].Index);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng bạn muốn xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            Load_DGV();
            Load_GRB();

            txtMaKH.Clear();
            txtTenKH.Clear();
            txtDiaChi.Clear();
            txtSDT.Clear();
            txtTimKiem.Clear();

            MessageBox.Show("Làm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (isEditing)
            {
                SaveEditedData();

                Load_DGV();
                Load_GRB();

                txtMaKH.Clear();
                txtTenKH.Clear();
                txtDiaChi.Clear();
                txtSDT.Clear();
                txtTimKiem.Clear();

                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (dgv_DSKH.SelectedRows.Count > 0)
                {
                    Load_Input_Data_2();

                    txtMaKH.Text = maKH;
                    txtTenKH.Text = tenKH;
                    txtDiaChi.Text = diaChiKH;
                    txtSDT.Text = sdtKH;

                    rowIndexToEdit = dgv_DSKH.SelectedRows[0].Index;
                    isEditing = true;
                    btnSua.Text = "Lưu";
                    grpSanPham.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn dòng bạn muốn sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        // 4.2 Phương thức để lưu dữ liệu sau khi sửa
        private void SaveEditedData()
        {
            // Sủa lại chỗ này
            maKH = txtMaKH.Text;
            tenKH = txtTenKH.Text;
            diaChiKH = txtDiaChi.Text;
            sdtKH = txtSDT.Text;

            string updateSql = $"UPDATE KhachHang SET TenKH = N'{tenKH}', SDT_KH = '{sdtKH}', DiaChi_KH = N'{diaChiKH}' WHERE MaKH = '{maKH}'";
            DBConnect.Instance.ExcuteNonQuery(updateSql);

            // Cập nhật dòng trong DataTable
            dt.Rows[rowIndexToEdit]["MaKH"] = maKH;
            dt.Rows[rowIndexToEdit]["TenKH"] = tenKH;
            dt.Rows[rowIndexToEdit]["SDT_KH"] = sdtKH;
            dt.Rows[rowIndexToEdit]["DiaChi_KH"] = diaChiKH;

            isEditing = false;
            rowIndexToEdit = -1;

            btnSua.Text = "Sửa";
        }

        // 4.3 Gán lại các đối tượng sau khi sửa
        public void Load_Input_Data_2()
        {
            maKH = dgv_DSKH.SelectedRows[0].Cells["MaKHH"].Value.ToString();
            tenKH = dgv_DSKH.SelectedRows[0].Cells["TenKHH"].Value.ToString();
            sdtKH = dgv_DSKH.SelectedRows[0].Cells["SDT_KHH"].Value.ToString();
            diaChiKH = dgv_DSKH.SelectedRows[0].Cells["DiaChi_KHH"].Value.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string searchTen = txtTimKiem.Text.ToLower();

                DataTable filteredDataTable = dt.Clone();

                foreach (DataRow row in dt.Rows)
                {
                    string tenNCC = row.Field<string>("TenKH").ToLower();

                    if (tenNCC.IndexOf(searchTen) != -1)
                        filteredDataTable.ImportRow(row);
                }

                dgv_DSKH.DataSource = filteredDataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_DSKH_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_DSKH.SelectedRows.Count > 0)
            {
                Load_Input_Data_2();

                txtMaKH.Text = maKH;
                txtTenKH.Text = tenKH;
                txtSDT.Text = sdtKH;
                txtDiaChi.Text = diaChiKH;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {

            // Kiểm tra xem ký tự nhập vào có phải là số và không phải là phím Control (như phím Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Không cho phép nhập ký tự này vào TextBox
            }
            // Kiểm tra độ dài của chuỗi trong TextBox
            TextBox textBox = sender as TextBox;

            if (textBox != null && textBox.Text.Length >= 10 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Nếu độ dài vượt quá 12 và không phải phím Backspace, không cho nhập thêm
            }
        }

        private void frm_QLKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            string tieuDe = "Bạn muốn thoát không?";
            string caption = "Thông báo";
            DialogResult r = MessageBox.Show(tieuDe, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

