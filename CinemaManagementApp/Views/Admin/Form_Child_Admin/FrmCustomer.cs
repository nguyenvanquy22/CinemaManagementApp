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

namespace CinemaManagementApp.Views.Admin.Form_Child
{
    public partial class FrmCustomer : Form
    {
		DataProcessor dtbase = new DataProcessor();
		public FrmCustomer()
        {
            InitializeComponent();
        }
		private void FrmCustomer_Load(object sender, EventArgs e)
		{
            fillComboboxes();
            cbPeriod.SelectedIndex = 0;
        }
        private void fillComboboxes()
        {
            string sql = "";
            sql = @"
                    Select Min(YEAR(NgayXuatHD)) From HOADONBAN;
                ";
            DataTable minYearTable = dtbase.ReadData(sql);
            int minYear = int.Parse(minYearTable.Rows[0][0].ToString());
            int countYearItems = -1;
            for (int i = minYear; i <= DateTime.Now.Year; i++)
            {
                cbTimeYear.Items.Add(i.ToString());
                countYearItems++;
            }
            cbTimeYear.SelectedIndex = countYearItems;

            for (int i = 1; i <= 12; i++)
            {
                cbTimeMonth.Items.Add(i.ToString());
            }
            //cbTimeMonth.SelectedIndex = 0;
        }

        private void GetData(string periodStatistic)
        {
            string sql = @"SELECT KHACHHANG.MaKH, TenKH, Tuoi, Email, SDT FROM KHACHHANG
                            inner join HOADONBAN on HOADONBAN.MaKH = KHACHHANG.MaKH";
                sql += " where YEAR(HOADONBAN.NgayXuatHD) = '" + cbTimeYear.SelectedItem + "'";
            if(periodStatistic == "Tháng")
            {
                sql += " and MONTH(HOADONBAN.NgayXuatHD) = '" + cbTimeMonth.SelectedItem + "'";
            }

            dgvListCustomer.DataSource = dtbase.ReadData(sql);
            dgvListCustomer.Columns[0].HeaderText = "Mã KH";
            dgvListCustomer.Columns[1].HeaderText = "Tên KH";
            dgvListCustomer.Columns[2].HeaderText = "Tuổi";
            dgvListCustomer.Columns[3].HeaderText = "Email";
            dgvListCustomer.Columns[4].HeaderText = "SDT";
            dgvListCustomer.Columns[0].Width = 120;
            dgvListCustomer.Columns[2].Width = 120;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT MaKH, TenKH, Tuoi, Email, SDT FROM KHACHHANG
					WHERE TenKH is not null";

            if (txtSearch.Text.Trim() != "")
            {
                sql += " and TenKH like '%" + txtSearch.Text + "%'";
                MessageBox.Show(sql);
            }

            dgvListCustomer.DataSource = dtbase.ReadData(sql);
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

            GetData(cbPeriod.Text);
        }

        private void cbTimeYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPeriod.Text == "Năm")
            {
                GetData("Năm");
            }
            if (cbPeriod.Text == "Tháng")
            {
                GetData("Tháng");
            }
        }

        private void cbTimeMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData("Tháng");
        }
    }
}
