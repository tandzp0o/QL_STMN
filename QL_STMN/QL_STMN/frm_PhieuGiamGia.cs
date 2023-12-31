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
    public partial class frm_PhieuGiamGia : Form
    {
        SqlConnection conn;
        DataTable PGG;
        SqlDataAdapter adap;
        public frm_PhieuGiamGia()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoiDB.strconn);
            PGG = new DataTable();
        }
        private void loadPGG()
        {
            adap = new SqlDataAdapter("Select MaPGG as N'Mã phiếu giảm', TenPGG as N'Tên phiếu giảm', NgayBD as N'Ngày bắt đầu', NgayKT as N'Ngày kết thúc', GiaTriGG as N'Giá trị giảm (%)', GhiChu as N'Ghi chú' from PhieuGiamGia", conn);
            adap.Fill(PGG);

            DataColumn[] key = new DataColumn[1];
            key[0] = PGG.Columns[0];
            PGG.PrimaryKey = key;

            dgvPGG.DataSource = PGG;
        }

        private void frm_PhieuGiamGia_Load(object sender, EventArgs e)
        {
            loadPGG();
            Bingdings();
        }
        private void Bingdings()
        {
            txtMaPGG.DataBindings.Add("Text", dgvPGG.DataSource, "Mã phiếu giảm");
            txtTenPGG.DataBindings.Add("Text", dgvPGG.DataSource, "Tên phiếu giảm");
            txtNgayBD1.DataBindings.Add("Text", dgvPGG.DataSource, "Ngày bắt đầu");
            txtNgayKT.DataBindings.Add("Text", dgvPGG.DataSource, "Ngày kết thúc");
            txtGiaTriGG.DataBindings.Add("Text", dgvPGG.DataSource, "Giá trị giảm (%)");
            txtGhiChu.DataBindings.Add("Text", dgvPGG.DataSource, "Ghi chú");
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
            string sql = "Select count(*) from PhieuGiamGia where MaPGG='" + ma + "'";
            cmd = new SqlCommand(sql, conn);
            int sl = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            if (sl > 0)
                return true;
            else
                return false;
        }
        private void themPGG()
        {
            adap = new SqlDataAdapter("Select MaPGG as N'Mã phiếu giảm', TenPGG as N'Tên phiếu giảm', NgayBD as N'Ngày bắt đầu', NgayKT as N'Ngày kết thúc', GiaTriGG as N'Giá trị giảm (%)', GhiChu as N'Ghi chú' from PhieuGiamGia", conn);
            DataRow newRow = PGG.NewRow();

            newRow["Mã phiếu giảm"] = txtMaPGG.Text;
            newRow["Tên phiếu giảm"] = txtTenPGG.Text;
            newRow["Ngày bắt đầu"] = txtNgayBD1.Text;
            newRow["Ngày kết thúc"] = txtNgayKT.Text;
            newRow["Giá trị giảm (%)"] = txtGiaTriGG.Text;
            newRow["Ghi chú"] = txtGhiChu.Text;
            PGG.Rows.Add(newRow);

            SqlCommandBuilder builder = new SqlCommandBuilder(adap);
            int kq = adap.Update(PGG);
            if (kq == 0)
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã thêm phiếu giảm giá mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadPGG();
            }
            dgvPGG.DataSource = PGG;
        }
        private void xoaPGG()
        {
            if (MessageBox.Show("Xác nhận xóa phiếu giảm giá này?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                adap = new SqlDataAdapter("Select MaPGG as N'Mã phiếu giảm', TenPGG as N'Tên phiếu giảm', NgayBD as N'Ngày bắt đầu', NgayKT as N'Ngày kết thúc', GiaTriGG as N'Giá trị giảm (%)', GhiChu as N'Ghi chú' from PhieuGiamGia", conn);
                DataRow deleteRow = PGG.Rows.Find(txtMaPGG.Text);
                if (deleteRow != null)
                    deleteRow.Delete();
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adap);
                int kq = adap.Update(PGG);
                if (kq == 0)
                    MessageBox.Show("Xóa phiếu giảm giá không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Xóa phiếu giảm giá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                dgvPGG.DataSource = PGG;
            }
        }
        private void suaPGG()
        {
            adap = new SqlDataAdapter("Select MaPGG as N'Mã phiếu giảm', TenPGG as N'Tên phiếu giảm', NgayBD as N'Ngày bắt đầu', NgayKT as N'Ngày kết thúc', GiaTriGG as N'Giá trị giảm (%)', GhiChu as N'Ghi chú' from PhieuGiamGia", conn);
            DataRow updateRow = PGG.Rows.Find(txtMaPGG.Text);
            if (updateRow != null)
            {
                updateRow.BeginEdit();
                updateRow["Tên phiếu giảm"] = txtTenPGG.Text;
                updateRow["Ngày bắt đầu"] = txtNgayBD1.Text;
                updateRow["Ngày kết thúc"] = txtNgayKT.Text;
                updateRow["Giá trị giảm (%)"] = txtGiaTriGG.Text;
                updateRow["Ghi chú"] = txtGhiChu.Text;
                updateRow.EndEdit();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa phiếu giảm giá không thành công\nLý do: không tìm thấy mã phiếu giảm giá\nLưu ý: Không được sửa mã phiếu giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadPGG();
                return;
            }
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adap);
            int kq = adap.Update(PGG);
            if (kq == 0)
                MessageBox.Show("Chỉnh sửa phiếu giảm giá không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Đã chỉnh sửa thông tin phiếu giảm giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            dgvPGG.DataSource = PGG;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isDuplicatePriKey(txtMaPGG.Text))
                MessageBox.Show("Trùng mã phiếu giảm giá !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                themPGG();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaPGG();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaPGG();
        }

    }
}
