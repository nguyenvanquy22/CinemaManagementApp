using CinemaManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CinemaManagementApp.Views.Admin.Form_Child_Admin.Form_Child_Statistic
{
    public partial class FrmTrend : Form
    {
        DataProcessor dtbase = new DataProcessor();
        public FrmTrend()
        {
            InitializeComponent();
        }

        private void FrmTrend_Load(object sender, EventArgs e)
        {
            fillComboboxes();
            cbMoviePeriod.SelectedIndex = 0;
            cbProdPeriod.SelectedIndex = 0;
        }

        private void fillComboboxes()
        {
            string sql = "";
            sql = @"
                    Select Min(YEAR(NgayXuatHD)) From HOADONBAN;
                ";
            DataTable minYearTable = dtbase.ReadData(sql);
            int minYear = int.Parse(minYearTable.Rows[0][0].ToString());
            for (int i = minYear; i <= DateTime.Now.Year; i++)
            {
                cbMovieTimeYear.Items.Add(i.ToString());
                cbProdTimeYear.Items.Add(i.ToString());
            }
            cbMovieTimeYear.SelectedIndex = 0;
            cbProdTimeYear.SelectedIndex = 0;

            for (int i = 1; i <= 12; i++)
            {
                cbMovieTimeMonth.Items.Add(i.ToString());
                cbProdTimeMonth.Items.Add(i.ToString());
            }
        }

        private void statisticMovie (string periodStatistic)
        {
            // Top Movies
            string sql = "";
            if (periodStatistic == "Năm")
            {
                 sql = @"
                    select TOP 5 ROW_NUMBER() OVER (ORDER BY sum(LICHCHIEU.GiaVe) DESC) AS STT,
                            Phim.TenPhim, sum(LICHCHIEU.GiaVe) as DoanhThu, Count(VE.MaVe) as SoVe
                    from PHIM 
	                    inner join LICHCHIEU on phim.MaPhim = LICHCHIEU.MaPhim
	                    inner join VE on LICHCHIEU.MaLC = VE.MaLC
                        inner join HOADONBAN on VE.MaVe = HOADONBAN.MaVe
                    where YEAR(HOADONBAN.NgayXuatHD) = '" + cbMovieTimeYear.SelectedItem + "'"
                    + " group by PHIM.TenPhim"
                    + " order by sum(LICHCHIEU.GiaVe) desc;";
            }
            if (periodStatistic == "Tháng")
            {
                sql = @"
                    select TOP 5 ROW_NUMBER() OVER (ORDER BY sum(LICHCHIEU.GiaVe) DESC) AS STT,
                            Phim.TenPhim, sum(LICHCHIEU.GiaVe) as DoanhThu, Count(VE.MaVe) as SoVe
                    from PHIM 
	                    inner join LICHCHIEU on phim.MaPhim = LICHCHIEU.MaPhim
	                    inner join VE on LICHCHIEU.MaLC = VE.MaLC
                        inner join HOADONBAN on VE.MaVe = HOADONBAN.MaVe
                     where YEAR(HOADONBAN.NgayXuatHD) = '" + cbMovieTimeYear.SelectedItem + "'" +
                            " and MONTH(HOADONBAN.NgayXuatHD) = '" + cbMovieTimeMonth.SelectedItem + "'"
                    + " group by PHIM.TenPhim"
                    + " order by sum(LICHCHIEU.GiaVe) desc;";
            }

            dgvTopMovies.DataSource = dtbase.ReadData(sql);
            dgvTopMovies.Columns[0].HeaderText = "STT";
            dgvTopMovies.Columns[1].HeaderText = "Tên phim";
            dgvTopMovies.Columns[2].HeaderText = "Doanh thu";
            dgvTopMovies.Columns[3].HeaderText = "Số vé";

            //ChartArea chartArea = chartMovies.ChartAreas[0];
            Series seriesMovies = chartMovies.Series["Movies"];
            seriesMovies.Points.Clear();
            for (int row = 0; row < dgvTopMovies.Rows.Count - 1; row++)
            {
                int stt = int.Parse(dgvTopMovies.Rows[row].Cells[0].Value.ToString());
                double doanhThu = double.Parse(dgvTopMovies.Rows[row].Cells[2].Value.ToString());

                seriesMovies.Points.AddXY(stt, doanhThu);
            }
        }
        private void statisticProduct (string periodStatistic)
        {
            // Top Products
            string sql = "";
            if (periodStatistic == "Năm")
            {
                sql = @"
                    select TOP 5 ROW_NUMBER() OVER (ORDER BY sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) DESC) AS STT, 
                            SANPHAMKHAC.TenSP,
                            sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) as DoanhThu, 
                            Sum(CTHDB.SoLuong) as TongSoLuong
                    from SANPHAMKHAC 
                        inner join CTHDB on SANPHAMKHAC.MaSP = CTHDB.MaSP
                        inner join HOADONBAN on CTHDB.MaHDB = HOADONBAN.MaHDB
                    where YEAR(HOADONBAN.NgayXuatHD) = '" + cbMovieTimeYear.SelectedItem + "'"
                    + " group by SANPHAMKHAC.TenSP"
                    + " order by sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) desc;";
            }
            if (periodStatistic == "Tháng")
            {
                sql = @"
                    select TOP 5 ROW_NUMBER() OVER (ORDER BY sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) DESC) AS STT, 
                            SANPHAMKHAC.TenSP,
                            sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) as DoanhThu, 
                            Sum(CTHDB.SoLuong) as TongSoLuong
                    from SANPHAMKHAC 
                        inner join CTHDB on SANPHAMKHAC.MaSP = CTHDB.MaSP
                        inner join HOADONBAN on CTHDB.MaHDB = HOADONBAN.MaHDB
                     where YEAR(HOADONBAN.NgayXuatHD) = '" + cbProdTimeYear.SelectedItem + "'" +
                            " and MONTH(HOADONBAN.NgayXuatHD) = '" + cbProdTimeMonth.SelectedItem + "'"
                     + " group by SANPHAMKHAC.TenSP"
                     + " order by sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) desc;";
            }

            dgvTopProducts.DataSource = dtbase.ReadData(sql);
            dgvTopProducts.Columns[0].HeaderText = "STT";
            dgvTopProducts.Columns[1].HeaderText = "Tên SP";
            dgvTopProducts.Columns[2].HeaderText = "Doanh thu";
            dgvTopProducts.Columns[3].HeaderText = "Số lượng";

            //ChartArea chartArea = chartMovies.ChartAreas[0];
            Series seriesProducts = chartProducts.Series["Products"];
            seriesProducts.Points.Clear();
            for (int row = 0; row < dgvTopProducts.Rows.Count - 1; row++)
            {
                int stt = int.Parse(dgvTopProducts.Rows[row].Cells[0].Value.ToString());
                double doanhThu = double.Parse(dgvTopProducts.Rows[row].Cells[2].Value.ToString());

                seriesProducts.Points.AddXY(stt, doanhThu);
            }
        }
        
        // period statistic movie
        private void cbMoviePeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMoviePeriod.Text == "Năm")
            {
                cbMovieTimeMonth.Enabled = false;
            }
            if (cbMoviePeriod.Text == "Tháng")
            {
                cbMovieTimeMonth.Enabled = true;
                cbMovieTimeMonth.SelectedIndex = 0;
            }
            statisticMovie(cbMoviePeriod.Text);
        }
        private void cbMovieTimeYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMoviePeriod.Text == "Năm")
            {
                statisticMovie("Năm");
            }
            if (cbMoviePeriod.Text == "Tháng")
            {
                statisticMovie("Tháng");
            }
        }
        private void cbMovieTimeMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            statisticMovie("Tháng");
        }

        // period statistic product
        private void cbProdPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProdPeriod.Text == "Năm")
            {
                cbProdTimeMonth.Enabled = false;
            }
            if (cbProdPeriod.Text == "Tháng")
            {
                cbProdTimeMonth.Enabled = true;
                cbProdTimeMonth.SelectedIndex = 0;
            }
            statisticProduct(cbProdPeriod.Text);
        }
        private void cbProdTimeYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProdPeriod.Text == "Năm")
            {
                statisticProduct("Năm");
            }
            if (cbProdPeriod.Text == "Tháng")
            {
                statisticProduct("Tháng");
            }
        }
        private void cbProdTimeMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            statisticProduct("Tháng");
        }
    }
}
