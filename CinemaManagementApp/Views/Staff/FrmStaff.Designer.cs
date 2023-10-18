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
			this.panelDesktop = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.IBtnLogout = new FontAwesome.Sharp.IconButton();
			this.IBtnProblem = new FontAwesome.Sharp.IconButton();
			this.IBtnProduct = new FontAwesome.Sharp.IconButton();
			this.IBtnMovie = new FontAwesome.Sharp.IconButton();
			this.panelShadow = new System.Windows.Forms.Panel();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblAdminName = new System.Windows.Forms.Label();
			this.iconAdminName = new FontAwesome.Sharp.IconPictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblTitleChildForm = new System.Windows.Forms.Label();
			this.iconCurrChildForm = new FontAwesome.Sharp.IconPictureBox();
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.panelLogo = new System.Windows.Forms.Panel();
			this.panelDesktop.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconAdminName)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).BeginInit();
			this.panelMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelDesktop
			// 
			this.panelDesktop.BackColor = System.Drawing.Color.White;
			this.panelDesktop.Controls.Add(this.panel3);
			this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelDesktop.Location = new System.Drawing.Point(240, 88);
			this.panelDesktop.Name = "panelDesktop";
			this.panelDesktop.Size = new System.Drawing.Size(994, 566);
			this.panelDesktop.TabIndex = 7;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.splitter2);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(994, 82);
			this.panel3.TabIndex = 0;
			// 
			// splitter2
			// 
			this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.splitter2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter2.Location = new System.Drawing.Point(0, 79);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(994, 3);
			this.splitter2.TabIndex = 0;
			this.splitter2.TabStop = false;
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
			this.IBtnLogout.Size = new System.Drawing.Size(240, 50);
			this.IBtnLogout.TabIndex = 9;
			this.IBtnLogout.Text = "Đăng xuất";
			this.IBtnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.IBtnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.IBtnLogout.UseVisualStyleBackColor = true;
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
			this.IBtnProblem.Size = new System.Drawing.Size(240, 50);
			this.IBtnProblem.TabIndex = 8;
			this.IBtnProblem.Text = "Sự cố";
			this.IBtnProblem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.IBtnProblem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.IBtnProblem.UseVisualStyleBackColor = true;
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
			this.IBtnProduct.Size = new System.Drawing.Size(240, 50);
			this.IBtnProduct.TabIndex = 3;
			this.IBtnProduct.Text = "Quản lý sản phẩm";
			this.IBtnProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.IBtnProduct.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.IBtnProduct.UseVisualStyleBackColor = true;
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
			this.IBtnMovie.Size = new System.Drawing.Size(240, 50);
			this.IBtnMovie.TabIndex = 1;
			this.IBtnMovie.Text = "Quản lý phim";
			this.IBtnMovie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.IBtnMovie.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.IBtnMovie.UseVisualStyleBackColor = true;
			// 
			// panelShadow
			// 
			this.panelShadow.BackColor = System.Drawing.Color.White;
			this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelShadow.Location = new System.Drawing.Point(240, 80);
			this.panelShadow.Name = "panelShadow";
			this.panelShadow.Size = new System.Drawing.Size(994, 8);
			this.panelShadow.TabIndex = 6;
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.Color.White;
			this.panelTitle.Controls.Add(this.panel1);
			this.panelTitle.Controls.Add(this.panel2);
			this.panelTitle.Controls.Add(this.splitter1);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(240, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(994, 80);
			this.panelTitle.TabIndex = 5;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblAdminName);
			this.panel1.Controls.Add(this.iconAdminName);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(751, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(243, 77);
			this.panel1.TabIndex = 6;
			// 
			// lblAdminName
			// 
			this.lblAdminName.AutoSize = true;
			this.lblAdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblAdminName.ForeColor = System.Drawing.Color.Black;
			this.lblAdminName.Location = new System.Drawing.Point(87, 31);
			this.lblAdminName.Name = "lblAdminName";
			this.lblAdminName.Size = new System.Drawing.Size(115, 20);
			this.lblAdminName.TabIndex = 5;
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
			this.iconAdminName.Location = new System.Drawing.Point(41, 22);
			this.iconAdminName.Name = "iconAdminName";
			this.iconAdminName.Size = new System.Drawing.Size(40, 40);
			this.iconAdminName.TabIndex = 4;
			this.iconAdminName.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.lblTitleChildForm);
			this.panel2.Controls.Add(this.iconCurrChildForm);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(280, 77);
			this.panel2.TabIndex = 5;
			// 
			// lblTitleChildForm
			// 
			this.lblTitleChildForm.AutoSize = true;
			this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitleChildForm.ForeColor = System.Drawing.Color.Black;
			this.lblTitleChildForm.Location = new System.Drawing.Point(61, 31);
			this.lblTitleChildForm.Name = "lblTitleChildForm";
			this.lblTitleChildForm.Size = new System.Drawing.Size(58, 20);
			this.lblTitleChildForm.TabIndex = 3;
			this.lblTitleChildForm.Text = this.IBtnMovie.Text;
			// 
			// iconCurrChildForm
			// 
			this.iconCurrChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
			this.iconCurrChildForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.iconCurrChildForm.IconChar = FontAwesome.Sharp.IconChar.Film;
			this.iconCurrChildForm.IconColor = System.Drawing.SystemColors.ButtonFace;
			this.iconCurrChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.iconCurrChildForm.IconSize = 40;
			this.iconCurrChildForm.Location = new System.Drawing.Point(15, 22);
			this.iconCurrChildForm.Name = "iconCurrChildForm";
			this.iconCurrChildForm.Size = new System.Drawing.Size(40, 40);
			this.iconCurrChildForm.TabIndex = 2;
			this.iconCurrChildForm.TabStop = false;
			// 
			// splitter1
			// 
			this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitter1.Location = new System.Drawing.Point(0, 77);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(994, 3);
			this.splitter1.TabIndex = 0;
			this.splitter1.TabStop = false;
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
			this.panelMenu.Size = new System.Drawing.Size(240, 654);
			this.panelMenu.TabIndex = 4;
			// 
			// panelLogo
			// 
			this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelLogo.Location = new System.Drawing.Point(0, 0);
			this.panelLogo.Name = "panelLogo";
			this.panelLogo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
			this.panelLogo.Size = new System.Drawing.Size(240, 120);
			this.panelLogo.TabIndex = 0;
			// 
			// FrmStaff
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1234, 654);
			this.Controls.Add(this.panelDesktop);
			this.Controls.Add(this.panelShadow);
			this.Controls.Add(this.panelTitle);
			this.Controls.Add(this.panelMenu);
			this.Name = "FrmStaff";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QCCinema";
			this.Load += new System.EventHandler(this.FrmStaff_Load);
			this.panelDesktop.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panelTitle.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconAdminName)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.iconCurrChildForm)).EndInit();
			this.panelMenu.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Panel panelDesktop;
		private FontAwesome.Sharp.IconButton IBtnLogout;
		private FontAwesome.Sharp.IconButton IBtnProblem;
		private FontAwesome.Sharp.IconButton IBtnProduct;
		private FontAwesome.Sharp.IconButton IBtnMovie;
		private System.Windows.Forms.Panel panelShadow;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Panel panelLogo;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblAdminName;
		private FontAwesome.Sharp.IconPictureBox iconAdminName;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblTitleChildForm;
		private FontAwesome.Sharp.IconPictureBox iconCurrChildForm;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Splitter splitter2;
	}
}