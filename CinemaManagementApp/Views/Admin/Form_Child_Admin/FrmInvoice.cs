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
using Excel = Microsoft.Office.Interop.Excel;

namespace CinemaManagementApp.Views.Admin.Form_Child
{
    public partial class FrmInvoice : Form
    {
        DataProcessor dtbase = new DataProcessor();
        private bool outcomeInvoice = true;
        private bool isBtnSearchClick = false;
        public FrmInvoice()
        {
            InitializeComponent();
            if (outcomeInvoice)
            {
                GetListOutComeInvoice();
            }
            else
            {
                GetListInComeInvoice();
            }

        }
        
        private void GetListOutComeInvoice ()
        {
            string sql = @"
                    select hoadonban.mahdb, hoadonban.ngayxuathd, nhanvien.TenNV, khachhang.TenKH, khachhang.sdt,
	                    sum(cthdb.dongia*cthdb.soluong*(1-cthdb.giamgia/100)) + sum(lichchieu.giave) as tonggia
                    from hoadonban
	                    inner join khachhang on khachhang.makh = hoadonban.makh
	                    inner join nhanvien on nhanvien.manv = hoadonban.manv
	                    inner join cthdb on cthdb.mahdb = hoadonban.mahdb
	                    inner join ve on ve.mahdb = hoadonban.mahdb
	                    inner join lichchieu on lichchieu.malc = ve.malc";
            sql += " WHERE hoadonban.ngayxuathd = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "'";
            if (isBtnSearchClick)
            {
                sql += " and hoadonban.mahdb is not null and hoadonban.mahdb like '%" + txtSearch.Text + "%'";
            }
            sql += @" group by hoadonban.mahdb, hoadonban.ngayxuathd,nhanvien.TenNV, khachhang.TenKH, khachhang.sdt
                    order by hoadonban.ngayxuathd desc;";
                

            dgvListInvoice.DataSource = dtbase.ReadData(sql);
            dgvListInvoice.Columns[0].HeaderText = "Mã HDB";
            dgvListInvoice.Columns[1].HeaderText = "Ngày xuất";
            dgvListInvoice.Columns[2].HeaderText = "Nhân viên";
            dgvListInvoice.Columns[3].HeaderText = "Khách hàng";
            dgvListInvoice.Columns[4].HeaderText = "SĐT";
            dgvListInvoice.Columns[5].HeaderText = "Tổng giá";
        }
        private void GetListInComeInvoice()
        {
            string sql = @"
                    select hoadonnhap.mahdn, hoadonnhap.ngaynhaphd, nhanvien.tennv, nhacungcap.tenncc, nhacungcap.sdt,
	                    sum(cthdn.dongia*cthdn.soluong) as tonggia
                    from hoadonnhap
	                    inner join nhacungcap on nhacungcap.mancc = hoadonnhap.mancc
	                    inner join nhanvien on nhanvien.manv = hoadonnhap.manv
	                    inner join cthdn on cthdn.mahdn = hoadonnhap.mahdn
	                    inner join sanphamkhac on sanphamkhac.masp = cthdn.masp";
            sql += " Where hoadonnhap.ngaynhaphd = '" + dtpDate.Value.ToString("yyyy-MM-dd") +"'";
            if (isBtnSearchClick)
            {
                sql += " and hoadonnhap.mahdn is not null and hoadonnhap.mahdn like '%" + txtSearch.Text + "%'";
            }
            sql += @" group by hoadonnhap.mahdn, hoadonnhap.ngaynhaphd, nhanvien.tennv, nhacungcap.tenncc, nhacungcap.sdt
                    order by hoadonnhap.ngaynhaphd desc;";

            dgvListInvoice.DataSource = dtbase.ReadData(sql);
            dgvListInvoice.Columns[0].HeaderText = "Mã HDN";
            dgvListInvoice.Columns[1].HeaderText = "Ngày nhập";
            dgvListInvoice.Columns[2].HeaderText = "Nhân viên";
            dgvListInvoice.Columns[3].HeaderText = "Nhà cung cấp";
            dgvListInvoice.Columns[4].HeaderText = "SĐT";
            dgvListInvoice.Columns[5].HeaderText = "Tổng giá";
        }

        private void tabOutcomeInvoice_Click(object sender, EventArgs e)
        {
            tabOutcomeInvoice.BackColor = Color.WhiteSmoke;
            tabIncomeInvoice.BackColor = Color.Gainsboro;
            outcomeInvoice = true;
            isBtnSearchClick = false;
            txtSearch.Text = "";
            GetListOutComeInvoice();
        }

        private void tabIncomeInvoice_Click(object sender, EventArgs e)
        {
            tabIncomeInvoice.BackColor = Color.WhiteSmoke;
            tabOutcomeInvoice.BackColor = Color.Gainsboro;
            outcomeInvoice = false;
            isBtnSearchClick = false;
            txtSearch.Text = "";
            GetListInComeInvoice();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            isBtnSearchClick = true;
            if (outcomeInvoice)
            {
                GetListOutComeInvoice();
            }
            else
            {
                GetListInComeInvoice();
            }
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];
            Excel.Range exRange = (Excel.Range)exSheet.Cells[1, 1];
            exRange.Font.Size = 15;
            exRange.Font.Bold = true;
            exRange.Font.Color = Color.Blue;
            exRange.Value = "RẠP CHIẾU PHIM ......";

            Excel.Range address = (Excel.Range)exSheet.Cells[2, 1];
            address.Font.Size = 13;
            address.Font.Color = Color.Blue;
            address.Value = "Địa chỉ: ......";

            Excel.Range Title = (Excel.Range)exSheet.Cells[4, 3];
            Title.Font.Size = 15;
            Title.Font.Bold = true;
            Title.Font.Color = Color.Red;

            if (outcomeInvoice)
            {
                Title.Value = "DANH SÁCH HÓA ĐƠN BÁN";

                exSheet.Range["A5"].Value = "STT ";
                exSheet.Range["B5"].Value = "Mã HDB ";
                exSheet.Range["C5"].Value = "Ngày xuất ";
                exSheet.Range["D5"].Value = "Nhân viên ";
                exSheet.Range["E5"].Value = "Khách hàng ";
                exSheet.Range["F5"].Value = "SĐT ";
                exSheet.Range["G5"].Value = "Tổng giá ";
            }
            else
            {
                Title.Value = "DANH SÁCH HÓA ĐƠN NHẬP";

                exSheet.Range["A5"].Value = "STT ";
                exSheet.Range["B5"].Value = "Mã HDB ";
                exSheet.Range["C5"].Value = "Ngày nhập ";
                exSheet.Range["D5"].Value = "Nhân viên ";
                exSheet.Range["E5"].Value = "Nhà cung cấp ";
                exSheet.Range["F5"].Value = "SĐT ";
                exSheet.Range["G5"].Value = "Tổng giá ";
            }

            int numberRow = 5;
            for (int i = 0; i < dgvListInvoice.Rows.Count - 1; i++)
            {
                numberRow++;
                exSheet.Range["A" + numberRow.ToString()].Value = (i + 1).ToString();
                exSheet.Range["B" + numberRow.ToString()].Value = dgvListInvoice.Rows[i].Cells[0].Value.ToString();
                exSheet.Range["C" + numberRow.ToString()].Value = dgvListInvoice.Rows[i].Cells[1].Value.ToString();
                exSheet.Range["D" + numberRow.ToString()].Value = dgvListInvoice.Rows[i].Cells[2].Value.ToString();
                exSheet.Range["E" + numberRow.ToString()].Value = dgvListInvoice.Rows[i].Cells[3].Value.ToString();
                exSheet.Range["F" + numberRow.ToString()].Value = dgvListInvoice.Rows[i].Cells[4].Value.ToString();
                exSheet.Range["G" + numberRow.ToString()].Value = dgvListInvoice.Rows[i].Cells[5].Value.ToString();
            }

            exSheet.Name = "DS_HoaDon";
            exSheet.Activate();

            SaveFileDialog file = new SaveFileDialog();
            file.Filter = "Excel 97-2002 Workbook|*.xls|Excel Workbook|*.xlsx|All File|*.*";
            file.FilterIndex = 2;
            if (file.ShowDialog() == DialogResult.OK)
            {
                exBook.SaveAs(file.FileName.ToLower());
                MessageBox.Show("Xuất file thành công.");
            }
            exApp.Quit();
        }

        private void dgvListInvoice_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (e.Value != null)
                {
                    if (double.TryParse(e.Value.ToString(), out double result))
                    {
                        // Định dạng giá trị với hai chữ số sau dấu phẩy
                        e.Value = result.ToString("N2");
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            if (outcomeInvoice)
            {
                GetListOutComeInvoice();
            }
            else
            {
                GetListInComeInvoice();
            }
        }
    }
}
