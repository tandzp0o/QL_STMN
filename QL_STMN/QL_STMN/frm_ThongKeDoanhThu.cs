using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QL_STMN
{
    public partial class frm_ThongKeDoanhThu : Form
    {
        public frm_ThongKeDoanhThu()
        {
            InitializeComponent();
        }
        void load7Days()
        {
            DataSet ds = new DataSet();
            string sql = "select * from dbo.DoanhThuNgay(dateadd(day,-7,getdate()),getdate())";
            SqlDataAdapter da = new SqlDataAdapter(sql, KetNoiDB.strconn);
            da.Fill(ds);
            chart7Days.DataSource = ds.Tables[0];
            chart7Days.ChartAreas[0].AxisX.Title = "Ngày";
            chart7Days.ChartAreas[0].AxisY.Title = "VND";
            chart7Days.Series["S1"].XValueMember = "Ngay";
            chart7Days.Series["S1"].YValueMembers = "DoanhThu";
        }
        void load30Days()
        {
            DataSet ds = new DataSet();
            string sql = "select * from dbo.DoanhThuNgay(dateadd(day,-30,getdate()),getdate())";
            SqlDataAdapter da = new SqlDataAdapter(sql, KetNoiDB.strconn);
            da.Fill(ds);
            chart30Days.DataSource = ds.Tables[0];
            chart30Days.ChartAreas[0].AxisX.Title = "Ngày";
            chart30Days.ChartAreas[0].AxisY.Title = "VND";
            chart30Days.Series["S1"].XValueMember = "Ngay";
            chart30Days.Series["S1"].YValueMembers = "DoanhThu";
        }

        void loadQuarter()
        {
            DataSet ds = new DataSet();
            string sql = "select * from dbo.DoanhThuQuy(" + cbbQuarter.SelectedItem.ToString() + ")";
            SqlDataAdapter da = new SqlDataAdapter(sql, KetNoiDB.strconn);
            da.Fill(ds);
            chartQuarter.DataSource = ds.Tables[0];
            chartQuarter.ChartAreas[0].AxisX.Title = "Tháng";
            chartQuarter.ChartAreas[0].AxisY.Title = "VND";
            chartQuarter.Series["S1"].XValueMember = "Thang";
            chartQuarter.Series["S1"].YValueMembers = "DoanhThu";
        }

        void loadQuaters()
        {
            DataSet ds = new DataSet();
            string sql = "select Quy, isnull(DoanhThu, 0) as DoanhThu from dbo.DoanhThuCacQuy()";
            SqlDataAdapter da = new SqlDataAdapter(sql, KetNoiDB.strconn);
            da.Fill(ds);
            chartQuarters.DataSource = ds.Tables[0];
            chartQuarters.ChartAreas[0].AxisX.Title = "Quý";
            chartQuarters.ChartAreas[0].AxisY.Title = "VND";
            chartQuarters.Series["S1"].XValueMember = "Quy";
            chartQuarters.Series["S1"].YValueMembers = "DoanhThu";
        }

        private void frm_ThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            cbbQuarter.SelectedIndex = (DateTime.Now.Month + 2) / 3 - 1;
            load7Days();
            load30Days();
            loadQuarter();
            loadQuaters();
        }

        private void cbbQuarter_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadQuarter();
        }
    }
}
