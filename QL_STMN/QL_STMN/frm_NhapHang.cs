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
using System.Text.RegularExpressions;

namespace QL_STMN
{
    public partial class frm_NhapHang : Form
    {
        SqlConnection conn;
        SqlDataAdapter adap;
        DataSet ds_HangHoa;
        DataTable dt;
        string maNhanVien;
        public frm_NhapHang(string ma)
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoiDB.strconn);
            ds_HangHoa = new DataSet();
            dt = new DataTable();
            maNhanVien = ma;
        }
        private void loadHH()
        {
            adap = new SqlDataAdapter("Select MaHH as N'Mã hàng hóa', TenHH as N'Tên hàng hóa', DVT, GiaNhap as N'Giá nhập', GiaBan as N'Giá bán', SoLuong as N'Số lượng', MaloaiHH as N'Mã loại', MaNCC as N'Mã nhà cung cấp' from HangHoa", conn);
            adap.Fill(ds_HangHoa, "HH");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_HangHoa.Tables["HH"].Columns[0];
            ds_HangHoa.Tables["HH"].PrimaryKey = key;

            dgvHangHoa.DataSource = ds_HangHoa.Tables["HH"];
        }
        private void loadNCC()
        {
            adap = new SqlDataAdapter("Select *from NhaCungCap", conn);
            adap.Fill(ds_HangHoa, "NCC");

            DataRow all = ds_HangHoa.Tables["NCC"].NewRow();
            all[0] = "All";
            all[1] = "Tất cả";
            ds_HangHoa.Tables["NCC"].Rows.InsertAt(all, 0);

            cboTimNCC.DataSource = ds_HangHoa.Tables["NCC"];
            cboTimNCC.DisplayMember = "TenNCC";
            cboTimNCC.ValueMember = "MaNCC";
        }
        private void loadLoaiHH()
        {
            adap = new SqlDataAdapter("Select *from LoaiHangHoa", conn);
            adap.Fill(ds_HangHoa, "LHH");

            DataRow all = ds_HangHoa.Tables["LHH"].NewRow();
            all[0] = "All";
            all[1] = "Tất cả";
            ds_HangHoa.Tables["LHH"].Rows.InsertAt(all, 0);

            cboTimLoaiHH.DataSource = ds_HangHoa.Tables["LHH"];
            cboTimLoaiHH.DisplayMember = "TenLoaiHH";
            cboTimLoaiHH.ValueMember = "MaLoaiHH";
        }
        private void loadBangdata()
        {
            dt.Columns.Add("Mã hàng", typeof(string));
            dt.Columns.Add("Tên hàng", typeof(string));
            dt.Columns.Add("Giá nhập", typeof(float));
            dt.Columns.Add("Đơn vị tính", typeof(string));
            dt.Columns.Add("Mã loại hàng", typeof(string));
            dt.Columns.Add("Mã nhà cung cấp", typeof(string));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Thành tiền", typeof(float));
            dgvHangNhap.DataSource = dt;
        }

        private void Bingdings()
        {
            txtMaHH.DataBindings.Clear();
            txtMaHH.DataBindings.Add("Text", dgvHangHoa.DataSource, "Mã hàng hóa");
            txtTenHH.DataBindings.Clear();
            txtTenHH.DataBindings.Add("Text", dgvHangHoa.DataSource, "Tên hàng hóa");
            txtGiaNhap.DataBindings.Clear();
            txtGiaNhap.DataBindings.Add("Text", dgvHangHoa.DataSource, "Giá nhập");
            txtNCC.DataBindings.Clear();
            txtNCC.DataBindings.Add("Text", dgvHangHoa.DataSource, "Mã nhà cung cấp");
            txtDVT.DataBindings.Clear();
            txtDVT.DataBindings.Add("Text", dgvHangHoa.DataSource, "DVT");
            txtLoaiHH.DataBindings.Clear();
            txtLoaiHH.DataBindings.Add("Text", dgvHangHoa.DataSource, "Mã loại");
            txtSoLuong.Text = "1";
        }
        private void NhapHang_Load(object sender, EventArgs e)
        {
            txtMaHH.Enabled = txtTenHH.Enabled = txtDVT.Enabled = txtGiaNhap.Enabled = txtLoaiHH.Enabled = txtNCC.Enabled = false;
            loadBangdata();
            loadHH();
            Bingdings();
            loadNCC();
            loadLoaiHH();
        }
        private bool isDuplicatePriKey(String ma)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd;
            string sql = "Select count(*) from HangHoa where MaHH='" + ma + "'";
            cmd = new SqlCommand(sql, conn);
            int sl = (int)cmd.ExecuteScalar();
            if (conn.State == ConnectionState.Open)
                conn.Close();
            if (sl > 0)
                return true;
            else
                return false;
        }

        private void themHangHoa()
        {
            for (int i = 0; i < dgvHangNhap.Rows.Count - 1; i++)
            {
                if (dgvHangNhap.Rows[i].Cells["Mã hàng"].Value.ToString() == txtMaHH.Text)
                {
                    dgvHangNhap.Rows[i].Cells["Số lượng"].Value = int.Parse(txtSoLuong.Text);
                    dgvHangNhap.Rows[i].Cells["Thành tiền"].Value = int.Parse(txtSoLuong.Text) * float.Parse(txtGiaNhap.Text);
                    return;
                }
            }
            dt.Rows.Add(txtMaHH.Text, txtTenHH.Text, txtGiaNhap.Text, txtDVT.Text, txtLoaiHH.Text, txtNCC.Text, txtSoLuong.Text, int.Parse(txtSoLuong.Text) * float.Parse(txtGiaNhap.Text));
            dgvHangNhap.DataSource = dt;
        }

        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            if(txtSoLuong.Text.Trim().Length > 0 && IsNumber(txtSoLuong.Text))
                if(int.Parse(txtSoLuong.Text) <= 0)
                    MessageBox.Show("Số lượng nhập phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else    
                    themHangHoa();
            else
                MessageBox.Show("Vui lòng điền số lượng nhập của hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Bingdings();
        }

        string maCTNH;
        private void themPhieuNH()
        {
            DateTime homNay = DateTime.Today;
            String strNgay = homNay.ToString("yyyy-MM-dd");
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd;
            string sql = "Select count(MaPhieuNhap) from PhieuNhapHang";
            cmd = new SqlCommand(sql, conn);
            int stt = (int)cmd.ExecuteScalar();
            stt++;
            String strStt = stt.ToString("000");
            String maNH = "PNH" + strStt;

            sql = "Insert into PhieuNhapHang Values('" + maNH + "', '" + strNgay + "',NULL, N'Nhập hàng tháng " + homNay.ToString("MM") + "', '"+maNhanVien+"')";
            cmd = new SqlCommand(sql, conn);
            int kq = cmd.ExecuteNonQuery();

            maCTNH = maNH;
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        private void themCTNH()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd;
            string sql;
            for (int i = 0; i < dgvHangNhap.Rows.Count - 1; i++)
            {
                string maHH = dgvHangNhap.Rows[i].Cells["Mã hàng"].Value.ToString();
                string gianhap = dgvHangNhap.Rows[i].Cells["Giá nhập"].Value.ToString();
                string sl = dgvHangNhap.Rows[i].Cells["Số lượng"].Value.ToString();
                sql = "Insert into ChiTietNhapHang(MaPhieuNhap, MaHH, GiaNhap, SoLuong) Values('" + maCTNH + "', '" + maHH + "', '" + gianhap + "', '" + sl + "')";
                cmd = new SqlCommand(sql, conn);
                int kq = cmd.ExecuteNonQuery();
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void resetNhapHang()
        {
            if (dgvHangNhap.Rows.Count > 0)
                dt.Clear();
            dgvHangNhap.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                if (MessageBox.Show("Xác nhận Nhập Hàng?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    themPhieuNH();
                    themCTNH();
                    MessageBox.Show("Đã Nhập hàng thành công");
                    resetNhapHang();
                    loadHH();

                    frm_InPhieuNhap frm1 = new frm_InPhieuNhap(maCTNH);
                    frm1.Show();
                }
            }
            else
                MessageBox.Show("Chưa có hàng hóa để nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void timKiem()
        {
            DataTable dt = new DataTable();
            int x = String.Compare(cboTimLoaiHH.SelectedValue.ToString(), "All", true);
            int y = String.Compare(cboTimNCC.SelectedValue.ToString(), "All", true);
            if (txtTimTen.Text.Trim().Length > 0)
            {
                if (x != 0 && y != 0)
                {
                    adap = new SqlDataAdapter("Select MaHH as N'Mã hàng hóa', TenHH as N'Tên hàng hóa', DVT, GiaNhap as N'Giá nhập', GiaBan as N'Giá bán', SoLuong as N'Số lượng', MaloaiHH as N'Mã loại', MaNCC as N'Mã nhà cung cấp' from HangHoa where TenHH like N'%" + txtTimTen.Text + "%' and MaloaiHH = '" + cboTimLoaiHH.SelectedValue + "' and MaNCC = '" + cboTimNCC.SelectedValue + "'", conn);
                    adap.Fill(dt);
                }
                else if (x != 0)
                {
                    adap = new SqlDataAdapter("Select MaHH as N'Mã hàng hóa', TenHH as N'Tên hàng hóa', DVT, GiaNhap as N'Giá nhập', GiaBan as N'Giá bán', SoLuong as N'Số lượng', MaloaiHH as N'Mã loại', MaNCC as N'Mã nhà cung cấp' from HangHoa where TenHH like N'%" + txtTimTen.Text + "%' and MaloaiHH = '" + cboTimLoaiHH.SelectedValue + "'", conn);
                    adap.Fill(dt);
                }
                else if (y != 0)
                {
                    adap = new SqlDataAdapter("Select MaHH as N'Mã hàng hóa', TenHH as N'Tên hàng hóa', DVT, GiaNhap as N'Giá nhập', GiaBan as N'Giá bán', SoLuong as N'Số lượng', MaloaiHH as N'Mã loại', MaNCC as N'Mã nhà cung cấp' from HangHoa where TenHH like N'%" + txtTimTen.Text + "%' and MaNCC = '" + cboTimNCC.SelectedValue + "'", conn);
                    adap.Fill(dt);
                }
                else
                {
                    adap = new SqlDataAdapter("Select MaHH as N'Mã hàng hóa', TenHH as N'Tên hàng hóa', DVT, GiaNhap as N'Giá nhập', GiaBan as N'Giá bán', SoLuong as N'Số lượng', MaloaiHH as N'Mã loại', MaNCC as N'Mã nhà cung cấp' from HangHoa where TenHH like N'%" + txtTimTen.Text + "%'", conn);
                    adap.Fill(dt);
                }
                dgvHangHoa.DataSource = dt;
            }
            else
            {
                if (x != 0 && y != 0)
                {
                    adap = new SqlDataAdapter("Select MaHH as N'Mã hàng hóa', TenHH as N'Tên hàng hóa', DVT, GiaNhap as N'Giá nhập', GiaBan as N'Giá bán', SoLuong as N'Số lượng', MaloaiHH as N'Mã loại', MaNCC as N'Mã nhà cung cấp' from HangHoaa where MaloaiHH = '" + cboTimLoaiHH.SelectedValue + "' and MaNCC = '" + cboTimNCC.SelectedValue + "'", conn);
                    adap.Fill(dt);
                }
                else if (x != 0)
                {
                    adap = new SqlDataAdapter("Select MaHH as N'Mã hàng hóa', TenHH as N'Tên hàng hóa', DVT, GiaNhap as N'Giá nhập', GiaBan as N'Giá bán', SoLuong as N'Số lượng', MaloaiHH as N'Mã loại', MaNCC as N'Mã nhà cung cấp' from HangHoa where MaloaiHH = '" + cboTimLoaiHH.SelectedValue + "'", conn);
                    adap.Fill(dt);
                }
                else if (y != 0)
                {
                    adap = new SqlDataAdapter("Select MaHH as N'Mã hàng hóa', TenHH as N'Tên hàng hóa', DVT, GiaNhap as N'Giá nhập', GiaBan as N'Giá bán', SoLuong as N'Số lượng', MaloaiHH as N'Mã loại', MaNCC as N'Mã nhà cung cấp' from HangHoa where MaNCC = '" + cboTimNCC.SelectedValue + "'", conn);
                    adap.Fill(dt);
                }
                else
                {
                    dgvHangHoa.DataSource = ds_HangHoa.Tables["HH"];
                    return;
                }
                dgvHangHoa.DataSource = dt;
            }
        }
        private void btnTimKiem_Click(object sender, System.EventArgs e)
        {
            timKiem();
        }

        private void frm_NhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Xác nhận thoát?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void xoaHangDaChon()
        {
            if (dgvHangNhap.Rows.Count > 1)
            {
                int vt = dgvHangNhap.CurrentCell.RowIndex;
                DataGridViewRow dtr = dgvHangNhap.Rows[vt];
                dgvHangNhap.Rows.RemoveAt(vt);
            }
            else
                MessageBox.Show("Không có hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void xoaHangToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            xoaHangDaChon();
        }
    }
}
