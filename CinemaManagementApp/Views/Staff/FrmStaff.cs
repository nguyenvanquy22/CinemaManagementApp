﻿using CinemaManagementApp.Views.Admin;
using CinemaManagementApp.Views.Login;
using CinemaManagementApp.Views.Staff.ChildForm;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagementApp.Views.Staff
{
    public partial class FrmStaff : Form
    {
		// Fields
		FrmOrder frmOrder;
		private IconButton currBtn;
		private Panel leftBorderBtn;
		private Form currChildForm;
        List<string> emptyList = new List<string>();
		FrmLogin frmLogin;
		private string nameStaff;

        // Constructor
        public FrmStaff(FrmLogin frmLogin, string name)
        {
            InitializeComponent();
			this.nameStaff = name;
			this.frmLogin = frmLogin;
			leftBorderBtn = new Panel();
			leftBorderBtn.Size = new Size(7, 50);
			panelMenu.Controls.Add(leftBorderBtn);
		}

		private void FrmStaff_Load(object sender, EventArgs e)
		{
			lblUsername.Text = this.nameStaff;

            ActivateButton(IBtnMovie, RGBColors.color1);
            OpenChildForm(new FrmMovie());
        }

		// Struct color
		private struct RGBColors
		{
			public static Color color1 = Color.FromArgb(172, 126, 241);
			public static Color color2 = Color.FromArgb(249, 118, 176);
			public static Color color3 = Color.FromArgb(253, 138, 114);
			public static Color color4 = Color.FromArgb(95, 77, 221);
			public static Color color5 = Color.FromArgb(249, 88, 155);
			public static Color color6 = Color.FromArgb(24, 161, 251);
			public static Color color7 = Color.FromArgb(4, 255, 251);
			public static Color color8 = Color.FromArgb(251, 188, 4);
		}

		// Methods
		private void ActivateButton(object senderBtn, Color color)
		{
			if (senderBtn != null)
			{
				DisableButton();
				// Button
				currBtn = (IconButton)senderBtn;
				currBtn.BackColor = Color.FromArgb(37, 36, 81);
				currBtn.ForeColor = color;
				currBtn.TextAlign = ContentAlignment.MiddleCenter;
				currBtn.IconColor = color;
				currBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
				currBtn.ImageAlign = ContentAlignment.MiddleRight;
				// Left border button
				leftBorderBtn.BackColor = color;
				leftBorderBtn.Location = new Point(0, currBtn.Location.Y);
				leftBorderBtn.Visible = true;
				leftBorderBtn.BringToFront();
				// Current Child Form Icon
				iconCurrChildForm.IconChar = currBtn.IconChar;
				iconCurrChildForm.IconColor = color;
				// Current Title
				lblTitleChildForm.Text = currBtn.Text;
			}
		}

		private void DisableButton()
		{
			if (currBtn != null)
			{
				currBtn.BackColor = System.Drawing.Color.FromArgb(31, 30, 68);
				currBtn.ForeColor = Color.Gainsboro;
				currBtn.TextAlign = ContentAlignment.MiddleLeft;
				currBtn.IconColor = Color.Gainsboro;
				currBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
				currBtn.ImageAlign = ContentAlignment.MiddleLeft;
			}
		}

		private void OpenChildForm(Form childForm)
		{
			if (currChildForm != null)
			{
				currChildForm.Close();
			}
			currChildForm = childForm;
			childForm.TopLevel = false;
			childForm.FormBorderStyle = FormBorderStyle.None;
			childForm.Dock = DockStyle.Fill;
			panelDesktop.Controls.Add(childForm);
			panelDesktop.Tag = childForm;
			childForm.BringToFront();
			childForm.Show();
			//lblTitleChildForm.Text = childForm.Text;
		}

		// Menu button click
		private void IBtnMovie_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color1);
			OpenChildForm(new ChildForm.FrmMovie());
		}

		private void IBtnProduct_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color3);
            OpenChildForm(new ChildForm.FrmOrderFood(emptyList, "", frmOrder));
        }

		private void IBtnProblem_Click(object sender, EventArgs e)
		{
			ActivateButton(sender, RGBColors.color8);
			OpenChildForm(new ChildForm.FrmProblem());
		}

		private void IBtnLogout_Click_1(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn đăng xuất không?","Thông báo!",MessageBoxButtons.YesNo) == DialogResult.Yes) 
			{
				this.Dispose();
				this.frmLogin.Show();
				this.Close();
			}
		}

        private void FrmStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
			Application.Exit();
        }
    }
}
