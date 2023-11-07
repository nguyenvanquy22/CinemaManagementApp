using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;
using System.Reflection;
using CinemaManagementApp.Classes;
using System.Windows;
using System.Text.RegularExpressions;
using System.IO;

namespace CinemaManagementApp.Views.Staff.ChildForm
{
    public partial class FrmFilmDetails : Form
    {
        private string showtime;
        private string filmID;
        DataProcessor db = new DataProcessor();
        public FrmFilmDetails(string showtime, string filmID)
        {
            InitializeComponent();
            this.showtime = showtime;
            this.filmID = filmID;
        }

        private void FrmFilmDetails_Load(object sender, EventArgs e)
        {
            DisplayMoviePhoto();
        }

        public void DisplayMoviePhoto()
        {
            string sql = "SELECT phim.TenPhim,phim.ThoiLuong,phim.Anh,LICHCHIEU.GioChieu,LichChieu.MaLC,LICHCHIEU.MaPhong,THELOAIPHIM.TenTLP,DINHDANGPHIM.TenDDP"
                        + " FROM phim"
                        + " JOIN LICHCHIEU ON phim.MaPhim = LICHCHIEU.maphim"
                        + " JOIN THELOAIPHIM ON phim.MaTLP = THELOAIPHIM.MaTLP"
                        + " JOIN DINHDANGPHIM ON phim.MaDDP = DINHDANGPHIM.MaDDP"
                        + " Where PHIM.MaPhim = '" + filmID +"'";
            DataTable dataTable = db.ReadData(sql);
            lblCategory.Text = dataTable.Rows[0]["TenTLP"].ToString();
            lblFormat.Text = dataTable.Rows[0]["TenDDP"].ToString();
            lblFilmTitle.Text = dataTable.Rows[0]["TenPhim"].ToString();
            lblDuration.Text = dataTable.Rows[0]["ThoiLuong"].ToString() + " Phút";
            DateTime date = (DateTime)dataTable.Rows[0]["GioChieu"];
            Button btnShowtime = new Button();
            btnShowtime.Text = "";
            lblShowtime.Text = date.Date.ToString("yyyy-MM-dd");
            string relativeImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "MoviePhotos");
            string fullPathToImage = Path.Combine(relativeImagePath, dataTable.Rows[0]["Anh"].ToString());
            ptBFilm.ImageLocation = fullPathToImage;
            ptBFilm.SizeMode = PictureBoxSizeMode.StretchImage;
            foreach (DataRow row in dataTable.Rows)
            {
                // Lịch chiếu và phòng chiếu
                Panel p = new Panel();
                Button btnTime = new Button();
                btnTime.AutoSize = true;
                btnTime.Text = date.Hour.ToString() + ":" + date.Minute.ToString();
                btnTime.Dock = DockStyle.Top;
                Button btnRoom = new Button();
                btnRoom.Text = row["MaPhong"].ToString();
                btnRoom.AutoSize = true;
                btnRoom.Dock = DockStyle.Top;
                btnRoom.Enabled = false;
                btnRoom.FlatAppearance.BorderSize = 0;
                btnRoom.FlatStyle = FlatStyle.Flat;
                p.Controls.Add(btnTime);
                p.Controls.Add(btnRoom);
                fLPShowtime.Controls.Add(p);
                btnTime.Click += new EventHandler((sender, e) =>
                {
                    string showtimeID = row["MaLC"].ToString();
                    ButtonClicked?.Invoke(this, EventArgs.Empty, showtimeID);
                });
                ButtonClicked += new ButtonClickHandler(btnTime_Click);
            }
        }

        public delegate void ButtonClickHandler(object sender, EventArgs e, string customParameter);

        public event ButtonClickHandler ButtonClicked;

        private void btnTime_Click(object sender, EventArgs e, string showtimeID)
        {
            // Xử lý sự kiện khi nút được nhấn
            //ButtonClicked?.Invoke(sender, e, showtimeID);
            FrmOrder frmOrder = new FrmOrder(showtimeID);
            frmOrder.ShowDialog();
            
        }
    }
}
