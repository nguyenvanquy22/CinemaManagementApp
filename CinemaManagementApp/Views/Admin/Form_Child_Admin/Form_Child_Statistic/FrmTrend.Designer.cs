namespace CinemaManagementApp.Views.Admin.Form_Child_Admin.Form_Child_Statistic
{
    partial class FrmTrend
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelMoviesRatings = new System.Windows.Forms.Panel();
            this.panelMovieChart = new System.Windows.Forms.Panel();
            this.dgvTopMovies = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.chartMovies = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelMovieFilter = new System.Windows.Forms.Panel();
            this.cbMovieTimeMonth = new System.Windows.Forms.ComboBox();
            this.cbMovieTimeYear = new System.Windows.Forms.ComboBox();
            this.cbMoviePeriod = new System.Windows.Forms.ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelProductsRatings = new System.Windows.Forms.Panel();
            this.panelProductChart = new System.Windows.Forms.Panel();
            this.dgvTopProducts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chartProducts = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelProductFilter = new System.Windows.Forms.Panel();
            this.cbProdTimeMonth = new System.Windows.Forms.ComboBox();
            this.cbProdTimeYear = new System.Windows.Forms.ComboBox();
            this.cbProdPeriod = new System.Windows.Forms.ComboBox();
            this.panelMoviesRatings.SuspendLayout();
            this.panelMovieChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovies)).BeginInit();
            this.panelMovieFilter.SuspendLayout();
            this.panelProductsRatings.SuspendLayout();
            this.panelProductChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).BeginInit();
            this.panelProductFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMoviesRatings
            // 
            this.panelMoviesRatings.Controls.Add(this.panelMovieChart);
            this.panelMoviesRatings.Controls.Add(this.panelMovieFilter);
            this.panelMoviesRatings.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMoviesRatings.Location = new System.Drawing.Point(0, 0);
            this.panelMoviesRatings.Name = "panelMoviesRatings";
            this.panelMoviesRatings.Size = new System.Drawing.Size(489, 586);
            this.panelMoviesRatings.TabIndex = 0;
            // 
            // panelMovieChart
            // 
            this.panelMovieChart.Controls.Add(this.dgvTopMovies);
            this.panelMovieChart.Controls.Add(this.label2);
            this.panelMovieChart.Controls.Add(this.chartMovies);
            this.panelMovieChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMovieChart.Location = new System.Drawing.Point(0, 64);
            this.panelMovieChart.Name = "panelMovieChart";
            this.panelMovieChart.Size = new System.Drawing.Size(489, 522);
            this.panelMovieChart.TabIndex = 3;
            // 
            // dgvTopMovies
            // 
            this.dgvTopMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopMovies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopMovies.Location = new System.Drawing.Point(0, 258);
            this.dgvTopMovies.Name = "dgvTopMovies";
            this.dgvTopMovies.RowHeadersWidth = 51;
            this.dgvTopMovies.RowTemplate.Height = 24;
            this.dgvTopMovies.Size = new System.Drawing.Size(489, 264);
            this.dgvTopMovies.TabIndex = 4;
            this.dgvTopMovies.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTopMovies_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 215);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.label2.Size = new System.Drawing.Size(379, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top 5 phim doanh thu cao nhất";
            // 
            // chartMovies
            // 
            chartArea7.Name = "ChartArea1";
            this.chartMovies.ChartAreas.Add(chartArea7);
            this.chartMovies.Dock = System.Windows.Forms.DockStyle.Top;
            legend7.Name = "Legend1";
            this.chartMovies.Legends.Add(legend7);
            this.chartMovies.Location = new System.Drawing.Point(0, 0);
            this.chartMovies.Name = "chartMovies";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Movies";
            this.chartMovies.Series.Add(series7);
            this.chartMovies.Size = new System.Drawing.Size(489, 215);
            this.chartMovies.TabIndex = 2;
            this.chartMovies.Text = "chart2";
            // 
            // panelMovieFilter
            // 
            this.panelMovieFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMovieFilter.Controls.Add(this.cbMovieTimeMonth);
            this.panelMovieFilter.Controls.Add(this.cbMovieTimeYear);
            this.panelMovieFilter.Controls.Add(this.cbMoviePeriod);
            this.panelMovieFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMovieFilter.Location = new System.Drawing.Point(0, 0);
            this.panelMovieFilter.Name = "panelMovieFilter";
            this.panelMovieFilter.Size = new System.Drawing.Size(489, 64);
            this.panelMovieFilter.TabIndex = 1;
            // 
            // cbMovieTimeMonth
            // 
            this.cbMovieTimeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMovieTimeMonth.FormattingEnabled = true;
            this.cbMovieTimeMonth.Location = new System.Drawing.Point(265, 19);
            this.cbMovieTimeMonth.Name = "cbMovieTimeMonth";
            this.cbMovieTimeMonth.Size = new System.Drawing.Size(80, 28);
            this.cbMovieTimeMonth.TabIndex = 11;
            this.cbMovieTimeMonth.SelectedIndexChanged += new System.EventHandler(this.cbMovieTimeMonth_SelectedIndexChanged);
            // 
            // cbMovieTimeYear
            // 
            this.cbMovieTimeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMovieTimeYear.FormattingEnabled = true;
            this.cbMovieTimeYear.Location = new System.Drawing.Point(162, 19);
            this.cbMovieTimeYear.Name = "cbMovieTimeYear";
            this.cbMovieTimeYear.Size = new System.Drawing.Size(80, 28);
            this.cbMovieTimeYear.TabIndex = 10;
            this.cbMovieTimeYear.SelectedIndexChanged += new System.EventHandler(this.cbMovieTimeYear_SelectedIndexChanged);
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
            this.cbMoviePeriod.TabIndex = 9;
            this.cbMoviePeriod.SelectedIndexChanged += new System.EventHandler(this.cbMoviePeriod_SelectedIndexChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(489, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 586);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panelProductsRatings
            // 
            this.panelProductsRatings.Controls.Add(this.panelProductChart);
            this.panelProductsRatings.Controls.Add(this.panelProductFilter);
            this.panelProductsRatings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductsRatings.Location = new System.Drawing.Point(499, 0);
            this.panelProductsRatings.Name = "panelProductsRatings";
            this.panelProductsRatings.Size = new System.Drawing.Size(480, 586);
            this.panelProductsRatings.TabIndex = 3;
            // 
            // panelProductChart
            // 
            this.panelProductChart.Controls.Add(this.dgvTopProducts);
            this.panelProductChart.Controls.Add(this.label1);
            this.panelProductChart.Controls.Add(this.chartProducts);
            this.panelProductChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProductChart.Location = new System.Drawing.Point(0, 64);
            this.panelProductChart.Name = "panelProductChart";
            this.panelProductChart.Size = new System.Drawing.Size(480, 522);
            this.panelProductChart.TabIndex = 3;
            // 
            // dgvTopProducts
            // 
            this.dgvTopProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTopProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTopProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTopProducts.Location = new System.Drawing.Point(0, 261);
            this.dgvTopProducts.Name = "dgvTopProducts";
            this.dgvTopProducts.RowHeadersWidth = 51;
            this.dgvTopProducts.RowTemplate.Height = 24;
            this.dgvTopProducts.Size = new System.Drawing.Size(480, 261);
            this.dgvTopProducts.TabIndex = 4;
            this.dgvTopProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvTopProducts_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 218);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 10, 4, 4);
            this.label1.Size = new System.Drawing.Size(434, 43);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top 5 sản phẩm doanh thu cao nhất";
            // 
            // chartProducts
            // 
            chartArea8.Name = "ChartArea1";
            this.chartProducts.ChartAreas.Add(chartArea8);
            this.chartProducts.Dock = System.Windows.Forms.DockStyle.Top;
            legend8.Name = "Legend1";
            this.chartProducts.Legends.Add(legend8);
            this.chartProducts.Location = new System.Drawing.Point(0, 0);
            this.chartProducts.Name = "chartProducts";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Products";
            this.chartProducts.Series.Add(series8);
            this.chartProducts.Size = new System.Drawing.Size(480, 218);
            this.chartProducts.TabIndex = 2;
            this.chartProducts.Text = "chart1";
            // 
            // panelProductFilter
            // 
            this.panelProductFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelProductFilter.Controls.Add(this.cbProdTimeMonth);
            this.panelProductFilter.Controls.Add(this.cbProdTimeYear);
            this.panelProductFilter.Controls.Add(this.cbProdPeriod);
            this.panelProductFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProductFilter.Location = new System.Drawing.Point(0, 0);
            this.panelProductFilter.Name = "panelProductFilter";
            this.panelProductFilter.Size = new System.Drawing.Size(480, 64);
            this.panelProductFilter.TabIndex = 2;
            // 
            // cbProdTimeMonth
            // 
            this.cbProdTimeMonth.Enabled = false;
            this.cbProdTimeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdTimeMonth.FormattingEnabled = true;
            this.cbProdTimeMonth.Location = new System.Drawing.Point(265, 19);
            this.cbProdTimeMonth.Name = "cbProdTimeMonth";
            this.cbProdTimeMonth.Size = new System.Drawing.Size(80, 28);
            this.cbProdTimeMonth.TabIndex = 11;
            this.cbProdTimeMonth.SelectedIndexChanged += new System.EventHandler(this.cbProdTimeMonth_SelectedIndexChanged);
            // 
            // cbProdTimeYear
            // 
            this.cbProdTimeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdTimeYear.FormattingEnabled = true;
            this.cbProdTimeYear.Location = new System.Drawing.Point(162, 19);
            this.cbProdTimeYear.Name = "cbProdTimeYear";
            this.cbProdTimeYear.Size = new System.Drawing.Size(80, 28);
            this.cbProdTimeYear.TabIndex = 10;
            this.cbProdTimeYear.SelectedIndexChanged += new System.EventHandler(this.cbProdTimeYear_SelectedIndexChanged);
            // 
            // cbProdPeriod
            // 
            this.cbProdPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbProdPeriod.FormattingEnabled = true;
            this.cbProdPeriod.Items.AddRange(new object[] {
            "Năm",
            "Tháng"});
            this.cbProdPeriod.Location = new System.Drawing.Point(23, 19);
            this.cbProdPeriod.Name = "cbProdPeriod";
            this.cbProdPeriod.Size = new System.Drawing.Size(114, 28);
            this.cbProdPeriod.TabIndex = 9;
            this.cbProdPeriod.SelectedIndexChanged += new System.EventHandler(this.cbProdPeriod_SelectedIndexChanged);
            // 
            // FrmTrend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 586);
            this.Controls.Add(this.panelProductsRatings);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelMoviesRatings);
            this.Name = "FrmTrend";
            this.Text = "Xu hướng";
            this.Load += new System.EventHandler(this.FrmTrend_Load);
            this.panelMoviesRatings.ResumeLayout(false);
            this.panelMovieChart.ResumeLayout(false);
            this.panelMovieChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMovies)).EndInit();
            this.panelMovieFilter.ResumeLayout(false);
            this.panelProductsRatings.ResumeLayout(false);
            this.panelProductChart.ResumeLayout(false);
            this.panelProductChart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartProducts)).EndInit();
            this.panelProductFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panelMoviesRatings;
		private System.Windows.Forms.Panel panelMovieFilter;
		private System.Windows.Forms.Panel panelMovieChart;
		private System.Windows.Forms.DataGridView dgvTopMovies;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartMovies;
        private System.Windows.Forms.ComboBox cbMovieTimeMonth;
        private System.Windows.Forms.ComboBox cbMovieTimeYear;
        private System.Windows.Forms.ComboBox cbMoviePeriod;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelProductsRatings;
        private System.Windows.Forms.Panel panelProductChart;
        private System.Windows.Forms.DataGridView dgvTopProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProducts;
        private System.Windows.Forms.Panel panelProductFilter;
        private System.Windows.Forms.ComboBox cbProdTimeMonth;
        private System.Windows.Forms.ComboBox cbProdTimeYear;
        private System.Windows.Forms.ComboBox cbProdPeriod;
    }
}