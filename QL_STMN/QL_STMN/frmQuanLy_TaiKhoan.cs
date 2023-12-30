using QL_STMN;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Nhom1_QuanLySieuThiMini
{
    public partial class frmQuanLy_TaiKhoan : Form
    {

        ListTaiKhoan dstk = new ListTaiKhoan();
        public frmQuanLy_TaiKhoan()
        {
            InitializeComponent();
        }

        private void frmQuanLy_TaiKhoan_Load(object sender, EventArgs e)
        {
            load_dtrv();
            load_cbbCV();
            load_cbbChuaTK();
        }

        public void load_dtrv()
        {
            string q = "select nv.MaNV, TaiKhoan, MatKhau, TenNV from TAIKHOAN tk join NHANVIEN nv on tk.MaNV = nv.MaNV";
            DataTable dt = DBConnect.Instance.ExcuteQuery(q);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns[0].HeaderText = "Mã nhân viên";
            dataGridView1.Columns[1].HeaderText = "Tài khoản";
            dataGridView1.Columns[2].HeaderText = "Mật khẩu";
            dataGridView1.Columns[3].HeaderText = "Tên nhân viên";
        }

        public void load_cbbCV()
        {
            string q = "select * from CHUCVU";
            DataTable dt = DBConnect.Instance.getDataTable(q);
            cbxChucVu.DataSource = dt;
            cbxChucVu.DisplayMember = "TenCV";
            cbxChucVu.ValueMember = "MaCV";
        }

        public void load_cbbChuaTK()
        {
            string q = "select nv.MaNV, TenNV from NHANVIEN nv where nv.MaNV not in (select MaNV from TAIKHOAN)";
            DataTable dt = DBConnect.Instance.getDataTable(q);
            cbbChuaTK.DataSource = dt;
            cbbChuaTK.DisplayMember = "TenNV";
            cbbChuaTK.ValueMember = "MaNV";
            // nếu combobox không có dữ liệu thì ẩn combobox đi
            if (dt.Rows.Count == 0)
            {
                cbbChuaTK.Visible = false;
                label3.Text = "tất cả nhân viên đã có tài khoản";
            }
            else
            {
                cbbChuaTK.Visible = true;
            }
        }

        public bool check_MNG(string manv)
        {
            string q = "select cv.macv from chucvu cv join nhanvien nv on cv.macv = nv.macv and nv.manv = '" + manv+"'";
            string kq = DBConnect.Instance.ExcuteScalar<string>(q);
            if (kq == "CV01")
                return true;
            return false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool MNG = false;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                row.Selected = true;
                if (dataGridView1.SelectedRows != null)
                {
                    txtMANV.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    txtTK.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    txtMK.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    txtTen.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    if (check_MNG(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()))
                        MNG = true;
                }
            }
            if (MNG)
            {
                // tự động chọn combobox chức vụ là quản lý
                cbxChucVu.SelectedIndex = 0;
            }
            else
            {
                // tự động chọn combobox chức vụ là nhân viên
                cbxChucVu.SelectedIndex = 1;
            }
            // nếu click vào dtrv thì ẩn nút thêm đi
            btnAdd.Visible = false;
            txtTen.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // thêm tài khoản vào db, nếu đã tồn tại thì thông báo tài khoản đã tồn tại, nếu điền không đủ thông tin thì thông báo điền đủ thông tin
            string q = "insert into TAIKHOAN values ('" + txtTK.Text + "', '" + txtMK.Text + "', '" + cbbChuaTK.SelectedValue.ToString() + "')";
            if (txtTK.Text != "" && txtMK.Text != "" && cbbChuaTK.SelectedValue.ToString() != "")
            {
                if (DBConnect.Instance.ExcuteNonQuery(q) > 0)
                {
                    MessageBox.Show("Thêm tài khoản thành công");
                    load_dtrv();
                    load_cbbChuaTK();
                }
                else
                {
                    MessageBox.Show("Tài khoản đã tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
        }

        private void txtMANV_Leave(object sender, EventArgs e)
        {
            // kiểm tra mã nhân viên có tồn tại hay không
            string q = "select * from NHANVIEN where MaNV = '" + txtMANV.Text + "'";
            DataTable dt = DBConnect.Instance.getDataTable(q);
            if (dt.Rows.Count > 0)
            {
                txtTen.Text = dt.Rows[0]["TenNV"].ToString();
            }
            else
            {
                // messagebox thông báo mã nhân viên không tồn tại
                MessageBox.Show("Mã nhân viên không tồn tại");
            }
        }

        private void cbbChuaTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRef_Click(object sender, EventArgs e)
        {
            // clear mọi thông tin khi bấm nút refresh
            txtMANV.Clear();
            txtTen.Clear();
            txtTK.Clear();
            txtMK.Clear();
            btnAdd.Visible = true;
            load_cbbChuaTK();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // xóa tài khoản khỏi db nhưng không được xoá tài khoản của quản lý
            string q = "delete from TAIKHOAN where MaNV = '" + txtMANV.Text + "'";
            string q1 = "select cv.macv from chucvu cv join nhanvien nv on cv.macv = nv.macv and nv.manv = '" + txtMANV.Text + "'"; 
            string kq = DBConnect.Instance.ExcuteScalar<string>(q1);
            if (kq == "CV01")
            {
                MessageBox.Show("Không được xóa tài khoản của quản lý");
            }
            else
            {
                if (DBConnect.Instance.ExcuteNonQuery(q) > 0)
                {
                    MessageBox.Show("Xóa tài khoản thành công");
                    load_dtrv();
                    load_cbbChuaTK();
                }
                else
                {
                    MessageBox.Show("Xóa tài khoản thất bại");
                }
            }
            // sau khi xóa thì clear mọi thông tin
            txtMANV.Clear();
            txtTen.Clear();
            txtTK.Clear();
            txtMK.Clear();
            btnAdd.Visible = true;
            label3.Text = "Chưa có TK";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // sửa tài khoản trong db
            string q = "update TAIKHOAN set TaiKhoan = '" + txtTK.Text + "', MatKhau = '" + txtMK.Text + "' where MaNV = '" + txtMANV.Text + "'";
            if (DBConnect.Instance.ExcuteNonQuery(q) > 0)
            {
                MessageBox.Show("Sửa tài khoản thành công");
                load_dtrv();
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
