using CinemaManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CinemaManagementApp.Views.Staff.ChildForm
{
    public partial class FrmOrder : Form
    {
        DataProcessor db = new DataProcessor();
        List<int> ChairNumber = new List<int>();
        List<string> Tickets = new List<string>();
        List<string> orders = new List<string>();
        float price;
        string showtimeID;
        public FrmOrder(string showtimeID)
        {
            InitializeComponent();
            this.showtimeID = showtimeID;
        }

        private void FrmOrder_Load(object sender, EventArgs e)
        {
            // Select số ghê
            string sql = "select LICHCHIEU.MaPhong, LICHCHIEU.GiaVe, LICHCHIEU.GioChieu, LICHCHIEU.MaPhim, HANG.ThuTuHang ,HANG.SLGhe\r\nfrom LICHCHIEU\r\njoin HANG on HANG.MaPhong = LICHCHIEU.MaPhong\r\nwhere LICHCHIEU.MaLC = '"+ showtimeID + "'";
            DataTable dataTable = db.ReadData(sql);
            int maxcol = 0;
            int sumChair = 0;
            price = float.Parse(dataTable.Rows[0]["GiaVe"].ToString());
            foreach(DataRow row in dataTable.Rows)
            {
                ChairNumber.Add(int.Parse(row["SLGhe"].ToString()));
                sumChair += int.Parse(row["SLGhe"].ToString());
                if (maxcol < int.Parse(row["SLGhe"].ToString())) maxcol = int.Parse(row["SLGhe"].ToString());
            }
            label1.Text = dataTable.Rows[0]["MaPhong"].ToString() + "  |  ";
            label2.Text = dataTable.Rows[0]["GioChieu"].ToString();
            // Select ghế đã chọn
            sql = "select TenGhe from Ve where MaLC = '" + showtimeID + "'";
            dataTable = db.ReadData(sql);
            foreach(DataRow row in dataTable.Rows)
            {
                Tickets.Add(row["TenGhe"].ToString());
            }
            // 
            label1.Text += "Số ghế: " + Tickets.Count + "/" + sumChair;
            // Vẽ bảng ghế
            drawBoard(maxcol);
            // Hiện thị vé
            showTicket();
        }

        public void drawBoard(int size)
        {
            tLPBoard.Controls.Clear();
            tLPBoard.RowCount = ChairNumber.Count;
            tLPBoard.ColumnCount = size;
            tLPBoard.RowStyles.Clear();
            tLPBoard.ColumnStyles.Clear();
            for (int i = 0; i < tLPBoard.RowCount; i++)
            {
                tLPBoard.RowStyles.Add(new RowStyle(SizeType.Percent,100/ tLPBoard.RowCount)); // Thiết lập kích thước hàng
            }
            for (int j = 0; j < tLPBoard.ColumnCount; j++)
            {
                tLPBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / tLPBoard.ColumnCount)); // Thiết lập kích thước cột
            }
            for (int  i = 0; i < tLPBoard.RowCount; i++)
            {
                for (int j = 0; j < ChairNumber[i]; j++)
                {
                    Button button = new Button();
                    button.Text = (char)('A' + i) + "" +(j+1);
                    button.Dock = DockStyle.Fill;
                    button.BackColor = Color.White;
                    button.Click += Button_Click;
                    if (Tickets.Find(item => item == button.Text.ToString()) != null)
                    {
                        button.BackColor = Color.Yellow;
                    }
                    // Thêm ô vào TableLayoutPanel
                    tLPBoard.Controls.Add(button,j,i);
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == Color.White)
            {
                button.BackColor = Color.Green;
                orders.Add(button.Text);
                string t = "";
                foreach(string s in orders)
                {
                    t += s + " ";
                }
                lblChairs.Text = t;
                lblTotal.Text = (orders.Count*price).ToString();
            }
            else if (button.BackColor == Color.Green)
            {
                button.BackColor = Color.White;
                orders.Remove(button.Text);
                string t = "";
                foreach (string s in orders)
                {
                    t += s +" ";
                }
                lblChairs.Text = t;
                lblTotal.Text = (orders.Count * price).ToString();
            }
            else if (button.BackColor == Color.Yellow)
            {
                MessageBox.Show("Ghế đã được chọn!", "Thông báo!", MessageBoxButtons.OK);
            }
        }

        private void showTicket()
        {
            lblPrice.Text = price.ToString();
            string sql = "select LichChieu.GioChieu, LichChieu.MaPhong, Phim.TenPhim, Phim.Anh from LichChieu " +
                "join Phim on Phim.MaPhim = LichChieu.MaPhim " +
                "where LichChieu.MaLC ='" + showtimeID + "'";
            DataTable datatable = db.ReadData(sql);
            if (datatable != null)
            {
                string relativeImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "MoviePhotos");
                string fullPathToImage = Path.Combine(relativeImagePath, datatable.Rows[0]["Anh"].ToString());
                ptBFilmPhoto.ImageLocation = fullPathToImage;
                ptBFilmPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                lblFilmTitle.Text = datatable.Rows[0]["TenPhim"].ToString();
                lblPlayRoom.Text = datatable.Rows[0]["MaPhong"].ToString();
                DateTime date = (DateTime)datatable.Rows[0]["GioChieu"];
                lblShowtime.Text = date.Hour.ToString() + ":" + date.Minute.ToString() + ":" + date.Second.ToString();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (orders.Count == 0) 
            {
                MessageBox.Show("Bạn chưa chọn ghế", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (MessageBox.Show("Bạn đã hoàn thành đặt ghế?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    FrmOrderFood f = new FrmOrderFood(orders,showtimeID, this);
                    f.Show();
                }
            }
        }
    }
}
