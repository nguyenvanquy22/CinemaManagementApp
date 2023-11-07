using CinemaManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using System.Xml.Linq;

namespace CinemaManagementApp.Views.Admin.Form_Child_Admin.Form_Modal
{
	public partial class FrmModalModifyStaff : Form
	{
		public event EventHandler<string> DataUpdated;
        Functions ft = new Functions();
        private DataRow infoNhanvien;
		private string btnClick;
		public FrmModalModifyStaff(DataTable dt, string btnClick)
		{
			InitializeComponent();
			this.btnClick = btnClick;
			if (btnClick.Equals("btnUpdate")) infoNhanvien = dt.Rows[0];
		}
		public FrmModalModifyStaff(string btnClick)
		{
			InitializeComponent();
			this.btnClick = btnClick;
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmModalModifyStaff_Load(object sender, EventArgs e)
		{
			if (btnClick.Equals("btnUpdate"))
			{
				txtMaNV.Text = infoNhanvien["MaNV"].ToString();
				txtTenNV.Text = infoNhanvien["TenNV"].ToString();
				dtpNgayVaoLam.Value = (DateTime)infoNhanvien["NgayVaoLam"];
				dtpNgaySinh.Value = (DateTime)infoNhanvien["NgaySinh"];
				txtEmail.Text = infoNhanvien["Email"].ToString();
				txtSDT.Text = infoNhanvien["SDT"].ToString();
				txtLuong.Text = infoNhanvien["Luong"].ToString();
				txtMaRap.Text = infoNhanvien["MaRap"].ToString();
				txtUsername.Text = infoNhanvien["TenDangNhap"].ToString();
				txtPassword.Text = infoNhanvien["MatKhau"].ToString();
				cbGioiTinh.SelectedItem = infoNhanvien["GioiTinh"].ToString();
				cbChucVu.SelectedItem = infoNhanvien["ChucVu"].ToString();
			}
			else
			{
				txtMaNV.Text = ft.SinhMaTuDong("NHANVIEN", "MaNV", "NV0");
                lblTitle.Text = "Thêm nhân viên";
			}	
		}

		private void btnLuu_Click(object sender, EventArgs e)
		{
			string sql = "";
			if (btnClick.Equals("btnUpdate"))
			{
				sql = "Update NHANVIEN SET ";
				sql += "TenNV = N'" + txtTenNV.Text + "',";
				sql += "NgayVaoLam = '" + dtpNgayVaoLam.Value.Date.ToString("yyyy-MM-dd") + "',";
				sql += "NgaySinh = '" + dtpNgaySinh.Value.Date.ToString("yyyy-MM-dd") + "',";
				sql += "SDT = '" + txtSDT.Text + "',";
				sql += "Email = '" + txtEmail.Text + "',";
				sql += "Luong = '" + txtLuong.Text + "',";
				sql += "MaRap = '" + txtMaRap.Text + "',";
				sql += "TenDangNhap = '" + txtUsername.Text + "',";
				sql += "MatKhau = '" + txtPassword.Text + "',";
				sql += "GioiTinh = N'" + cbGioiTinh.SelectedItem.ToString() + "',";
				sql += "ChucVu = N'" + cbChucVu.SelectedItem.ToString() + "' ";
				sql += "Where MaNV = '" + txtMaNV.Text + "'";
			}
			else
			{
				sql = "INSERT INTO NHANVIEN(MaNV, TenNV, NgayVaoLam, NgaySinh, SDT," +
					" Email, Luong, MaRap, TenDangNhap, MatKhau, GioiTinh, ChucVu) VALUES(";
				sql += "'" + txtMaNV.Text + "',N'" + txtTenNV.Text + "','"
					+ dtpNgayVaoLam.Value.Date.ToString("yyyy-MM-dd") + "','" + dtpNgaySinh.Value.Date.ToString("yyyy-MM-dd") + "','"
					+ txtSDT.Text + "','" + txtEmail.Text + "','" + txtLuong.Text + "','"
					+ txtMaRap.Text + "','" + txtUsername.Text + "','" + txtPassword.Text + "',N'"
					+ cbGioiTinh.SelectedItem.ToString() + "',N'" + cbChucVu.SelectedItem.ToString() + "')";
			}

			DataUpdated?.Invoke(this, sql);

			this.Close();
		}

    }
}
