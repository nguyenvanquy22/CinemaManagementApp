namespace CinemaManagementApp.Views.Login
{
    partial class FrmLogin
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
			this.ptBMovie = new System.Windows.Forms.PictureBox();
			this.panelLogin = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblForgotPassword = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.IcPassword = new FontAwesome.Sharp.IconPictureBox();
			this.icPUsername = new FontAwesome.Sharp.IconPictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ptBMovie)).BeginInit();
			this.panelLogin.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IcPassword)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.icPUsername)).BeginInit();
			this.SuspendLayout();
			// 
			// ptBMovie
			// 
			this.ptBMovie.Dock = System.Windows.Forms.DockStyle.Left;
			this.ptBMovie.Location = new System.Drawing.Point(0, 0);
			this.ptBMovie.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.ptBMovie.Name = "ptBMovie";
			this.ptBMovie.Size = new System.Drawing.Size(334, 453);
			this.ptBMovie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ptBMovie.TabIndex = 0;
			this.ptBMovie.TabStop = false;
			// 
			// panelLogin
			// 
			this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panelLogin.Controls.Add(this.panel1);
			this.panelLogin.Controls.Add(this.label1);
			this.panelLogin.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLogin.Location = new System.Drawing.Point(334, 0);
			this.panelLogin.Name = "panelLogin";
			this.panelLogin.Size = new System.Drawing.Size(648, 453);
			this.panelLogin.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnLogin);
			this.panel1.Controls.Add(this.lblForgotPassword);
			this.panel1.Controls.Add(this.txtPassword);
			this.panel1.Controls.Add(this.txtUsername);
			this.panel1.Controls.Add(this.IcPassword);
			this.panel1.Controls.Add(this.icPUsername);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 117);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(644, 332);
			this.panel1.TabIndex = 1;
			// 
			// lblForgotPassword
			// 
			this.lblForgotPassword.AutoSize = true;
			this.lblForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblForgotPassword.ForeColor = System.Drawing.Color.Blue;
			this.lblForgotPassword.Location = new System.Drawing.Point(349, 165);
			this.lblForgotPassword.Name = "lblForgotPassword";
			this.lblForgotPassword.Size = new System.Drawing.Size(157, 25);
			this.lblForgotPassword.TabIndex = 4;
			this.lblForgotPassword.Text = "Quên mật khẩu?";
			this.lblForgotPassword.MouseEnter += new System.EventHandler(this.lblForgotPassword_MouseEnter_1);
			this.lblForgotPassword.MouseLeave += new System.EventHandler(this.lblForgotPassword_MouseLeave);
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(171, 101);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(335, 30);
			this.txtPassword.TabIndex = 3;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(171, 35);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(335, 30);
			this.txtUsername.TabIndex = 2;
			// 
			// IcPassword
			// 
			this.IcPassword.BackColor = System.Drawing.Color.White;
			this.IcPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			this.IcPassword.ForeColor = System.Drawing.SystemColors.ControlText;
			this.IcPassword.IconChar = FontAwesome.Sharp.IconChar.Lock;
			this.IcPassword.IconColor = System.Drawing.SystemColors.ControlText;
			this.IcPassword.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.IcPassword.Location = new System.Drawing.Point(106, 99);
			this.IcPassword.Name = "IcPassword";
			this.IcPassword.Size = new System.Drawing.Size(32, 32);
			this.IcPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.IcPassword.TabIndex = 1;
			this.IcPassword.TabStop = false;
			this.IcPassword.Click += new System.EventHandler(this.IcPassword_Click);
			// 
			// icPUsername
			// 
			this.icPUsername.BackColor = System.Drawing.Color.White;
			this.icPUsername.Cursor = System.Windows.Forms.Cursors.Hand;
			this.icPUsername.ForeColor = System.Drawing.SystemColors.ControlText;
			this.icPUsername.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
			this.icPUsername.IconColor = System.Drawing.SystemColors.ControlText;
			this.icPUsername.IconFont = FontAwesome.Sharp.IconFont.Auto;
			this.icPUsername.Location = new System.Drawing.Point(106, 33);
			this.icPUsername.Name = "icPUsername";
			this.icPUsername.Size = new System.Drawing.Size(32, 32);
			this.icPUsername.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.icPUsername.TabIndex = 0;
			this.icPUsername.TabStop = false;
			this.icPUsername.Click += new System.EventHandler(this.icPUsername_Click);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(644, 117);
			this.label1.TabIndex = 0;
			this.label1.Text = "WELCOME BACK";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.Blue;
			this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.ForeColor = System.Drawing.Color.White;
			this.btnLogin.Location = new System.Drawing.Point(324, 227);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(182, 50);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "Đăng nhập";
			this.btnLogin.UseVisualStyleBackColor = false;
			// 
			// FrmLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(982, 453);
			this.Controls.Add(this.panelLogin);
			this.Controls.Add(this.ptBMovie);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLogin_FormClosed);
			this.Load += new System.EventHandler(this.FrmLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.ptBMovie)).EndInit();
			this.panelLogin.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.IcPassword)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.icPUsername)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.PictureBox ptBMovie;
		private System.Windows.Forms.Panel panelLogin;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.TextBox txtUsername;
		private FontAwesome.Sharp.IconPictureBox IcPassword;
		private FontAwesome.Sharp.IconPictureBox icPUsername;
		private System.Windows.Forms.Label lblForgotPassword;
		private System.Windows.Forms.Button btnLogin;
	}
}