using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_STMN
{
    public class Account
    {
        //tạo 1 thể hiện(instance)
        private static Account instance;
        public string TK { get; set; }
        public string MK { get; set; }
        public string MaNV { get; set; }
        public static Account Instance
        {
            get
            {
                if (instance == null)
                    instance = new Account();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        public Account(string tk, string mk, string manv)
        {
            this.TK = tk;
            this.MK = mk;
            this.MaNV = manv;
        }
        public Account()
        {

        }

    }
    public class ListTaiKhoan
    {
        public List<Account> DsTaiKhoan { get; set; }

        DataSet Ds_TaiKhoan = new DataSet();
        //Lấy dữ liệu từ cơ sở dữ liệu
        public void GetData_TaiKhoan()
        {
            using (SqlConnection conn = new SqlConnection(KetNoiDB.strconn))
            {
                conn.Open();

                string sqlSelect = "SELECT * FROM TaiKhoan"; // Chú ý cú pháp SQL đúng là "SELECT * FROM NhanVien"

                SqlDataAdapter da_NV = new SqlDataAdapter(sqlSelect, conn);
                da_NV.Fill(Ds_TaiKhoan, "TaiKhoan");
            }
            // Khởi tạo danh sách nhân viên
            DsTaiKhoan = new List<Account>();

            // Lặp qua từng dòng trong bảng "NhanVien" và thêm vào danh sách
            foreach (DataRow row in Ds_TaiKhoan.Tables["TaiKhoan"].Rows)
            {
                Account taiKhoan = new Account
                {
                    TK = row["TaiKhoan"].ToString(),
                    MK = row["MatKhau"].ToString(),
                    MaNV = row["MaNV"].ToString()
                };

                DsTaiKhoan.Add(taiKhoan);
            }
        }

        public bool Login(string tk, string mk)
        {
            foreach (var item in DsTaiKhoan)
            {
                if (tk == item.TK && mk == item.MK)
                    return true;
            }
            return false;
        }
        public string Find_MaNV_By_TK(string tk)
        {
            foreach (var item in DsTaiKhoan)
            {
                if (tk == item.TK)
                {
                    return item.MaNV;
                }
            }
            return "Không tìm thấy";
        }
    }
}
