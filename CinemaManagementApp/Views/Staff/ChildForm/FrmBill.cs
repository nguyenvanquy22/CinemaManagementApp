using CinemaManagementApp.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CinemaManagementApp.Views.Staff.ChildForm
{
    public partial class FrmBill : Form
    {
        private FrmOrderFood frmOrderFood;
        private FrmOrder FrmOrder;
        string showtimeID;
        List<string> ordersFilm = new List<string>();
        Dictionary<string, int> ordersFood = new Dictionary<string, int>();

        DataProcessor db = new DataProcessor();
        string customerID = "";
        string BillID = "";
        float totalFilm = 0;
        float totalFood = 0;
        public FrmBill(string showtimeID, List<string>ordersFilm, Dictionary<string, int> ordersFood, FrmOrderFood frmOrderFood, FrmOrder frmOrder)
        {
            InitializeComponent();
            this.showtimeID = showtimeID;
            this.ordersFilm = ordersFilm;
            this.ordersFood = ordersFood;
            this.frmOrderFood = frmOrderFood;
            this.FrmOrder = frmOrder;
        }
        private void FrmBill_Load(object sender, EventArgs e)
        {
            showFilm();
            showFood();
            float total = totalFilm + totalFood;
            lblTotal.Text = total.ToString();
        }
        private void showFilm()
        {
            if (ordersFilm.Count == 0)
            {
                lblPayFilm.Text = "0";
                return;
            }
            string sql = "select Phim.TenPhim, LICHCHIEU.GioChieu, LICHCHIEU.MaPhong, LICHCHIEU.GiaVe\r\nfrom LICHCHIEU join Phim on PHIM.MaPhim = LICHCHIEU.MaPhim\r\nwhere LICHCHIEU.MaLC = '" + showtimeID + "'";
            DataTable dataTable = db.ReadData(sql);
            lblFilmTitle.Text = dataTable.Rows[0]["TenPhim"].ToString();
            DateTime showtime = (DateTime)(dataTable.Rows[0]["GioChieu"]);
            lblDate.Text = showtime.Date.ToString();
            lblTime.Text = showtime.Hour + ":" + showtime.Minute + ":" + showtime.Second;
            lblRoom.Text = dataTable.Rows[0]["MaPhong"].ToString();
            lblPrice.Text = dataTable.Rows[0]["GiaVe"].ToString();
            string s = "";
            foreach(var i in ordersFilm)
            {
                s += i + " ";
            }
            lblChairs.Text = s;
            totalFilm = float.Parse(dataTable.Rows[0]["GiaVe"].ToString()) * ordersFilm.Count;
            lblPayFilm.Text = totalFilm.ToString();
        }

        private void showFood()
        {
            if (ordersFood.Count == 0)
            {
                lblPayFood.Text = "0";
                return;
            }
            string sql;
            DataTable dataTable;
            foreach (var i in ordersFood)
            {
                sql = "select TenSP, SoLuong, DonGia from SANPHAMKHAC where MaSP = '" + i.Key +"'"; 
                dataTable = db.ReadData(sql);
                Panel container = new Panel();
                container.Size = new Size(flowLayoutPanel1.Width * 95 / 100, 100);
                Panel p = new Panel();
                Label name = new Label();
                Label qty = new Label();
                Label tPrice = new Label();
                name.Text = dataTable.Rows[0]["TenSP"].ToString();
                qty.Text = i.Value + "x" + dataTable.Rows[0]["DonGia"].ToString();
                tPrice.Text = (i.Value * float.Parse(dataTable.Rows[0]["DonGia"].ToString())).ToString();
                name.AutoSize = false;
                qty.AutoSize = false;
                tPrice.AutoSize = false;
                name.Dock = DockStyle.Top;
                
                container.Controls.Add(p);
                container.Controls.Add(name);
                name.Height = container.Height / 3;
                p.Dock = DockStyle.Top;
                p.Height = container.Height * 15/30;
                qty.Dock = DockStyle.Left;
                tPrice.Dock = DockStyle.Right;
                tPrice.TextAlign = ContentAlignment.TopRight;
                p.Controls.Add(qty);
                p.Controls.Add(tPrice);
                flowLayoutPanel1.Controls.Add(container);
                totalFood += i.Value * float.Parse(dataTable.Rows[0]["DonGia"].ToString());
            }
            lblPayFood.Text = totalFood.ToString();
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Vui lòng nhập tên khách hàng");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                errorProvider1.SetError(txtPhoneNumber, "Vui lòng nhập số điện thoại khách hàng");
                return;
            }

            // Insert database
            string sql = "select MaKH, TenKH, SDT from KHACHHANG where LOWER(TenKH) = LOWER(N'" + txtName.Text.Trim() + "')"
                + " and SDT = '" + txtPhoneNumber.Text + "'";
            DataTable dt = db.ReadData(sql);
            
            if (dt.Rows.Count == 0)
            {
                customerID = new Classes.Functions().SinhMaTuDong("KHACHHANG", "MaKH", "KH1");
                sql = "Insert into KHACHHANG Values('" + customerID + "',"
                    + "N'" + txtName.Text.Trim() + "',"
                    + "'" + txtAge.Text.Trim() + "',"
                    + "'" + txtEmail.Text.Trim() + "',"
                    + "'" + txtPhoneNumber.Text.Trim() + "')";
                db.ChangeData(sql);
            }
            else customerID = dt.Rows[0]["MaKH"].ToString();

            DateTime now = DateTime.Now.Date;
            BillID = new Classes.Functions().SinhMaTuDong("HOADONBAN", "MaHDB", "HDB1");
            sql = "Insert into HoaDonBan Values('" + BillID + "',"
                + "'" + now.ToString("yyyy-MM-dd") + "',"
                + "'" + "NV001" + "',"
                + "'" + customerID + "')";
            db.ChangeData(sql);

            string TicketID = "";
            if (ordersFilm .Count > 0)
            {
                foreach (string i in ordersFilm)
                {
                    TicketID = new Classes.Functions().SinhMaTuDong("VE", "MaVe", "VE1");
                    sql = "Insert into Ve Values('" + TicketID + "',"
                            + "'" + i + "',"
                            + "'" + showtimeID + "',"
                            + "'" + BillID + "')";
                    db.ChangeData(sql);
                }
            }

            if (ordersFood.Count > 0)
            {
                foreach (var i in ordersFood)
                {
                    sql = "select DonGia from SANPHAMKHAC where MaSP='" + i.Key + "'";
                    dt = db.ReadData(sql);
                    sql = "Insert into CTHDB Values('" + i.Key + "',"
                            + "'" + i.Value + "',"
                            + "'" + dt.Rows[0]["DonGia"].ToString() + "',"
                            + "'" + 0 + "',"
                            + "'" + BillID + "')";
                    db.ChangeData(sql);
                    sql = "update SANPHAMKHAC set SoLuong = Soluong - " + i.Value
                        + " where MaSP ='" + i.Key + "'";
                    db.ChangeData(sql);
                }
            }

            MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);

            btnPay.Enabled = false;
            txtName.Enabled = false;
            txtAge.Enabled = false;
            txtEmail.Enabled = false;
            txtPhoneNumber.Enabled = false;
            btnExportData.Enabled = true;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmBill_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnExportData_Click(object sender, EventArgs e)
        {
            string sql = "select\tCTHDB.MaSP, CTHDB.DonGia, CTHDB.SoLuong, SANPHAMKHAC.TenSP\r\n\t\tfrom HOADONBAN join CTHDB on HOADONBAN.MaHDB = CTHDB.MaHDB\r\n\t\tjoin SANPHAMKHAC on CTHDB.MaSP = SANPHAMKHAC.MaSP\r\n\t\twhere HOADONBAN.MaHDB = '" + BillID + "'";
            DataTable dataTable = db.ReadData(sql);

            string templateFilePath = "D:\\NguyenTienDat\\CinemaManagementApp\\CinemaManagementApp\\bin\\Debug\\BillTemplate\\BillTemplate.xlsx";

            // Khởi tạo một ứng dụng Excel
            Excel.Application excelApp = new Excel.Application();
            //excelApp.Visible = true; // Hiển thị ứng dụng Excel

            // Mở file Excel template có sẵn
            Excel.Workbook templateWorkbook = excelApp.Workbooks.Open(templateFilePath);

            // Mở bản sao
            Excel.Workbook copyWorkbook = excelApp.Workbooks.Add();

            foreach (Excel.Worksheet templateWorksheet in templateWorkbook.Worksheets)
            {
                templateWorksheet.Copy(Before: copyWorkbook.Sheets[copyWorkbook.Sheets.Count]);
            }

            // Lấy trang trong bản sao
            Excel.Worksheet worksheet = copyWorkbook.Sheets["Sales Invoice"];

            // In ngày tạo hóa đơn
            worksheet.Cells[3, 8] = lblDate.Text;
            // In mã hóa đơn
            worksheet.Cells[4, 8] = BillID;
            // In mã khách hàng
            worksheet.Cells[5, 8] = customerID;
            // In tên khách hàng
            worksheet.Cells[6, 3] = "Họ tên: " + txtName.Text;
            // In tuổi khách hàng
            worksheet.Cells[7, 3] = "Tuổi: " + txtAge.Text;
            // In email khách hàng
            worksheet.Cells[8, 3] = "Email: " + txtEmail.Text;
            // In số điện thoại khách hàng
            worksheet.Cells[9, 3] = "SĐT: " + txtPhoneNumber.Text;

            // In thông tin đặt phim
            // In tên phim
            worksheet.Cells[13, 2] = lblFilmTitle.Text;
            // In đơn giá
            worksheet.Cells[13, 3] = lblPrice.Text;
            // In ghế
            worksheet.Cells[13, 4] = lblChairs.Text;
            // In ngày chiếu
            worksheet.Cells[13, 5] = lblDate.Text;
            // In giờ chiếu
            worksheet.Cells[13, 6] = lblTime.Text;
            // In phòng chiếu
            worksheet.Cells[13, 7] = lblRoom.Text;
            // In tổng tiền phim
            worksheet.Cells[13, 8] = lblPayFilm.Text;

            int row = 0;
            for(int i = 0; i < dataTable.Rows.Count; i++)
            {
                // In tên sản phẩm
                worksheet.Cells[16 + i, 2] = dataTable.Rows[i]["TenSP"].ToString();
                // In số lượng
                worksheet.Cells[16 + i, 3] = dataTable.Rows[i]["SoLuong"].ToString();
                // In đơn giá
                worksheet.Cells[16 + i, 4] = dataTable.Rows[i]["DonGia"].ToString();
                // In tổng tiền đồ ăn
                worksheet.Cells[16 + i, 5] = (float.Parse(dataTable.Rows[i]["SoLuong"].ToString()) * float.Parse(dataTable.Rows[i]["DonGia"].ToString())).ToString();

                ++row;
            }

            // In tổng giá trị hóa đơn
            Excel.Range cell = worksheet.Cells[19 + row, 7];
            cell.HorizontalAlignment = Excel.XlHAlign.xlHAlignRight;
            worksheet.Cells[17 + row, 7] = "Tổng tiền:";
            worksheet.Cells[17 + row, 8] = lblTotal.Text;
            //worksheet.Cells[20 + dong, 2] = "Thank you for your business!";
            

            // Sử dụng hộp thoại Lưu tệp để chọn nơi lưu tệp Excel mới
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.FileName = BillID + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = saveFileDialog.FileName;
                copyWorkbook.SaveAs(savePath);
            }

            // Đóng bản sao của file Excel template
            copyWorkbook.Close(false);

            // Đóng file Excel template gốc
            templateWorkbook.Close(false);

            // Đóng ứng dụng Excel
            excelApp.Quit();

            // Giải phóng tài nguyên
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(copyWorkbook);
            Marshal.ReleaseComObject(templateWorkbook);
            Marshal.ReleaseComObject(excelApp);

            MessageBox.Show("Đã tạo hóa đơn", "Thông báo", MessageBoxButtons.OK);
            frmOrderFood.Close();
            FrmOrder.Close();
            this.Close();
        }
    }
}
