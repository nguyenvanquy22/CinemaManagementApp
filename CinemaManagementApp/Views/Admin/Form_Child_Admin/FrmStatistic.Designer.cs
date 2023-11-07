namespace CinemaManagementApp.Views.Admin.Form_Child
{
    partial class FrmStatistic
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
            this.panelTab = new System.Windows.Forms.Panel();
            this.tabTrend = new System.Windows.Forms.Button();
            this.tabRatings = new System.Windows.Forms.Button();
            this.tabIOcomeTotal = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTab.Controls.Add(this.tabTrend);
            this.panelTab.Controls.Add(this.tabRatings);
            this.panelTab.Controls.Add(this.tabIOcomeTotal);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTab.Location = new System.Drawing.Point(0, 0);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(982, 48);
            this.panelTab.TabIndex = 0;
            // 
            // tabTrend
            // 
            this.tabTrend.BackColor = System.Drawing.Color.Gainsboro;
            this.tabTrend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabTrend.FlatAppearance.BorderSize = 0;
            this.tabTrend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabTrend.Location = new System.Drawing.Point(248, 0);
            this.tabTrend.Margin = new System.Windows.Forms.Padding(0);
            this.tabTrend.Name = "tabTrend";
            this.tabTrend.Size = new System.Drawing.Size(120, 48);
            this.tabTrend.TabIndex = 2;
            this.tabTrend.Text = "Xu hướng";
            this.tabTrend.UseVisualStyleBackColor = false;
            this.tabTrend.Click += new System.EventHandler(this.tabTrend_Click);
            // 
            // tabRatings
            // 
            this.tabRatings.BackColor = System.Drawing.Color.Gainsboro;
            this.tabRatings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabRatings.FlatAppearance.BorderSize = 0;
            this.tabRatings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabRatings.Location = new System.Drawing.Point(120, 0);
            this.tabRatings.Margin = new System.Windows.Forms.Padding(0);
            this.tabRatings.Name = "tabRatings";
            this.tabRatings.Size = new System.Drawing.Size(128, 48);
            this.tabRatings.TabIndex = 1;
            this.tabRatings.Text = "Bảng xếp hạng";
            this.tabRatings.UseVisualStyleBackColor = false;
            this.tabRatings.Click += new System.EventHandler(this.tabRatings_Click);
            // 
            // tabIOcomeTotal
            // 
            this.tabIOcomeTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabIOcomeTotal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabIOcomeTotal.FlatAppearance.BorderSize = 0;
            this.tabIOcomeTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabIOcomeTotal.Location = new System.Drawing.Point(0, 0);
            this.tabIOcomeTotal.Margin = new System.Windows.Forms.Padding(0);
            this.tabIOcomeTotal.Name = "tabIOcomeTotal";
            this.tabIOcomeTotal.Size = new System.Drawing.Size(120, 48);
            this.tabIOcomeTotal.TabIndex = 0;
            this.tabIOcomeTotal.Text = "Tổng thu chi";
            this.tabIOcomeTotal.UseVisualStyleBackColor = false;
            this.tabIOcomeTotal.Click += new System.EventHandler(this.tabIOcomeTotal_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 48);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(982, 505);
            this.panelContent.TabIndex = 1;
            // 
            // FrmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTab);
            this.Name = "FrmStatistic";
            this.Text = "Thống kê";
            this.panelTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button tabIOcomeTotal;
        private System.Windows.Forms.Button tabTrend;
        private System.Windows.Forms.Button tabRatings;
    }
}