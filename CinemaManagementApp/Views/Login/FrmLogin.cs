using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagementApp.Views.Login
{
    public partial class FrmLogin : Form
    {
		string[] imageFiles = Directory.GetFiles("..\\Debug\\Images\\MoviePhotos", "*.jpg"
				, SearchOption.AllDirectories);
		Timer timer = new Timer();
		int count = 0;
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
	}
}
