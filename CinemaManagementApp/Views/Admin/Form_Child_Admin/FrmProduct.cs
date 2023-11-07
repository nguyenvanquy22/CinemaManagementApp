using CinemaManagementApp.Classes;
using CinemaManagementApp.Views.Admin.Form_Child_Admin.Form_Modal;
using FontAwesome.Sharp;
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

namespace CinemaManagementApp.Views.Admin.Form_Child
{
    public partial class FrmProduct : Form
    {
        DataProcessor dt = new DataProcessor();
        public FrmProduct()
        {
            InitializeComponent();
        }

        private void FrmProduct_Load(object sender, EventArgs e)
        {
            showProducts();
        }

        public void showProducts()
        {
            List<string> listFoodID = new List<string>();
            string sql = "select MaSP, TenSP, SoLuong, LoaiSP, DonGia, Anh from SANPHAMKHAC";
            DataTable dataTable = dt.ReadData(sql);
     
            // 
            flowLayoutPanel1.Controls.Clear();
            foreach (DataRow dr in dataTable.Rows)
            {
                PictureBox p = new PictureBox();
                string relativeImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "FoodsPhotos");
                string fullPathToImage = Path.Combine(relativeImagePath, dr["Anh"].ToString());
                p.ImageLocation = fullPathToImage;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                string fid = dr["MaSP"].ToString();
                Panel p1 = new Panel();
                Panel p2 = new Panel();
                Label name = new Label();
                Label qty = new Label();
                Label price = new Label();

                name.Text = dr["TenSP"].ToString();
                price.Text = dr["DonGia"].ToString();

                IconButton btnUpdate = new IconButton();

                btnUpdate.IconChar = IconChar.PenAlt;
                btnUpdate.IconSize = 20;
                btnUpdate.Size = new Size(28, 23);
                btnUpdate.BackColor = Color.SkyBlue;
                btnUpdate.Dock = DockStyle.Right;
                btnUpdate.Click += (sender, e) =>
                {
                    using (FrmModalModifyProduct modal = new FrmModalModifyProduct(dr, "btnUpdate"))
                    {
                        modal.ShowDialog();
                    }
                    showProducts();
                };

                IconButton btnDelete = new IconButton();
                btnDelete.IconChar = IconChar.TrashAlt;
                btnDelete.IconSize = 20;
                btnDelete.Size = new Size(28, 23);
                btnDelete.BackColor = Color.SkyBlue;
                btnDelete.Dock = DockStyle.Right;
                btnDelete.Click += (sender, e) =>
                {
                    string sqlDelete = "";
                    if (btnDelete.Enabled == true)
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            sqlDelete = "Delete From SANPHAMKHAC Where MaSP = '" + dr["MaSP"].ToString() + "'";
                            dt.ChangeData(sqlDelete);
                            showProducts();
                        }
                    }

                    btnUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                };


                name.Dock = DockStyle.Left;
                qty.Dock = DockStyle.Left;
                price.Dock = DockStyle.Right;
                price.TextAlign = ContentAlignment.TopRight;
                p1.Controls.Add(name);
                p1.Controls.Add(btnUpdate);
                p1.Controls.Add(btnDelete);
                p2.Controls.Add(qty);
                p2.Controls.Add(price);
                p1.Dock = DockStyle.Bottom;
                p2.Dock = DockStyle.Bottom;
                p1.Size = new Size(30, 25);
                p2.Size = new Size(30, 25);

                p.Controls.Add(p1);
                p.Controls.Add(p2);
                p.Size = new Size(200, 250);
                p.BorderStyle = BorderStyle.Fixed3D;
                //p.Dock = DockStyle.Fill;
                flowLayoutPanel1.Controls.Add(p);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FrmModalModifyProduct modal = new FrmModalModifyProduct(btnCreate.Text))
            {
                modal.ShowDialog();
            }
            showProducts();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            using (FrmModalImportProduct modal = new FrmModalImportProduct())
            {
                modal.ShowDialog();
            }
            showProducts();
        }
    }
}
