namespace NguyenHoTruongTam_1150080156_Buoi8
{
    partial class Form4
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
            this.colDia = new System.Windows.Forms.ColumnHeader();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupDanhSach.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieuDe
            // 
            this.lblTieuDe.AutoSize = true;
            this.lblTieuDe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTieuDe.Location = new System.Drawing.Point(360, 18);
            this.lblTieuDe.Name = "lblTieuDe";
            this.lblTieuDe.Size = new System.Drawing.Size(98, 21);
            this.lblTieuDe.TabIndex = 0;
            this.lblTieuDe.Text = "Xóa dữ liệu";
            // 
            // groupDanhSach
            // 
            this.groupDanhSach.Controls.Add(this.lsvDanhSach);
            this.groupDanhSach.Location = new System.Drawing.Point(18, 55);
            this.groupDanhSach.Name = "groupDanhSach";
            this.groupDanhSach.Size = new System.Drawing.Size(760, 300);
            this.groupDanhSach.TabIndex = 1;
            this.groupDanhSach.TabStop = false;
            this.groupDanhSach.Text = "Danh sách nhà xuất bản:";
            // 
            // lsvDanhSach
            // 
            this.lsvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMa,
            this.colTen,
            this.colDia});
            this.lsvDanhSach.FullRowSelect = true;
            this.lsvDanhSach.GridLines = true;
            this.lsvDanhSach.HideSelection = false;
            this.lsvDanhSach.Location = new System.Drawing.Point(12, 22);
            this.lsvDanhSach.Name = "lsvDanhSach";
            this.lsvDanhSach.Size = new System.Drawing.Size(735, 265);
            this.lsvDanhSach.TabIndex = 0;
            this.lsvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lsvDanhSach.View = System.Windows.Forms.View.Details;
            this.lsvDanhSach.SelectedIndexChanged += new System.EventHandler(this.lsvDanhSach_SelectedIndexChanged);
            // 
            // colMa
            // 
            this.colMa.Text = "Mã NXB";
            this.colMa.Width = 120;
            // 
            // colTen
            // 
            this.colTen.Text = "Tên NXB";
            this.colTen.Width = 300;
            // 
            // colDia
            // 
            this.colDia.Text = "Địa chỉ";
            this.colDia.Width = 300;
            // 
            // btnXoa
            // 
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(320, 370);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(160, 38);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa dữ liệu";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 425);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupDanhSach);
            this.Controls.Add(this.lblTieuDe);
            this.Name = "Form4";
            this.Text = "Xóa dữ liệu_Nguyễn Hồ Trường Tam_1150080156";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.groupDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTieuDe;
        private System.Windows.Forms.GroupBox groupDanhSach;
        private System.Windows.Forms.ListView lsvDanhSach;
        private System.Windows.Forms.ColumnHeader colMa;
        private System.Windows.Forms.ColumnHeader colTen;
        private System.Windows.Forms.ColumnHeader colDia;
        private System.Windows.Forms.Button btnXoa;
    }
}