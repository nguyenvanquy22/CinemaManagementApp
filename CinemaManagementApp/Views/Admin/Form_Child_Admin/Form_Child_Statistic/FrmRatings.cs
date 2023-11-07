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
    public partial class FrmRatings : Form
    {
        DataProcessor dtbase = new DataProcessor();
        public FrmRatings()
        {
            InitializeComponent();
        }

        private void FrmRatings_Load(object sender, EventArgs e)
        {
            fillComboboxes();
            cbCustPeriod.SelectedIndex = 0;
            cbStaffPeriod.SelectedIndex = 0;
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
                cbCustTimeYear.Items.Add(i.ToString());
                cbStaffTimeYear.Items.Add(i.ToString());
            }
            cbCustTimeYear.SelectedIndex = 0;
            cbStaffTimeYear.SelectedIndex = 0;

            for (int i = 1; i <= 12; i++)
            {
                cbCustTimeMonth.Items.Add(i.ToString());
                cbStaffTimeMonth.Items.Add(i.ToString());
            }
        }

        private void statisticCustomer(string periodStatistic)
        {
            // Top Customers
            string sql = "";
            if (periodStatistic == "Năm")
            {
                sql = @"
                    select TOP 5 ROW_NUMBER() OVER (ORDER BY sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) DESC) AS STT,
                            KHACHHANG.TenKH, KHACHHANG.SDT, sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) as TongChiSP, sum(LICHCHIEU.GiaVe) as TongChiVe,
                            sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) as TongChi
                    from KHACHHANG 
                        inner join HOADONBAN on KHACHHANG.MaKH = HOADONBAN.MaKH
                        inner join CTHDB on HOADONBAN.MaHDB = CTHDB.MaHDB
                        inner join VE on HOADONBAN.MaHDB = VE.MaHDB
                        inner join LICHCHIEU on VE.MaLC = LICHCHIEU.MaLC
                    where YEAR(HOADONBAN.NgayXuatHD) = '" + cbCustTimeYear.SelectedItem + "'"
                        + " group by KHACHHANG.TenKH, KHACHHANG.SDT"
                        + " order by sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) DESC;";
            }
            if (periodStatistic == "Tháng")
            {
                sql = @"
                    select TOP 5 ROW_NUMBER() OVER (ORDER BY sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) DESC) AS STT,
                            KHACHHANG.TenKH, KHACHHANG.SDT, sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) as TongChiSP, sum(LICHCHIEU.GiaVe) as TongChiVe,
                            sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) as TongChi
                    from KHACHHANG 
                        inner join HOADONBAN on KHACHHANG.MaKH = HOADONBAN.MaKH
                        inner join CTHDB on HOADONBAN.MaHDB = CTHDB.MaHDB
                        inner join VE on HOADONBAN.MaHDB = VE.MaHDB
                        inner join LICHCHIEU on VE.MaLC = LICHCHIEU.MaLC
                    where YEAR(HOADONBAN.NgayXuatHD) = '" + cbCustTimeYear.SelectedItem + "'" +
                            " and MONTH(HOADONBAN.NgayXuatHD) = '" + cbCustTimeMonth.SelectedItem + "'"
                     + " group by KHACHHANG.TenKH, KHACHHANG.SDT"
                     + " order by sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) DESC;";
            }

            dgvTopCustomers.DataSource = dtbase.ReadData(sql);
            dgvTopCustomers.Columns[0].HeaderText = "STT";
            dgvTopCustomers.Columns[1].HeaderText = "Tên KH";
            dgvTopCustomers.Columns[2].HeaderText = "SDT";
            dgvTopCustomers.Columns[5].HeaderText = "Chi tiêu";
            dgvTopCustomers.Columns[3].Visible = false;
            dgvTopCustomers.Columns[4].Visible = false;
            dgvTopCustomers.Columns[0].Width = 50;
            dgvTopCustomers.Columns[1].Width = 150;

            //ChartArea chartArea = chartCustomer.ChartAreas[0];
            Series seriesCust = chartCustomer.Series["Top1Cust"];
            seriesCust.Points.Clear();
            double tongChiSP = double.Parse(dgvTopCustomers.Rows[0].Cells[3].Value.ToString());
            double tongChiVe = double.Parse(dgvTopCustomers.Rows[0].Cells[4].Value.ToString());
            double tongChi = double.Parse(dgvTopCustomers.Rows[0].Cells[5].Value.ToString());

            seriesCust.Points.AddXY("Vé", tongChiVe / tongChi);
            seriesCust.Points.AddXY("Sản phẩm", tongChiSP / tongChi);
        }

        private void statisticStaff(string periodStatistic)
        {
            // Top Staffs
            string sql = "";
            if (periodStatistic == "Năm")
            {
                sql = @"
                    select TOP 5 ROW_NUMBER() OVER (ORDER BY sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) DESC) AS STT,
		                NHANVIEN.MaNV, NHANVIEN.TenNV, sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) as TongThu
                from NHANVIEN 
	                inner join HOADONBAN on NHANVIEN.MaNV = HOADONBAN.MaNV
	                inner join CTHDB on HOADONBAN.MaHDB = CTHDB.MaHDB
	                inner join VE on HOADONBAN.MaHDB = VE.MaHDB
                    inner join LICHCHIEU on VE.MaLC = LICHCHIEU.MaLC
                    where YEAR(HOADONBAN.NgayXuatHD) = '" + cbStaffTimeYear.SelectedItem + "'"
                        + " group by NHANVIEN.MaNV, NHANVIEN.TenNV"
                        + " order by sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) DESC;";
            }
            if (periodStatistic == "Tháng")
            {
                sql = @"
                    select TOP 5 ROW_NUMBER() OVER (ORDER BY sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) DESC) AS STT,
		                NHANVIEN.MaNV, NHANVIEN.TenNV, sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) as TongThu
                from NHANVIEN 
	                inner join HOADONBAN on NHANVIEN.MaNV = HOADONBAN.MaNV
	                inner join CTHDB on HOADONBAN.MaHDB = CTHDB.MaHDB
	                inner join VE on HOADONBAN.MaHDB = VE.MaHDB
                    inner join LICHCHIEU on VE.MaLC = LICHCHIEU.MaLC
                    where YEAR(HOADONBAN.NgayXuatHD) = '" + cbStaffTimeYear.SelectedItem + "'" +
                            " and MONTH(HOADONBAN.NgayXuatHD) = '" + cbStaffTimeMonth.SelectedItem + "'"
                     + " group by NHANVIEN.MaNV, NHANVIEN.TenNV"
                     + " order by sum(CTHDB.DonGia*CTHDB.SoLuong*(1-CTHDB.GiamGia/100)) + sum(LICHCHIEU.GiaVe) DESC;";
            }

            dgvTopStaffs.DataSource = dtbase.ReadData(sql);
            dgvTopStaffs.Columns[0].HeaderText = "STT";
            dgvTopStaffs.Columns[1].HeaderText = "Mã NV";
            dgvTopStaffs.Columns[2].HeaderText = "Tên NV";
            dgvTopStaffs.Columns[3].HeaderText = "Doanh số";
            dgvTopStaffs.Columns[0].Width = 50;
            dgvTopStaffs.Columns[2].Width = 150;

            //ChartArea chartArea = chartCustomer.ChartAreas[0];
            Series seriesStaff = chartStaff.Series["TopStaff"];
            seriesStaff.Points.Clear();
            for (int row = 0; row < dgvTopStaffs.Rows.Count - 1; row++)
            {
                string maNv = dgvTopStaffs.Rows[row].Cells[1].Value.ToString();
                double doanhThu = double.Parse(dgvTopStaffs.Rows[row].Cells[3].Value.ToString());

                seriesStaff.Points.AddXY(maNv, doanhThu);
            }
        }

        // cust
        private void cbCustPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustPeriod.Text == "Năm")
            {
                cbCustTimeMonth.Enabled = false;
            }
            if (cbCustPeriod.Text == "Tháng")
            {
                cbCustTimeMonth.Enabled = true;
                cbCustTimeMonth.SelectedIndex = 0;
            }
            statisticCustomer(cbCustPeriod.Text);
        }
        private void cbCustTimeYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCustPeriod.Text == "Năm")
            {
                statisticCustomer("Năm");
            }
            if (cbCustPeriod.Text == "Tháng")
            {
                statisticCustomer("Tháng");
            }
        }
        private void cbCustTimeMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            statisticCustomer("Tháng");
        }

        // staff
        private void cbStaffPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStaffPeriod.Text == "Năm")
            {
                cbStaffTimeMonth.Enabled = false;
            }
            if (cbStaffPeriod.Text == "Tháng")
            {
                cbStaffTimeMonth.Enabled = true;
                cbStaffTimeMonth.SelectedIndex = 0;
            }
            statisticStaff(cbStaffPeriod.Text);
        }
        private void cbStaffTimeYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStaffPeriod.Text == "Năm")
            {
                statisticStaff("Năm");
            }
            if (cbStaffPeriod.Text == "Tháng")
            {
                statisticStaff("Tháng");
            }
        }
        private void cbStaffTimeMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            statisticStaff("Tháng");
        }

        private void dgvTopCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.Value != null)
                {
                    if (double.TryParse(e.Value.ToString(), out double result))
                    {
                        // Định dạng giá trị với hai chữ số sau dấu phẩy
                        e.Value = result.ToString("N2");
                        e.FormattingApplied = true;
                    }

                }
            }
        }

        private void dgvTopStaffs_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (e.Value != null)
                {
                    if (double.TryParse(e.Value.ToString(), out double result))
                    {
                        // Định dạng giá trị với hai chữ số sau dấu phẩy
                        e.Value = result.ToString("N2");
                        e.FormattingApplied = true;
                    }

                }
            }
        }
    }
}
