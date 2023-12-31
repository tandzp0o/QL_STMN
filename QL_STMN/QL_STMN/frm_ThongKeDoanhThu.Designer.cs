
namespace QL_STMN
{
    partial class frm_ThongKeDoanhThu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ThongKeDoanhThu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gr_DoanhThu_CacQuy = new System.Windows.Forms.GroupBox();
            this.chartQuarters = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gr_DoanhThu_Quy = new System.Windows.Forms.GroupBox();
            this.chartQuarter = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cbbQuarter = new System.Windows.Forms.ComboBox();
            this.gr_DoanhThu_30Days = new System.Windows.Forms.GroupBox();
            this.chart30Days = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gr_DoanhThu_7Days = new System.Windows.Forms.GroupBox();
            this.chart7Days = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.gr_DoanhThu_CacQuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuarters)).BeginInit();
            this.gr_DoanhThu_Quy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuarter)).BeginInit();
            this.gr_DoanhThu_30Days.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart30Days)).BeginInit();
            this.gr_DoanhThu_7Days.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart7Days)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gr_DoanhThu_CacQuy);
            this.panel1.Controls.Add(this.gr_DoanhThu_Quy);
            this.panel1.Controls.Add(this.gr_DoanhThu_30Days);
            this.panel1.Controls.Add(this.gr_DoanhThu_7Days);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(2, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(489, 727);
            this.panel1.TabIndex = 1;
            // 
            // gr_DoanhThu_CacQuy
            // 
            this.gr_DoanhThu_CacQuy.Controls.Add(this.chartQuarters);
            this.gr_DoanhThu_CacQuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_DoanhThu_CacQuy.Location = new System.Drawing.Point(4, 544);
            this.gr_DoanhThu_CacQuy.Name = "gr_DoanhThu_CacQuy";
            this.gr_DoanhThu_CacQuy.Size = new System.Drawing.Size(482, 180);
            this.gr_DoanhThu_CacQuy.TabIndex = 3;
            this.gr_DoanhThu_CacQuy.TabStop = false;
            this.gr_DoanhThu_CacQuy.Text = "Doanh thu các quý";
            // 
            // chartQuarters
            // 
            chartArea1.Name = "ChartArea1";
            this.chartQuarters.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartQuarters.Legends.Add(legend1);
            this.chartQuarters.Location = new System.Drawing.Point(7, 25);
            this.chartQuarters.Name = "chartQuarters";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.LegendText = "Quý";
            series1.Name = "S1";
            this.chartQuarters.Series.Add(series1);
            this.chartQuarters.Size = new System.Drawing.Size(421, 136);
            this.chartQuarters.TabIndex = 4;
            this.chartQuarters.Text = "chart4";
            // 
            // gr_DoanhThu_Quy
            // 
            this.gr_DoanhThu_Quy.Controls.Add(this.chartQuarter);
            this.gr_DoanhThu_Quy.Controls.Add(this.cbbQuarter);
            this.gr_DoanhThu_Quy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_DoanhThu_Quy.Location = new System.Drawing.Point(4, 364);
            this.gr_DoanhThu_Quy.Name = "gr_DoanhThu_Quy";
            this.gr_DoanhThu_Quy.Size = new System.Drawing.Size(482, 180);
            this.gr_DoanhThu_Quy.TabIndex = 2;
            this.gr_DoanhThu_Quy.TabStop = false;
            this.gr_DoanhThu_Quy.Text = "Doanh thu trong quý";
            // 
            // chartQuarter
            // 
            chartArea2.Name = "ChartArea1";
            this.chartQuarter.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartQuarter.Legends.Add(legend2);
            this.chartQuarter.Location = new System.Drawing.Point(7, 25);
            this.chartQuarter.Name = "chartQuarter";
            series2.ChartArea = "ChartArea1";
            series2.IsValueShownAsLabel = true;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.LegendText = "Tháng";
            series2.Name = "S1";
            this.chartQuarter.Series.Add(series2);
            this.chartQuarter.Size = new System.Drawing.Size(420, 136);
            this.chartQuarter.TabIndex = 3;
            this.chartQuarter.Text = "chart3";
            // 
            // cbbQuarter
            // 
            this.cbbQuarter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuarter.FormattingEnabled = true;
            this.cbbQuarter.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbbQuarter.Location = new System.Drawing.Point(432, 15);
            this.cbbQuarter.Name = "cbbQuarter";
            this.cbbQuarter.Size = new System.Drawing.Size(44, 28);
            this.cbbQuarter.TabIndex = 2;
            this.cbbQuarter.SelectedIndexChanged += new System.EventHandler(this.cbbQuarter_SelectedIndexChanged);
            // 
            // gr_DoanhThu_30Days
            // 
            this.gr_DoanhThu_30Days.Controls.Add(this.chart30Days);
            this.gr_DoanhThu_30Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_DoanhThu_30Days.Location = new System.Drawing.Point(4, 184);
            this.gr_DoanhThu_30Days.Name = "gr_DoanhThu_30Days";
            this.gr_DoanhThu_30Days.Size = new System.Drawing.Size(482, 180);
            this.gr_DoanhThu_30Days.TabIndex = 1;
            this.gr_DoanhThu_30Days.TabStop = false;
            this.gr_DoanhThu_30Days.Text = "Doanh thu trong 30 ngày";
            // 
            // chart30Days
            // 
            chartArea3.Name = "ChartArea1";
            this.chart30Days.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart30Days.Legends.Add(legend3);
            this.chart30Days.Location = new System.Drawing.Point(6, 25);
            this.chart30Days.Name = "chart30Days";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.IsValueShownAsLabel = true;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.LegendText = "Ngày";
            series3.Name = "S1";
            this.chart30Days.Series.Add(series3);
            this.chart30Days.Size = new System.Drawing.Size(421, 136);
            this.chart30Days.TabIndex = 1;
            this.chart30Days.Text = "chart2";
            // 
            // gr_DoanhThu_7Days
            // 
            this.gr_DoanhThu_7Days.Controls.Add(this.chart7Days);
            this.gr_DoanhThu_7Days.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gr_DoanhThu_7Days.Location = new System.Drawing.Point(4, 4);
            this.gr_DoanhThu_7Days.Name = "gr_DoanhThu_7Days";
            this.gr_DoanhThu_7Days.Size = new System.Drawing.Size(482, 180);
            this.gr_DoanhThu_7Days.TabIndex = 0;
            this.gr_DoanhThu_7Days.TabStop = false;
            this.gr_DoanhThu_7Days.Text = "Doanh thu trong 7 ngày";
            // 
            // chart7Days
            // 
            chartArea4.Name = "ChartArea1";
            this.chart7Days.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart7Days.Legends.Add(legend4);
            this.chart7Days.Location = new System.Drawing.Point(6, 25);
            this.chart7Days.Name = "chart7Days";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series4.IsValueShownAsLabel = true;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.LegendText = "Ngày";
            series4.Name = "S1";
            series4.YValuesPerPoint = 4;
            this.chart7Days.Series.Add(series4);
            this.chart7Days.Size = new System.Drawing.Size(421, 136);
            this.chart7Days.TabIndex = 1;
            this.chart7Days.Text = "chart1";
            // 
            // frm_ThongKeDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 745);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_ThongKeDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frm_ThongKeDoanhThu_Load);
            this.panel1.ResumeLayout(false);
            this.gr_DoanhThu_CacQuy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartQuarters)).EndInit();
            this.gr_DoanhThu_Quy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartQuarter)).EndInit();
            this.gr_DoanhThu_30Days.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart30Days)).EndInit();
            this.gr_DoanhThu_7Days.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart7Days)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gr_DoanhThu_CacQuy;
        private System.Windows.Forms.GroupBox gr_DoanhThu_Quy;
        private System.Windows.Forms.ComboBox cbbQuarter;
        private System.Windows.Forms.GroupBox gr_DoanhThu_30Days;
        private System.Windows.Forms.GroupBox gr_DoanhThu_7Days;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuarters;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuarter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart30Days;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart7Days;
    }
}