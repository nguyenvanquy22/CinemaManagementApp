using CinemaManagementApp.Classes;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagementApp.Views.Staff.ChildForm
{
    public partial class FrmFood : Form
    {
        DataTable dataTable = new DataTable();
        PictureBox p;
        Label name;
        Label qty;
        Label price;
        IconButton btnAdd;
        public FrmFood(DataTable data)
        {
            InitializeComponent();
            this.dataTable = data;
        }

        private void FrmFood_Load(object sender, EventArgs e)
        {
            //showProduct();
        }

        /*public void showProduct()
        {
            Panel p1 = new Panel();
            Panel p2 = new Panel();
            string sql = "select MaSP, TenSP, SoLuong, DonGia, Anh from SANPHAMKHAC where MaSP='" + foodID + "'";
            DataTable dataTable = db.ReadData(sql);
            Label name =new Label();
            Label qty = new Label();
            Label price = new Label();
            Button btnAdd = new Button();
            name.Text = dataTable.Rows[0]["TenSP"].ToString();
            name.Dock = DockStyle.Bottom;
            pictureBox1.Controls.Add(name);
        }*/
    }
}
