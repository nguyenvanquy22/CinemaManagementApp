namespace CinemaManagementApp.Views.Admin
{
    partial class FrmAdmin
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.IBtnLogout = new FontAwesome.Sharp.IconButton();
            this.IBtnProblem = new FontAwesome.Sharp.IconButton();
            this.IBtnHistory = new FontAwesome.Sharp.IconButton();
            this.IBtnStatistic = new FontAwesome.Sharp.IconButton();
            this.IBtnCustomer = new FontAwesome.Sharp.IconButton();
            this.IBtnStaff = new FontAwesome.Sharp.IconButton();
            this.IBtnProduct = new FontAwesome.Sharp.IconButton();
            this.IBtnShow = new FontAwesome.Sharp.IconButton();
            this.IBtnMovie = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblAdminName = new System.Windows.Forms.Label();
            this.iconAdminName = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAdminName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.IBtnLogout);
            this.panelMenu.Controls.Add(this.IBtnProblem);
            this.panelMenu.Controls.Add(this.IBtnHistory);
            this.panelMenu.Controls.Add(this.IBtnStatistic);
            this.panelMenu.Controls.Add(this.IBtnCustomer);
            this.panelMenu.Controls.Add(this.IBtnStaff);
            this.panelMenu.Controls.Add(this.IBtnProduct);
            this.panelMenu.Controls.Add(this.IBtnShow);
            this.panelMenu.Controls.Add(this.IBtnMovie);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 654);
            this.panelMenu.TabIndex = 0;
            // 
            // IBtnLogout
            // 
            this.IBtnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtnLogout.FlatAppearance.BorderSize = 0;
            this.IBtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnLogout.ForeColor = System.Drawing.Color.Gainsboro;
            this.IBtnLogout.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.IBtnLogout.IconColor = System.Drawing.Color.Gainsboro;
            this.IBtnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnLogout.IconSize = 32;
            this.IBtnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnLogout.Location = new System.Drawing.Point(0, 520);
            this.IBtnLogout.Name = "IBtnLogout";
            this.IBtnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnLogout.Size = new System.Drawing.Size(220, 50);
            this.IBtnLogout.TabIndex = 9;
            this.IBtnLogout.Text = "Đăng xuất";
            this.IBtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnLogout.UseVisualStyleBackColor = true;
            this.IBtnLogout.Click += new System.EventHandler(this.IBtnLogout_Click);
            // 
            // IBtnProblem
            // 
            this.IBtnProblem.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtnProblem.FlatAppearance.BorderSize = 0;
            this.IBtnProblem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnProblem.ForeColor = System.Drawing.Color.Gainsboro;
            this.IBtnProblem.IconChar = FontAwesome.Sharp.IconChar.ExclamationCircle;
            this.IBtnProblem.IconColor = System.Drawing.Color.Gainsboro;
            this.IBtnProblem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnProblem.IconSize = 32;
            this.IBtnProblem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnProblem.Location = new System.Drawing.Point(0, 470);
            this.IBtnProblem.Name = "IBtnProblem";
            this.IBtnProblem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnProblem.Size = new System.Drawing.Size(220, 50);
            this.IBtnProblem.TabIndex = 8;
            this.IBtnProblem.Text = "Sự cố";
            this.IBtnProblem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnProblem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnProblem.UseVisualStyleBackColor = true;
            this.IBtnProblem.Click += new System.EventHandler(this.IBtnProblem_Click);
            // 
            // IBtnHistory
            // 
            this.IBtnHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtnHistory.FlatAppearance.BorderSize = 0;
            this.IBtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnHistory.ForeColor = System.Drawing.Color.Gainsboro;
            this.IBtnHistory.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            this.IBtnHistory.IconColor = System.Drawing.Color.Gainsboro;
            this.IBtnHistory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnHistory.IconSize = 32;
            this.IBtnHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnHistory.Location = new System.Drawing.Point(0, 420);
            this.IBtnHistory.Name = "IBtnHistory";
            this.IBtnHistory.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnHistory.Size = new System.Drawing.Size(220, 50);
            this.IBtnHistory.TabIndex = 7;
            this.IBtnHistory.Text = "Lịch sử";
            this.IBtnHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnHistory.UseVisualStyleBackColor = true;
            this.IBtnHistory.Click += new System.EventHandler(this.IBtnHistory_Click);
            // 
            // IBtnStatistic
            // 
            this.IBtnStatistic.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtnStatistic.FlatAppearance.BorderSize = 0;
            this.IBtnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnStatistic.ForeColor = System.Drawing.Color.Gainsboro;
            this.IBtnStatistic.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            this.IBtnStatistic.IconColor = System.Drawing.Color.Gainsboro;
            this.IBtnStatistic.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnStatistic.IconSize = 32;
            this.IBtnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnStatistic.Location = new System.Drawing.Point(0, 370);
            this.IBtnStatistic.Name = "IBtnStatistic";
            this.IBtnStatistic.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnStatistic.Size = new System.Drawing.Size(220, 50);
            this.IBtnStatistic.TabIndex = 6;
            this.IBtnStatistic.Text = "Thống kê";
            this.IBtnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnStatistic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnStatistic.UseVisualStyleBackColor = true;
            this.IBtnStatistic.Click += new System.EventHandler(this.IBtnStatistic_Click);
            // 
            // IBtnCustomer
            // 
            this.IBtnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtnCustomer.FlatAppearance.BorderSize = 0;
            this.IBtnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnCustomer.ForeColor = System.Drawing.Color.Gainsboro;
            this.IBtnCustomer.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.IBtnCustomer.IconColor = System.Drawing.Color.Gainsboro;
            this.IBtnCustomer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnCustomer.IconSize = 32;
            this.IBtnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnCustomer.Location = new System.Drawing.Point(0, 320);
            this.IBtnCustomer.Name = "IBtnCustomer";
            this.IBtnCustomer.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnCustomer.Size = new System.Drawing.Size(220, 50);
            this.IBtnCustomer.TabIndex = 5;
            this.IBtnCustomer.Text = "Quản lý khách hàng";
            this.IBtnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnCustomer.UseVisualStyleBackColor = true;
            this.IBtnCustomer.Click += new System.EventHandler(this.IBtnCustomer_Click);
            // 
            // IBtnStaff
            // 
            this.IBtnStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtnStaff.FlatAppearance.BorderSize = 0;
            this.IBtnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnStaff.ForeColor = System.Drawing.Color.Gainsboro;
            this.IBtnStaff.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.IBtnStaff.IconColor = System.Drawing.Color.Gainsboro;
            this.IBtnStaff.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnStaff.IconSize = 32;
            this.IBtnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnStaff.Location = new System.Drawing.Point(0, 270);
            this.IBtnStaff.Name = "IBtnStaff";
            this.IBtnStaff.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnStaff.Size = new System.Drawing.Size(220, 50);
            this.IBtnStaff.TabIndex = 4;
            this.IBtnStaff.Text = "Quản lý nhân sự";
            this.IBtnStaff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnStaff.UseVisualStyleBackColor = true;
            this.IBtnStaff.Click += new System.EventHandler(this.IBtnStaff_Click);
            // 
            // IBtnProduct
            // 
            this.IBtnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtnProduct.FlatAppearance.BorderSize = 0;
            this.IBtnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnProduct.ForeColor = System.Drawing.Color.Gainsboro;
            this.IBtnProduct.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.IBtnProduct.IconColor = System.Drawing.Color.Gainsboro;
            this.IBtnProduct.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnProduct.IconSize = 32;
            this.IBtnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnProduct.Location = new System.Drawing.Point(0, 220);
            this.IBtnProduct.Name = "IBtnProduct";
            this.IBtnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnProduct.Size = new System.Drawing.Size(220, 50);
            this.IBtnProduct.TabIndex = 3;
            this.IBtnProduct.Text = "Quản lý sản phẩm";
            this.IBtnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnProduct.UseVisualStyleBackColor = true;
            this.IBtnProduct.Click += new System.EventHandler(this.IBtnProduct_Click);
            // 
            // IBtnShow
            // 
            this.IBtnShow.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtnShow.FlatAppearance.BorderSize = 0;
            this.IBtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.IBtnShow.IconChar = FontAwesome.Sharp.IconChar.Ticket;
            this.IBtnShow.IconColor = System.Drawing.Color.Gainsboro;
            this.IBtnShow.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnShow.IconSize = 32;
            this.IBtnShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnShow.Location = new System.Drawing.Point(0, 170);
            this.IBtnShow.Name = "IBtnShow";
            this.IBtnShow.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnShow.Size = new System.Drawing.Size(220, 50);
            this.IBtnShow.TabIndex = 2;
            this.IBtnShow.Text = "Quản lý suất chiếu";
            this.IBtnShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnShow.UseVisualStyleBackColor = true;
            this.IBtnShow.Click += new System.EventHandler(this.IBtnShow_Click);
            // 
            // IBtnMovie
            // 
            this.IBtnMovie.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBtnMovie.FlatAppearance.BorderSize = 0;
            this.IBtnMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBtnMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBtnMovie.ForeColor = System.Drawing.Color.Gainsboro;
            this.IBtnMovie.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.IBtnMovie.IconColor = System.Drawing.Color.Gainsboro;
            this.IBtnMovie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBtnMovie.IconSize = 32;
            this.IBtnMovie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnMovie.Location = new System.Drawing.Point(0, 120);
            this.IBtnMovie.Name = "IBtnMovie";
            this.IBtnMovie.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnMovie.Size = new System.Drawing.Size(220, 50);
            this.IBtnMovie.TabIndex = 1;
            this.IBtnMovie.Text = "Quản lý phim";
            this.IBtnMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnMovie.UseVisualStyleBackColor = true;
            this.IBtnMovie.Click += new System.EventHandler(this.IBtnMovie_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.panelLogo.Size = new System.Drawing.Size(220, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitle.Controls.Add(this.lblAdminName);
            this.panelTitle.Controls.Add(this.iconAdminName);
            this.panelTitle.Controls.Add(this.lblTitleChildForm);
            this.panelTitle.Controls.Add(this.iconCurrChildForm);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1014, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // lblAdminName
            // 
            this.lblAdminName.AutoSize = true;
            this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAdminName.Location = new System.Drawing.Point(788, 31);
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(115, 20);
            this.lblAdminName.TabIndex = 3;
            this.lblAdminName.Text = "Admin Name";
            // 
            // iconAdminName
            // 
            this.iconAdminName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconAdminName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAdminName.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconAdminName.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconAdminName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconAdminName.IconSize = 40;
            this.iconAdminName.Location = new System.Drawing.Point(742, 22);
            this.iconAdminName.Name = "iconAdminName";
            this.iconAdminName.Size = new System.Drawing.Size(40, 40);
            this.iconAdminName.TabIndex = 2;
            this.iconAdminName.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitleChildForm.Location = new System.Drawing.Point(68, 31);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(64, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "HOME";
            // 
            // iconCurrChildForm
            // 
            this.iconCurrChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrChildForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconCurrChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrChildForm.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconCurrChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrChildForm.IconSize = 40;
            this.iconCurrChildForm.Location = new System.Drawing.Point(22, 22);
            this.iconCurrChildForm.Name = "iconCurrChildForm";
            this.iconCurrChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrChildForm.TabIndex = 0;
            this.iconCurrChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 80);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1014, 8);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 88);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1014, 566);
            this.panelDesktop.TabIndex = 3;
            // 
            // FrmAdmin
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1234, 654);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconAdminName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton IBtnMovie;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton IBtnLogout;
        private FontAwesome.Sharp.IconButton IBtnProblem;
        private FontAwesome.Sharp.IconButton IBtnHistory;
        private FontAwesome.Sharp.IconButton IBtnStatistic;
        private FontAwesome.Sharp.IconButton IBtnCustomer;
        private FontAwesome.Sharp.IconButton IBtnStaff;
        private FontAwesome.Sharp.IconButton IBtnProduct;
        private FontAwesome.Sharp.IconButton IBtnShow;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private FontAwesome.Sharp.IconPictureBox iconAdminName;
        private System.Windows.Forms.Label lblAdminName;
    }
}