using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_STMN
{
    class NhanVienSTMN
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
    }
}
