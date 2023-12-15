using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using QL_STMN;

namespace Nhom1_QuanLySieuThiMini
{
    public class NhanVien
    {
        public string maNV {  get; set; }
        public string tenNV { get; set; }
        public string gioiTinh { get; set; }
        public string namSinh { get; set; }
        public string sDT_NV { get; set; }
        public string diaChi_NV { get; set; }
        public string maCV { get; set; }

        public NhanVien(string manv, string tennv, string gioitinh, string namsinh,
            string sdt_nv, string diachi_nv, string macv)
        {
            this.maNV = manv;
            this.tenNV = tennv;
            this.gioiTinh = gioitinh;
            this.namSinh = namsinh;
            this.sDT_NV = sdt_nv;
            this.diaChi_NV = diachi_nv;
            this.maCV = macv;
        }
        public NhanVien()
        {

        }

    }
    public class ListNhanVien
    {
        public List<NhanVien> DsNhanVien { get; set; }
        DataSet DS_NhanVien = new DataSet();
        public void GetData_NhanVien()
        {
            using (SqlConnection conn = new SqlConnection(KetNoiDB.strconn))
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM NhanVien";

                SqlDataAdapter da_NV = new SqlDataAdapter(sqlSelect, conn);
                da_NV.Fill(DS_NhanVien, "NV");
            }
            // Khởi tạo danh sách nhân viên
            DsNhanVien = new List<NhanVien>();

            // Lặp qua từng dòng trong bảng "NhanVien" và thêm vào danh sách
            foreach (DataRow row in DS_NhanVien.Tables["NV"].Rows)
            {
                NhanVien nhanVien = new NhanVien
                {
                    maNV = row["MaNV"].ToString(),
                    tenNV = row["TenNV"].ToString(),
                    gioiTinh = row["GioiTinh"].ToString(),
                    namSinh = row["NamSinh"].ToString(),
                    sDT_NV = row["SDT_NV"].ToString(),
                    diaChi_NV = row["DiaChi_NV"].ToString(),
                    maCV = row["MaCV"].ToString()
                };

                DsNhanVien.Add(nhanVien);
            }
        }

        public string Find_MaCV(string MaNV)
        {
            foreach (var item in DsNhanVien)
            {
                if (MaNV == item.maNV)
                {
                    return item.maCV;
                }
            }
            return null;
        }
    }
}
