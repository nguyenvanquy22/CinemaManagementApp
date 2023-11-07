using CinemaManagementApp.Classes;
using CinemaManagementApp.Views.Login;
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
    public partial class FrmModalImportProduct : Form
    {
        DataProcessor dt = new DataProcessor();
        Functions ft = new Functions();
        Dictionary<string, object[]> mapSP = new Dictionary<string, object[]>();
        public FrmModalImportProduct()
        {
            InitializeComponent();
        }

        private void FrmModalNhapSP_Load(object sender, EventArgs e)
        {
            DataTable listSP = dt.ReadData("select MaSP, TenSP, SoLuong, Anh from SANPHAMKHAC");
            
            foreach (DataRow sp in listSP.Rows)
            {
                mapSP[sp[1].ToString()] = new object[] { sp[0].ToString(), sp[2].ToString(), sp[3].ToString() };
                cbTenSP.Items.Add(sp["TenSP"].ToString());
            }
        }

        private void cbTenSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!mapSP[cbTenSP.Text][2].ToString().Equals(""))
            {
                picSP.Image = Image.FromFile(Application.StartupPath + "\\Images\\FoodsPhotos\\" + mapSP[cbTenSP.Text][2].ToString());
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // update sp
            int newQuantity = int.Parse(txtSoluong.Text) + int.Parse(mapSP[cbTenSP.Text][1].ToString());
            string sql = "Update SANPHAMKHAC SET ";
            sql += "SoLuong = '" + newQuantity + "' ";
            sql += "Where MaSP = '" + mapSP[cbTenSP.Text][0] +"'";
            dt.ChangeData(sql);

            // add hdn
            string mahdn = ft.SinhMaTuDong("HOADONNHAP", "MaHDN", "HDN00");
            sql = "INSERT INTO HOADONNHAP(MaHDN, NgayNhapHD, MaNV, MaNCC) VALUES(";
            sql += "'" + mahdn + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '"
                + FrmLogin.staffID + "','" + "NCC001" + "')"; 
            dt.ChangeData (sql);

            // add cthdn
            sql = "INSERT INTO CTHDN(MaHDN, MaSP, SoLuong, DonGia ) VALUES(";
            sql += "'" + mahdn + "', '" + mapSP[cbTenSP.Text][0] + "','"
                + txtSoluong.Text + "','" + txtGiaTien.Text + "')";
            dt.ChangeData(sql);

            this.Close();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
