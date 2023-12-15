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
    
    public partial class frm_InPhieuNhap : Form
    {
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable dt;
        public frm_InPhieuNhap(string maPBH)
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoiDB.strconn);
            dt = new DataTable();

            string sql = "Select TenNV, PhieuNhapHang.MaPhieuNhap, NgayNhap, GhiChu, TienNhapHang" +
                        " From PhieuNhapHang left join ChiTietNhapHang" +
                        " On PhieuNhapHang.MaPhieuNhap = ChiTietNhapHang.MaPhieuNhap" +
                        " left join NhanVien" +
                        " On PhieuNhapHang.MaNV = NhanVien.MaNV" +
                        " Where PhieuNhapHang.MaPhieuNhap = '"+maPBH+"'";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(dt);

            DataRow dr = dt.Rows[0];
            lblMaNhap.Text = dr[1].ToString();
            lblNhanVien.Text = dr[0].ToString();
            lblNgayLap.Text = dr[2].ToString();
            lblGhiChu.Text = dr[3].ToString();
            lblTongTien.Text = dr[4].ToString() + " đ";

            dt = new DataTable();
            sql = "Select TenHH as N'Tên hàng', ChiTietNhapHang.GiaNhap as N'Giá bán', ChiTietNhapHang.SoLuong as N'Số lượng', ThanhTien as N'Thành tiền'" +
                 " From ChiTietNhapHang, HangHoa" +
                 " Where HangHoa.MaHH = ChiTietNhapHang.MaHH and MaPhieuNhap = '" + maPBH + "'";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(dt);
            dgvnhaphang.DataSource = dt;
            dgvnhaphang.Columns[0].Width = 300;
            dgvnhaphang.Columns[1].Width = 120;
            dgvnhaphang.Columns[2].Width = 120;
            dgvnhaphang.Columns[3].Width = 120;
        }
    }
}
