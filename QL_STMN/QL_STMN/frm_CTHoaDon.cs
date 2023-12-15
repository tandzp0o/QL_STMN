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
    public partial class frmChiTietHoaDon : Form
    {
        DataGridViewRow hoaDon;
        SqlConnection conn;
        SqlDataAdapter adap;
        DataTable tblCTHD;
        public frmChiTietHoaDon(DataGridViewRow row)
        {
            hoaDon = row;
            InitializeComponent();
            conn = new SqlConnection(KetNoiDB.strconn);
            tblCTHD = new DataTable();

            lblDisplayMaHoaDon.Text = hoaDon.Cells["Mã hóa đơn"].Value.ToString();
            lblDisplayNgayLap.Text = hoaDon.Cells["Ngày lập"].Value.ToString();
            lblDisplayKhachHang.Text = hoaDon.Cells["Khách hàng"].Value.ToString();
            lblDisplayNhanVienLap.Text = hoaDon.Cells["Nhân viên"].Value.ToString();
            txtGhiChu.Text = hoaDon.Cells["Phiếu giảm giá"].Value.ToString();
            lblDisplayTongTien.Text = hoaDon.Cells["Tổng tiền"].Value.ToString();

            string sql = "SELECT ctbh.MaHH as N'Mã hàng', hh.TenHH as N'Tên hàng hóa', ctbh.GiaBan as N'Giá bán', ctbh.SoLuong as N'Số lượng', ctbh.ThanhTien as N'Thành tiền'" +
                         " FROM	ChiTietBanHang ctbh, HangHoa hh" +
                         " WHERE ctbh.MaBanHang = '" + lblDisplayMaHoaDon.Text + "' AND" +
                         " ctbh.MaHH = hh.MaHH";
            adap = new SqlDataAdapter(sql, conn);
            adap.Fill(tblCTHD);

            dataGridView1.DataSource = tblCTHD;
        }
    }
}
