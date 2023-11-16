namespace CinemaManagementApp.Views.Admin.Form_Child
{
    partial class FrmInvoice
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.btnExportFile = new FontAwesome.Sharp.IconButton();
            this.panelTab = new System.Windows.Forms.Panel();
            this.tabIncomeInvoice = new System.Windows.Forms.Button();
            this.tabOutcomeInvoice = new System.Windows.Forms.Button();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.panelListInvoice = new System.Windows.Forms.Panel();
            this.dgvListInvoice = new System.Windows.Forms.DataGridView();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.panelControl.SuspendLayout();
            this.panelTab.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelListInvoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelControl.Controls.Add(this.btnExportFile);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 489);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(982, 64);
            this.panelControl.TabIndex = 4;
            // 
            // btnExportFile
            // 
            this.btnExportFile.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.btnExportFile.IconColor = System.Drawing.Color.Black;
            this.btnExportFile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExportFile.IconSize = 28;
            this.btnExportFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportFile.Location = new System.Drawing.Point(817, 13);
            this.btnExportFile.Name = "btnExportFile";
            this.btnExportFile.Size = new System.Drawing.Size(153, 36);
            this.btnExportFile.TabIndex = 5;
            this.btnExportFile.Text = "Xuất file Excel";
            this.btnExportFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportFile.UseVisualStyleBackColor = true;
            this.btnExportFile.Click += new System.EventHandler(this.btnExportFile_Click);
            // 
            // panelTab
            // 
            this.panelTab.BackColor = System.Drawing.Color.Gainsboro;
            this.panelTab.Controls.Add(this.tabIncomeInvoice);
            this.panelTab.Controls.Add(this.tabOutcomeInvoice);
            this.panelTab.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTab.Location = new System.Drawing.Point(0, 0);
            this.panelTab.Name = "panelTab";
            this.panelTab.Size = new System.Drawing.Size(982, 48);
            this.panelTab.TabIndex = 5;
            // 
            // tabIncomeInvoice
            // 
            this.tabIncomeInvoice.BackColor = System.Drawing.Color.Gainsboro;
            this.tabIncomeInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabIncomeInvoice.FlatAppearance.BorderSize = 0;
            this.tabIncomeInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabIncomeInvoice.Location = new System.Drawing.Point(120, 0);
            this.tabIncomeInvoice.Margin = new System.Windows.Forms.Padding(0);
            this.tabIncomeInvoice.Name = "tabIncomeInvoice";
            this.tabIncomeInvoice.Size = new System.Drawing.Size(128, 48);
            this.tabIncomeInvoice.TabIndex = 1;
            this.tabIncomeInvoice.Text = "Nhập kho";
            this.tabIncomeInvoice.UseVisualStyleBackColor = false;
            this.tabIncomeInvoice.Click += new System.EventHandler(this.tabIncomeInvoice_Click);
            // 
            // tabOutcomeInvoice
            // 
            this.tabOutcomeInvoice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabOutcomeInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabOutcomeInvoice.FlatAppearance.BorderSize = 0;
            this.tabOutcomeInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabOutcomeInvoice.Location = new System.Drawing.Point(0, 0);
            this.tabOutcomeInvoice.Margin = new System.Windows.Forms.Padding(0);
            this.tabOutcomeInvoice.Name = "tabOutcomeInvoice";
            this.tabOutcomeInvoice.Size = new System.Drawing.Size(120, 48);
            this.tabOutcomeInvoice.TabIndex = 0;
            this.tabOutcomeInvoice.Text = "Hóa đơn";
            this.tabOutcomeInvoice.UseVisualStyleBackColor = false;
            this.tabOutcomeInvoice.Click += new System.EventHandler(this.tabOutcomeInvoice_Click);
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFilter.Controls.Add(this.dtpDate);
            this.panelFilter.Controls.Add(this.txtSearch);
            this.panelFilter.Controls.Add(this.btnSearch);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 48);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(982, 70);
            this.panelFilter.TabIndex = 6;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(37, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 27);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.Tag = "";
            // 
            // btnSearch
            // 
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.Black;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 28;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(260, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(116, 36);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panelListInvoice
            // 
            this.panelListInvoice.Controls.Add(this.dgvListInvoice);
            this.panelListInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelListInvoice.Location = new System.Drawing.Point(0, 118);
            this.panelListInvoice.Name = "panelListInvoice";
            this.panelListInvoice.Size = new System.Drawing.Size(982, 371);
            this.panelListInvoice.TabIndex = 7;
            // 
            // dgvListInvoice
            // 
            this.dgvListInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListInvoice.Location = new System.Drawing.Point(0, 0);
            this.dgvListInvoice.Name = "dgvListInvoice";
            this.dgvListInvoice.RowHeadersWidth = 51;
            this.dgvListInvoice.RowTemplate.Height = 24;
            this.dgvListInvoice.Size = new System.Drawing.Size(982, 371);
            this.dgvListInvoice.TabIndex = 0;
            this.dgvListInvoice.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListInvoice_CellFormatting);
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(817, 25);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(153, 27);
            this.dtpDate.TabIndex = 15;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // FrmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.panelListInvoice);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTab);
            this.Controls.Add(this.panelControl);
            this.Name = "FrmInvoice";
            this.Text = "Lịch sử";
            this.panelControl.ResumeLayout(false);
            this.panelTab.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.panelListInvoice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelControl;
        private FontAwesome.Sharp.IconButton btnExportFile;
        private System.Windows.Forms.Panel panelTab;
        private System.Windows.Forms.Button tabIncomeInvoice;
        private System.Windows.Forms.Button tabOutcomeInvoice;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btnSearch;
        private System.Windows.Forms.Panel panelListInvoice;
        private System.Windows.Forms.DataGridView dgvListInvoice;
        private System.Windows.Forms.DateTimePicker dtpDate;
    }
}