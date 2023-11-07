namespace CinemaManagementApp.Views.Admin.Form_Child_Admin.Form_Child_Statistic
{
    partial class FrmRatings
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
            this.dgvTopStaffs = new System.Windows.Forms.DataGridView();
            this.panelStaffChart = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.chartStaff = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTimeStaffFilter = new System.Windows.Forms.Panel();
            this.cbStaffTimeMonth = new System.Windows.Forms.ComboBox();
            this.cbStaffTimeYear = new System.Windows.Forms.ComboBox();
            this.cbStaffPeriod = new System.Windows.Forms.ComboBox();
            this.dgvTopCustomers = new System.Windows.Forms.DataGridView();
            this.chartCustomer = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTimeCustomerFilter = new System.Windows.Forms.Panel();
            this.panelProductFilter = new System.Windows.Forms.Panel();
            this.cbCustTimeMonth = new System.Windows.Forms.ComboBox();
            this.cbCustTimeYear = new System.Windows.Forms.ComboBox();
            this.cbCustPeriod = new System.Windows.Forms.ComboBox();
            this.cbMovieTimeMonth = new System.Windows.Forms.ComboBox();
            this.cbMovieTimeYear = new System.Windows.Forms.ComboBox();
            this.cbMoviePeriod = new System.Windows.Forms.ComboBox();
            this.panelStaffRatings = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelCustomerRatings = new System.Windows.Forms.Panel();
            this.panelCustomerChart = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopStaffs)).BeginInit();
            this.panelStaffChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStaff)).BeginInit();
            this.panelTimeStaffFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).BeginInit();
            this.panelTimeCustomerFilter.SuspendLayout();
            this.panelProductFilter.SuspendLayout();
            this.panelStaffRatings.SuspendLayout();
            this.panelCustomerRatings.SuspendLayout();
            this.panelCustomerChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTopStaffs
            // 
            this.dgvTopStaffs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopStaffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopStaffs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopStaffs.Location = new System.Drawing.Point(0, 261);
            this.dgvTopStaffs.Name = "dgvTopStaffs";
            this.dgvTopStaffs.RowHeadersWidth = 51;
            this.dgvTopStaffs.RowTemplate.Height = 24;
            this.dgvTopStaffs.Size = new System.Drawing.Size(483, 264);
            this.dgvTopStaffs.TabIndex = 4;
            this.dgvTopStaffs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTopStaffs_CellFormatting);
            // 
            // panelStaffChart
            // 
            this.panelStaffChart.Controls.Add(this.dgvTopStaffs);
            this.panelStaffChart.Controls.Add(this.label1);
            this.panelStaffChart.Controls.Add(this.chartStaff);
            this.panelStaffChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStaffChart.Location = new System.Drawing.Point(0, 64);
            this.panelStaffChart.Name = "panelStaffChart";
            this.panelStaffChart.Size = new System.Drawing.Size(483, 525);
            this.panelStaffChart.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 218);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.label1.Size = new System.Drawing.Size(452, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top 5 nhân viên đóng góp nhiều nhất";
            // 
            // chartStaff
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStaff.ChartAreas.Add(chartArea1);
            this.chartStaff.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chartStaff.Legends.Add(legend1);
            this.chartStaff.Location = new System.Drawing.Point(0, 0);
            this.chartStaff.Name = "chartStaff";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "TopStaff";
            this.chartStaff.Series.Add(series1);
            this.chartStaff.Size = new System.Drawing.Size(483, 218);
            this.chartStaff.TabIndex = 2;
            this.chartStaff.Text = "chart1";
            // 
            // panelTimeStaffFilter
            // 
            this.panelTimeStaffFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelTimeStaffFilter.Controls.Add(this.cbStaffTimeMonth);
            this.panelTimeStaffFilter.Controls.Add(this.cbStaffTimeYear);
            this.panelTimeStaffFilter.Controls.Add(this.cbStaffPeriod);
            this.panelTimeStaffFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimeStaffFilter.Location = new System.Drawing.Point(0, 0);
            this.panelTimeStaffFilter.Name = "panelTimeStaffFilter";
            this.panelTimeStaffFilter.Size = new System.Drawing.Size(483, 64);
            this.panelTimeStaffFilter.TabIndex = 2;
            // 
            // cbStaffTimeMonth
            // 
            this.cbStaffTimeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffTimeMonth.FormattingEnabled = true;
            this.cbStaffTimeMonth.Location = new System.Drawing.Point(261, 19);
            this.cbStaffTimeMonth.Name = "cbStaffTimeMonth";
            this.cbStaffTimeMonth.Size = new System.Drawing.Size(80, 28);
            this.cbStaffTimeMonth.TabIndex = 14;
            this.cbStaffTimeMonth.SelectedIndexChanged += new System.EventHandler(this.cbStaffTimeMonth_SelectedIndexChanged);
            // 
            // cbStaffTimeYear
            // 
            this.cbStaffTimeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffTimeYear.FormattingEnabled = true;
            this.cbStaffTimeYear.Location = new System.Drawing.Point(158, 19);
            this.cbStaffTimeYear.Name = "cbStaffTimeYear";
            this.cbStaffTimeYear.Size = new System.Drawing.Size(80, 28);
            this.cbStaffTimeYear.TabIndex = 13;
            this.cbStaffTimeYear.SelectedIndexChanged += new System.EventHandler(this.cbStaffTimeYear_SelectedIndexChanged);
            // 
            // cbStaffPeriod
            // 
            this.cbStaffPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStaffPeriod.FormattingEnabled = true;
            this.cbStaffPeriod.Items.AddRange(new object[] {
            "Năm",
            "Tháng"});
            this.cbStaffPeriod.Location = new System.Drawing.Point(19, 19);
            this.cbStaffPeriod.Name = "cbStaffPeriod";
            this.cbStaffPeriod.Size = new System.Drawing.Size(114, 28);
            this.cbStaffPeriod.TabIndex = 12;
            this.cbStaffPeriod.SelectedIndexChanged += new System.EventHandler(this.cbStaffPeriod_SelectedIndexChanged);
            // 
            // dgvTopCustomers
            // 
            this.dgvTopCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopCustomers.Location = new System.Drawing.Point(0, 261);
            this.dgvTopCustomers.Name = "dgvTopCustomers";
            this.dgvTopCustomers.RowHeadersWidth = 51;
            this.dgvTopCustomers.RowTemplate.Height = 24;
            this.dgvTopCustomers.Size = new System.Drawing.Size(489, 264);
            this.dgvTopCustomers.TabIndex = 4;
            this.dgvTopCustomers.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTopCustomers_CellFormatting);
            // 
            // chartCustomer
            // 
            chartArea2.Name = "ChartArea1";
            this.chartCustomer.ChartAreas.Add(chartArea2);
            this.chartCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            legend2.Name = "Legend1";
            this.chartCustomer.Legends.Add(legend2);
            this.chartCustomer.Location = new System.Drawing.Point(0, 0);
            this.chartCustomer.Name = "chartCustomer";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Top1Cust";
            this.chartCustomer.Series.Add(series2);
            this.chartCustomer.Size = new System.Drawing.Size(489, 218);
            this.chartCustomer.TabIndex = 2;
            this.chartCustomer.Text = "chart2";
            // 
            // panelTimeCustomerFilter
            // 
            this.panelTimeCustomerFilter.Controls.Add(this.panelProductFilter);
            this.panelTimeCustomerFilter.Controls.Add(this.cbMovieTimeMonth);
            this.panelTimeCustomerFilter.Controls.Add(this.cbMovieTimeYear);
            this.panelTimeCustomerFilter.Controls.Add(this.cbMoviePeriod);
            this.panelTimeCustomerFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTimeCustomerFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelTimeCustomerFilter.Location = new System.Drawing.Point(0, 0);
            this.panelTimeCustomerFilter.Name = "panelTimeCustomerFilter";
            this.panelTimeCustomerFilter.Size = new System.Drawing.Size(489, 64);
            this.panelTimeCustomerFilter.TabIndex = 1;
            // 
            // panelProductFilter
            // 
            this.panelProductFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelProductFilter.Controls.Add(this.cbCustTimeMonth);
            this.panelProductFilter.Controls.Add(this.cbCustTimeYear);
            this.panelProductFilter.Controls.Add(this.cbCustPeriod);
            this.panelProductFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductFilter.Location = new System.Drawing.Point(0, 0);
            this.panelProductFilter.Name = "panelProductFilter";
            this.panelProductFilter.Size = new System.Drawing.Size(489, 64);
            this.panelProductFilter.TabIndex = 12;
            // 
            // cbCustTimeMonth
            // 
            this.cbCustTimeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustTimeMonth.FormattingEnabled = true;
            this.cbCustTimeMonth.Location = new System.Drawing.Point(265, 19);
            this.cbCustTimeMonth.Name = "cbCustTimeMonth";
            this.cbCustTimeMonth.Size = new System.Drawing.Size(80, 28);
            this.cbCustTimeMonth.TabIndex = 11;
            this.cbCustTimeMonth.SelectedIndexChanged += new System.EventHandler(this.cbCustTimeMonth_SelectedIndexChanged);
            // 
            // cbCustTimeYear
            // 
            this.cbCustTimeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustTimeYear.FormattingEnabled = true;
            this.cbCustTimeYear.Location = new System.Drawing.Point(162, 19);
            this.cbCustTimeYear.Name = "cbCustTimeYear";
            this.cbCustTimeYear.Size = new System.Drawing.Size(80, 28);
            this.cbCustTimeYear.TabIndex = 10;
            this.cbCustTimeYear.SelectedIndexChanged += new System.EventHandler(this.cbCustTimeYear_SelectedIndexChanged);
            // 
            // cbCustPeriod
            // 
            this.cbCustPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustPeriod.FormattingEnabled = true;
            this.cbCustPeriod.Items.AddRange(new object[] {
            "Năm",
            "Tháng"});
            this.cbCustPeriod.Location = new System.Drawing.Point(23, 19);
            this.cbCustPeriod.Name = "cbCustPeriod";
            this.cbCustPeriod.Size = new System.Drawing.Size(114, 28);
            this.cbCustPeriod.TabIndex = 9;
            this.cbCustPeriod.SelectedIndexChanged += new System.EventHandler(this.cbCustPeriod_SelectedIndexChanged);
            // 
            // cbMovieTimeMonth
            // 
            this.cbMovieTimeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMovieTimeMonth.FormattingEnabled = true;
            this.cbMovieTimeMonth.Location = new System.Drawing.Point(265, 19);
            this.cbMovieTimeMonth.Name = "cbMovieTimeMonth";
            this.cbMovieTimeMonth.Size = new System.Drawing.Size(80, 28);
            this.cbMovieTimeMonth.TabIndex = 15;
            // 
            // cbMovieTimeYear
            // 
            this.cbMovieTimeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMovieTimeYear.FormattingEnabled = true;
            this.cbMovieTimeYear.Location = new System.Drawing.Point(162, 19);
            this.cbMovieTimeYear.Name = "cbMovieTimeYear";
            this.cbMovieTimeYear.Size = new System.Drawing.Size(80, 28);
            this.cbMovieTimeYear.TabIndex = 14;
            // 
            // cbMoviePeriod
            // 
            this.cbMoviePeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMoviePeriod.FormattingEnabled = true;
            this.cbMoviePeriod.Items.AddRange(new object[] {
            "Năm",
            "Tháng"});
            this.cbMoviePeriod.Location = new System.Drawing.Point(23, 19);
            this.cbMoviePeriod.Name = "cbMoviePeriod";
            this.cbMoviePeriod.Size = new System.Drawing.Size(114, 28);
            this.cbMoviePeriod.TabIndex = 13;
            // 
            // panelStaffRatings
            // 
            this.panelStaffRatings.Controls.Add(this.panelStaffChart);
            this.panelStaffRatings.Controls.Add(this.panelTimeStaffFilter);
            this.panelStaffRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStaffRatings.Location = new System.Drawing.Point(499, 0);
            this.panelStaffRatings.Name = "panelStaffRatings";
            this.panelStaffRatings.Size = new System.Drawing.Size(483, 589);
            this.panelStaffRatings.TabIndex = 5;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(489, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 589);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // panelCustomerRatings
            // 
            this.panelCustomerRatings.Controls.Add(this.panelCustomerChart);
            this.panelCustomerRatings.Controls.Add(this.panelTimeCustomerFilter);
            this.panelCustomerRatings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCustomerRatings.Location = new System.Drawing.Point(0, 0);
            this.panelCustomerRatings.Name = "panelCustomerRatings";
            this.panelCustomerRatings.Size = new System.Drawing.Size(489, 589);
            this.panelCustomerRatings.TabIndex = 3;
            // 
            // panelCustomerChart
            // 
            this.panelCustomerChart.Controls.Add(this.dgvTopCustomers);
            this.panelCustomerChart.Controls.Add(this.label2);
            this.panelCustomerChart.Controls.Add(this.chartCustomer);
            this.panelCustomerChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCustomerChart.Location = new System.Drawing.Point(0, 64);
            this.panelCustomerChart.Name = "panelCustomerChart";
            this.panelCustomerChart.Size = new System.Drawing.Size(489, 525);
            this.panelCustomerChart.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 218);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.label2.Size = new System.Drawing.Size(446, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top 5 khách hàng chi tiêu nhiều nhất";
            // 
            // FrmRatings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 589);
            this.Controls.Add(this.panelStaffRatings);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelCustomerRatings);
            this.Name = "FrmRatings";
            this.Text = "Bảng xếp hạng";
            this.Load += new System.EventHandler(this.FrmRatings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopStaffs)).EndInit();
            this.panelStaffChart.ResumeLayout(false);
            this.panelStaffChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStaff)).EndInit();
            this.panelTimeStaffFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCustomer)).EndInit();
            this.panelTimeCustomerFilter.ResumeLayout(false);
            this.panelProductFilter.ResumeLayout(false);
            this.panelStaffRatings.ResumeLayout(false);
            this.panelCustomerRatings.ResumeLayout(false);
            this.panelCustomerChart.ResumeLayout(false);
            this.panelCustomerChart.PerformLayout();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dgvTopStaffs;
		private System.Windows.Forms.Panel panelStaffChart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelTimeStaffFilter;
		private System.Windows.Forms.DataGridView dgvTopCustomers;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartCustomer;
		private System.Windows.Forms.Panel panelTimeCustomerFilter;
		private System.Windows.Forms.Panel panelStaffRatings;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panelCustomerRatings;
		private System.Windows.Forms.Panel panelCustomerChart;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStaff;
        private System.Windows.Forms.Panel panelProductFilter;
        private System.Windows.Forms.ComboBox cbCustTimeMonth;
        private System.Windows.Forms.ComboBox cbCustTimeYear;
        private System.Windows.Forms.ComboBox cbCustPeriod;
        private System.Windows.Forms.ComboBox cbMovieTimeMonth;
        private System.Windows.Forms.ComboBox cbMovieTimeYear;
        private System.Windows.Forms.ComboBox cbMoviePeriod;
        private System.Windows.Forms.ComboBox cbStaffTimeMonth;
        private System.Windows.Forms.ComboBox cbStaffTimeYear;
        private System.Windows.Forms.ComboBox cbStaffPeriod;
    }
}