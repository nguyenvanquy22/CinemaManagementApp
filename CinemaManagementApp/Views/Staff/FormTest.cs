using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaManagementApp.Views.Staff
{
	public partial class FormTest : Form
	{
		public FormTest()
		{
			InitializeComponent();
		}

		private void FormTest_Load(object sender, EventArgs e)
		{
			showMovies();
		}

		private void showMovies()
		{
			ChildForm.Product f = new ChildForm.Product();
			f.TopLevel = false;
			tblLPListFims.Controls.Add(f,1,1);
			f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			f.Dock = DockStyle.Fill;
			f.Show();
		}
	}
}
