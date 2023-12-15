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
using System.Globalization;

namespace QL_STMN
{
    public partial class frm_BanHang : Form
    {
        SqlConnection conn;
        DataSet ds_HangHoa;
        SqlDataAdapter adap;
        DataTable dt;
        public float tongTien = 0;
        public frm_BanHang()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoiDB.strconn);
            ds_HangHoa = new DataSet();
            dt = new DataTable();
        }

        private void btnThemPGG_Click(object sender, EventArgs e)
        {
            frm_PhieuGiamGia frm3 = new frm_PhieuGiamGia();
            frm3.ShowDialog();
        }
        private void loadHangHoa()
        {
            adap = new SqlDataAdapter("Select MaHH, TenHH, DVT, GiaBan, SoLuong, TenLoaiHH from HangHoa, LoaiHangHoa where HangHoa.MaloaiHH = LoaiHangHoa.MaLoaiHH", conn);
            adap.Fill(ds_HangHoa, "HH");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_HangHoa.Tables["HH"].Columns[0];
            ds_HangHoa.Tables["HH"].PrimaryKey = key;

            dgvHangHoa.DataSource = ds_HangHoa.Tables["HH"];
        }
        private void loadPGG()
        {
            adap = new SqlDataAdapter("Select *from PhieuGiamGia where Datediff(dd, Getdate(), NgayKT) >= 0", conn);
            adap.Fill(ds_HangHoa, "PGG");

            DataRow all = ds_HangHoa.Tables["PGG"].NewRow();
            all[0] = "All";
            all[1] = "Chọn phiếu giảm giá";
            ds_HangHoa.Tables["PGG"].Rows.InsertAt(all, 0);

            cboPGG.DataSource = ds_HangHoa.Tables["PGG"];
            cboPGG.DisplayMember = "TenPGG";
            cboPGG.ValueMember = "MaPGG";
        }
        private void cboPGG_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd;
            string Laygt = "Select GiaTriGG from PhieuGiamGia where MaPGG = '" + cboPGG.SelectedValue + "'";
            cmd = new SqlCommand(Laygt, conn);
            txtGTGiam.Text = Convert.ToString(cmd.ExecuteScalar());
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        private void loadKH()
        {
            adap = new SqlDataAdapter("Select *from KhachHang", conn);
            adap.Fill(ds_HangHoa, "KH");

            DataRow all = ds_HangHoa.Tables["KH"].NewRow();
            all[0] = "Chọn khách hàng";
            all[1] = "Chọn khách hàng";
            ds_HangHoa.Tables["KH"].Rows.InsertAt(all, 0);

            cboMaKH.DataSource = ds_HangHoa.Tables["KH"];
            cboMaKH.DisplayMember = "MaKH";
            cboMaKH.ValueMember = "MaKH";
        }
        private void cboMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd;
            string LayTen = "Select TenKH from KhachHang where MaKH = '" + cboMaKH.SelectedValue + "'";
            cmd = new SqlCommand(LayTen, conn);
            txtTenKH.Text = Convert.ToString(cmd.ExecuteScalar());
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        private void Bingdings()
        {
            txtMaHH.DataBindings.Clear();
            txtMaHH.DataBindings.Add("Text", dgvHangHoa.DataSource, "MaHH");
            txtTenHH.DataBindings.Clear();
            txtTenHH.DataBindings.Add("Text", dgvHangHoa.DataSource, "TenHH");
            txtDVT.DataBindings.Clear();
            txtDVT.DataBindings.Add("Text", dgvHangHoa.DataSource, "DVT");
            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", dgvHangHoa.DataSource, "GiaBan");
            txtSoLuongTon.DataBindings.Clear();
            txtSoLuongTon.DataBindings.Add("Text", dgvHangHoa.DataSource, "SoLuong");
            txtLoaiHH.DataBindings.Clear();
            txtLoaiHH.DataBindings.Add("Text", dgvHangHoa.DataSource, "TenLoaiHH");
            txtSoLuongMua.Value = 1;
        }
        private void loadBangHangMua()
        {
            dt.Columns.Add("Mã hàng", typeof(string));
            dt.Columns.Add("Tên hàng", typeof(string));
            dt.Columns.Add("Giá bán", typeof(float));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Thành tiền", typeof(float));
            dgvHangMua.DataSource = dt;
        }
        private void frm_BanHang_Load(object sender, EventArgs e)
        {
            txtMaHH.Enabled = txtTenHH.Enabled = txtDVT.Enabled = txtGiaBan.Enabled = txtSoLuongTon.Enabled =txtLoaiHH.Enabled = false;
            cboPGG.Enabled = txtGTGiam.Enabled = txtTongTien.Enabled  = txtTenKH.Enabled = cboMaKH.Enabled = txtTraLai.Enabled = false;
            loadBangHangMua();
            loadHangHoa();
            Bingdings();
            timer1.Enabled = true;
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Bingdings();
        }
        private void timKiem()
        {
            DataTable tk = new DataTable();
            if (txtTimTen.Text.Trim().Length > 0)
            {
                adap = new SqlDataAdapter("Select MaHH, TenHH, DVT, GiaBan, SoLuong, TenLoaiHH from HangHoa, LoaiHangHoa where HangHoa.MaloaiHH = LoaiHangHoa.MaLoaiHH and TenHH like N'%" + txtTimTen.Text + "%'", conn);
                adap.Fill(tk);
                dgvHangHoa.DataSource = tk;
            }
            else
                dgvHangHoa.DataSource = ds_HangHoa.Tables["HH"];
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timKiem();
        }
        private void themHangHoa()
        {
            for (int i = 0; i < dgvHangMua.Rows.Count - 1; i++)
            {
                if (dgvHangMua.Rows[i].Cells["Mã hàng"].Value.ToString() == txtMaHH.Text)
                {
                    if (int.Parse(txtSoLuongTon.Text) >= int.Parse(txtSoLuongMua.Text))
                    {
                        dgvHangMua.Rows[i].Cells["Số lượng"].Value = int.Parse(txtSoLuongMua.Text);
                        dgvHangMua.Rows[i].Cells["Thành tiền"].Value = int.Parse(txtSoLuongMua.Text) * float.Parse(txtGiaBan.Text);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Hàng hóa này vượt quá số lượng để bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            if (int.Parse(txtSoLuongTon.Text) >= int.Parse(txtSoLuongMua.Text))
                dt.Rows.Add(txtMaHH.Text, txtTenHH.Text, txtGiaBan.Text, txtSoLuongMua.Text, (int.Parse(txtSoLuongMua.Text) * float.Parse(txtGiaBan.Text)).ToString());
            else
            {
                MessageBox.Show("Hàng hóa này hiện đã hết hoặc số lượng không đủ để bán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dgvHangMua.DataSource = dt;
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
        private void btnChonHang_Click(object sender, EventArgs e)
        {
            if (txtSoLuongMua.Value > 0)
                themHangHoa();
            else if (txtSoLuongMua.Value == 0)
                MessageBox.Show("Số lượng mua phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Hãy nhập đúng kiểu số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
        }
        private void xoaHangDaChon()
        {
            if (dgvHangMua.Rows.Count > 1)
            {
                int vt = dgvHangMua.CurrentCell.RowIndex;
                DataGridViewRow dtr = dgvHangMua.Rows[vt];
                dgvHangMua.Rows.RemoveAt(vt);
            }
            else
                MessageBox.Show("Không có hàng để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void xoaHangDaChonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xoaHangDaChon();
        }

        private void chkCoPGG_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoPGG.Checked == true)
            {
                cboPGG.Enabled = true;
                loadPGG();
                cboPGG.SelectedIndex = 0;
            }
            else
            {
                ((DataTable)cboPGG.DataSource).Clear();
                cboPGG.Enabled = false;
                txtGTGiam.ResetText();
            }  
        }

        private void chkKHTT_CheckedChanged(object sender, EventArgs e)
        {
            if (chkKHTT.Checked == true)
            {
                cboMaKH.Enabled = txtTenKH.Enabled = true;
                loadKH();
                cboMaKH.SelectedIndex = 0;
            }
            else
            {
                ((DataTable)cboMaKH.DataSource).Clear();
                cboMaKH.Enabled = txtTenKH.Enabled = false;
                txtTenKH.ResetText();
            }
        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            if(txtTienNhan.Text.Trim().Length > 0 && IsNumber(txtTienNhan.Text))
            {
                float x = float.Parse(txtTienNhan.Text);
                float y = float.Parse(txtTongTien.Text);
                if (x > y)
                    txtTraLai.Text = (x - y).ToString();
                else
                    txtTraLai.Text = "0";
            }
            else
                txtTraLai.Text = "0";
        }

        private void btnThenKH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gán bảng khách hàng vào");
        }
        private void resetMuaHang()
        {
            tongTien = 0;
            txtTongTien.Text = Convert.ToString(tongTien);
            if (dgvHangMua.Rows.Count > 0)
                dt.Clear();
            dgvHangMua.DataSource = dt;

            if (chkCoPGG.Checked == true)
                chkCoPGG.Checked = false;
            if (chkKHTT.Checked == true)
                chkKHTT.Checked = false;
            txtTienNhan.ResetText();
            txtTraLai.ResetText();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận hủy và nhập lại?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                resetMuaHang();
            }
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            tongTien = 0;
            if (dgvHangMua.Rows.Count > 0)
            {
                for (int i = 0; i < dgvHangMua.Rows.Count - 1; i++)
                {
                    tongTien += float.Parse(dgvHangMua.Rows[i].Cells["Thành tiền"].Value.ToString());
                }
                if (chkCoPGG.Checked == true)
                    if (txtGTGiam.Text.Trim().Length > 0)
                        tongTien = tongTien - tongTien * float.Parse(txtGTGiam.Text) / 100;
                txtTongTien.Text = Convert.ToString(tongTien);
            }
            else
                txtTongTien.Text = "0";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_BanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Xác nhận thoát?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblTime.Text = DateTime.Now.ToShortTimeString();
        }

        string maCTBH;
        DataTable dtPBH = new DataTable();
        private void themPhieuBH()
        {
            DateTime homNay = DateTime.Today;
            String strNgay = homNay.ToString("yyyy-MM-dd");
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd;
            string sql = "Select count(MaBanHang) from PhieuBanHang";
            cmd = new SqlCommand(sql, conn);
            int stt = (int)cmd.ExecuteScalar();
            stt++;
            String strStt = stt.ToString("000");
            String maPBH = "PBH" + strStt;

            String maPGG;
            String maKH;

            if (chkKHTT.Checked == true && txtTenKH.Text.Trim().Length > 0 && chkCoPGG.Checked == true && txtGTGiam.Text.Trim().Length > 0)
            {
                maPGG = cboPGG.SelectedValue.ToString();
                maKH = cboMaKH.SelectedValue.ToString();
                sql = "Insert into PhieuBanHang Values('" + maPBH + "', 'NV001', '" + maPGG + "', '" + maKH + "','" + strNgay + "', 'Bán hàng tháng " + homNay.ToString("MM") + "', NULL)";
                cmd = new SqlCommand(sql, conn);
                int kq = cmd.ExecuteNonQuery();
            }
            else if (chkKHTT.Checked == true && txtTenKH.Text.Trim().Length > 0 && chkCoPGG.Checked == false)
            {
                maKH = cboMaKH.SelectedValue.ToString();
                sql = "Insert into PhieuBanHang Values('" + maPBH + "', 'NV001', NULL, '" + maKH + "','" + strNgay + "', 'Bán hàng tháng " + homNay.ToString("MM") + "', NULL)";
                cmd = new SqlCommand(sql, conn);
                int kq = cmd.ExecuteNonQuery();
            }
            else if (chkCoPGG.Checked == true && txtGTGiam.Text.Trim().Length > 0 && chkKHTT.Checked == false)
            {
                maPGG = cboPGG.SelectedValue.ToString();
                sql = "Insert into PhieuBanHang Values('" + maPBH + "', 'NV001', '" + maPGG + "', NULL,'" + strNgay + "', 'Bán hàng tháng " + homNay.ToString("MM") + "', NULL)";
                cmd = new SqlCommand(sql, conn);
                int kq = cmd.ExecuteNonQuery();
            }
            else
            {
                sql = "Insert into PhieuBanHang Values('" + maPBH + "', 'NV001', NULL, NULL,'" + strNgay + "', 'Bán hàng tháng " + homNay.ToString("MM") + "', NULL)";
                cmd = new SqlCommand(sql, conn);
                int kq = cmd.ExecuteNonQuery();
            }
            maCTBH = maPBH;
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        private void themCTBH()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            SqlCommand cmd;
            string sql;
            for (int i = 0; i < dgvHangMua.Rows.Count - 1; i++)
            {
                string maHH = dgvHangMua.Rows[i].Cells["Mã hàng"].Value.ToString();
                string giaBan = dgvHangMua.Rows[i].Cells["Giá bán"].Value.ToString();
                string sl = dgvHangMua.Rows[i].Cells["Số lượng"].Value.ToString();
                sql = "Insert into ChiTietBanHang(MaBanHang, MaHH, GiaBan, SoLuong) Values('" + maCTBH + "', '" + maHH + "', '" + giaBan + "', '" + sl + "')";
                cmd = new SqlCommand(sql, conn);
                int kq = cmd.ExecuteNonQuery();
            }
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(dt.Rows.Count > 0)
            {
                if(txtTienNhan.Text.Trim().Length > 0 && IsNumber(txtTienNhan.Text))
                {
                    if (MessageBox.Show("Xác nhận thanh toán?", "Thông báo",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        themPhieuBH();
                        themCTBH();
                        MessageBox.Show("Đã thanh toán thành công", "Thông báo");
                        resetMuaHang();
                        loadHangHoa();

                        frm_InHoaDon frm1 = new frm_InHoaDon(maCTBH);
                        frm1.Show();
                    }
                }
                else
                    MessageBox.Show("Hãy nhập số tiền đã nhận từ khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Chưa có hàng hóa để thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}