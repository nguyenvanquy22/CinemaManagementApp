using CinemaManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace CinemaManagementApp.Views.Admin.Form_Child_Admin.Form_Modal
{
    public partial class FrmModalUpdateShow : Form
    {
        DataProcessor dtbase = new DataProcessor();
        Functions ft = new Functions();
        Dictionary<string, object[]> mapPhim = new Dictionary<string, object[]>();
        Dictionary<string, string> mapPhong = new Dictionary<string, string>();
        DataRow dataLC;
        public FrmModalUpdateShow(DataRow LC)
        {
            InitializeComponent();
            this.dataLC = LC;
        }

        private void FrmModalUpdateShow_Load(object sender, EventArgs e)
        {
            DataTable dataPhim = dtbase.ReadData("select maphim, tenphim, anh from PHIM");
            foreach (DataRow phim in dataPhim.Rows)
            {
                mapPhim[phim["tenphim"].ToString()] = new object[] { phim["maphim"].ToString(), phim["anh"].ToString() };
                cbTenPhim.Items.Add(phim["tenphim"].ToString());
            }

            DataTable dataPhongchieu = dtbase.ReadData("select maphong, tenphong from Phongchieu");
            foreach (DataRow phong in dataPhongchieu.Rows)
            {
                mapPhong[phong["tenphong"].ToString()] = phong["maphong"].ToString();
                cbRoom.Items.Add(phong["tenphong"].ToString());
            }

            // selected ten phim
            string desiredValue = dataLC["tenphim"].ToString();
            for (int i = 0; i < cbTenPhim.Items.Count; i++)
            {
                string itemValue = cbTenPhim.Items[i].ToString();

                if (desiredValue.Equals(itemValue, StringComparison.OrdinalIgnoreCase))
                {
                    cbTenPhim.SelectedIndex = i;
                    break; 
                }
            }

            // selected ten phong
            desiredValue = dataLC["tenphong"].ToString();
            for (int i = 0; i < cbRoom.Items.Count; i++)
            {
                string itemValue = cbRoom.Items[i].ToString();

                if (desiredValue.Equals(itemValue, StringComparison.OrdinalIgnoreCase))
                {
                    cbRoom.SelectedIndex = i;
                    break; 
                }
            }

            // selected ngay
            dtpDate.Value = (DateTime)dataLC["ngaychieu"];

            // in gio
            txtGioChieu.Text = dataLC["giochieu"].ToString();

            // in gia ve
            txtGiaVe.Text = dataLC["giave"].ToString();

            drawRoom();

        }

        private void drawRoom ()
        {
            List<int> ChairNumber = new List<int>();
            List<string> Tickets = new List<string>();
            List<string> orders = new List<string>();

            string sql = "select LICHCHIEU.MaPhong, LICHCHIEU.GiaVe, LICHCHIEU.GioChieu, LICHCHIEU.MaPhim, HANG.ThuTuHang ,HANG.SLGhe\r\nfrom LICHCHIEU\r\njoin HANG on HANG.MaPhong = LICHCHIEU.MaPhong\r\nwhere LICHCHIEU.MaLC = '" + dataLC["MaLC"] + "'";
            DataTable dataTable = dtbase.ReadData(sql);
            int maxcol = 0;
            int sumChair = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                ChairNumber.Add(int.Parse(row["SLGhe"].ToString()));
                sumChair += int.Parse(row["SLGhe"].ToString());
                if (maxcol < int.Parse(row["SLGhe"].ToString())) maxcol = int.Parse(row["SLGhe"].ToString());
            }

            // Select ghế đã chọn
            sql = "select TenGhe from Ve where MaLC = '" + dataLC["MaLC"] + "'";
            dataTable = dtbase.ReadData(sql);
            foreach (DataRow row in dataTable.Rows)
            {
                Tickets.Add(row["TenGhe"].ToString());
            }

            // Vẽ bảng ghế
            tLPBoard.Controls.Clear();
            tLPBoard.RowCount = ChairNumber.Count;
            tLPBoard.ColumnCount = maxcol;
            tLPBoard.RowStyles.Clear();
            tLPBoard.ColumnStyles.Clear();
            for (int i = 0; i < tLPBoard.RowCount; i++)
            {
                tLPBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / tLPBoard.RowCount)); // Thiết lập kích thước hàng
            }
            for (int j = 0; j < tLPBoard.ColumnCount; j++)
            {
                tLPBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / tLPBoard.ColumnCount)); // Thiết lập kích thước cột
            }
            for (int i = 0; i < tLPBoard.RowCount; i++)
            {
                for (int j = 0; j < ChairNumber[i]; j++)
                {
                    Button button = new Button();
                    button.Text = (char)('A' + i) + "" + (j + 1);
                    button.Dock = DockStyle.Fill;
                    button.BackColor = Color.White;
                    //button.Click += Button_Click;
                    if (Tickets.Find(item => item == button.Text.ToString()) != null)
                    {
                        button.BackColor = Color.Yellow;
                    }
                    // Thêm ô vào TableLayoutPanel
                    tLPBoard.Controls.Add(button, j, i);
                }
            }

            lblTongSoGhe.Text = sumChair.ToString();
            lblDaDat.Text = Tickets.Count.ToString();
            lblConTrong.Text = (sumChair - Tickets.Count).ToString();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "Update LICHCHIEU SET ";
            sql += "GioChieu = '" + dtpDate.Value.ToString("yyyy-MM-dd") + " " + txtGioChieu.Text + "',";
            sql += "MaPhim = '" + mapPhim[cbTenPhim.Text][0] + "',";
            sql += "MaPhong = '" + mapPhong[cbRoom.Text] + "',";
            sql += "GiaVe = '" + txtGiaVe.Text + "' ";
            sql += "Where MaLC = '" + dataLC["MaLC"].ToString() + "'";

            //MessageBox.Show(sql);
            dtbase.ChangeData(sql);

            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
