﻿using System;
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
    public partial class frm_HangHoa : Form
    {
        SqlConnection conn;
        DataSet ds_HangHoa;
        SqlDataAdapter adap;
        public frm_HangHoa()
        {
            InitializeComponent();
            conn = new SqlConnection(KetNoiDB.strconn);
            ds_HangHoa = new DataSet();
        }
        private void loadLoaiHH()
        {
            adap = new SqlDataAdapter("Select *from LoaiHangHoa", conn);
            adap.Fill(ds_HangHoa, "LHH");

            cboLoaiHH.DataSource = ds_HangHoa.Tables["LHH"];
            cboLoaiHH.DisplayMember = "TenLoaiHH";
            cboLoaiHH.ValueMember = "MaLoaiHH";
        }
        private void loadTimLoaiHH()
        {
            adap = new SqlDataAdapter("Select *from LoaiHangHoa", conn);
            adap.Fill(ds_HangHoa, "TimLHH");

            DataRow all = ds_HangHoa.Tables["TimLHH"].NewRow();
            all[0] = "All";
            all[1] = "Tất cả";
            ds_HangHoa.Tables["TimLHH"].Rows.InsertAt(all, 0);

            cboTimLoaiHH.DataSource = ds_HangHoa.Tables["TimLHH"];
            cboTimLoaiHH.DisplayMember = "TenLoaiHH";
            cboTimLoaiHH.ValueMember = "MaLoaiHH";
        }
        private void loadNCC()
        {
            adap = new SqlDataAdapter("Select *from NhaCungCap", conn);
            adap.Fill(ds_HangHoa, "NCC");

            cboNCC.DataSource = ds_HangHoa.Tables["NCC"];
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
        }
        private void loadTimNCC()
        {
            adap = new SqlDataAdapter("Select *from NhaCungCap", conn);
            adap.Fill(ds_HangHoa, "TimNCC");

            DataRow all = ds_HangHoa.Tables["TimNCC"].NewRow();
            all[0] = "All";
            all[1] = "Tất cả";
            ds_HangHoa.Tables["TimNCC"].Rows.InsertAt(all, 0);

            cboTimNCC.DataSource = ds_HangHoa.Tables["TimNCC"];
            cboTimNCC.DisplayMember = "TenNCC";
            cboTimNCC.ValueMember = "MaNCC";
        }
        private void loadHangHoa()
        {
            adap = new SqlDataAdapter("Select *from HangHoa", conn);
            adap.Fill(ds_HangHoa, "HH");

            DataColumn[] key = new DataColumn[1];
            key[0] = ds_HangHoa.Tables["HH"].Columns[0];
            ds_HangHoa.Tables["HH"].PrimaryKey = key;

            dgvHangHoa.DataSource = ds_HangHoa.Tables["HH"];
        }
        private void btnQLLoaiHH_Click(object sender, EventArgs e)
        {
            frm_LoaiHangHoa frm1 = new frm_LoaiHangHoa();
            frm1.ShowDialog();
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            frm_NhaCungCap frm2 = new frm_NhaCungCap();
            frm2.ShowDialog();
        }
        private void Bingdings()
        {
            txtMaHH.DataBindings.Clear();
            txtMaHH.DataBindings.Add("Text", dgvHangHoa.DataSource, "MaHH");
            txtTenHH.DataBindings.Clear();
            txtTenHH.DataBindings.Add("Text", dgvHangHoa.DataSource, "TenHH");
            txtDVT.DataBindings.Clear();
            txtDVT.DataBindings.Add("Text", dgvHangHoa.DataSource, "DVT");
            txtGiaNhap.DataBindings.Clear();
            txtGiaNhap.DataBindings.Add("Text", dgvHangHoa.DataSource, "GiaNhap");
            txtGiaBan.DataBindings.Clear();
            txtGiaBan.DataBindings.Add("Text", dgvHangHoa.DataSource, "GiaBan");
            txtSLuong.DataBindings.Clear();
            txtSLuong.DataBindings.Add("Text", dgvHangHoa.DataSource, "SoLuong");
            cboLoaiHH.DataBindings.Clear();
            cboLoaiHH.DataBindings.Add("SelectedValue", dgvHangHoa.DataSource,"MaLoaiHH");
            cboNCC.DataBindings.Clear();
            cboNCC.DataBindings.Add("SelectedValue", dgvHangHoa.DataSource, "MaNCC");
        }
        private void frm_QLHangHoa_Load(object sender, EventArgs e)
        {
            loadLoaiHH();
            loadNCC();
            loadTimLoaiHH();
            loadTimNCC();
            loadHangHoa();
            Bingdings();
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
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void themHangHoa()
        {
            adap = new SqlDataAdapter("Select *from HangHoa", conn);
            DataRow newRow = ds_HangHoa.Tables["HH"].NewRow();

            newRow["MaHH"] = txtMaHH.Text;
            newRow["TenHH"] = txtTenHH.Text;
            newRow["DVT"] = txtDVT.Text;
            newRow["GiaNhap"] = txtGiaNhap.Text;
            newRow["GiaBan"] = txtGiaBan.Text;
            newRow["SoLuong"] = txtSLuong.Text;
            newRow["MaloaiHH"] = cboLoaiHH.SelectedValue.ToString();
            newRow["MaNCC"] = cboNCC.SelectedValue.ToString();
            ds_HangHoa.Tables["HH"].Rows.Add(newRow);

            SqlCommandBuilder builder = new SqlCommandBuilder(adap);
            int kq = adap.Update(ds_HangHoa.Tables["HH"]);
            if (kq == 0)
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Đã thêm hàng hóa mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                loadHangHoa();
            }
            dgvHangHoa.DataSource = ds_HangHoa.Tables["HH"];
        }
        private void xoaHangHoa()
        {
            if (MessageBox.Show("Xác nhận xóa hàng hóa này?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                adap = new SqlDataAdapter("Select *from HangHoa", conn);
                DataRow deleteRow = ds_HangHoa.Tables["HH"].Rows.Find(txtMaHH.Text);
                if (deleteRow != null)
                    deleteRow.Delete();
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adap);
                int kq = adap.Update(ds_HangHoa.Tables["HH"]);
                if (kq == 0)
                {
                    MessageBox.Show("Xóa hàng hóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadHangHoa();
                }    
                else
                    MessageBox.Show("Xóa hàng hóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                dgvHangHoa.DataSource = ds_HangHoa.Tables["HH"];    
            }
        }
        private void suaHangHoa()
        {
            adap = new SqlDataAdapter("Select *from HangHoa", conn);
            DataRow updateRow = ds_HangHoa.Tables["HH"].Rows.Find(txtMaHH.Text);
            if (updateRow != null)
            {
                updateRow.BeginEdit();
                updateRow["TenHH"] = txtTenHH.Text;
                updateRow["DVT"] = txtDVT.Text;
                updateRow["GiaNhap"] = txtGiaNhap.Text;
                updateRow["GiaBan"] = txtGiaBan.Text;
                updateRow["SoLuong"] = txtSLuong.Text;
                updateRow["MaloaiHH"] = cboLoaiHH.SelectedValue.ToString();
                updateRow["MaNCC"] = cboNCC.SelectedValue.ToString();
                updateRow.EndEdit();
            }
            else
            {
                MessageBox.Show("Chỉnh sửa hàng hóa không thành công\nLý do: không tìm thấy mã hàng hóa\nLưu ý: Không được sửa mã hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadHangHoa();
                return;
            }
            SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adap);
            int kq = adap.Update(ds_HangHoa.Tables["HH"]);
            if (kq == 0)
                MessageBox.Show("Chỉnh sửa hàng hóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show("Đã chỉnh sửa thông tin hàng hóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            dgvHangHoa.DataSource = ds_HangHoa.Tables["HH"];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (isDuplicatePriKey(txtMaHH.Text) == true)
                MessageBox.Show("Mã hàng hóa bị trùng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                themHangHoa();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoaHangHoa();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            suaHangHoa();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    adap = new SqlDataAdapter("Select *from HangHoa where TenHH like N'%" + txtTimTen.Text + "%' and MaloaiHH = '" + cboTimLoaiHH.SelectedValue + "' and MaNCC = '" + cboTimNCC.SelectedValue + "'", conn);
                    adap.Fill(dt);
                }
                else if (x != 0)
                {
                    adap = new SqlDataAdapter("Select *from HangHoa where TenHH like N'%" + txtTimTen.Text + "%' and MaloaiHH = '" + cboTimLoaiHH.SelectedValue + "'", conn);
                    adap.Fill(dt);
                }
                else if (y != 0)
                {
                    adap = new SqlDataAdapter("Select *from HangHoa where TenHH like N'%" + txtTimTen.Text + "%' and MaNCC = '" + cboTimNCC.SelectedValue + "'", conn);
                    adap.Fill(dt);
                }
                else
                {
                    adap = new SqlDataAdapter("Select *from HangHoa where TenHH like N'%" + txtTimTen.Text + "%'", conn);
                    adap.Fill(dt);
                }
                dgvHangHoa.DataSource = dt;
            }
            else
            {
                if (x != 0 && y != 0)
                {
                    adap = new SqlDataAdapter("Select *from HangHoa where MaloaiHH = '" + cboTimLoaiHH.SelectedValue + "' and MaNCC = '" + cboTimNCC.SelectedValue + "'", conn);
                    adap.Fill(dt);
                }
                else if (x != 0)
                {
                    adap = new SqlDataAdapter("Select *from HangHoa where MaloaiHH = '" + cboTimLoaiHH.SelectedValue + "'", conn);
                    adap.Fill(dt);
                }
                else if (y != 0)
                {
                    adap = new SqlDataAdapter("Select *from HangHoa where MaNCC = '" + cboTimNCC.SelectedValue + "'", conn);
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
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            timKiem();
        }

        private void frm_QLHangHoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Xác nhận thoát?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void txtGiaNhap_TextChanged(object sender, EventArgs e)
        {
            Control ctr = (Control)sender;
            if (ctr.Text.Trim().Length > 0 && !Char.IsDigit(ctr.Text[ctr.Text.Length - 1]))
                this.errorProvider1.SetError(ctr, "Đây không phải kiểu số");
            else this.errorProvider1.Clear();
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Bingdings();
        }

    }
}