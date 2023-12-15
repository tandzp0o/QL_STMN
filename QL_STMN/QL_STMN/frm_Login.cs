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
using QL_STMN.Properties;
using Nhom1_QuanLySieuThiMini;


namespace QL_STMN
{
    public partial class frm_Login : Form
    {

        ListTaiKhoan dstk = new ListTaiKhoan();
        ListNhanVien dsnv = new ListNhanVien();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tk = txtTK.Text;
            string mk = txtMK.Text;
            bool login = dstk.Login(tk, mk);

            if (login)
            {
                string MaNV = dstk.Find_MaNV_By_TK(tk);
                string MaCV = dsnv.Find_MaCV(MaNV);
                if(MaCV == "CV01") // quản lý
                {
                    Form1 f = new Form1();
                    txtTK.Text = string.Empty;
                    txtMK.Text = string.Empty;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }    
                else if(MaCV == "CV02") // nv bán hàng
                {
                    frm_BanHang f = new frm_BanHang();
                    txtTK.Text = string.Empty;
                    txtMK.Text = string.Empty;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (MaCV == "CV03") // nv kế toán
                {
                    frm_BanHang f = new frm_BanHang();
                    txtTK.Text = string.Empty;
                    txtMK.Text = string.Empty;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else if (MaCV == "CV04") // nv kho
                {
                    frm_BanHang f = new frm_BanHang();
                    txtTK.Text = string.Empty;
                    txtMK.Text = string.Empty;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
                MessageBox.Show("Tài khoản hoặc mật khẩu chưa chính xác");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            dsnv.GetData_NhanVien();
            dstk.GetData_TaiKhoan();
            MaximizeBox = false;
            pictureBox1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(txtMK.UseSystemPasswordChar == true)
            {
                txtMK.UseSystemPasswordChar = false;
                pictureBox1.Image = Properties.Resources.action_display_password_512;
            }
            else
            {
                txtMK.UseSystemPasswordChar = true;
                pictureBox1.Image = Properties.Resources.action_hide_password;

            }
        }

        private void txtMK_TextChanged(object sender, EventArgs e)
        {
            if (txtMK.Text == string.Empty)
            {
                pictureBox1.Visible = false;
            }
            else
                pictureBox1.Visible = true;
        }
    }
}
