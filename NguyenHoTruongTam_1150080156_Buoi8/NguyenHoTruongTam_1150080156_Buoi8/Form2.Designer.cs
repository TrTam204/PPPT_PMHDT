namespace NguyenHoTruongTam_1150080156_Buoi8
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieuDe = new System.Windows.Forms.Label();
            this.groupDanhSach = new System.Windows.Forms.GroupBox();
            this.lsvDanhSach = new System.Windows.Forms.ListView();
            this.colMa = new System.Windows.Forms.ColumnHeader();
            this.colTen = new System.Windows.Forms.ColumnHeader();
            this.colDiaChi = new System.Windows.Forms.ColumnHeader();
            this.groupNhap = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblMa = new System.Windows.Forms.Label();
            this.groupDanhSach.SuspendLayout();
            this.groupNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTieuDe.Location = new System.Drawing.Point(330, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(111, 21);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Thêm dữ liệu";
            // 
            // groupDanhSach
            // 
            this.groupDanhSach.Controls.Add(this.lsvDanhSach);
            this.groupDanhSach.Location = new System.Drawing.Point(18, 55);
            this.groupDanhSach.Name = "groupDanhSach";
            this.groupDanhSach.Size = new System.Drawing.Size(420, 270);
            this.groupDanhSach.TabIndex = 1;
            this.groupDanhSach.TabStop = false;
            this.groupDanhSach.Text = "Danh sách nhà xuất bản:";
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMa,
            this.colTen,
            this.colDiaChi});
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(12, 22);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(395, 235);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // colMa
            // 
            this.colMa.Text = "Mã NXB";
            this.colMa.Width = 90;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên NXB";
            this.colTen.Width = 150;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 150;
            // 
            // groupNhap
            // 
            this.groupNhap.Controls.Add(this.btnThem);
            this.groupNhap.Controls.Add(this.txtDiaChi);
            this.groupNhap.Controls.Add(this.txtTenXB);
            this.groupNhap.Controls.Add(this.txtMaXB);
            this.groupNhap.Controls.Add(this.lblDiaChi);
            this.groupNhap.Controls.Add(this.lblTen);
            this.groupNhap.Controls.Add(this.lblMa);
            this.groupNhap.Location = new System.Drawing.Point(454, 55);
            this.groupNhap.Name = "groupNhap";
            this.groupNhap.Size = new System.Drawing.Size(300, 270);
            this.groupNhap.TabIndex = 2;
            this.groupNhap.TabStop = false;
            this.groupNhap.Text = "Thông tin nhập liệu:";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Honeydew;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(52, 196);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(196, 40);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm nhà xuất bản";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(95, 134);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(190, 23);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(95, 96);
            this.txtTenXB.Name = "txtTenXB";
            this.txtTenXB.Size = new System.Drawing.Size(190, 23);
            this.txtTenXB.TabIndex = 4;
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(95, 58);
            this.txtMaXB.Name = "txtMaXB";
            this.txtMaXB.Size = new System.Drawing.Size(190, 23);
            this.txtMaXB.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(25, 137);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(50, 15);
            this.lblDiaChi.TabIndex = 2;
            this.lblDiaChi.Text = "Địa chỉ:";
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(25, 99);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(56, 15);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "Tên NXB:";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(25, 61);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(51, 15);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã NXB:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 345);
            this.Controls.Add(this.groupNhap);
            this.Controls.Add(this.groupDanhSach);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "Form2";
            this.Text = "Thêm dữ liệu_Nguyễn Hồ Trường Tam_1150080156";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupDanhSach.ResumeLayout(false);
            this.groupNhap.ResumeLayout(false);
            this.groupNhap.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupDanhSach;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colMa;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.GroupBox groupNhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenXB;
        private System.Windows.Forms.TextBox txtMaXB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblMa;
    }
}