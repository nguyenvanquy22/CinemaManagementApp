namespace CinemaManagementApp.Views.Staff.ChildForm
{
	partial class FrmMovie
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dTPShowtime = new System.Windows.Forms.DateTimePicker();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iBtnPre = new FontAwesome.Sharp.IconButton();
            this.iBtnNext = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.dTPShowtime);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 110);
            this.panel1.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(774, 42);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 28);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Silver;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 107);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(944, 3);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // dTPShowtime
            // 
            this.dTPShowtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTPShowtime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPShowtime.Location = new System.Drawing.Point(492, 43);
            this.dTPShowtime.MaxDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dTPShowtime.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dTPShowtime.Name = "dTPShowtime";
            this.dTPShowtime.Size = new System.Drawing.Size(200, 27);
            this.dTPShowtime.TabIndex = 2;
            this.dTPShowtime.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dTPShowtime.ValueChanged += new System.EventHandler(this.dTPShowtime_ValueChanged);
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(341, 42);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 28);
            this.cbCategory.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(53, 42);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(249, 30);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Tên phim";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.iBtnPre);
            this.panel2.Controls.Add(this.iBtnNext);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 579);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 38);
            this.panel2.TabIndex = 1;
            // 
            // iBtnPre
            // 
            this.iBtnPre.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.iBtnPre.IconColor = System.Drawing.Color.Black;
            this.iBtnPre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnPre.IconSize = 16;
            this.iBtnPre.Location = new System.Drawing.Point(848, 6);
            this.iBtnPre.Name = "iBtnPre";
            this.iBtnPre.Size = new System.Drawing.Size(39, 23);
            this.iBtnPre.TabIndex = 1;
            this.iBtnPre.UseVisualStyleBackColor = true;
            this.iBtnPre.Click += new System.EventHandler(this.iBtnPre_Click);
            // 
            // iBtnNext
            // 
            this.iBtnNext.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.iBtnNext.IconColor = System.Drawing.Color.Black;
            this.iBtnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnNext.IconSize = 16;
            this.iBtnNext.Location = new System.Drawing.Point(893, 6);
            this.iBtnNext.Name = "iBtnNext";
            this.iBtnNext.Size = new System.Drawing.Size(39, 23);
            this.iBtnNext.TabIndex = 0;
            this.iBtnNext.UseVisualStyleBackColor = true;
            this.iBtnNext.Click += new System.EventHandler(this.iBtnNext_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 9;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4F));
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 110);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(944, 469);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // FrmMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 617);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phim đang chiếu";
            this.Load += new System.EventHandler(this.FrmMovie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dTPShowtime;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private FontAwesome.Sharp.IconButton iBtnNext;
        private FontAwesome.Sharp.IconButton iBtnPre;
        private System.Windows.Forms.Button btnSearch;
    }
}