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
    public partial class FrmShow : Form
    {
        DataProcessor dtbase = new DataProcessor();

        public FrmShow()
        {
            InitializeComponent();
        }

        private void FrmShow_Load(object sender, EventArgs e)
        {
            string sql = @"
                select phim.tenphim, dinhdangphim.tenddp, phim.thoiluong, 
                       FORMAT(lichchieu.giochieu,'HH:mm:00') as giochieu, phongchieu.tenphong, lichchieu.malc
                    from lichchieu
	                    inner join phim on phim.maphim = lichchieu.maphim
	                    inner join phongchieu on phongchieu.maphong = lichchieu.maphong
	                    inner join dinhdangphim on phim.maddp = dinhdangphim.maddp
                    where CONVERT(DATE,lichchieu.giochieu) = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "'";

            //MessageBox.Show();

            dgvListShow.DataSource = dtbase.ReadData(sql);
            dgvListShow.Columns[0].HeaderText = "Tên phim";
            dgvListShow.Columns[1].HeaderText = "Định dạng";
            dgvListShow.Columns[2].HeaderText = "Thời lượng";
            dgvListShow.Columns[3].HeaderText = "Giờ chiếu";
            dgvListShow.Columns[4].HeaderText = "Phòng chiếu";
            dgvListShow.Columns[5].Visible = false;

            DataTable dataTenPhongchieu = dtbase.ReadData("select tenphong from Phongchieu");
            cbRoom.Items.Add("Phòng chiếu");
            cbRoom.SelectedIndex = 0;
            foreach (DataRow tenphong in dataTenPhongchieu.Rows)
            {
                cbRoom.Items.Add(tenphong["tenphong"].ToString());
            }
        }
        // filter
        private void btnSearch_Click(object sender, EventArgs e)
        {
            filterData();
        }
        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            filterData();
        }
        private void cbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void filterData ()
        {
            string sql = @"
                select phim.tenphim, dinhdangphim.tenddp, phim.thoiluong,
                       FORMAT(lichchieu.giochieu,'HH:mm:00') as giochieu, phongchieu.tenphong, lichchieu.malc 
                    from lichchieu
	                    inner join phim on phim.maphim = lichchieu.maphim
	                    inner join phongchieu on phongchieu.maphong = lichchieu.maphong
	                    inner join dinhdangphim on phim.maddp = dinhdangphim.maddp
                    where CONVERT(DATE,lichchieu.giochieu) = '" + dtpDate.Value.ToString("yyyy-MM-dd") + "'";
            if (cbRoom.SelectedIndex != 0)
            {
                sql += " and phongchieu.tenphong = N'" + cbRoom.SelectedItem + "'";
            }
            if (!txtSearch.Text.Equals(""))
            {
                sql += " and phim.tenphim like N'%" + txtSearch.Text + "%'";
            }

            //MessageBox.Show(sql);

            dgvListShow.DataSource = dtbase.ReadData(sql);
        }

        // open modal
        private void dgvListShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void dgvListShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sql = @"
                select phim.tenphim, CONVERT(DATE,lichchieu.giochieu) as ngaychieu,
                        FORMAT(lichchieu.giochieu,'HH:mm:00') as giochieu,
                        phongchieu.tenphong, lichchieu.giave, lichchieu.malc
                from lichchieu
	                    inner join phim on phim.maphim = lichchieu.maphim
	                    inner join phongchieu on phongchieu.maphong = lichchieu.maphong
                where lichchieu.malc = '" + dgvListShow.CurrentRow.Cells[5].Value.ToString() + "'";

            DataTable dtLC = dtbase.ReadData(sql);
            DataRow dtSelectedRow = dtLC.Rows[0]; 

            using (FrmModalUpdateShow modal = new FrmModalUpdateShow(dtSelectedRow))
            {
                modal.ShowDialog();
            }
            filterData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (FrmModalAddShow modal = new FrmModalAddShow())
            {
                modal.ShowDialog();
            }
            filterData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sql = @"
                select phim.tenphim, CONVERT(DATE,lichchieu.giochieu) as ngaychieu,
                        FORMAT(lichchieu.giochieu,'HH:mm:00') as giochieu,
                        phongchieu.tenphong, lichchieu.giave, lichchieu.malc
                from lichchieu
	                    inner join phim on phim.maphim = lichchieu.maphim
	                    inner join phongchieu on phongchieu.maphong = lichchieu.maphong
                where lichchieu.malc = '" + dgvListShow.CurrentRow.Cells[5].Value.ToString() + "'";

            DataTable dtLC = dtbase.ReadData(sql);
            DataRow dtSelectedRow = dtLC.Rows[0];

            using (FrmModalUpdateShow modal = new FrmModalUpdateShow(dtSelectedRow))
            {
                modal.ShowDialog();
            }
            filterData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (btnDelete.Enabled == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql = "Delete From LICHCHIEU Where MaLC = '" + dgvListShow.CurrentRow.Cells[5].Value + "'";
                    dtbase.ChangeData(sql);
                    filterData();
                }
            }

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
    }
}
