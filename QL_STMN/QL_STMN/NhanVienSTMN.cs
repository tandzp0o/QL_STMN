using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_STMN
{
    public class NhanVienSTMN
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string MaChucVu { get; set; }
        public DateTime NamSinh { get; set; }
        public string GioiTinh { get; set; }

        public NhanVienSTMN(string maNhanVien, string tenNhanVien, string gioiTinh, DateTime namSinh, string soDienThoai, string diaChi, string maChucVu)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            MaChucVu = maChucVu;
            NamSinh = namSinh;
            GioiTinh = gioiTinh;
        }

        public NhanVienSTMN()
        {

        }
    }

    public class ListNhanVienSTMN
    {
        public List<NhanVienSTMN> DsNhanVienSTMN { get; set; }
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
            DsNhanVienSTMN = new List<NhanVienSTMN>();

            // Lặp qua từng dòng trong bảng "NhanVien" và thêm vào danh sách
            foreach (DataRow row in DS_NhanVien.Tables["NV"].Rows)
            {
                NhanVienSTMN nhanVien = new NhanVienSTMN
                {
                    MaNhanVien = row["MaNV"].ToString(),
                    TenNhanVien = row["TenNV"].ToString(),
                    DiaChi = row["DiaChi_NV"].ToString(),
                    SoDienThoai = row["SDT_NV"].ToString(),
                    MaChucVu = row["MaCV"].ToString(),
                    NamSinh = DateTime.Parse(row["NamSinh"].ToString()),
                    GioiTinh = row["GioiTinh"].ToString()
                };

                DsNhanVienSTMN.Add(nhanVien);
            }
        }

        public string Find_MaCV(string MaNV)
        {
            foreach (var item in DsNhanVienSTMN)
            {
                if (MaNV == item.MaChucVu)
                {
                    return item.MaChucVu;
                }
            }
            return null;
        }
    }
}
