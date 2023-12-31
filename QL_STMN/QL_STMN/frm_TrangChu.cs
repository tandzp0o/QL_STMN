using Nhom1_QuanLySieuThiMini;
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
    public partial class frm_TrangChu : Form
    {
        SqlConnection conn;
        public string maNhanVien;
        public frm_TrangChu(string tk)
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoiDB.strconn);

            //lấy mã nhân viên của tài khoản đang đăng nhập
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd;
            string Laytk = "Select MaNV from TaiKhoan where TaiKhoan = '" + tk + "'";
            cmd = new SqlCommand(Laytk, conn);
            maNhanVien = Convert.ToString(cmd.ExecuteScalar());
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private void mn_thongtin_Click(object sender, EventArgs e)
        {
            String tt = "Phần mềm : Quản lý Siêu thị  \n\nNhóm 8:\n\t\n\n\t\tGVHD: Nguyễn Thị Bích Ngân\n";
            MessageBox.Show((tt), "Thông tin", MessageBoxButtons.OK);
        }

        private void mn_hethong_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r==DialogResult.Yes)
            {
                frm_Login frmDangNhap = new frm_Login();
                //frmDangNhap.Show();
                this.Close();
            }
        }

        int x = 166, y =0 , a = 1;

        private void quảnLíLoạiHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_LoaiHangHoa frmLoaiHH = new frm_LoaiHangHoa();
         
            frmLoaiHH.ShowDialog();
        }

        private void quảnLíPhiếuGiảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PhieuGiamGia frmPGG = new frm_PhieuGiamGia();
            
            frmPGG.ShowDialog();
        }

        private void quảnLíSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HangHoa frmHH = new frm_HangHoa();
     
            frmHH.ShowDialog();
        }

        private void quảnLíNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhaCungCap frmNCC = new frm_NhaCungCap();
       
            frmNCC.ShowDialog();
        }

        private void quảnLíKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QLKhachHang frmKH = new frm_QLKhachHang();

            frmKH.Show();
        }

        private void quảnLíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLy_TaiKhoan frmQuanLyTK = new frmQuanLy_TaiKhoan();
            frmQuanLyTK.ShowDialog();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BanHang frmBanHang = new frm_BanHang(maNhanVien);
     
            frmBanHang.ShowDialog();
        }

        private void nhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_NhapHang frmNhapHang = new frm_NhapHang(maNhanVien);
     
            frmNhapHang.ShowDialog();
        }

        private void mn_quanly_Click(object sender, EventArgs e)
        {
            
        }

        private void quảnLíHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QLHoaDon frmHoaDon = new frm_QLHoaDon();
            frmHoaDon.ShowDialog();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhanVien frmNV = new frm_NhanVien();
            frmNV.ShowDialog();
        }

        private void quảnLíNhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_NhaCungCap frmNCC = new frm_NhaCungCap();
            frmNCC.ShowDialog();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongKeDoanhThu frmDoanhThu = new frm_ThongKeDoanhThu();
            frmDoanhThu.ShowDialog();
        }
    }
}
