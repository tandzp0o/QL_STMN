using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QL_STMN
{
    public partial class frm_NhaCungCap : Form
    {
        SqlConnection conn;
        DataTable NCC;
        SqlDataAdapter adap;
        public frm_NhaCungCap()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoiDB.strconn);
            NCC = new DataTable();
        }
        private void loadNCC()
        {
            adap = new SqlDataAdapter("Select MaNCC as N'Mã nhà cung cấp', TenNCC as N'Tên nhà cung cấp', DiaChi_NCC as N'Địa chỉ nhà cung cấp' from NhaCungCap", conn);
            adap.Fill(NCC);

            DataColumn[] key = new DataColumn[1];
            key[0] = NCC.Columns[0];
            NCC.PrimaryKey = key;

            dgvNCC.DataSource = NCC;
        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            loadNCC();
            Bingdings();
        }
        private void Bingdings()
        {
            txtMaNCC.DataBindings.Add("Text", dgvNCC.DataSource, "Mã nhà cung cấp");
            txtTenNCC.DataBindings.Add("Text", dgvNCC.DataSource, "Tên nhà cung cấp");
            txtDiaChiNCC.DataBindings.Add("Text", dgvNCC.DataSource, "Địa chỉ nhà cung cấp");
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool isDuplicatePriKey(String ma)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd;
            string sql = "Select count(*) from NhaCungCap where MaNCC='" + ma + "'";
            cmd = new SqlCommand(sql, conn);
            int sl = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            if (sl > 0)
                return true;
            else
                return false;
        }
        private void themNCC()
        {
            adap = new SqlDataAdapter("Select MaNCC as N'Mã nhà cung cấp', TenNCC as N'Tên nhà cung cấp', DiaChi_NCC as N'Địa chỉ nhà cung cấp' from NhaCungCap", conn);
            DataRow newRow = NCC.NewRow();

            newRow["Mã nhà cung cấp"] = txtMaNCC.Text;
            newRow["Tên nhà cung cấp"] = txtTenNCC.Text;
            newRow["Địa chỉ nhà cung cấp"] = txtDiaChiNCC.Text;
            NCC.Rows.Add(newRow);

            SqlCommandBuilder builder = new SqlCommandBuilder(adap);
            int kq = adap.Update(NCC);
            if (kq == 0)
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã thêm nhà cung cấp mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadNCC();
            }
            dgvNCC.DataSource = NCC;
        }
        private void xoaNCC()
        {
            if (MessageBox.Show("Xác nhận xóa nhà cung cấp này?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter ds_HH = new SqlDataAdapter("Select *from HangHoa where MaNCC = '" + txtMaNCC.Text + "'", conn);
                ds_HH.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Nhà cung cấp này đang được sử dụng không thể xóa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                adap = new SqlDataAdapter("Select MaNCC as N'Mã nhà cung cấp', TenNCC as N'Tên nhà cung cấp', DiaChi_NCC as N'Địa chỉ nhà cung cấp' from NhaCungCap", conn);
                DataRow deleteRow = NCC.Rows.Find(txtMaNCC.Text);
                if (deleteRow != null)
                    deleteRow.Delete();
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adap);
                int kq = adap.Update(NCC);
                if (kq == 0)
                    MessageBox.Show("Xóa nhà cung cấp không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Xóa nhà cung cấp thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                dgvNCC.DataSource = NCC;
            }
        }
        private void suaNCC()
        {
            adap = new SqlDataAdapter("Select MaNCC as N'Mã nhà cung cấp', TenNCC as N'Tên nhà cung cấp', DiaChi_NCC as N'Địa chỉ nhà cung cấp' from NhaCungCap", conn);
            DataRow updateRow = NCC.Rows.Find(txtMaNCC.Text);
            if (updateRow != null)
            {
                updateRow.BeginEdit();
                updateRow["Tên nhà cung cấp"] = txtTenNCC.Text;
                updateRow["Địa chỉ nhà cung cấp"] = txtDiaChiNCC.Text;
                updateRow.EndEdit();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa nhà cung cấp không thành công\nLý do: không tìm thấy mã nhà cung cấp\nLưu ý: Không được sửa mã nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadNCC();
                return;
            }
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adap);
            int kq = adap.Update(NCC);
            if (kq == 0)
                MessageBox.Show("Chỉnh sửa nhà cung cấp không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Đã chỉnh sửa thông tin nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            dgvNCC.DataSource = NCC;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isDuplicatePriKey(txtMaNCC.Text))
                MessageBox.Show("Trùng mã nhà cung cấp !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                themNCC();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaNCC();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaNCC();
        }
    }
}
