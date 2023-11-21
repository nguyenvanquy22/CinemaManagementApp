namespace CinemaManagementApp.Views.Admin.Form_Child_Admin.Form_Modal
{
    partial class FrmModalDetailInvoice
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTongGia = new System.Windows.Forms.Label();
            this.lblNgay = new System.Windows.Forms.Label();
            this.lblDoitac = new System.Windows.Forms.Label();
            this.lblNhanvien = new System.Windows.Forms.Label();
            this.panelVe = new System.Windows.Forms.Panel();
            this.dgvVE = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelProds = new System.Windows.Forms.Panel();
            this.dgvCTHDB = new System.Windows.Forms.DataGridView();
            this.lblSDT = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelVe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVE)).BeginInit();
            this.panelProds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDB)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 77);
            this.panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(128, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 29);
            this.lblTitle.TabIndex = 61;
            this.lblTitle.Text = "Chi tiết hóa đơn";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(766, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 23);
            this.btnClose.TabIndex = 60;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblSDT);
            this.panel2.Controls.Add(this.lblTongGia);
            this.panel2.Controls.Add(this.lblNgay);
            this.panel2.Controls.Add(this.lblDoitac);
            this.panel2.Controls.Add(this.lblNhanvien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 431);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 169);
            this.panel2.TabIndex = 1;
            // 
            // lblTongGia
            // 
            this.lblTongGia.AutoSize = true;
            this.lblTongGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGia.Location = new System.Drawing.Point(427, 122);
            this.lblTongGia.Name = "lblTongGia";
            this.lblTongGia.Size = new System.Drawing.Size(53, 20);
            this.lblTongGia.TabIndex = 3;
            this.lblTongGia.Text = "label1";
            // 
            // lblNgay
            // 
            this.lblNgay.AutoSize = true;
            this.lblNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgay.Location = new System.Drawing.Point(26, 30);
            this.lblNgay.Name = "lblNgay";
            this.lblNgay.Size = new System.Drawing.Size(53, 20);
            this.lblNgay.TabIndex = 2;
            this.lblNgay.Text = "label1";
            // 
            // lblDoitac
            // 
            this.lblDoitac.AutoSize = true;
            this.lblDoitac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoitac.Location = new System.Drawing.Point(427, 30);
            this.lblDoitac.Name = "lblDoitac";
            this.lblDoitac.Size = new System.Drawing.Size(53, 20);
            this.lblDoitac.TabIndex = 1;
            this.lblDoitac.Text = "label1";
            // 
            // lblNhanvien
            // 
            this.lblNhanvien.AutoSize = true;
            this.lblNhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanvien.Location = new System.Drawing.Point(26, 74);
            this.lblNhanvien.Name = "lblNhanvien";
            this.lblNhanvien.Size = new System.Drawing.Size(53, 20);
            this.lblNhanvien.TabIndex = 0;
            this.lblNhanvien.Text = "label1";
            // 
            // panelVe
            // 
            this.panelVe.Controls.Add(this.dgvVE);
            this.panelVe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelVe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelVe.Location = new System.Drawing.Point(0, 268);
            this.panelVe.Name = "panelVe";
            this.panelVe.Size = new System.Drawing.Size(800, 163);
            this.panelVe.TabIndex = 2;
            // 
            // dgvVE
            // 
            this.dgvVE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVE.Location = new System.Drawing.Point(0, 0);
            this.dgvVE.Name = "dgvVE";
            this.dgvVE.RowHeadersWidth = 51;
            this.dgvVE.RowTemplate.Height = 24;
            this.dgvVE.Size = new System.Drawing.Size(800, 163);
            this.dgvVE.TabIndex = 1;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter1.Location = new System.Drawing.Point(0, 258);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(800, 10);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // panelProds
            // 
            this.panelProds.Controls.Add(this.dgvCTHDB);
            this.panelProds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProds.Location = new System.Drawing.Point(0, 77);
            this.panelProds.Name = "panelProds";
            this.panelProds.Size = new System.Drawing.Size(800, 181);
            this.panelProds.TabIndex = 5;
            // 
            // dgvCTHDB
            // 
            this.dgvCTHDB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCTHDB.Location = new System.Drawing.Point(0, 0);
            this.dgvCTHDB.Name = "dgvCTHDB";
            this.dgvCTHDB.RowHeadersWidth = 51;
            this.dgvCTHDB.RowTemplate.Height = 24;
            this.dgvCTHDB.Size = new System.Drawing.Size(800, 181);
            this.dgvCTHDB.TabIndex = 0;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(427, 74);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(53, 20);
            this.lblSDT.TabIndex = 4;
            this.lblSDT.Text = "label1";
            // 
            // FrmModalDetailInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.panelProds);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelVe);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModalDetailInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModalDetailInvoice";
            this.Load += new System.EventHandler(this.FrmModalDetailInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelVe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVE)).EndInit();
            this.panelProds.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHDB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelVe;
        private System.Windows.Forms.DataGridView dgvVE;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelProds;
        private System.Windows.Forms.DataGridView dgvCTHDB;
        private System.Windows.Forms.Label lblNhanvien;
        private System.Windows.Forms.Label lblTongGia;
        private System.Windows.Forms.Label lblNgay;
        private System.Windows.Forms.Label lblDoitac;
        private System.Windows.Forms.Label lblSDT;
    }
}