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
    public partial class frm_InHoaDon : Form
    {
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable dt;
        public frm_InHoaDon(string maPBH )
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoiDB.strconn);
            dt = new DataTable();
            
            string sql = "Select TenNV, GiaTriGG, TenKH, NgayBH, TongTien" +
                        " From PhieuBanHang left join KhachHang" +
                        " On PhieuBanHang.MaKH = KhachHang.MaKH" +
                        " left join NhanVien" +
                        " On PhieuBanHang.MaNV = NhanVien.MaNV" +
                        " left join PhieuGiamGia" +
                        " On PhieuBanHang.MaPGG = PhieuGiamGia.MaPGG" +
                        " Where MaBanHang = '"+maPBH+"'";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(dt);

            DataRow dr = dt.Rows[0];
            lblNgay.Text = dr[3].ToString();
            lblNhanVien.Text = dr[0].ToString();
            lblKhachHang.Text = dr[2].ToString();
            lblGiamGia.Text = dr[1].ToString() + " %";
            lblTongTien.Text = dr[4].ToString() + " đ";

            dt = new DataTable();
            sql = "Select TenHH as N'Tên hàng', ChiTietBanHang.GiaBan as N'Giá bán', ChiTietBanHang.SoLuong as N'Số lượng', ThanhTien as N'Thành tiền'" +
                 " From ChiTietBanHang, HangHoa" +
                 " Where HangHoa.MaHH = ChiTietBanHang.MaHH and MaBanHang = '"+maPBH+"'";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(dt);
            dgvHangMua.DataSource = dt;
            dgvHangMua.Columns[0].Width = 200;
            dgvHangMua.Columns[1].Width = 80;
            dgvHangMua.Columns[2].Width = 70;
            dgvHangMua.Columns[3].Width = 80;
        }
    }
}
