using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_STMN
{
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
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
            
            frmLoaiHH.Show();
        }

        private void quảnLíPhiếuGiảmGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_PhieuGiamGia frmPGG = new frm_PhieuGiamGia();
            
            frmPGG.Show();
        }

        private void quảnLíSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HangHoa frmHH = new frm_HangHoa();
     
            frmHH.Show();
        }

        private void quảnLíNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhaCungCap frmNCC = new frm_NhaCungCap();
       
            frmNCC.Show();
        }

        private void quảnLíKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmQuanLy_KhachHang frmKH = new frmQuanLy_KhachHang();

            //frmKH.Show();
        }

        private void quảnLíTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmQuanLy_TaiKhoan frmTK = new frmQuanLy_TaiKhoan();
           
            //frmTK.Show();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_BanHang frmBanHang = new frm_BanHang();
     
            frmBanHang.Show();
        }

        private void nhậpHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_NhapHang frmNhapHang = new frm_NhapHang();
     
            frmNhapHang.Show();
        }

        private void mn_quanly_Click(object sender, EventArgs e)
        {

        }

        private void quảnLíHoáĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_QLHoaDon frmHoaDon = new frm_QLHoaDon();
            frmHoaDon.Show();
        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_NhanVien frmNV = new frm_NhanVien();
            frmNV.Show();
        }

        private void quảnLíNhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frm_NhaCungCap frmNCC = new frm_NhaCungCap();
            frmNCC.Show();
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {

        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ThongKeDoanhThu frmDoanhThu = new frm_ThongKeDoanhThu();
            frmDoanhThu.Show();
        }
    }
}
