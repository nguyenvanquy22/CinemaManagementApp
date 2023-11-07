using CinemaManagementApp.Views.Admin;
using CinemaManagementApp.Views.Staff;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagementApp.Views.Login
{
    public partial class FrmLogin : Form
    {
		//private Form currentForm;

		string[] imageFiles = Directory.GetFiles("..\\Debug\\Images\\MoviePhotos", "*.jpg"
				, SearchOption.AllDirectories);
		Timer timer = new Timer();
		int count = 0;

		public static string userName;
		public static string staffID;
		Classes.DataProcessor db = new Classes.DataProcessor();
		public FrmLogin()
        {
            InitializeComponent();
        }

		private void FrmLogin_Load(object sender, EventArgs e)
		{
			// Thiết lập khoảng thời gian là 1000ms (tức 1s)
			timer.Interval = 2000;
			// Bắt đầu chạy Timer
			timer.Start();
			// Đăng ký sự kiện Tick
			timer.Tick += Timer_Tick;
			//ptBMovie.ImageLocation = "D:\\NguyenTienDat\\CinemaManagementApp\\CinemaManagementApp\\bin\\Debug\\Images\\MoviePhotos\\GodzillaVsKong.jpg";
 		}

		private void lblForgotPassword_MouseEnter_1(object sender, EventArgs e)
		{
			lblForgotPassword.ForeColor = System.Drawing.Color.Red;
		}

		private void lblForgotPassword_MouseLeave(object sender, EventArgs e)
		{
			lblForgotPassword.ForeColor = System.Drawing.Color.Blue;
		}

		private void icPUsername_Click(object sender, EventArgs e)
		{
			txtUsername.Focus();
		}

		private void IcPassword_Click(object sender, EventArgs e)
		{
			txtPassword.Focus();
		}

		public void SlideMoviePhoto(int i)
		{
			ptBMovie.ImageLocation = imageFiles[i];
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			if (count + 1 > imageFiles.Length) count = 0;
			SlideMoviePhoto(count++);
		}

		private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			timer.Stop();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			// Tải khoản không bỏ trống
			if (txtUsername.Text.Trim().Equals(""))
			{
				MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo!", MessageBoxButtons.OK);
			}
			else
			{
				// Mật khẩu không bỏ trống
				if (txtPassword.Text.Trim().Equals(""))
				{
					MessageBox.Show("Vui lòng nhập mật khẩu,", "Thông báo!", MessageBoxButtons.OK);
				}
				else
				{
					string password = "";
					// Nhân viên có chức vụ = 1; Quản lý có chức vụ = 2
					string chucvu = "";
					string sql = "select MaNV, MatKhau, ChucVu from NHANVIEN where TenDangNhap = '" + txtUsername.Text.Trim() + "'";
					DataTable dataTable = db.ReadData(sql);
					if (dataTable.Rows.Count > 0)
					{
						password = dataTable.Rows[0]["MatKhau"].ToString();
						chucvu = dataTable.Rows[0]["chucvu"].ToString();
					}
					//Console.WriteLine(password);
					//Console.WriteLine(chucvu);
					if (txtPassword.Text.Trim().Equals(password))
					{
                        // Form nhân viên
                        staffID = dataTable.Rows[0]["MaNV"].ToString();
                        if (chucvu.Equals("Nhân viên"))
						{
							OpenNextForm(new FrmStaff());
						}
						// Form admin
						else 
						{ 
							OpenNextForm(new FrmAdmin()); 
						}
					}
					else
					{
						MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác. "
						+ "Vui lòng nhập lại!", "Lỗi!", MessageBoxButtons.OK);
					}
				}
			}
		}

		// Mở Form khi đăng nhập thành công
		private void OpenNextForm(Form nextForm)
		{
			userName = txtUsername.Text;
			nextForm.Show();
			this.Hide();
		}
	}
}
