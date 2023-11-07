using CinemaManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagementApp.Views.Staff.ChildForm
{
	public partial class FrmMovie : Form
	{
        private List<string> listFilmID = new List<string>();
        //private string showtime;
        private int currentFilmIndex;
        private string FilmTitle;
        private string Category;
        //private string sql;
        private DateTime showtime;
        

        DataProcessor db = new DataProcessor();
        DataTable dataTable;

        public FrmMovie()
		{
			InitializeComponent();
            showtime = dTPShowtime.Value;
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            // Hiển thị khoảng thời gian phim đang chiếu
            setShowTime(-2, 4);

            // Hiển thị các thể loại
            setComboBoxCategoryItem();

            // Hiển thị danh sách phim
            string sql = "SELECT LichChieu.GioChieu, Phim.MaPhim FROM LichChieu "
                + "JOIN Phim ON LichChieu.MaPhim = Phim.MaPhim "
                + "where CONVERT(DATE, LichChieu.GioChieu) ='" + showtime + "'";
            listFilm(sql);
            setListFilm();
        }

        public void setShowTime(int preDay, int nextDay)
        {
            DateTime t = dTPShowtime.Value;

            // Tính toán ngày tối thiểu
            //DateTime minDate = t.AddDays(preDay);

            // Tính toán ngày tối đa
            //DateTime maxDate = t.AddDays(nextDay);

            // Đặt giá trị tối thiểu và tối đa cho DateTimePicker
            //dTPShowtime.MinDate = minDate;
            //dTPShowtime.MaxDate = maxDate;
        }

        public void setComboBoxCategoryItem()
        {
            string sql = "select TenTLP from THELOAIPHIM";
            dataTable = db.ReadData(sql);
            foreach (DataRow row in dataTable.Rows)
            {
                string category = row["TenTLP"].ToString();
                cbCategory.Items.Add(category);
            }
        }

        public void setListFilm()
        {
            tableLayoutPanel1.Controls.Clear();
            if (currentFilmIndex == 0) iBtnPre.Enabled = false;
            Film f;
            int row = 1, col = 1;
            for (int i = currentFilmIndex; i < listFilmID.Count; i++)
            {
                string filmID = listFilmID[currentFilmIndex];
                f = new Film(filmID, showtime.ToString("yyyy-MM-dd"));
                f.TopLevel = false;
                f.FormBorderStyle = FormBorderStyle.None;
                f.Dock = DockStyle.Fill;
                tableLayoutPanel1.Controls.Add(f, col, row);
                f.Show();
                col += 2;
                if (col > 7)
                {
                    col = 1;
                    row += 2;
                }
                if (row > 3)
                {
                    break;
                }
                currentFilmIndex++;
            }
            if (currentFilmIndex >= listFilmID.Count) iBtnNext.Enabled = false;
        }

        public void listFilm(string sql)
        {
            listFilmID.Clear();
            currentFilmIndex = 0;
            dataTable = db.ReadData(sql);
            foreach (DataRow row in dataTable.Rows)
            {
                listFilmID.Add(row["MaPhim"].ToString());
            }
        }
        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim().Equals("Tên phim"))  txtSearch.Text = "";
        }

        private void iBtnNext_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(currentFilmIndex+"", "Số phim", MessageBoxButtons.OK);
            currentFilmIndex++;
            //tableLayoutPanel1.Controls.Clear();
            setListFilm();
            if (currentFilmIndex >= listFilmID.Count) iBtnNext.Enabled = false;
            iBtnPre.Enabled = true;
        }

        private void iBtnPre_Click(object sender, EventArgs e)
        {
            //tableLayoutPanel1.Controls.Clear();
            if (currentFilmIndex + 1 > 8)
                currentFilmIndex = (currentFilmIndex-7) / 8 * 8;
            setListFilm();
            iBtnNext.Enabled = true;
        }

        private void dTPShowtime_ValueChanged(object sender, EventArgs e)
        {
            showtime = dTPShowtime.Value;
            //MessageBox.Show(showtime.ToString(), "Số phim", MessageBoxButtons.OK);
            string sql = "SELECT LichChieu.GioChieu, Phim.MaPhim FROM LichChieu "
                + "JOIN Phim ON LichChieu.MaPhim = Phim.MaPhim "
                + "where CONVERT(DATE, LichChieu.GioChieu) ='" + showtime + "'";
            listFilm(sql);
            setListFilm();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sql = "SELECT LichChieu.GioChieu, Phim.MaPhim FROM LichChieu "
                + "JOIN Phim ON LichChieu.MaPhim = Phim.MaPhim "
                + "where CONVERT(DATE, LichChieu.GioChieu) ='" + showtime + "'"
                + " and Lower(Phim.TenPhim) = Lower('" + txtSearch.Text.Trim() + "')";
            if (txtSearch.Text.Trim().Equals(""))
            {
                sql = "SELECT LichChieu.GioChieu, Phim.MaPhim FROM LichChieu "
                + "JOIN Phim ON LichChieu.MaPhim = Phim.MaPhim "
                + "where CONVERT(DATE, LichChieu.GioChieu) ='" + showtime + "'";
            }
            listFilm(sql);
            setListFilm();
        }
    }
}
