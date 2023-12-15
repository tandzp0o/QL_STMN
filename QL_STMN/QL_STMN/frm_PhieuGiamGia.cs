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
            adap = new SqlDataAdapter("Select *from PhieuGiamGia", conn);
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
            txtMaPGG.DataBindings.Add("Text", dgvPGG.DataSource, "MaPGG");
            txtTenPGG.DataBindings.Add("Text", dgvPGG.DataSource, "TenPGG");
            txtNgayBD1.DataBindings.Add("Text", dgvPGG.DataSource, "NgayBD");
            txtNgayKT.DataBindings.Add("Text", dgvPGG.DataSource, "NgayKT");
            txtGiaTriGG.DataBindings.Add("Text", dgvPGG.DataSource, "GiaTriGG");
            txtGhiChu.DataBindings.Add("Text", dgvPGG.DataSource, "GhiChu");
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
            adap = new SqlDataAdapter("Select *from PhieuGiamGia", conn);
            DataRow newRow = PGG.NewRow();

            newRow["MaPGG"] = txtMaPGG.Text;
            newRow["TenPGG"] = txtTenPGG.Text;
            newRow["NgayBD"] = txtNgayBD1.Text;
            newRow["NgayKT"] = txtNgayKT.Text;
            newRow["GiaTriGG"] = txtGiaTriGG.Text;
            newRow["GhiChu"] = txtGhiChu.Text;
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
                adap = new SqlDataAdapter("Select *from PhieuGiamGia", conn);
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
            adap = new SqlDataAdapter("Select *from PhieuGiamGia", conn);
            DataRow updateRow = PGG.Rows.Find(txtMaPGG.Text);
            if (updateRow != null)
            {
                updateRow.BeginEdit();
                updateRow["TenPGG"] = txtTenPGG.Text;
                updateRow["NgayBD"] = txtNgayBD1.Text;
                updateRow["NgayKT"] = txtNgayKT.Text;
                updateRow["GiaTriGG"] = txtGiaTriGG.Text;
                updateRow["GhiChu"] = txtGhiChu.Text;
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
