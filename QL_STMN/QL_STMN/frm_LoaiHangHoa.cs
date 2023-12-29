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
    public partial class frm_LoaiHangHoa : Form
    {
        SqlConnection conn;
        DataTable loaiHH;
        SqlDataAdapter adap;
        public frm_LoaiHangHoa()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoiDB.strconn);
            loaiHH = new DataTable();
        }
        private void loadLoaiHH()
        {
            adap = new SqlDataAdapter("Select MaLoaiHH as N'Mã loại hàng', TenLoaiHH as N'Tên loại hàng' from LoaiHangHoa", conn);
            adap.Fill(loaiHH);

            DataColumn[] key = new DataColumn[1];
            key[0] = loaiHH.Columns[0];
            loaiHH.PrimaryKey = key;

            dgvLoaiHH.DataSource = loaiHH;
        }

        private void frm_LoaiHangHoa_Load(object sender, EventArgs e)
        {
            loadLoaiHH();
            Bingdings();
        }
        private void Bingdings()
        {
            txtMaLoaiHH.DataBindings.Add("Text", dgvLoaiHH.DataSource, "Mã loại hàng");
            txtTenLoaiHH.DataBindings.Add("Text", dgvLoaiHH.DataSource, "Tên loại hàng");
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
            string sql = "Select count(*) from LoaiHangHoa where MaLoaiHH='" + ma + "'";
            cmd = new SqlCommand(sql, conn);
            int sl = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            if (sl > 0)
                return true;
            else
                return false;
        }
        private void themLoaiHH()
        {
            adap = new SqlDataAdapter("Select MaLoaiHH as N'Mã loại hàng', TenLoaiHH as N'Tên loại hàng' from LoaiHangHoa", conn);
            DataRow newRow = loaiHH.NewRow();

            newRow["Mã loại hàng"] = txtMaLoaiHH.Text;
            newRow["Tên loại hàng"] = txtTenLoaiHH.Text;
            loaiHH.Rows.Add(newRow);

            SqlCommandBuilder builder = new SqlCommandBuilder(adap);
            int kq = adap.Update(loaiHH);
            if (kq == 0)
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã thêm loại hàng hóa mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadLoaiHH();
            }
            dgvLoaiHH.DataSource = loaiHH;
        }
        private void xoaLoaiHH()
        {
            if (MessageBox.Show("Xác nhận xóa loại hàng hóa này?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                SqlDataAdapter ds_HH = new SqlDataAdapter("Select *from HangHoa where MaLoaiHH = '" + txtMaLoaiHH.Text + "'", conn);
                ds_HH.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Loại hàng hóa này đang được sử dụng không thể xóa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                adap = new SqlDataAdapter("Select MaLoaiHH as N'Mã loại hàng', TenLoaiHH as N'Tên loại hàng' from LoaiHangHoa", conn);
                DataRow deleteRow = loaiHH.Rows.Find(txtMaLoaiHH.Text);
                if (deleteRow != null)
                    deleteRow.Delete();
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adap);
                int kq = adap.Update(loaiHH);
                if (kq == 0)
                {
                    MessageBox.Show("Xóa loại hàng hóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadLoaiHH();
                }    
                else
                    MessageBox.Show("Xóa loại hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                dgvLoaiHH.DataSource = loaiHH;
            }
        }
        private void suaLoaiHH()
        {
            adap = new SqlDataAdapter("Select MaLoaiHH as N'Mã loại hàng', TenLoaiHH as N'Tên loại hàng' from LoaiHangHoa", conn);
            DataRow updateRow = loaiHH.Rows.Find(txtMaLoaiHH.Text);
            if (updateRow != null)
            {
                updateRow.BeginEdit();
                updateRow["Tên loại hàng"] = txtTenLoaiHH.Text;
                updateRow.EndEdit();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa loại hàng hóa không thành công\nLý do: không tìm thấy mã loại hàng hóa\nLưu ý: Không được sửa mã loại hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadLoaiHH();
                return;
            }
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adap);
            int kq = adap.Update(loaiHH);
            if (kq == 0)
                MessageBox.Show("Chỉnh sửa loại hàng hóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Đã chỉnh sửa thông tin loại hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            dgvLoaiHH.DataSource = loaiHH;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(isDuplicatePriKey(txtMaLoaiHH.Text))
                MessageBox.Show("Trùng mã loại hàng hóa !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                themLoaiHH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaLoaiHH();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaLoaiHH();
        }
    }
}
