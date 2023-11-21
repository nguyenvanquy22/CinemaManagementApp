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
    public partial class FrmModalDetailInvoice : Form
    {
        DataProcessor dtbase = new DataProcessor();
        private bool outcomeInvoice;
        private DataGridViewRow invoice;

        public FrmModalDetailInvoice(bool outcomeInvoice, DataGridViewRow invoice)
        {
            InitializeComponent();
            this.outcomeInvoice = outcomeInvoice;
            this.invoice = invoice;
        }

        private void FrmModalDetailInvoice_Load(object sender, EventArgs e)
        {
            if (outcomeInvoice)
            {
                string sql = @"
                    SELECT SANPHAMKHAC.MaSP, SANPHAMKHAC.TenSP, CTHDB.SoLuong, CTHDB.GiamGia, CTHDB.DonGia 
                    FROM CTHDB
                    JOIN SANPHAMKHAC on SANPHAMKHAC.MaSP = CTHDB.MaSP
                    WHERE CTHDB.MaHDB = '" + invoice.Cells[0].Value.ToString() + "'";

                dgvCTHDB.DataSource = dtbase.ReadData(sql);
                dgvCTHDB.Columns[0].HeaderText = "Mã SP";
                dgvCTHDB.Columns[1].HeaderText = "Tên SP";
                dgvCTHDB.Columns[2].HeaderText = "Số lượng";
                dgvCTHDB.Columns[3].HeaderText = "Giảm giá";
                dgvCTHDB.Columns[4].HeaderText = "Đơn giá";

                sql = @"
                    SELECT VE.MaVe, PHIM.TenPhim, VE.TenGhe, PHONGCHIEU.TenPhong, LICHCHIEU.GioChieu, LICHCHIEU.GiaVe 
                    FROM VE
                    JOIN LICHCHIEU on LICHCHIEU.MaLC = VE.MaLC
                    JOIN PHIM on LICHCHIEU.MaPhim = PHIM.MaPhim
                    JOIN PHONGCHIEU on PHONGCHIEU.MaPhong = LICHCHIEU.MaPhong
                    WHERE VE.MaHDB = '" + invoice.Cells[0].Value.ToString() + "'";

                dgvVE.DataSource = dtbase.ReadData(sql);
                dgvVE.Columns[0].HeaderText = "Mã vé";
                dgvVE.Columns[1].HeaderText = "Phim";
                dgvVE.Columns[2].HeaderText = "Ghế";
                dgvVE.Columns[3].HeaderText = "Phòng";
                dgvVE.Columns[4].HeaderText = "Giờ chiếu";
                dgvVE.Columns[5].HeaderText = "Giá vé";

                lblTitle.Text = "CHI TIẾT HÓA ĐƠN BÁN " + invoice.Cells[0].Value.ToString();
                lblNgay.Text = "Ngày bán: " + invoice.Cells[1].Value.ToString();
                lblNhanvien.Text = "Nhân viên: " + invoice.Cells[2].Value.ToString();
                lblDoitac.Text = "Khách hàng: " + invoice.Cells[3].Value.ToString();
                lblSDT.Text = "SDT: " + invoice.Cells[4].Value.ToString();
                lblTongGia.Text = "Tổng giá: " + invoice.Cells[5].Value.ToString() + "000 (VND)";
            }
            else
            {
                string sql = @"
                    SELECT SANPHAMKHAC.MaSP, SANPHAMKHAC.TenSP, CTHDN.SoLuong, CTHDN.DonGia 
                    FROM CTHDN
                    JOIN SANPHAMKHAC on SANPHAMKHAC.MaSP = CTHDN.MaSP
                    WHERE CTHDN.MaHDN = '" + invoice.Cells[0].Value.ToString() + "'";

                dgvCTHDB.DataSource = dtbase.ReadData(sql);
                dgvCTHDB.Columns[0].HeaderText = "Mã SP";
                dgvCTHDB.Columns[1].HeaderText = "Tên SP";
                dgvCTHDB.Columns[2].HeaderText = "Số lượng";
                dgvCTHDB.Columns[3].HeaderText = "Đơn giá";

                dgvVE.Visible = false;

                lblTitle.Text = "CHI TIẾT HÓA ĐƠN NHẬP " + invoice.Cells[0].Value.ToString();
                lblNgay.Text = "Ngày nhập: " + invoice.Cells[1].Value.ToString();
                lblNhanvien.Text = "Nhân viên: " + invoice.Cells[2].Value.ToString();
                lblDoitac.Text = "Nhà cung cấp: " + invoice.Cells[3].Value.ToString();
                lblSDT.Text = "SDT: " + invoice.Cells[4].Value.ToString();
                lblTongGia.Text = "Tổng giá: " + invoice.Cells[5].Value.ToString() + "000 (VND)";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
