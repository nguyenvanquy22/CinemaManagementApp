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
    public partial class FrmModalModifyProduct : Form
    {
        DataProcessor dtbase = new DataProcessor();
        Functions ft = new Functions();
        public event EventHandler<string> DataUpdated;
        private DataRow infoProducts;
        private string btnClick;
        private string sql = "";
        string fileImage = "";
        public FrmModalModifyProduct(DataRow dt, string btnClick)
        {
            InitializeComponent();
            this.infoProducts = dt;
            this.btnClick = btnClick;
        }
        public FrmModalModifyProduct(string btnClick)
        {
            InitializeComponent();
            this.btnClick = btnClick;
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
                pictureSP.Image = Image.FromFile(openFileDialog.FileName);
                images = openFileDialog.FileName.ToString().Split('\\');
                fileImage = images[images.Length - 1];
            }
        }

        private void FrmModalModifyProduct_Load(object sender, EventArgs e)
        {
            if (btnClick.Equals("btnUpdate"))
            {
                txtTenSP.Text = infoProducts["TenSP"].ToString();
                txtLoaiSP.Text = infoProducts["LoaiSP"].ToString();
                txtGiaTien.Text = infoProducts["DonGia"].ToString();
                if (!infoProducts["Anh"].ToString().Equals(""))
                {
                    pictureSP.Image = Image.FromFile(Application.StartupPath + "\\Images\\FoodsPhotos\\" + infoProducts["Anh"].ToString());
                    fileImage = infoProducts["Anh"].ToString();
                }
            }
            else
            {
                lblTitle.Text = "Thêm sản phẩm";
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (btnClick.Equals("btnUpdate"))
            {
                sql = "Update SANPHAMKHAC SET ";
                sql += "TenSP = N'" + txtTenSP.Text + "',";
                sql += "LoaiSP = N'" + txtLoaiSP.Text + "',";
                sql += "DonGia = '" + txtGiaTien.Text + "',";
                sql += "Anh = '" + fileImage + "' ";
                sql += "Where MaSP = '" + infoProducts["MaSP"] + "'";
            }
            else
            {
                sql = "INSERT INTO SANPHAMKHAC(MaSP, TenSP, LoaiSP, SoLuong, DonGia, Anh) VALUES(";
                sql += "'" + ft.SinhMaTuDong("SANPHAMKHAC", "MaSP", "SP00") + "', N'" + txtTenSP.Text + "',N'"
                    + txtLoaiSP.Text + "','" + 0 + "','"
                    + txtGiaTien.Text + "','" + fileImage + "')";
            }

            dtbase.ChangeData(sql);

            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
