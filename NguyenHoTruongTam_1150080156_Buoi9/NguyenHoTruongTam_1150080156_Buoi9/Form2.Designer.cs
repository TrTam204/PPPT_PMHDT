using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_Buoi9
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private SplitContainer splitContainer1;

        // Left
        private Label lblDanhSach;
        private DataGridView dgvNhaXB;

        // Right
        private GroupBox grpNhap;
        private Label labelMa;
        private Label labelTen;
        private Label labelDiaChi;
        private TextBox txtMaXB;
        private TextBox txtTenXB;
        private TextBox txtDiaChi;
        private Button btnThem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.dgvNhaXB = new System.Windows.Forms.DataGridView();
            this.grpNhap = new System.Windows.Forms.GroupBox();
            this.labelMa = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.txtMaXB = new System.Windows.Forms.TextBox();
            this.txtTenXB = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXB)).BeginInit();
            this.grpNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle (tiêu đề giữa form)
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblTitle.Size = new System.Drawing.Size(800, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thêm dữ liệu vào database_1150080156_Nguyễn Hồ Trường Tam";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1 (chia 2 cột như ảnh)
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 45);
            this.splitContainer1.Name = "splitContainer1";
            // Left panel
            this.splitContainer1.Panel1.Controls.Add(this.dgvNhaXB);
            this.splitContainer1.Panel1.Controls.Add(this.lblDanhSach);
            // Right panel
            this.splitContainer1.Panel2.Controls.Add(this.grpNhap);
            this.splitContainer1.Size = new System.Drawing.Size(800, 455);
            this.splitContainer1.SplitterDistance = 430;  // giống tỷ lệ ảnh
            this.splitContainer1.TabIndex = 1;
            // 
            // lblDanhSach (trên DataGridView)
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(12, 12);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(153, 20);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách nhà xuất bản:";
            // 
            // dgvNhaXB (màu xám như ảnh)
            // 
            this.dgvNhaXB.AllowUserToAddRows = false;
            this.dgvNhaXB.AllowUserToDeleteRows = false;
            this.dgvNhaXB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                                   | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvNhaXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhaXB.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dgvNhaXB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhaXB.Location = new System.Drawing.Point(12, 38);
            this.dgvNhaXB.MultiSelect = false;
            this.dgvNhaXB.Name = "dgvNhaXB";
            this.dgvNhaXB.ReadOnly = true;
            this.dgvNhaXB.RowHeadersVisible = false;
            this.dgvNhaXB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhaXB.Size = new System.Drawing.Size(405, 405);
            this.dgvNhaXB.TabIndex = 1;
            // 
            // grpNhap (khung bên phải)
            // 
            this.grpNhap.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                   | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNhap.Controls.Add(this.btnThem);
            this.grpNhap.Controls.Add(this.txtDiaChi);
            this.grpNhap.Controls.Add(this.txtTenXB);
            this.grpNhap.Controls.Add(this.txtMaXB);
            this.grpNhap.Controls.Add(this.labelDiaChi);
            this.grpNhap.Controls.Add(this.labelTen);
            this.grpNhap.Controls.Add(this.labelMa);
            this.grpNhap.Location = new System.Drawing.Point(10, 12);
            this.grpNhap.Name = "grpNhap";
            this.grpNhap.Size = new System.Drawing.Size(340, 300);
            this.grpNhap.TabIndex = 0;
            this.grpNhap.TabStop = false;
            this.grpNhap.Text = "Nhập thông tin:";
            // 
            // labelMa
            // 
            this.labelMa.AutoSize = true;
            this.labelMa.Location = new System.Drawing.Point(16, 45);
            this.labelMa.Name = "labelMa";
            this.labelMa.Size = new System.Drawing.Size(60, 20);
            this.labelMa.TabIndex = 0;
            this.labelMa.Text = "Mã NXB:";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Location = new System.Drawing.Point(16, 95);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(66, 20);
            this.labelTen.TabIndex = 1;
            this.labelTen.Text = "Tên NXB:";
            // 
            // labelDiaChi
            // 
            this.labelDiaChi.AutoSize = true;
            this.labelDiaChi.Location = new System.Drawing.Point(16, 145);
            this.labelDiaChi.Name = "labelDiaChi";
            this.labelDiaChi.Size = new System.Drawing.Size(55, 20);
            this.labelDiaChi.TabIndex = 2;
            this.labelDiaChi.Text = "Địa chỉ:";
            // 
            // txtMaXB
            // 
            this.txtMaXB.Location = new System.Drawing.Point(110, 42);
            this.txtMaXB.MaxLength = 10;
            this.txtMaXB.Name = "txtMaXB";
            this.txtMaXB.Size = new System.Drawing.Size(210, 27);
            this.txtMaXB.TabIndex = 3;
            // 
            // txtTenXB
            // 
            this.txtTenXB.Location = new System.Drawing.Point(110, 92);
            this.txtTenXB.MaxLength = 100;
            this.txtTenXB.Name = "txtTenXB";
            this.txtTenXB.Size = new System.Drawing.Size(210, 27);
            this.txtTenXB.TabIndex = 4;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 142);
            this.txtDiaChi.MaxLength = 200;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(210, 27);
            this.txtDiaChi.TabIndex = 5;
            // 
            // btnThem (nút to giống ảnh)
            // 
            this.btnThem.Location = new System.Drawing.Point(60, 210);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(220, 50);
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm dữ liệu";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(820, 540);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhaXB)).EndInit();
            this.grpNhap.ResumeLayout(false);
            this.grpNhap.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion
    }
}