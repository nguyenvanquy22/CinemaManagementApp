namespace CinemaManagementApp.Views.Admin.Form_Child
{
    partial class FrmStaff
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
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnCreate = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelListStaff = new System.Windows.Forms.Panel();
            this.dgvListStaff = new System.Windows.Forms.DataGridView();
            this.paneFilter.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelListStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // paneFilter
            // 
            this.paneFilter.Controls.Add(this.cbChucVu);
            this.paneFilter.Controls.Add(this.txtSearch);
            this.paneFilter.Controls.Add(this.btnSearch);
            this.paneFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneFilter.Location = new System.Drawing.Point(0, 0);
            this.paneFilter.Name = "paneFilter";
            this.paneFilter.Size = new System.Drawing.Size(982, 62);
            this.paneFilter.TabIndex = 5;
            // 
            // cbChucVu
            // 
            this.cbChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(840, 15);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(130, 28);
            this.cbChucVu.TabIndex = 9;
            this.cbChucVu.SelectedIndexChanged += new System.EventHandler(this.cbChucVu_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(29, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Tag = "";
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 28;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(268, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 36);
            this.btnSearch.TabIndex = 7;
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
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnDelete);
            this.panelControl.Controls.Add(this.btnCreate);
            this.panelControl.Controls.Add(this.btnUpdate);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 489);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(982, 64);
            this.panelControl.TabIndex = 7;
            // 
            // panelListStaff
            // 
            this.panelListStaff.Controls.Add(this.dgvListStaff);
            this.panelListStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListStaff.Location = new System.Drawing.Point(0, 62);
            this.panelListStaff.Name = "panelListStaff";
            this.panelListStaff.Size = new System.Drawing.Size(982, 427);
            this.panelListStaff.TabIndex = 8;
            // 
            // dgvListStaff
            // 
            this.dgvListStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListStaff.Location = new System.Drawing.Point(0, 0);
            this.dgvListStaff.Name = "dgvListStaff";
            this.dgvListStaff.RowHeadersWidth = 51;
            this.dgvListStaff.RowTemplate.Height = 24;
            this.dgvListStaff.Size = new System.Drawing.Size(982, 427);
            this.dgvListStaff.TabIndex = 0;
            this.dgvListStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListStaff_CellClick);
            this.dgvListStaff.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListStaff_CellDoubleClick);
            // 
            // FrmStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panelListStaff);
            this.Controls.Add(this.paneFilter);
            this.Controls.Add(this.panelControl);
            this.Name = "FrmStaff";
            this.Text = "Quản lý nhân sự";
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.paneFilter.ResumeLayout(false);
            this.paneFilter.PerformLayout();
            this.panelControl.ResumeLayout(false);
            this.panelListStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paneFilter;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnCreate;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panelListStaff;
        private System.Windows.Forms.DataGridView dgvListStaff;
    }
}