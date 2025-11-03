using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace NguyenHoTruongTam_1150080156_Buoi9
{
    partial class FormPhan4
    {
        private System.ComponentModel.IContainer components = null;

        // Title
        private System.Windows.Forms.Label lblTitle;

        // grbTimKiem
        private System.Windows.Forms.GroupBox grbTimKiem;
        private System.Windows.Forms.Label lblTKMa;
        private System.Windows.Forms.TextBox txtTKMa;
        private System.Windows.Forms.Label lblTKTên;
        private System.Windows.Forms.TextBox txtTKTên;
        private System.Windows.Forms.Label lblTKNgaySX;
        private System.Windows.Forms.DateTimePicker dtTKNgaySX;
        private System.Windows.Forms.Label lblTKNgayHH;
        private System.Windows.Forms.DateTimePicker dtTKNgayHH;
        private System.Windows.Forms.Label lblTKDonGia;
        private System.Windows.Forms.NumericUpDown numTKDonGia;

        // grbChiTiet
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.Label lblMa;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblNgaySX;
        private System.Windows.Forms.DateTimePicker dtNgaySX;
        private System.Windows.Forms.Label lblNgayHH;
        private System.Windows.Forms.DateTimePicker dtNgayHH;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.NumericUpDown numDonGia;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;

        // grbDanhSach
        private System.Windows.Forms.GroupBox grbDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;

        // Bottom buttons
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grbTimKiem = new System.Windows.Forms.GroupBox();
            this.lblTKMa = new System.Windows.Forms.Label();
            this.txtTKMa = new System.Windows.Forms.TextBox();
            this.lblTKTên = new System.Windows.Forms.Label();
            this.txtTKTên = new System.Windows.Forms.TextBox();
            this.lblTKNgaySX = new System.Windows.Forms.Label();
            this.dtTKNgaySX = new System.Windows.Forms.DateTimePicker();
            this.lblTKNgayHH = new System.Windows.Forms.Label();
            this.dtTKNgayHH = new System.Windows.Forms.DateTimePicker();
            this.lblTKDonGia = new System.Windows.Forms.Label();
            this.numTKDonGia = new System.Windows.Forms.NumericUpDown();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.lblMa = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblNgaySX = new System.Windows.Forms.Label();
            this.dtNgaySX = new System.Windows.Forms.DateTimePicker();
            this.lblNgayHH = new System.Windows.Forms.Label();
            this.dtNgayHH = new System.Windows.Forms.DateTimePicker();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.numDonGia = new System.Windows.Forms.NumericUpDown();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTKDonGia)).BeginInit();
            this.grbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).BeginInit();
            this.grbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.lblTitle.Size = new System.Drawing.Size(1102, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TÌM KIẾM MẶT HÀNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbTimKiem
            // 
            this.grbTimKiem.Controls.Add(this.lblTKMa);
            this.grbTimKiem.Controls.Add(this.txtTKMa);
            this.grbTimKiem.Controls.Add(this.lblTKTên);
            this.grbTimKiem.Controls.Add(this.txtTKTên);
            this.grbTimKiem.Controls.Add(this.lblTKNgaySX);
            this.grbTimKiem.Controls.Add(this.dtTKNgaySX);
            this.grbTimKiem.Controls.Add(this.lblTKNgayHH);
            this.grbTimKiem.Controls.Add(this.dtTKNgayHH);
            this.grbTimKiem.Controls.Add(this.lblTKDonGia);
            this.grbTimKiem.Controls.Add(this.numTKDonGia);
            this.grbTimKiem.Location = new System.Drawing.Point(12, 60);
            this.grbTimKiem.Name = "grbTimKiem";
            this.grbTimKiem.Size = new System.Drawing.Size(520, 170);
            this.grbTimKiem.TabIndex = 1;
            this.grbTimKiem.Text = "grbTimKiem (nhập Mã hoặc Tên là đủ)";
            // 
            // lblTKMa
            // 
            this.lblTKMa.AutoSize = true;
            this.lblTKMa.Location = new System.Drawing.Point(15, 30);
            this.lblTKMa.Name = "lblTKMa";
            this.lblTKMa.Size = new System.Drawing.Size(53, 20);
            this.lblTKMa.TabIndex = 0;
            this.lblTKMa.Text = "Mã SP:";
            // 
            // txtTKMa
            // 
            this.txtTKMa.Location = new System.Drawing.Point(100, 26);
            this.txtTKMa.Name = "txtTKMa";
            this.txtTKMa.Size = new System.Drawing.Size(150, 27);
            this.txtTKMa.TabIndex = 1;
            // 
            // lblTKTên
            // 
            this.lblTKTên.AutoSize = true;
            this.lblTKTên.Location = new System.Drawing.Point(270, 30);
            this.lblTKTên.Name = "lblTKTên";
            this.lblTKTên.Size = new System.Drawing.Size(55, 20);
            this.lblTKTên.TabIndex = 2;
            this.lblTKTên.Text = "Tên SP:";
            // 
            // txtTKTên
            // 
            this.txtTKTên.Location = new System.Drawing.Point(340, 26);
            this.txtTKTên.Name = "txtTKTên";
            this.txtTKTên.Size = new System.Drawing.Size(160, 27);
            this.txtTKTên.TabIndex = 3;
            // 
            // lblTKNgaySX
            // 
            this.lblTKNgaySX.AutoSize = true;
            this.lblTKNgaySX.Location = new System.Drawing.Point(15, 70);
            this.lblTKNgaySX.Name = "lblTKNgaySX";
            this.lblTKNgaySX.Size = new System.Drawing.Size(79, 20);
            this.lblTKNgaySX.TabIndex = 4;
            this.lblTKNgaySX.Text = "Ngày SX ≥";
            // 
            // dtTKNgaySX
            // 
            this.dtTKNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTKNgaySX.Location = new System.Drawing.Point(100, 66);
            this.dtTKNgaySX.Name = "dtTKNgaySX";
            this.dtTKNgaySX.ShowCheckBox = true;
            this.dtTKNgaySX.Size = new System.Drawing.Size(150, 27);
            this.dtTKNgaySX.TabIndex = 5;
            // 
            // lblTKNgayHH
            // 
            this.lblTKNgayHH.AutoSize = true;
            this.lblTKNgayHH.Location = new System.Drawing.Point(270, 70);
            this.lblTKNgayHH.Name = "lblTKNgayHH";
            this.lblTKNgayHH.Size = new System.Drawing.Size(45, 20);
            this.lblTKNgayHH.TabIndex = 6;
            this.lblTKNgayHH.Text = "HH ≤";
            // 
            // dtTKNgayHH
            // 
            this.dtTKNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTKNgayHH.Location = new System.Drawing.Point(340, 66);
            this.dtTKNgayHH.Name = "dtTKNgayHH";
            this.dtTKNgayHH.ShowCheckBox = true;
            this.dtTKNgayHH.Size = new System.Drawing.Size(160, 27);
            this.dtTKNgayHH.TabIndex = 7;
            // 
            // lblTKDonGia
            // 
            this.lblTKDonGia.AutoSize = true;
            this.lblTKDonGia.Location = new System.Drawing.Point(15, 110);
            this.lblTKDonGia.Name = "lblTKDonGia";
            this.lblTKDonGia.Size = new System.Drawing.Size(76, 20);
            this.lblTKDonGia.TabIndex = 8;
            this.lblTKDonGia.Text = "Đơn giá ≥";
            // 
            // numTKDonGia
            // 
            this.numTKDonGia.Location = new System.Drawing.Point(100, 106);
            this.numTKDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numTKDonGia.Name = "numTKDonGia";
            this.numTKDonGia.Size = new System.Drawing.Size(150, 27);
            this.numTKDonGia.TabIndex = 9;
            this.numTKDonGia.ThousandsSeparator = true;
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Controls.Add(this.lblMa);
            this.grbChiTiet.Controls.Add(this.txtMa);
            this.grbChiTiet.Controls.Add(this.lblTen);
            this.grbChiTiet.Controls.Add(this.txtTen);
            this.grbChiTiet.Controls.Add(this.lblNgaySX);
            this.grbChiTiet.Controls.Add(this.dtNgaySX);
            this.grbChiTiet.Controls.Add(this.lblNgayHH);
            this.grbChiTiet.Controls.Add(this.dtNgayHH);
            this.grbChiTiet.Controls.Add(this.lblDonVi);
            this.grbChiTiet.Controls.Add(this.txtDonVi);
            this.grbChiTiet.Controls.Add(this.lblDonGia);
            this.grbChiTiet.Controls.Add(this.numDonGia);
            this.grbChiTiet.Controls.Add(this.lblGhiChu);
            this.grbChiTiet.Controls.Add(this.txtGhiChu);
            this.grbChiTiet.Controls.Add(this.btnLuu);
            this.grbChiTiet.Controls.Add(this.btnHuy);
            this.grbChiTiet.Location = new System.Drawing.Point(550, 60);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(538, 340);
            this.grbChiTiet.TabIndex = 2;
            this.grbChiTiet.Text = "grbChiTiet (chi tiết bản ghi)";
            // 
            // lblMa
            // 
            this.lblMa.AutoSize = true;
            this.lblMa.Location = new System.Drawing.Point(20, 30);
            this.lblMa.Name = "lblMa";
            this.lblMa.Size = new System.Drawing.Size(53, 20);
            this.lblMa.TabIndex = 0;
            this.lblMa.Text = "Mã SP:";
            // 
            // txtMa
            // 
            this.txtMa.Location = new System.Drawing.Point(120, 26);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(120, 27);
            this.txtMa.TabIndex = 1;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Location = new System.Drawing.Point(20, 62);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(55, 20);
            this.lblTen.TabIndex = 2;
            this.lblTen.Text = "Tên SP:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(120, 58);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(380, 27);
            this.txtTen.TabIndex = 3;
            // 
            // lblNgaySX
            // 
            this.lblNgaySX.AutoSize = true;
            this.lblNgaySX.Location = new System.Drawing.Point(20, 94);
            this.lblNgaySX.Name = "lblNgaySX";
            this.lblNgaySX.Size = new System.Drawing.Size(68, 20);
            this.lblNgaySX.TabIndex = 4;
            this.lblNgaySX.Text = "Ngày SX:";
            // 
            // dtNgaySX
            // 
            this.dtNgaySX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySX.Location = new System.Drawing.Point(120, 90);
            this.dtNgaySX.Name = "dtNgaySX";
            this.dtNgaySX.Size = new System.Drawing.Size(140, 27);
            this.dtNgaySX.TabIndex = 5;
            // 
            // lblNgayHH
            // 
            this.lblNgayHH.AutoSize = true;
            this.lblNgayHH.Location = new System.Drawing.Point(20, 126);
            this.lblNgayHH.Name = "lblNgayHH";
            this.lblNgayHH.Size = new System.Drawing.Size(73, 20);
            this.lblNgayHH.TabIndex = 6;
            this.lblNgayHH.Text = "Ngày HH:";
            // 
            // dtNgayHH
            // 
            this.dtNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayHH.Location = new System.Drawing.Point(120, 122);
            this.dtNgayHH.Name = "dtNgayHH";
            this.dtNgayHH.Size = new System.Drawing.Size(140, 27);
            this.dtNgayHH.TabIndex = 7;
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(20, 158);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(55, 20);
            this.lblDonVi.TabIndex = 8;
            this.lblDonVi.Text = "Đơn vị:";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(120, 154);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(140, 27);
            this.txtDonVi.TabIndex = 9;
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(20, 190);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(65, 20);
            this.lblDonGia.TabIndex = 10;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // numDonGia
            // 
            this.numDonGia.Location = new System.Drawing.Point(120, 186);
            this.numDonGia.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numDonGia.Name = "numDonGia";
            this.numDonGia.Size = new System.Drawing.Size(140, 27);
            this.numDonGia.TabIndex = 11;
            this.numDonGia.ThousandsSeparator = true;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.AutoSize = true;
            this.lblGhiChu.Location = new System.Drawing.Point(20, 222);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(61, 20);
            this.lblGhiChu.TabIndex = 12;
            this.lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(120, 218);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(380, 60);
            this.txtGhiChu.TabIndex = 13;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(250, 290);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 36);
            this.btnLuu.TabIndex = 14;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(360, 290);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 36);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // grbDanhSach
            // 
            this.grbDanhSach.Controls.Add(this.dgvDanhSach);
            this.grbDanhSach.Location = new System.Drawing.Point(12, 240);
            this.grbDanhSach.Name = "grbDanhSach";
            this.grbDanhSach.Size = new System.Drawing.Size(520, 330);
            this.grbDanhSach.TabIndex = 3;
            this.grbDanhSach.Text = "dgvDanhSach hiển thị kết quả";
            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDanhSach.ColumnHeadersHeight = 29;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(3, 23);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.RowHeadersWidth = 51;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(514, 304);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);
            this.dgvDanhSach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellContentClick);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnTim);
            this.pnlButtons.Controls.Add(this.btnThem);
            this.pnlButtons.Controls.Add(this.btnSua);
            this.pnlButtons.Controls.Add(this.btnXoa);
            this.pnlButtons.Controls.Add(this.btnThoat);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 570);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1102, 60);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(12, 12);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 36);
            this.btnTim.TabIndex = 0;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(142, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(120, 36);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(272, 12);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(120, 36);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(402, 12);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(120, 36);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(532, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(120, 36);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // FormPhan4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 630);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.grbDanhSach);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.grbTimKiem);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MinimumSize = new System.Drawing.Size(1120, 670);
            this.Name = "FormPhan4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLBanHang - MatHang";
            this.Load += new System.EventHandler(this.FormPhan4_Load);
            this.grbTimKiem.ResumeLayout(false);
            this.grbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTKDonGia)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            this.grbChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDonGia)).EndInit();
            this.grbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
    }
}