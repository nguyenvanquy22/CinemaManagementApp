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
    public partial class FrmModalModifyMovie : Form
    {
        DataProcessor dtbase = new DataProcessor();
        Functions ft =  new Functions();
        public event EventHandler<string> DataUpdated;
        private DataRow infoMovies;
        private string btnClick;
        private string sql = "";
        string fileImage = "";

        public FrmModalModifyMovie(DataTable dt, string btnClick)
        {
            InitializeComponent();
            this.btnClick = btnClick;
            if (btnClick.Equals("btnUpdate")) infoMovies = dt.Rows[0];
        }
        public FrmModalModifyMovie(string btnClick)
        {
            InitializeComponent();
            this.btnClick = btnClick;
        }

        private void FrmModalModifyMovie_Load(object sender, EventArgs e)
        {
            DataTable dinhDang = dtbase.ReadData("Select * from DINHDANGPHIM");
            DataTable theLoai = dtbase.ReadData("Select * from THELOAIPHIM");

            foreach (DataRow dd in dinhDang.Rows)
            {
                cbDinhDang.Items.Add(dd["TenDDP"].ToString());
            }
            foreach (DataRow tl in theLoai.Rows)
            {
                cbTheLoai.Items.Add(tl["TenTLP"].ToString());
            }

            if (btnClick.Equals("btnUpdate"))
            {
                //txtMaNV.Text = infoMovies["MaNV"].ToString();
                txtTenPhim.Text = infoMovies["TenPhim"].ToString();
                cbDinhDang.SelectedItem = infoMovies["TenDDP"].ToString();
                cbTheLoai.SelectedItem = infoMovies["TenTLP"].ToString();
                txtQuocGiaSx.Text = infoMovies["QuocGiaSX"].ToString();
                txtHangSx.Text = infoMovies["HangSX"].ToString();
                dtpNgayKhoiChieu.Value = (DateTime)infoMovies["NgayKhoiChieu"];
                dtpNgayKetThuc.Value = (DateTime)infoMovies["NgayKetThuc"];
                txtDaoDien.Text = infoMovies["DaoDien"].ToString();
                txtDienVien.Text = infoMovies["DienVienChinh"].ToString();
                txtThoiLuong.Text = infoMovies["ThoiLuong"].ToString();
                txtTongChiPhi.Text = infoMovies["TongChiPhi"].ToString();
                txtMoTa.Text = infoMovies["MoTa"].ToString();
                if (!infoMovies["Anh"].ToString().Equals(""))
                {
                    picAnhPhim.Image = Image.FromFile(Application.StartupPath + "\\Images\\MoviePhotos\\" + infoMovies["Anh"].ToString());
                }
            }
            else
            {
                lblTitle.Text = "Thêm phim";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            DataTable maDinhDang = dtbase.ReadData("Select MaDDP from DINHDANGPHIM Where TenDDP = N'" + cbDinhDang.SelectedItem + "'");
            DataTable maTheLoai = dtbase.ReadData("Select MaTLP from THELOAIPHIM Where TenTLP = N'" + cbTheLoai.SelectedItem + "'");
  
            if (btnClick.Equals("btnUpdate"))
            {
                sql = "Update PHIM SET ";
                sql += "TenPhim = N'" + txtTenPhim.Text + "',";
                sql += "MaDDP = '" + maDinhDang.Rows[0][0].ToString() + "',";
                sql += "MaTLP = '" + maTheLoai.Rows[0][0].ToString() + "',";
                sql += "QuocGiaSX = '" + txtQuocGiaSx.Text + "',";
                sql += "HangSX = '" + txtHangSx.Text + "',";
                sql += "NgayKhoiChieu = '" + dtpNgayKhoiChieu.Value.Date.ToString("yyyy-MM-dd") + "',";
                sql += "NgayKetThuc = '" + dtpNgayKetThuc.Value.Date.ToString("yyyy-MM-dd") + "',";
                sql += "DaoDien = '" + txtDaoDien.Text + "',";
                sql += "DienVienChinh = '" + txtDienVien.Text + "',";
                sql += "ThoiLuong = '" + txtThoiLuong.Text + "',";
                sql += "TongChiPhi = '" + txtTongChiPhi.Text + "',";
                sql += "Anh = '" + fileImage + "',";
                sql += "MoTa = '" + txtMoTa.Text + "' ";
                sql += "Where TenPhim = N'" + txtTenPhim.Text + "'";
            }
            else
            {
                string maPhimMoi = ft.SinhMaTuDong("PHIM", "MaPhim", "P00");
                sql = "INSERT INTO PHIM(MaPhim, TenPhim, MaDDP, MaTLP, QuocGiaSX, HangSX, NgayKhoiChieu, NgayKetThuc," +
                    " DaoDien, DienVienChinh, ThoiLuong, TongChiPhi, Anh, MoTa) VALUES(";
                sql += "'" + maPhimMoi + "', N'" + txtTenPhim.Text + "','" + maDinhDang.Rows[0][0].ToString() + "','" + maTheLoai.Rows[0][0].ToString() + "','" 
                    + txtQuocGiaSx.Text + "','" + txtHangSx.Text + "','" 
                    + dtpNgayKhoiChieu.Value.Date.ToString("yyyy-MM-dd") + "','" + dtpNgayKetThuc.Value.Date.ToString("yyyy-MM-dd") + "','"
                    + txtDaoDien.Text + "','" + txtDienVien.Text + "','" + txtThoiLuong.Text + "','"
                    + txtTongChiPhi.Text + "','" + fileImage + "',N'" + txtMoTa.Text + "')";
            }

            //MessageBox.Show(sql);

            DataUpdated?.Invoke(this, sql);

            this.Close();
        }
		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void cbDinhDang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key
            {
                string newItem = cbDinhDang.Text;
                if (!string.IsNullOrWhiteSpace(newItem) && !cbDinhDang.Items.Contains(newItem))
                {
                    cbDinhDang.Items.Add(newItem);
                    sql = "INSERT INTO DINHDANGPHIM VALUES('" 
                        + ft.SinhMaTuDong("DINHDANGPHIM", "MaDDP", "DDP00") + "','" + newItem + "')";

                    dtbase.ChangeData(sql);
                }
            }
        }

        private void cbTheLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Enter key
            {
                string newItem = cbTheLoai.Text;
                if (!string.IsNullOrWhiteSpace(newItem) && !cbTheLoai.Items.Contains(newItem))
                {
                    cbTheLoai.Items.Add(newItem);
                    sql = "INSERT INTO THELOAIPHIM VALUES('"
                        + ft.SinhMaTuDong("THELOAIPHIM", "MaTLP", "TLP00") + "','" + newItem + "')";

                    dtbase.ChangeData(sql);
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            string[] images;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG Images|*.JPG|PNG Images|*.png|All file|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.InitialDirectory = Application.StartupPath;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picAnhPhim.Image = Image.FromFile(openFileDialog.FileName);
                images = openFileDialog.FileName.ToString().Split('\\');
                fileImage = images[images.Length - 1];
            }
        }
    }
}
