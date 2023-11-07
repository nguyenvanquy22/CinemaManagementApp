namespace CinemaManagementApp.Views.Staff
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.IBtnLogout = new FontAwesome.Sharp.IconButton();
            this.IBtnProblem = new FontAwesome.Sharp.IconButton();
            this.IBtnProduct = new FontAwesome.Sharp.IconButton();
            this.IBtnMovie = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.iconUsername = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsername)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.IBtnLogout);
            this.panelMenu.Controls.Add(this.IBtnProblem);
            this.panelMenu.Controls.Add(this.IBtnProduct);
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
            this.IBtnLogout.Location = new System.Drawing.Point(0, 270);
            this.IBtnLogout.Name = "IBtnLogout";
            this.IBtnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnLogout.Size = new System.Drawing.Size(220, 50);
            this.IBtnLogout.TabIndex = 10;
            this.IBtnLogout.Text = "Đăng xuất";
            this.IBtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnLogout.UseVisualStyleBackColor = true;
            this.IBtnLogout.Click += new System.EventHandler(this.IBtnLogout_Click_1);
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
            this.IBtnProblem.Location = new System.Drawing.Point(0, 220);
            this.IBtnProblem.Name = "IBtnProblem";
            this.IBtnProblem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnProblem.Size = new System.Drawing.Size(220, 50);
            this.IBtnProblem.TabIndex = 9;
            this.IBtnProblem.Text = "Báo cáo sự cố";
            this.IBtnProblem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnProblem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnProblem.UseVisualStyleBackColor = true;
            this.IBtnProblem.Click += new System.EventHandler(this.IBtnProblem_Click);
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
            this.IBtnProduct.Location = new System.Drawing.Point(0, 170);
            this.IBtnProduct.Name = "IBtnProduct";
            this.IBtnProduct.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.IBtnProduct.Size = new System.Drawing.Size(220, 50);
            this.IBtnProduct.TabIndex = 4;
            this.IBtnProduct.Text = "Đồ ăn";
            this.IBtnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBtnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBtnProduct.UseVisualStyleBackColor = true;
            this.IBtnProduct.Click += new System.EventHandler(this.IBtnProduct_Click);
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
            this.IBtnMovie.TabIndex = 2;
            this.IBtnMovie.Text = "Phim đang chiếu";
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
            this.panelLogo.Size = new System.Drawing.Size(220, 120);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitle.Controls.Add(this.panel2);
            this.panelTitle.Controls.Add(this.panel1);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(220, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1014, 80);
            this.panelTitle.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.iconUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(814, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 80);
            this.panel2.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(64, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(103, 20);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Staff Name";
            // 
            // iconUsername
            // 
            this.iconUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconUsername.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconUsername.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.iconUsername.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUsername.IconSize = 40;
            this.iconUsername.Location = new System.Drawing.Point(18, 22);
            this.iconUsername.Name = "iconUsername";
            this.iconUsername.Size = new System.Drawing.Size(40, 40);
            this.iconUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconUsername.TabIndex = 1;
            this.iconUsername.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitleChildForm);
            this.panel1.Controls.Add(this.iconCurrChildForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 80);
            this.panel1.TabIndex = 0;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(68, 31);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(148, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Phim đang chiếu";
            // 
            // iconCurrChildForm
            // 
            this.iconCurrChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrChildForm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconCurrChildForm.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.iconCurrChildForm.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconCurrChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrChildForm.IconSize = 40;
            this.iconCurrChildForm.Location = new System.Drawing.Point(22, 22);
            this.iconCurrChildForm.Name = "iconCurrChildForm";
            this.iconCurrChildForm.Size = new System.Drawing.Size(40, 40);
            this.iconCurrChildForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconCurrChildForm.TabIndex = 0;
            this.iconCurrChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1014, 574);
            this.panelDesktop.TabIndex = 2;
            // 
            // FrmStaff
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1234, 654);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "FrmStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QDCinema";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmStaff_FormClosed);
            this.Load += new System.EventHandler(this.FrmStaff_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconUsername)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Panel panelTitle;
		private FontAwesome.Sharp.IconButton IBtnMovie;
		private FontAwesome.Sharp.IconButton IBtnProduct;
		private FontAwesome.Sharp.IconButton IBtnProblem;
		private FontAwesome.Sharp.IconButton IBtnLogout;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel1;
		private FontAwesome.Sharp.IconPictureBox iconCurrChildForm;
		private FontAwesome.Sharp.IconPictureBox iconUsername;
		private System.Windows.Forms.Label lblTitleChildForm;
		private System.Windows.Forms.Label lblUsername;
		private System.Windows.Forms.Panel panelDesktop;
    }
}