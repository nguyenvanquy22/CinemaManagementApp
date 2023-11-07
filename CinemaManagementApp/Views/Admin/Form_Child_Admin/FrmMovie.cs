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
    public partial class FrmMovie : Form
    {
        DataProcessor dtbase = new DataProcessor();
        string sql = "";
        string sqlQueryMovies = @"
            SELECT PHIM.TenPhim, 
                   DINHDANGPHIM.TenDDP,
                   PHIM.QuocGiaSX, 
                   THELOAIPHIM.TenTLP,
                   PHIM.ThoiLuong
            FROM PHIM
                INNER JOIN THELOAIPHIM ON PHIM.MaTLP = THELOAIPHIM.MaTLP
                INNER JOIN DinhDangPhim ON PHIM.MaDDP = DinhDangPhim.MaDDP";
        public FrmMovie()
        {
            InitializeComponent();
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

            /* SELECT PHIM.TenPhim, 
                   STUFF((SELECT ', ' + DINHDANGPHIM.TenDinhDangPhim 
                          FROM DinhDang
                          WHERE DinhDang.MaPhim = PHIM.MaPhim
                          FOR XML PATH('')), 1, 2, '') AS DinhDang,
                   PHIM.QuocGiaSX, 
                   STUFF((SELECT ', ' + THELOAIPHIM.TenTLP 
                          FROM ChiTietTL
                          WHERE ChiTietTL.MaPhim = PHIM.MaPhim
                          FOR XML PATH('')), 1, 2, '') AS TheLoaiPhim,
                   PHIM.ThoiLuong */

            dgvListMovie.DataSource = dtbase.ReadData(sqlQueryMovies);
            dgvListMovie.Columns[0].HeaderText = "Tên phim";
            dgvListMovie.Columns[1].HeaderText = "Loại phim";
            dgvListMovie.Columns[2].HeaderText = "Quốc gia";
            dgvListMovie.Columns[3].HeaderText = "Thể loại";
            dgvListMovie.Columns[4].HeaderText = "Thời lượng";

            DataTable dinhDang = dtbase.ReadData("Select * from DINHDANGPHIM");
            DataTable theLoai = dtbase.ReadData("Select * from THELOAIPHIM");
            cbDinhDang.Items.Add("Định dạng");
            cbDinhDang.SelectedIndex = 0;
            cbTheLoai.Items.Add("Thể loại");
            cbTheLoai.SelectedIndex = 0;

            foreach (DataRow dd in dinhDang.Rows)
            {
                cbDinhDang.Items.Add(dd["TenDDP"].ToString());
            }
            foreach (DataRow tl in theLoai.Rows)
            {
                cbTheLoai.Items.Add(tl["TenTLP"].ToString());
            }
        }

        private void dgvListMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void dgvListMovie_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            drawModal(btnUpdate.Name);

            if (!sql.Equals(""))
            {
                dtbase.ChangeData(sql);
                dgvListMovie.DataSource = dtbase.ReadData(sqlQueryMovies);
            }
        }

        private void drawModal(string btnName)
        {
            DataTable dt;
            Form modalBackground = new Form();
            FrmModalModifyMovie modal;

            if (btnName.Equals(btnUpdate.Name))
            {
                string sql = @"
				SELECT * from Phim
                    inner join DinhDangPhim on Phim.MaDDP = DinhDangPhim.MaDDP
                    inner join TheLoaiPhim on Phim.MaTLP = TheLoaiPhim.MaTLP
				Where TenPhim = '" + dgvListMovie.CurrentRow.Cells[0].Value.ToString() + "'";

                dt = dtbase.ReadData(sql);
                modal = new FrmModalModifyMovie(dt, btnName);
            }
            else
            {
                modal = new FrmModalModifyMovie(btnName);
            }

            using (modal)
            {
                /*modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                //modalBackground.Opacity = .50d;
                modalBackground.Opacity = 0;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = this.Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();

                modal.Owner = modalBackground;*/
                modal.DataUpdated += ModalFormGetSQL;
                modal.ShowDialog();
                //modalBackground.Dispose();
            }
        }
        private void ModalFormGetSQL(object sender, string sql)
        {
            // Xử lý dữ liệu từ form con
            this.sql = sql;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            drawModal(btnCreate.Name);

            if (!sql.Equals(""))
            {
                dtbase.ChangeData(sql);
                dgvListMovie.DataSource = dtbase.ReadData(sqlQueryMovies);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            drawModal(btnUpdate.Name);

            if (!sql.Equals(""))
            {
                dtbase.ChangeData(sql);
                dgvListMovie.DataSource = dtbase.ReadData(sqlQueryMovies);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (btnDelete.Enabled == true)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sql = "Delete From PHIM Where TenPhim = '" + dgvListMovie.CurrentRow.Cells[0].Value + "'";
                    dtbase.ChangeData(sql);
                    dgvListMovie.DataSource = dtbase.ReadData(sqlQueryMovies);
                }
            }

            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filterData();
        }

        private void cbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void cbDinhDang_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void filterData ()
        {
            sql = sqlQueryMovies + " WHERE PHIM.TenPhim is not null";

            if (txtSearch.Text.Trim() != "")
            {
                sql += " and PHIM.TenPhim like N'%" + txtSearch.Text + "%'";
            }
            if (cbDinhDang.SelectedIndex != 0)
            {
                sql += " and dinhdangphim.TenDDP = N'" + cbDinhDang.SelectedItem + "'";
            }
            if (cbTheLoai.SelectedIndex != 0)
            {
                sql += " and theloaiphim.TenTLP = N'" + cbTheLoai.SelectedItem + "';";
            }

            dgvListMovie.DataSource = dtbase.ReadData(sql);
        }
    }
}
