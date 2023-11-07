namespace CinemaManagementApp.Views.Admin.Form_Child
{
    partial class FrmMovie
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.paneFilter = new System.Windows.Forms.Panel();
            this.cbDinhDang = new System.Windows.Forms.ComboBox();
            this.cbTheLoai = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnCreate = new FontAwesome.Sharp.IconButton();
            this.panelListMovie = new System.Windows.Forms.Panel();
            this.dgvListMovie = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.paneFilter.SuspendLayout();
            this.panelListMovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMovie)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneFilter
            // 
            this.paneFilter.Controls.Add(this.cbDinhDang);
            this.paneFilter.Controls.Add(this.cbTheLoai);
            this.paneFilter.Controls.Add(this.txtSearch);
            this.paneFilter.Controls.Add(this.btnSearch);
            this.paneFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneFilter.Location = new System.Drawing.Point(0, 0);
            this.paneFilter.Name = "paneFilter";
            this.paneFilter.Size = new System.Drawing.Size(982, 64);
            this.paneFilter.TabIndex = 0;
            // 
            // cbDinhDang
            // 
            this.cbDinhDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDinhDang.FormattingEnabled = true;
            this.cbDinhDang.Location = new System.Drawing.Point(828, 17);
            this.cbDinhDang.Name = "cbDinhDang";
            this.cbDinhDang.Size = new System.Drawing.Size(130, 28);
            this.cbDinhDang.TabIndex = 7;
            this.cbDinhDang.SelectedIndexChanged += new System.EventHandler(this.cbDinhDang_SelectedIndexChanged);
            // 
            // cbTheLoai
            // 
            this.cbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTheLoai.FormattingEnabled = true;
            this.cbTheLoai.Location = new System.Drawing.Point(670, 17);
            this.cbTheLoai.Name = "cbTheLoai";
            this.cbTheLoai.Size = new System.Drawing.Size(130, 28);
            this.cbTheLoai.TabIndex = 6;
            this.cbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbTheLoai_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(30, 17);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Tag = "";
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 28;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(263, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 36);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 28;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(384, 14);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnUpdate.IconColor = System.Drawing.Color.Black;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.IconSize = 28;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(226, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnCreate.IconColor = System.Drawing.Color.Black;
            this.btnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreate.IconSize = 28;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(66, 14);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 36);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Thêm";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panelListMovie
            // 
            this.panelListMovie.Controls.Add(this.dgvListMovie);
            this.panelListMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListMovie.Location = new System.Drawing.Point(0, 64);
            this.panelListMovie.Name = "panelListMovie";
            this.panelListMovie.Size = new System.Drawing.Size(982, 425);
            this.panelListMovie.TabIndex = 1;
            // 
            // dgvListMovie
            // 
            this.dgvListMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListMovie.Location = new System.Drawing.Point(0, 0);
            this.dgvListMovie.Name = "dgvListMovie";
            this.dgvListMovie.RowHeadersWidth = 51;
            this.dgvListMovie.RowTemplate.Height = 24;
            this.dgvListMovie.Size = new System.Drawing.Size(982, 425);
            this.dgvListMovie.TabIndex = 0;
            this.dgvListMovie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListMovie_CellClick);
            this.dgvListMovie.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListMovie_CellDoubleClick);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnDelete);
            this.panelControl.Controls.Add(this.btnCreate);
            this.panelControl.Controls.Add(this.btnUpdate);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 489);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(982, 64);
            this.panelControl.TabIndex = 1;
            // 
            // FrmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panelListMovie);
            this.Controls.Add(this.panelControl);
            this.Controls.Add(this.paneFilter);
            this.Name = "FrmMovie";
            this.Text = "Quản lý phim";
            this.Load += new System.EventHandler(this.FrmMovie_Load);
            this.paneFilter.ResumeLayout(false);
            this.paneFilter.PerformLayout();
            this.panelListMovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListMovie)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneFilter;
        private FontAwesome.Sharp.IconButton btnCreate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.Panel panelListMovie;
        private System.Windows.Forms.DataGridView dgvListMovie;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ComboBox cbTheLoai;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cbDinhDang;
    }
}