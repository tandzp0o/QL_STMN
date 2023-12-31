using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;

namespace QL_STMN
{
    public class DBConnect
    {
        private static DBConnect instance;
        public static DBConnect Instance
        {
            get
            {
                if (instance == null)
                    instance = new DBConnect();
                return DBConnect.instance;
            }
            private set
            {
                DBConnect.instance = value;
            }
        }


        private DBConnect() { }

        // lấy datatable
        public DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();
            // dùng xong khối lệnh tự giải phóng dữ liệu đc khai báo
            using (SqlConnection con = new SqlConnection(KetNoiDB.strconn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        // lấy số dòng thành công
        public int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;
            // dùng xong khối lệnh tự giải phóng dữ liệu đc khai báo
            using (SqlConnection con = new SqlConnection(KetNoiDB.strconn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteNonQuery();
                con.Close();
            }
            return data;
        }

        // lấy ô đầu tiên trong dòng kết quả
        public T ExcuteScalar<T>(string query, object[] parameter = null)
        {
            object data;
            // dùng xong khối lệnh tự giải phóng dữ liệu đc khai báo
            using (SqlConnection con = new SqlConnection(KetNoiDB.strconn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                con.Close();
            }
            return (T)Convert.ChangeType(data, typeof(T));
        }

        public DataTable ExecuteProcedure(string query)
        {
            DataTable data = new DataTable();
            // dùng xong khối lệnh tự giải phóng dữ liệu đc khai báo
            using (SqlConnection con = new SqlConnection(KetNoiDB.strconn))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                con.Close();
            }
            return data;
        }

        SqlConnection conn = new SqlConnection(KetNoiDB.strconn);
        // Mở CSDL
        public void openConnection()
        {
            if (conn.State.ToString() == "Closed")
                conn.Open();
        }
        //Dóng CDSL
        public void closeConnection()
        {
            if (conn.State.ToString() == "Open")
                conn.Close();
        }

        DataSet ds;
        // lấy 1 cột không cụ thể
        public DataTable getDataTable(string sql)
        {
            ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds);
            return ds.Tables[0];
        }

        // Lấy 1 cột củ thể
        public DataTable getDataTable(string sql, string tableName)
        {
            ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(ds, tableName);
            return ds.Tables[tableName];
        }

        // Thực thi câu truy vấn
        public int executeNonQuery(string sql)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = cmd.ExecuteNonQuery();
            closeConnection();
            return result;
        }

        // Trả về giá trị
        public int getResult_ExecuteScalar(string sql)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int result = (int)cmd.ExecuteScalar();
            closeConnection();
            return result;
        }

        public DataTable ExecuteReader(string sql)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            reader.Close();
            closeConnection();
            return dt;
        }
        public object getScalar(string sql)
        {
            openConnection();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object kq = cmd.ExecuteScalar();
            closeConnection();
            return kq;
        }
    }
}