using CinemaManagementApp.Views.Admin.Form_Child_Admin.Form_Child_Statistic;
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
    public partial class FrmStatistic : Form
    {
        private Form currChildForm;
        public FrmStatistic()
        {
            InitializeComponent();
            OpenChildForm(new FrmIOcomeTotal());
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
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void tabIOcomeTotal_Click(object sender, EventArgs e)
        {
            tabIOcomeTotal.BackColor = Color.WhiteSmoke;
            tabRatings.BackColor = Color.Gainsboro;
            tabTrend.BackColor = Color.Gainsboro;
            OpenChildForm(new FrmIOcomeTotal());
        }

        private void tabRatings_Click(object sender, EventArgs e)
        {
            tabIOcomeTotal.BackColor = Color.Gainsboro;
            tabRatings.BackColor = Color.WhiteSmoke;
            tabTrend.BackColor = Color.Gainsboro;
            OpenChildForm(new FrmRatings());
        }

        private void tabTrend_Click(object sender, EventArgs e)
        {
            tabIOcomeTotal.BackColor = Color.Gainsboro;
            tabRatings.BackColor = Color.Gainsboro;
            tabTrend.BackColor = Color.WhiteSmoke;
            OpenChildForm(new FrmTrend());
        }
    }
}
