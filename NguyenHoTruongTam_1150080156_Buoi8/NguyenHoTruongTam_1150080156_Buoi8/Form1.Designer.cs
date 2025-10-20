namespace NguyenHoTruongTam_1150080156_Buoi8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colMaXB = new System.Windows.Forms.ColumnHeader();
            this.colTenXB = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblMaXB = new System.Windows.Forms.Label();
            this.lblTenXB = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaXB,
            this.colTenXB,
            this.colDiaChi});
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(20, 20);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(550, 220);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);

            // 
            // colMaXB
            // 
            this.colMaXB.Text = "Mã XB";
            this.colMaXB.Width = 100;

            // 
            // colTenXB
            // 
            this.colTenXB.Text = "Tên Nhà Xuất Bản";
            this.colTenXB.Width = 200;

            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 230;

            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(120, 270);
            this.txtMaXB.Name = "txtMaXB";
            this.txtMaXB.Size = new System.Drawing.Size(200, 23);
            this.txtMaXB.TabIndex = 1;

            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(120, 310);
            this.txtTenXB.Name = "txtTenXB";
            this.txtTenXB.Size = new System.Drawing.Size(450, 23);
            this.txtTenXB.TabIndex = 2;

            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(120, 350);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(450, 23);
            this.txtDiaChi.TabIndex = 3;

            // 
            // lblMaXB
            // 
            this.lblMaXB.AutoSize = true;
            this.lblMaXB.Location = new System.Drawing.Point(40, 273);
            this.lblMaXB.Name = "lblMaXB";
            this.lblMaXB.Size = new System.Drawing.Size(45, 15);
            this.lblMaXB.TabIndex = 4;
            this.lblMaXB.Text = "Mã XB:";

            // 
            // lblTenXB
            // 
            this.lblTenXB.AutoSize = true;
            this.lblTenXB.Location = new System.Drawing.Point(40, 313);
            this.lblTenXB.Name = "lblTenXB";
            this.lblTenXB.Size = new System.Drawing.Size(49, 15);
            this.lblTenXB.TabIndex = 5;
            this.lblTenXB.Text = "Tên XB:";

            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(40, 353);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 15);
            this.lblDiaChi.TabIndex = 6;
            this.lblDiaChi.Text = "Địa chỉ:";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblTenXB);
            this.Controls.Add(this.lblMaXB);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenXB);
            this.Controls.Add(this.txtMaXB);
            this.Controls.Add(this.lsvDanhSach);
            this.Name = "Form1";
            this.Text = "Quản lý Nhà Xuất Bản_NguyenHoTruongTam_1150080156";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colMaXB;
        private System.Windows.Forms.ColumnHeader colTenXB;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblMaXB;
        private System.Windows.Forms.Label lblTenXB;
        private System.Windows.Forms.Label lblDiaChi;
    }
}