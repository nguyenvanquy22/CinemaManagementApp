using CinemaManagementApp.Classes;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CinemaManagementApp.Views.Staff.ChildForm
{
    public partial class FrmOrderFood : Form
    {
        FrmOrder frmOrder;

        List<string> orders = new List<string>();
        string showtimeID;
        Dictionary<string, int> ordersFood = new Dictionary<string, int>();
        DataProcessor db = new DataProcessor();
        //bool check = false;
        float sum = 0;
        public FrmOrderFood(List<string> orders, string showtimeID, FrmOrder frmOrder)
        {
            InitializeComponent();
            this.orders = orders;
            this.showtimeID = showtimeID;
            this.frmOrder = frmOrder;
        }

        private void FrmOrderFood_Load(object sender, EventArgs e)
        {
            showProducts();
            /*groupBox1.Height = flowLayoutPanel1.Height * 3 / 4;*/
        }

        public void showProducts()
        {
            List<string> listFoodID = new List<string>();
            string sql = "select MaSP, TenSP, SoLuong, DonGia, Anh from SANPHAMKHAC";
            DataTable dataTable = db.ReadData(sql);
            foreach (DataRow dr in dataTable.Rows)
            {
                listFoodID.Add(dr["MaSP"].ToString());
            }
            // 
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < listFoodID.Count; i++)
            {
                PictureBox p = new PictureBox();
                string relativeImagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "FoodPhotos");
                string fullPathToImage = Path.Combine(relativeImagePath, dataTable.Rows[i]["Anh"].ToString());
                p.ImageLocation = fullPathToImage;
                p.SizeMode = PictureBoxSizeMode.StretchImage;
                string fid = listFoodID[i];
                Panel p1 = new Panel();
                Panel p2 = new Panel();
                Label name = new Label();
                Label qty = new Label();
                Label price = new Label();
                IconButton btnAdd = new IconButton();
                name.Text = dataTable.Rows[i]["TenSP"].ToString();
                if(ordersFood.ContainsKey(fid))
                {
                    qty.Text = "SL: " + (int.Parse(dataTable.Rows[i]["SoLuong"].ToString()) - ordersFood[fid]).ToString();
                    //check = false;
                }
                else qty.Text = "SL: " + dataTable.Rows[i]["SoLuong"].ToString();
                price.Text = dataTable.Rows[i]["DonGia"].ToString();
                btnAdd.IconChar = IconChar.Plus;
                btnAdd.IconSize = 16;
                btnAdd.Size = new Size(28, 23);
                btnAdd.BackColor = Color.SkyBlue;
                btnAdd.Dock = DockStyle.Right;
                btnAdd.Click += (sender, e) =>
                {
                    if (!ordersFood.ContainsKey(fid))
                    {
                        ordersFood.Add(fid, 0);
                        ordersFood[fid]++;
                    }
                    else ordersFood[fid]++;
                    int q = int.Parse(qty.Text.Split(':')[1].Trim());
                    if (q == 0)
                    {
                        MessageBox.Show("Số lượng hết", "Thông báo", MessageBoxButtons.OK);
                    }
                    else qty.Text = "SL: " + --q;
                    // Hiện thị thanh toán
                    Label n = name;
                    Label pri = price;
                    PictureBox pictureBox = p;
                    sum += float.Parse(price.Text);
                    lblTotal.Text = sum.ToString();
                    showBill();
                };

                name.Dock = DockStyle.Left;
                qty.Dock = DockStyle.Left;
                price.Dock = DockStyle.Right;
                price.TextAlign = ContentAlignment.TopRight;
                p1.Controls.Add(name);
                p1.Controls.Add(btnAdd);
                p2.Controls.Add(qty);
                p2.Controls.Add(price);
                p1.Dock = DockStyle.Bottom;
                p2.Dock = DockStyle.Bottom;
                p1.Size = new Size(30, 25);
                p2.Size = new Size(30, 25);

                p.Controls.Add(p1);
                p.Controls.Add(p2);
                p.Size = new Size(200, 350);
                p.BorderStyle = BorderStyle.Fixed3D;
                //p.Dock = DockStyle.Fill;
                flowLayoutPanel1.Controls.Add(p);
            }
        }

        private void iBtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            FrmBill f = new FrmBill(showtimeID,orders,ordersFood,this, this.frmOrder);
            f.ShowDialog();
        }

        public void showBill()
        {   
            flowLayoutPanel2.Controls.Clear();
            foreach (var i in ordersFood)
            {
                string sql = "select MaSP, TenSP, SoLuong, DonGia, Anh from SANPHAMKHAC where MaSP='" + i.Key + "'";
                DataTable dataTable = db.ReadData(sql);
                Panel container = new Panel();
                Label name = new Label();
                Label qty = new Label();
                IconButton btnSubstract = new IconButton();
                name.Text = dataTable.Rows[0]["TenSP"].ToString();
                qty.Text = i.Value.ToString();
                btnSubstract.IconChar = IconChar.Subtract;
                name.Dock = DockStyle.Left;
                qty.Dock = DockStyle.Left;
                name.TextAlign = ContentAlignment.MiddleLeft;
                qty.TextAlign = ContentAlignment.MiddleLeft;
                btnSubstract.BackColor = Color.Red;
                btnSubstract.FlatStyle = FlatStyle.Flat;
                btnSubstract.FlatAppearance.BorderSize = 0;
                btnSubstract.Dock = DockStyle.Left;
                btnSubstract.Click += (sender, e) =>
                {
                    //check = true;
                    ordersFood[i.Key]--;
                    sum -= float.Parse(dataTable.Rows[0]["DonGia"].ToString());
                    lblTotal.Text = sum.ToString();
                    showProducts();
                    if (ordersFood[i.Key] == 0)
                    {
                        ordersFood.Remove(i.Key);
                        showBill();
                        return;
                    }
                    else 
                    {
                        showBill();
                        return;
                    }
                };
                container.Size = new Size(flowLayoutPanel2.Width * 95 / 100, 50);
                container.Controls.Add(btnSubstract);
                container.Controls.Add(qty);
                container.Controls.Add(name);
                flowLayoutPanel2.Controls.Add(container);
            }
        }

        /*private void FrmOrderFood_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmOrder.Close();
            this.Close();
        }*/
    }
}
