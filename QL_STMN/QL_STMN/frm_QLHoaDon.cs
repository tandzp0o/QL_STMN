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
    public partial class frm_QLHoaDon : Form
    {
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tblHoaDon;
        DataTable tblKhachHang;
        DataTable tblNhanVien;

        public frm_QLHoaDon()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoiDB.strconn);
            tblHoaDon = new DataTable();
            tblKhachHang = new DataTable();
            tblNhanVien = new DataTable();
        }

        private void load_HoaDon()
        {
            string sql = "Select MaBanHang as N'Mã hóa đơn', TenNV as N'Nhân viên', TenPGG as N'Phiếu giảm giá', TenKH as N'Khách hàng', NgayBH as N'Ngày lập', ISNULL(TongTien,0) as N'Tổng tiền'" +
                        " From PhieuBanHang left join KhachHang" +
                        " On PhieuBanHang.MaKH = KhachHang.MaKH" +
                        " left join NhanVien" +
                        " On PhieuBanHang.MaNV = NhanVien.MaNV" +
                        " left join PhieuGiamGia" +
                        " On PhieuBanHang.MaPGG = PhieuGiamGia.MaPGG";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(tblHoaDon);

            dataGridViewHoaDons.DataSource = tblHoaDon;
            load_soLuongHoaDonVaTongDoanhTHu();
        }
        private void load_cboNhanVien()
        {
            adap = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
            adap.Fill(tblNhanVien);
            cboSearchNhanVien.DataSource = tblNhanVien;
            cboSearchNhanVien.DisplayMember = "TenNV";
            cboSearchNhanVien.ValueMember = "MaNV";

        }
        private void load_cboKhachHang()
        {
            adap = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
            adap.Fill(tblKhachHang);

            cboSearchKhachHang.DataSource = tblKhachHang;
            cboSearchKhachHang.DisplayMember = "TenKH";
            cboSearchKhachHang.ValueMember = "MaKH";
        }
        DataTable dt = new DataTable();
        private void load_soLuongHoaDonVaTongDoanhTHu()
        {
            int countHoaDon = dataGridViewHoaDons.Rows.Count - 1;
            double tongDoanhThu = 0;

            DataTable table = (DataTable)dataGridViewHoaDons.DataSource;
            tongDoanhThu = table.AsEnumerable().Sum(row => (double)row["Tổng tiền"]);

            lblDisplaySoLuongHoaDon.Text = countHoaDon.ToString();
            lblDisplayTongDoanhThu.Text = tongDoanhThu.ToString();
        }

        private void frmQuanLy_HoaDon_Load(object sender, EventArgs e)
        {
            txtSearchMaHoaDon.Enabled = cboSearchNhanVien.Enabled = cboSearchKhachHang.Enabled = false;
            load_HoaDon();
            load_cboNhanVien();
            load_cboKhachHang();
            Bingdings();

            radSearchNgayBan_Ngay.Checked = false;
            radSearchNgayBan_KhoangThoiGian.Checked = false;
            txtSearch_rad_ngay.Enabled = false;
            txtSearch_radKhoangThoiGian_A.Enabled = false;
            txtSearch_radKhoangThoiGian_B.Enabled = false;
        }

        public bool IsMoney(string input)
        {
            if (input.All(char.IsDigit))
                return true;
            else
                return false;
        }

        public bool IsValidDate(string date)
        {
            if (date.Length != 10)
            {
                return false;
            }

            for (int i = 0; i < date.Length; i++)
            {
                if (i == 2 || i == 5)
                {
                    if (date[i] != '/')
                    {
                        return false;
                    }
                }
                else
                {
                    if (!char.IsDigit(date[i]))
                    {
                        return false;
                    }
                }
            }

            int day = int.Parse(date.Substring(0, 2));
            int month = int.Parse(date.Substring(3, 2));
            int year = int.Parse(date.Substring(6, 4));

            if (year < 1000 || year > 9999)
            {
                return false;
            }

            if (month < 1 || month > 12)
            {
                return false;
            }

            if (month == 2 && year % 4 == 0 && year % 100 != 0)
            {
                if (day > 29)
                {
                    return false;
                }
            }
            else if (month == 2 && day > 28)
            {
                return false;
            }

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day > 31)
                {
                    return false;
                }
            }
            else if (day > 30)
            {
                return false;
            }
            return true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            timKiem();
        }
        private void radSearchNgayBan_Ngay_CheckedChanged(object sender, EventArgs e)
        {
            if (radSearchNgayBan_Ngay.Checked)
            {
                txtSearch_rad_ngay.Enabled = true;
                radSearchNgayBan_KhoangThoiGian.Checked = false;
                txtSearch_radKhoangThoiGian_A.Enabled = false;
                txtSearch_radKhoangThoiGian_B.Enabled = false;
            }
            else
            {
                txtSearch_rad_ngay.Enabled = false;
                radSearchNgayBan_KhoangThoiGian.Checked = true;
                txtSearch_radKhoangThoiGian_A.Enabled = true;
                txtSearch_radKhoangThoiGian_B.Enabled = true;
            }
        }


        private void radSearchNgayBan_KhoangThoiGian_CheckedChanged(object sender, EventArgs e)
        {
            if (radSearchNgayBan_KhoangThoiGian.Checked)
            {
                txtSearch_rad_ngay.Enabled = false;
                radSearchNgayBan_KhoangThoiGian.Checked = true;
                txtSearch_radKhoangThoiGian_A.Enabled = true;
                txtSearch_radKhoangThoiGian_B.Enabled = true;
            }
            else
            {
                txtSearch_rad_ngay.Enabled = true;
                radSearchNgayBan_KhoangThoiGian.Checked = false;
                txtSearch_radKhoangThoiGian_A.Enabled = false;
                txtSearch_radKhoangThoiGian_B.Enabled = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tblHoaDon.Clear();
            dataGridViewHoaDons.DataSource = tblHoaDon;
            load_HoaDon();
            dataGridViewHoaDons.ClearSelection();

            txtSearchMaHoaDon.Clear();
            cboSearchNhanVien.SelectedIndex = -1;
            cboSearchKhachHang.SelectedIndex = -1;

            radSearchNgayBan_Ngay.Checked = false;
            radSearchNgayBan_KhoangThoiGian.Checked = false;
            txtSearch_rad_ngay.Enabled = false;
            txtSearch_radKhoangThoiGian_A.Enabled = false;
            txtSearch_radKhoangThoiGian_A.Clear();
            txtSearch_radKhoangThoiGian_B.Enabled = false;
            txtSearch_radKhoangThoiGian_B.Clear();

            txtSearchKhoangGiaA.Clear();
            txtSearchKhoangGiaB.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChiTietHoaDon_Click(object sender, EventArgs e)
        {
            if (dataGridViewHoaDons.SelectedRows.Count > 0)
            {
                frmChiTietHoaDon frmCTHD = new frmChiTietHoaDon(dataGridViewHoaDons.SelectedRows[0]);
                frmCTHD.Show();
            }
        }
        private void Bingdings()
        {
            txtSearchMaHoaDon.DataBindings.Clear();
            txtSearchMaHoaDon.DataBindings.Add("Text", dataGridViewHoaDons.DataSource, "Mã hóa đơn");
            cboSearchNhanVien.DataBindings.Clear();
            cboSearchNhanVien.DataBindings.Add("Text", dataGridViewHoaDons.DataSource, "Nhân viên");
            cboSearchKhachHang.DataBindings.Clear();
            cboSearchKhachHang.DataBindings.Add("Text", dataGridViewHoaDons.DataSource, "Khách hàng");
        }
        private void timKiem()
        {
            if (IsMoney(txtSearchKhoangGiaA.Text) == false)
            {
                MessageBox.Show("Giá trị khoảng giá A không hợp lệ! Vui lòng nhập lại!");
                txtSearchKhoangGiaA.Focus();
                return;
            }
            if (IsMoney(txtSearchKhoangGiaB.Text) == false)
            {
                MessageBox.Show("Giá trị khoảng giá B không hợp lệ! Vui lòng nhập lại!");
                txtSearchKhoangGiaB.Focus();
                return;
            }

            if (radSearchNgayBan_Ngay.Checked)
            {
                if (string.IsNullOrEmpty(txtSearch_rad_ngay.Text))
                {
                    MessageBox.Show("Ngày không được để trống!");
                    txtSearch_rad_ngay.Focus();
                    return;
                }
                if (IsValidDate(txtSearch_rad_ngay.Text) == false)
                {
                    MessageBox.Show("Ngày không hợp lệ! Vui lòng kiểm tra và nhập lại!");
                    txtSearch_rad_ngay.Focus();
                    return;
                }
            }

            if (radSearchNgayBan_KhoangThoiGian.Checked)
            {
                if (string.IsNullOrEmpty(txtSearch_radKhoangThoiGian_A.Text))
                {
                    MessageBox.Show("Ngày bắt đầu không được để trống!");
                    txtSearch_radKhoangThoiGian_A.Focus();
                    return;
                }
                if (IsValidDate(txtSearch_radKhoangThoiGian_A.Text) == false)
                {
                    MessageBox.Show("Ngày bắt đầu không hợp lệ! Vui lòng kiểm tra và nhập lại!");
                    txtSearch_radKhoangThoiGian_A.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(txtSearch_radKhoangThoiGian_B.Text))
                {
                    MessageBox.Show("Ngày kết thúc  không được để trống!");
                    txtSearch_radKhoangThoiGian_B.Focus();
                    return;
                }
                if (IsValidDate(txtSearch_radKhoangThoiGian_B.Text) == false)
                {
                    MessageBox.Show("Ngày kết thúc không hợp lệ! Vui lòng kiểm tra và nhập lại!");
                    txtSearch_radKhoangThoiGian_B.Focus();
                    return;
                }
            }

            string khoangGiaA = "0";
            string khoangGiaB = "1000000000000";

            if (!string.IsNullOrEmpty(txtSearchKhoangGiaA.Text))
            {
                khoangGiaA = txtSearchKhoangGiaA.Text;
            }
            if (!string.IsNullOrEmpty(txtSearchKhoangGiaB.Text))
            {
                khoangGiaB = txtSearchKhoangGiaB.Text;
            }
            
            if(radSearchNgayBan_Ngay.Checked)
            {
                if(txtSearchKhoangGiaA.Text.Trim().Length>0 && txtSearchKhoangGiaB.Text.Trim().Length>0)
                {
                    dt.Clear();
                    adap = new SqlDataAdapter("SELECT hd.MaBanHang as N'Mã hóa đơn', nv.TenNV as N'Nhân viên', pgg.TenPGG as N'Phiếu giảm giá', kh.TenKH as N'Khách hàng', NgayBH as N'Ngày lập', ISNULL(TongTien,0) as N'Tổng tiền'" +
                        "FROM PhieuBanHang hd left join NhanVien nv on hd.MaNV = nv.MaNV left join KhachHang kh on hd.MaKH = kh.MaKH left join PhieuGiamGia pgg on hd.MaPGG = pgg.MaPGG WHERE CONVERT(Date,hd.NgayBH,103) = CONVERT(date,'"+txtSearch_rad_ngay.Text+"',103)" +
                         "AND (hd.TongTien Between '"+ txtSearchKhoangGiaA.Text+ "' AND '"+ txtSearchKhoangGiaB.Text+ "')", conn);
                    adap.Fill(dt);
                }
                else
                {
                    dt.Clear();
                    adap = new SqlDataAdapter("SELECT hd.MaBanHang as N'Mã hóa đơn', nv.TenNV as N'Nhân viên', pgg.TenPGG as N'Phiếu giảm giá', kh.TenKH as N'Khách hàng', NgayBH as N'Ngày lập', ISNULL(TongTien,0) as N'Tổng tiền'" +
                        "FROM PhieuBanHang hd left join NhanVien nv on hd.MaNV = nv.MaNV left join KhachHang kh on hd.MaKH = kh.MaKH left join PhieuGiamGia pgg on hd.MaPGG = pgg.MaPGG WHERE CONVERT(Date,hd.NgayBH,103) = CONVERT(date,'" + txtSearch_rad_ngay.Text + "',103)", conn);
                    adap.Fill(dt);
                }
                
            }
            else if (radSearchNgayBan_KhoangThoiGian.Checked)
            {
                if (txtSearchKhoangGiaA.Text.Trim().Length > 0 && txtSearchKhoangGiaB.Text.Trim().Length > 0)
                {
                    dt.Clear();
                    adap = new SqlDataAdapter("SELECT hd.MaBanHang as N'Mã hóa đơn', nv.TenNV as N'Nhân viên', pgg.TenPGG as N'Phiếu giảm giá', kh.TenKH as N'Khách hàng', NgayBH as N'Ngày lập', ISNULL(TongTien,0) as N'Tổng tiền'" +
                        "FROM PhieuBanHang hd left join NhanVien nv on hd.MaNV = nv.MaNV left join KhachHang kh on hd.MaKH = kh.MaKH left join PhieuGiamGia pgg on hd.MaPGG = pgg.MaPGG WHERE  (CONVERT(Date,hd.NgayBH,103) BETWEEN CONVERT(date,'"+txtSearch_radKhoangThoiGian_A.Text+"',103) AND CONVERT(date,'"+txtSearch_radKhoangThoiGian_B.Text+"',103))"+
                        "AND(hd.TongTien Between '"+ txtSearchKhoangGiaA.Text + "' AND '"+ txtSearchKhoangGiaB.Text+ "')", conn);
                    adap.Fill(dt);
                }
                else
                {
                    dt.Clear();
                    adap = new SqlDataAdapter("SELECT hd.MaBanHang as N'Mã hóa đơn', nv.TenNV as N'Nhân viên', pgg.TenPGG as N'Phiếu giảm giá', kh.TenKH as N'Khách hàng', NgayBH as N'Ngày lập', ISNULL(TongTien,0) as N'Tổng tiền'" +
                        "FROM PhieuBanHang hd left join NhanVien nv on hd.MaNV = nv.MaNV left join KhachHang kh on hd.MaKH = kh.MaKH left join PhieuGiamGia pgg on hd.MaPGG = pgg.MaPGG WHERE (CONVERT(Date,hd.NgayBH,103) BETWEEN CONVERT(date,'"+txtSearch_radKhoangThoiGian_A.Text +"',103) AND CONVERT(date,'"+txtSearch_radKhoangThoiGian_B.Text+"',103))", conn);
                    adap.Fill(dt);
                }
            }
            else if(radSearchNgayBan_Ngay.Checked == false && radSearchNgayBan_KhoangThoiGian.Checked == false && txtSearchKhoangGiaA.Text == string.Empty && txtSearchKhoangGiaB.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn phương thức thống kê!!", "Thông báo");
                return;
            }
            else
            {
                dt.Clear();
                string sql = "SELECT hd.MaBanHang as N'Mã hóa đơn', nv.TenNV as N'Nhân viên', pgg.TenPGG as N'Phiếu giảm giá', kh.TenKH as N'Khách hàng', NgayBH as N'Ngày lập', ISNULL(TongTien,0) as N'Tổng tiền'" +
                        "FROM PhieuBanHang hd " +
                        "left join NhanVien nv on hd.MaNV = nv.MaNV " +
                        "left join KhachHang kh on hd.MaKH = kh.MaKH " +
                        "left join PhieuGiamGia pgg on hd.MaPGG = pgg.MaPGG WHERE hd.TongTien >= " + txtSearchKhoangGiaA.Text + " AND hd.TongTien <= " + txtSearchKhoangGiaB.Text + " ";
                adap = new SqlDataAdapter(sql, conn);
                adap.Fill(dt);
            }

            dataGridViewHoaDons.DataSource = dt;
            if(dataGridViewHoaDons.Rows.Count > 0)
            {
                load_soLuongHoaDonVaTongDoanhTHu();
            }
        }

        private void dataGridViewHoaDons_SelectionChanged(object sender, EventArgs e)
        {
            Bingdings();
        }
    }
}
