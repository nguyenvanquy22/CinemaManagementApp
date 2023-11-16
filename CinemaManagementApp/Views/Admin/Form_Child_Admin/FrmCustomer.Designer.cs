namespace CinemaManagementApp.Views.Admin.Form_Child
{
    partial class FrmCustomer
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
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panelListCustomer = new System.Windows.Forms.Panel();
            this.dgvListCustomer = new System.Windows.Forms.DataGridView();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.cbTimeYear = new System.Windows.Forms.ComboBox();
            this.cbTimeMonth = new System.Windows.Forms.ComboBox();
            this.paneFilter.SuspendLayout();
            this.panelListCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // paneFilter
            // 
            this.paneFilter.Controls.Add(this.cbTimeMonth);
            this.paneFilter.Controls.Add(this.cbTimeYear);
            this.paneFilter.Controls.Add(this.cbPeriod);
            this.paneFilter.Controls.Add(this.btnSearch);
            this.paneFilter.Controls.Add(this.txtSearch);
            this.paneFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.paneFilter.Location = new System.Drawing.Point(0, 0);
            this.paneFilter.Name = "paneFilter";
            this.paneFilter.Size = new System.Drawing.Size(982, 64);
            this.paneFilter.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 28;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(258, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 36);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(30, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 22);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.Tag = "";
            // 
            // panelListCustomer
            // 
            this.panelListCustomer.Controls.Add(this.dgvListCustomer);
            this.panelListCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListCustomer.Location = new System.Drawing.Point(0, 64);
            this.panelListCustomer.Name = "panelListCustomer";
            this.panelListCustomer.Size = new System.Drawing.Size(982, 489);
            this.panelListCustomer.TabIndex = 3;
            // 
            // dgvListCustomer
            // 
            this.dgvListCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListCustomer.Location = new System.Drawing.Point(0, 0);
            this.dgvListCustomer.Name = "dgvListCustomer";
            this.dgvListCustomer.RowHeadersWidth = 51;
            this.dgvListCustomer.RowTemplate.Height = 24;
            this.dgvListCustomer.Size = new System.Drawing.Size(982, 489);
            this.dgvListCustomer.TabIndex = 0;
            // 
            // cbPeriod
            // 
            this.cbPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Items.AddRange(new object[] {
            "Năm",
            "Tháng"});
            this.cbPeriod.Location = new System.Drawing.Point(684, 20);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(114, 28);
            this.cbPeriod.TabIndex = 9;
            this.cbPeriod.SelectedIndexChanged += new System.EventHandler(this.cbPeriod_SelectedIndexChanged);
            // 
            // cbTimeYear
            // 
            this.cbTimeYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeYear.FormattingEnabled = true;
            this.cbTimeYear.Location = new System.Drawing.Point(804, 20);
            this.cbTimeYear.Name = "cbTimeYear";
            this.cbTimeYear.Size = new System.Drawing.Size(80, 28);
            this.cbTimeYear.TabIndex = 10;
            this.cbTimeYear.SelectedIndexChanged += new System.EventHandler(this.cbTimeYear_SelectedIndexChanged);
            // 
            // cbTimeMonth
            // 
            this.cbTimeMonth.Enabled = false;
            this.cbTimeMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTimeMonth.FormattingEnabled = true;
            this.cbTimeMonth.Location = new System.Drawing.Point(890, 20);
            this.cbTimeMonth.Name = "cbTimeMonth";
            this.cbTimeMonth.Size = new System.Drawing.Size(80, 28);
            this.cbTimeMonth.TabIndex = 11;
            this.cbTimeMonth.SelectedIndexChanged += new System.EventHandler(this.cbTimeMonth_SelectedIndexChanged);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panelListCustomer);
            this.Controls.Add(this.paneFilter);
            this.Name = "FrmCustomer";
            this.Text = "Quản lý khách hàng";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            this.paneFilter.ResumeLayout(false);
            this.paneFilter.PerformLayout();
            this.panelListCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel paneFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panelListCustomer;
        private System.Windows.Forms.DataGridView dgvListCustomer;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.ComboBox cbTimeYear;
        private System.Windows.Forms.ComboBox cbTimeMonth;
    }
}