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
    public partial class FrmIOcomeTotal : Form
    {
        DataProcessor dtbase = new DataProcessor();
        string sql = "";

        public FrmIOcomeTotal()
        {
            InitializeComponent();
        }

        private void FrmIOcomeTotal_Load(object sender, EventArgs e)
        {
            fillComboboxes();
            cbPeriod.SelectedIndex = 0;
        }

        private void fillComboboxes ()
        {
            string sql = "";
            sql = @"
                    Select Min(YEAR(NgayXuatHD)) From HOADONBAN;
                ";
            DataTable minYearTable = dtbase.ReadData(sql);
            int minYear = int.Parse(minYearTable.Rows[0][0].ToString());
            for (int i = minYear; i <= DateTime.Now.Year; i++)
            {
                cbTimeYear.Items.Add(i.ToString());
            }
            cbTimeYear.SelectedIndex = 0;

            for (int i = 1; i <= 12; i++)
            {
                cbTimeMonth.Items.Add(i.ToString());
            }
            //cbTimeMonth.SelectedIndex = 0;
        }

        private void drawChart(string periodStatistic)
        {
            if (periodStatistic == "Năm")
            {
                sql = @"
                    SELECT MONTH(HOADONBAN.NgayXuatHD) as Thang,
                            sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) as TongThuSP, sum(LICHCHIEU.GiaVe) as TongThuVe,
		                    sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) as TongThu
                    from HOADONBAN 
	                    inner join CTHDB on HOADONBAN.MaHDB = CTHDB.MaHDB
	                    inner join VE on HOADONBAN.MaHDB = VE.MaHDB
                        inner join LICHCHIEU on VE.MaLC = LICHCHIEU.MaLC
                    where YEAR(HOADONBAN.NgayXuatHD) = '" + cbTimeYear.SelectedItem + "'"
                    + "GROUP BY MONTH(HOADONBAN.NgayXuatHD)"
                    + "ORDER BY MONTH(HOADONBAN.NgayXuatHD);";
            }
            if (periodStatistic == "Tháng")
            {
                sql = @"
                    SELECT Day(HOADONBAN.NgayXuatHD) as Ngay, 
                            sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) as TongThuSP, sum(LICHCHIEU.GiaVe) as TongThuVe,
		                    sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) as TongThu
                    from HOADONBAN 
	                    inner join CTHDB on HOADONBAN.MaHDB = CTHDB.MaHDB
	                    inner join VE on HOADONBAN.MaHDB = VE.MaHDB
                        inner join LICHCHIEU on VE.MaLC = LICHCHIEU.MaLC
                    where YEAR(HOADONBAN.NgayXuatHD) = '" + cbTimeYear.SelectedItem + "'" +
                            " and MONTH(HOADONBAN.NgayXuatHD) = '" + cbTimeMonth.SelectedItem + "'"
                    + " GROUP BY HOADONBAN.NgayXuatHD"
                    + " ORDER BY HOADONBAN.NgayXuatHD;";
            }

            DataTable doanhThuTable = dtbase.ReadData(sql);
            double totalProd = 0;
            double totalTicket = 0;
            double totalIncome = 0;

            Series seriesIOCome = chartIOCome.Series["IOCome"];
            seriesIOCome.Points.Clear();
            for (int row = 0; row < doanhThuTable.Rows.Count; row++)
            {
                int time = int.Parse(doanhThuTable.Rows[row][0].ToString());
                double doanhThu = double.Parse(doanhThuTable.Rows[row][3].ToString());
                totalProd += double.Parse(doanhThuTable.Rows[row][1].ToString());
                totalTicket += double.Parse(doanhThuTable.Rows[row][2].ToString());
                totalIncome += doanhThu;

                seriesIOCome.Points.AddXY(time, doanhThu);
            }

            lblIncomeTotalValue.Text = Math.Round(totalIncome,2).ToString() + "K VND";
            lblTotalProd.Text = Math.Round(totalProd,2).ToString() + "K VND";
            lblTotalTicket.Text = Math.Round(totalTicket,2).ToString() + "K VND";
            lblPercentProd.Text = (Math.Round(totalProd * 100 / totalIncome, 2)).ToString() + "%";
            lblPercentTicket.Text = (Math.Round(totalTicket * 100 / totalIncome,2)).ToString() + "%";

            //DataTable tongChiSP = dtbase.ReadData("Select ");
            //lblOutcomeTotalValue.Text = 
        }

        private void cbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeriod.Text == "Năm")
            {
                cbTimeMonth.Enabled = false;
            }
            if (cbPeriod.Text == "Tháng")
            {
                cbTimeMonth.Enabled = true;
                cbTimeMonth.SelectedIndex = 0;
            }

            drawChart(cbPeriod.Text);
        }

        private void cbTimeYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeriod.Text == "Năm")
            {
                drawChart("Năm");
            }
            if (cbPeriod.Text == "Tháng")
            {
                drawChart("Tháng");
            }
        }

        private void cbTimeMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawChart("Tháng");
        }
    }
}
