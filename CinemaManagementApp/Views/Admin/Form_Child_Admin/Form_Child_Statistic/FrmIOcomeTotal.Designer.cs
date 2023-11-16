namespace CinemaManagementApp.Views.Admin.Form_Child_Admin.Form_Child_Statistic
{
    partial class FrmIOcomeTotal
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
            this.panelFilter = new System.Windows.Forms.Panel();
            this.cbTimeMonth = new System.Windows.Forms.ComboBox();
            this.cbTimeYear = new System.Windows.Forms.ComboBox();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.panelStatistic = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalProd = new System.Windows.Forms.Label();
            this.lblTotalTicket = new System.Windows.Forms.Label();
            this.lblPercentProd = new System.Windows.Forms.Label();
            this.lblPercentTicket = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblTicket = new System.Windows.Forms.Label();
            this.lblIncomeTotalValue = new System.Windows.Forms.Label();
            this.lbInComeTotal = new System.Windows.Forms.Label();
            this.panelChart = new System.Windows.Forms.Panel();
            this.chartIOCome = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelFilter.SuspendLayout();
            this.panelStatistic.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartIOCome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFilter.Controls.Add(this.cbTimeMonth);
            this.panelFilter.Controls.Add(this.cbTimeYear);
            this.panelFilter.Controls.Add(this.cbPeriod);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 0);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(982, 73);
            this.panelFilter.TabIndex = 0;
            // 
            // cbTimeMonth
            // 
            this.cbTimeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeMonth.FormattingEnabled = true;
            this.cbTimeMonth.Location = new System.Drawing.Point(278, 24);
            this.cbTimeMonth.Name = "cbTimeMonth";
            this.cbTimeMonth.Size = new System.Drawing.Size(80, 28);
            this.cbTimeMonth.TabIndex = 8;
            this.cbTimeMonth.SelectedIndexChanged += new System.EventHandler(this.cbTimeMonth_SelectedIndexChanged);
            // 
            // cbTimeYear
            // 
            this.cbTimeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeYear.FormattingEnabled = true;
            this.cbTimeYear.Location = new System.Drawing.Point(175, 24);
            this.cbTimeYear.Name = "cbTimeYear";
            this.cbTimeYear.Size = new System.Drawing.Size(80, 28);
            this.cbTimeYear.TabIndex = 7;
            this.cbTimeYear.SelectedIndexChanged += new System.EventHandler(this.cbTimeYear_SelectedIndexChanged);
            // 
            // cbPeriod
            // 
            this.cbPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Items.AddRange(new object[] {
            "Năm",
            "Tháng"});
            this.cbPeriod.Location = new System.Drawing.Point(36, 24);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(114, 28);
            this.cbPeriod.TabIndex = 6;
            this.cbPeriod.SelectedIndexChanged += new System.EventHandler(this.cbPeriod_SelectedIndexChanged);
            // 
            // panelStatistic
            // 
            this.panelStatistic.Controls.Add(this.panel1);
            this.panelStatistic.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelStatistic.Location = new System.Drawing.Point(0, 73);
            this.panelStatistic.Name = "panelStatistic";
            this.panelStatistic.Size = new System.Drawing.Size(223, 480);
            this.panelStatistic.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTotalProd);
            this.panel1.Controls.Add(this.lblTotalTicket);
            this.panel1.Controls.Add(this.lblPercentProd);
            this.panel1.Controls.Add(this.lblPercentTicket);
            this.panel1.Controls.Add(this.lblProduct);
            this.panel1.Controls.Add(this.lblTicket);
            this.panel1.Controls.Add(this.lblIncomeTotalValue);
            this.panel1.Controls.Add(this.lbInComeTotal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 480);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalProd
            // 
            this.lblTotalProd.AutoSize = true;
            this.lblTotalProd.Location = new System.Drawing.Point(16, 306);
            this.lblTotalProd.Name = "lblTotalProd";
            this.lblTotalProd.Size = new System.Drawing.Size(14, 16);
            this.lblTotalProd.TabIndex = 8;
            this.lblTotalProd.Text = "0";
            // 
            // lblTotalTicket
            // 
            this.lblTotalTicket.AutoSize = true;
            this.lblTotalTicket.Location = new System.Drawing.Point(14, 174);
            this.lblTotalTicket.Name = "lblTotalTicket";
            this.lblTotalTicket.Size = new System.Drawing.Size(14, 16);
            this.lblTotalTicket.TabIndex = 7;
            this.lblTotalTicket.Text = "0";
            // 
            // lblPercentProd
            // 
            this.lblPercentProd.AutoSize = true;
            this.lblPercentProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentProd.Location = new System.Drawing.Point(13, 261);
            this.lblPercentProd.Name = "lblPercentProd";
            this.lblPercentProd.Size = new System.Drawing.Size(35, 20);
            this.lblPercentProd.TabIndex = 6;
            this.lblPercentProd.Text = "0%";
            // 
            // lblPercentTicket
            // 
            this.lblPercentTicket.AutoSize = true;
            this.lblPercentTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentTicket.Location = new System.Drawing.Point(12, 130);
            this.lblPercentTicket.Name = "lblPercentTicket";
            this.lblPercentTicket.Size = new System.Drawing.Size(35, 20);
            this.lblPercentTicket.TabIndex = 5;
            this.lblPercentTicket.Text = "0%";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(13, 227);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(84, 20);
            this.lblProduct.TabIndex = 4;
            this.lblProduct.Text = "Sản phẩm";
            // 
            // lblTicket
            // 
            this.lblTicket.AutoSize = true;
            this.lblTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicket.Location = new System.Drawing.Point(12, 96);
            this.lblTicket.Name = "lblTicket";
            this.lblTicket.Size = new System.Drawing.Size(29, 20);
            this.lblTicket.TabIndex = 3;
            this.lblTicket.Text = "Vé";
            // 
            // lblIncomeTotalValue
            // 
            this.lblIncomeTotalValue.AutoSize = true;
            this.lblIncomeTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncomeTotalValue.Location = new System.Drawing.Point(13, 47);
            this.lblIncomeTotalValue.Name = "lblIncomeTotalValue";
            this.lblIncomeTotalValue.Size = new System.Drawing.Size(19, 20);
            this.lblIncomeTotalValue.TabIndex = 2;
            this.lblIncomeTotalValue.Text = "0";
            // 
            // lbInComeTotal
            // 
            this.lbInComeTotal.AutoSize = true;
            this.lbInComeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInComeTotal.Location = new System.Drawing.Point(7, 12);
            this.lbInComeTotal.Name = "lbInComeTotal";
            this.lbInComeTotal.Size = new System.Drawing.Size(164, 25);
            this.lbInComeTotal.TabIndex = 1;
            this.lbInComeTotal.Text = "Tổng doanh thu";
            // 
            // panelChart
            // 
            this.panelChart.Controls.Add(this.chartIOCome);
            this.panelChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChart.Location = new System.Drawing.Point(223, 73);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(759, 480);
            this.panelChart.TabIndex = 0;
            // 
            // chartIOCome
            // 
            chartArea1.Name = "ChartArea1";
            this.chartIOCome.ChartAreas.Add(chartArea1);
            this.chartIOCome.DataSource = this.chartIOCome.ChartAreas;
            this.chartIOCome.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartIOCome.Legends.Add(legend1);
            this.chartIOCome.Location = new System.Drawing.Point(0, 0);
            this.chartIOCome.Name = "chartIOCome";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "IOCome";
            series1.YValuesPerPoint = 4;
            this.chartIOCome.Series.Add(series1);
            this.chartIOCome.Size = new System.Drawing.Size(759, 480);
            this.chartIOCome.TabIndex = 0;
            this.chartIOCome.Text = "chart1";
            // 
            // FrmIOcomeTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.panelStatistic);
            this.Controls.Add(this.panelFilter);
            this.Name = "FrmIOcomeTotal";
            this.Text = "Tổng thu chi";
            this.Load += new System.EventHandler(this.FrmIOcomeTotal_Load);
            this.panelFilter.ResumeLayout(false);
            this.panelStatistic.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartIOCome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Panel panelStatistic;
        private System.Windows.Forms.Panel panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartIOCome;
        private System.Windows.Forms.ComboBox cbTimeYear;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.ComboBox cbTimeMonth;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalProd;
        private System.Windows.Forms.Label lblTotalTicket;
        private System.Windows.Forms.Label lblPercentProd;
        private System.Windows.Forms.Label lblPercentTicket;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTicket;
        private System.Windows.Forms.Label lblIncomeTotalValue;
        private System.Windows.Forms.Label lbInComeTotal;
    }
}