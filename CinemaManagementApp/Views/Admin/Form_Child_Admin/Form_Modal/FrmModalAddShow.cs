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

namespace CinemaManagementApp.Views.Admin.Form_Child_Admin.Form_Modal
{
    public partial class FrmModalAddShow : Form
    {
        DataProcessor dtbase = new DataProcessor();
        Functions ft = new Functions();
        Dictionary<string, object[]> mapPhim = new Dictionary<string, object[]>();
        Dictionary<string, string> mapPhong = new Dictionary<string, string>();

        public FrmModalAddShow()
        {
            InitializeComponent();
        }

        private void FrmModalAddShow_Load(object sender, EventArgs e)
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
        }
        private void cbTenPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!mapPhim[cbTenPhim.Text][1].Equals(""))
            {
                picPhim.Image = Image.FromFile(Application.StartupPath + "\\Images\\MoviePhotos\\" + mapPhim[cbTenPhim.Text][1]);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbTenPhim.Text.Equals("") || cbRoom.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa nhập hết thông tin.");
                return;
            }

            string sql = "INSERT INTO LichChieu(MaLC, GioChieu, MaPhim, MaPhong, GiaVe) VALUES(";
            sql += "'" + ft.SinhMaTuDong("LichChieu", "MaLC", "LC00") + "','" 
                + dtpDate.Value.ToString("yyyy-MM-dd") + " "+ txtGioChieu.Text + "','" + mapPhim[cbTenPhim.Text][0] + "','" 
                + mapPhong[cbRoom.Text] + "','" + txtGiaVe.Text + "')";

            dtbase.ChangeData(sql);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGioChieu_Click(object sender, EventArgs e)
        {
            txtGioChieu.Text = "";
        }
    }
}
