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
			string sql = "SELECT MaKH, TenKH, Tuoi, Email, SDT FROM KHACHHANG";

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
    }
}
