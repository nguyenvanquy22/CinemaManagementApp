using CinemaManagementApp.Classes;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CinemaManagementApp.Views.Staff.ChildForm
{
    public partial class Film : Form
	{
        DataProcessor db = new DataProcessor();
		private string filmID;
		private string showtime;
        Label name;
        Label time;
        public Film(string fid, string s)
		{
			filmID = fid;
			showtime = s;
			InitializeComponent();
		}

        private void Film_Load(object sender, EventArgs e)
        {
            showFilm();
        }

        public void showFilm()
        {
            string sql = "select TenPhim, ThoiLuong, Anh from Phim where MaPhim ='" + filmID + "'";
            DataTable dataTable = db.ReadData(sql);
            foreach (DataRow row in dataTable.Rows)
            {
                name = new Label();
                name.Dock = DockStyle.Bottom;
                name.Text = row["TenPhim"].ToString();
                time = new Label();
                time.Dock = DockStyle.Bottom;
                time.Text = row["ThoiLuong"].ToString();
                string relativeImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "MoviePhotos");
                string fullPathToImage = Path.Combine(relativeImagePath, row["Anh"].ToString());
                pictureBox1.ImageLocation = fullPathToImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
                pictureBox1.Controls.Add(name);
                pictureBox1.Controls.Add(time);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(showtimeID, "Mã LC", MessageBoxButtons.OK);
            FrmFilmDetails frmFilmDetails = new FrmFilmDetails(showtime,filmID);
            using (frmFilmDetails)
            {
                frmFilmDetails.ShowDialog();
            }
        }
    }
}
