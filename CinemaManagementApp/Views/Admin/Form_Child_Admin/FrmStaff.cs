using CinemaManagementApp.Classes;
using CinemaManagementApp.Views.Admin.Form_Child_Admin.Form_Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagementApp.Views.Admin.Form_Child
{
    public partial class FrmStaff : Form
    {
		DataProcessor dtbase = new DataProcessor();
		string sql = "";
		public FrmStaff()
        {
            InitializeComponent();
        }

		private void FrmStaff_Load(object sender, EventArgs e)
		{
			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;

			string sql = @"
            SELECT manv,tennv,gioitinh,ngaysinh,sdt,email,chucvu,ngayvaolam from NHANVIEN	
			";

			dgvListStaff.DataSource = dtbase.ReadData(sql);
			dgvListStaff.Columns[0].HeaderText = "Mã NV";
			dgvListStaff.Columns[1].HeaderText = "Tên NV";
			dgvListStaff.Columns[2].HeaderText = "Giới tính";
			dgvListStaff.Columns[3].HeaderText = "Ngày sinh";
			dgvListStaff.Columns[4].HeaderText = "Số điện thoại";
			dgvListStaff.Columns[5].HeaderText = "Email";
			dgvListStaff.Columns[6].HeaderText = "Chức vụ";
			dgvListStaff.Columns[7].HeaderText = "Ngày bắt đầu";
			dgvListStaff.Columns[0].Width = 100;
            dgvListStaff.Columns[1].Width = 160;
            dgvListStaff.Columns[2].Width = 100;

            DataTable chucVu = dtbase.ReadData("Select ChucVu from NHANVIEN group by ChucVu");
            cbChucVu.Items.Add("Chức vụ");
            cbChucVu.SelectedIndex = 0;

            foreach (DataRow dd in chucVu.Rows)
            {
                cbChucVu.Items.Add(dd["ChucVu"].ToString());
            }
		}

        private void dgvListStaff_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lấy giá trị từ cột cụ thể của hàng được chọn
            /*DataGridViewRow selectedRow;
			if (e.RowIndex >= 0)
			{
				selectedRow = dgvListStaff.Rows[e.RowIndex];
			}
			else return;

			string sql = @"
            SELECT * from NHANVIEN
			Where MaNV = '" + selectedRow.Cells[0].Value.ToString() + "'";
			
			DataTable dt = dtbase.ReadData(sql);*/

            // Hiện modal chi tiết nhan vien
            drawModal(btnUpdate.Name);

            // Update data
            if (!sql.Equals(""))
            {
                dtbase.ChangeData(sql);
                sql = "SELECT manv,tennv,gioitinh,ngaysinh,sdt,email,chucvu,ngayvaolam from NHANVIEN";
                dgvListStaff.DataSource = dtbase.ReadData(sql);
            }
        }

        private void dgvListStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void drawModal (string btnName)
		{
			DataTable dt;
			Form modalBackground = new Form();
			FrmModalModifyStaff modal;

			if (btnName.Equals(btnUpdate.Name))
			{
				string sql = @"
				SELECT * from NHANVIEN
				Where MaNV = '" + dgvListStaff.CurrentRow.Cells[0].Value.ToString() + "'";

				dt = dtbase.ReadData(sql);
				modal = new FrmModalModifyStaff(dt, btnName);
			}
			else
			{
				modal = new FrmModalModifyStaff(btnName);
			}

			using (modal)
			{
				modalBackground.StartPosition = FormStartPosition.CenterScreen;
				modalBackground.FormBorderStyle = FormBorderStyle.None;
				//modalBackground.Opacity = .50d;
				modalBackground.Opacity = 0;
				modalBackground.BackColor = Color.Black;
				modalBackground.Size = this.Size;
				modalBackground.Location = this.Location;
				modalBackground.ShowInTaskbar = false;
				modalBackground.Show();

				modal.Owner = modalBackground;
				modal.DataUpdated += ModalFormGetSQL;
				modal.ShowDialog();
				modalBackground.Dispose();
			}
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			/*string sql = @"
            SELECT * from NHANVIEN";

			DataTable dt = dtbase.ReadData(sql);*/

			drawModal(btnCreate.Name);

            if (!sql.Equals(""))
            {
                dtbase.ChangeData(sql);
                sql = "SELECT manv,tennv,gioitinh,ngaysinh,sdt,email,chucvu,ngayvaolam from NHANVIEN";
                dgvListStaff.DataSource = dtbase.ReadData(sql);
            }
        }

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			drawModal(btnUpdate.Name);

			if(!sql.Equals(""))
			{
				dtbase.ChangeData(sql);
				sql = "SELECT manv,tennv,gioitinh,ngaysinh,sdt,email,chucvu,ngayvaolam from NHANVIEN";
				dgvListStaff.DataSource = dtbase.ReadData(sql);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (btnDelete.Enabled == true)
			{
				if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
					sql = "Delete From NHANVIEN Where MaNV = '" + dgvListStaff.CurrentRow.Cells[0].Value + "'";
			}

			dtbase.ChangeData(sql);
			sql = "SELECT manv,tennv,gioitinh,ngaysinh,sdt,email,chucvu,ngayvaolam from NHANVIEN";
			dgvListStaff.DataSource = dtbase.ReadData(sql);

			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;
		}

		private void ModalFormGetSQL(object sender, string sql)
		{
			// Xử lý dữ liệu từ form con
			this.sql = sql;
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			filterData();
        }

        private void cbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {
			filterData();
        }

		private void filterData()
		{
            sql = @"SELECT manv,tennv,gioitinh,ngaysinh,sdt,email,chucvu,ngayvaolam 
					FROM NHANVIEN 
					WHERE TenNV is not null";

            if (txtSearch.Text.Trim() != "")
            {
                sql += " and TenNV like N'%" + txtSearch.Text + "%'";
            }
            if (cbChucVu.SelectedIndex != 0)
            {
                sql += " and chucvu = N'" + cbChucVu.SelectedItem + "'";
            }

            dgvListStaff.DataSource = dtbase.ReadData(sql);
        }
    }
}
