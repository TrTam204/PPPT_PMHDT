using System.Drawing;
using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_Lap3_TH2
{
    partial class Form1
    {
        private Label lblTitle;
        private GroupBox gbThongTin;
        private TextBox txtHoTen, txtLop, txtDiaChi;
        private Label lblHoTen, lblNgaySinh, lblLop, lblDiaChi;
        private DateTimePicker dtNgaySinh;
        private GroupBox gbChucNang;
        private Button btnThem, btnSua, btnXoa, btnThoat;
        private GroupBox gbDanhSach;
        private DataGridView dgvSinhVien;

        private void InitializeComponent()
        {
            this.lblTitle = new Label();
            this.gbThongTin = new GroupBox();
            this.txtHoTen = new TextBox();
            this.txtLop = new TextBox();
            this.txtDiaChi = new TextBox();
            this.lblHoTen = new Label();
            this.lblNgaySinh = new Label();
            this.lblLop = new Label();
            this.lblDiaChi = new Label();
            this.dtNgaySinh = new DateTimePicker();
            this.gbChucNang = new GroupBox();
            this.btnThem = new Button();
            this.btnSua = new Button();
            this.btnXoa = new Button();
            this.btnThoat = new Button();
            this.gbDanhSach = new GroupBox();
            this.dgvSinhVien = new DataGridView();

            // === FORM ===
            this.Text = "Danh sách sinh viên";
            this.ClientSize = new Size(800, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Font = new Font("Segoe UI", 10F);

            // === TIÊU ĐỀ ===
            this.lblTitle.Text = "DANH MỤC SINH VIÊN";
            this.lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.RoyalBlue;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Dock = DockStyle.Top;
            this.lblTitle.Height = 60;

            // === THÔNG TIN SINH VIÊN ===
            this.gbThongTin.Text = "Thông tin sinh viên";
            this.gbThongTin.Location = new Point(20, 70);
            this.gbThongTin.Size = new Size(760, 130);

            // Họ tên
            this.lblHoTen.Text = "Họ tên:";
            this.lblHoTen.Location = new Point(20, 30);
            this.txtHoTen.Location = new Point(90, 27);
            this.txtHoTen.Size = new Size(220, 27);

            // Lớp
            this.lblLop.Text = "Lớp:";
            this.lblLop.Location = new Point(400, 30);
            this.txtLop.Location = new Point(450, 27);
            this.txtLop.Size = new Size(200, 27);

            // Ngày sinh
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.Location = new Point(20, 70);
            this.dtNgaySinh.Location = new Point(90, 67);
            this.dtNgaySinh.Size = new Size(220, 27);

            // Địa chỉ
            this.lblDiaChi.Text = "Địa chỉ:";
            this.lblDiaChi.Location = new Point(400, 70);
            this.txtDiaChi.Location = new Point(450, 67);
            this.txtDiaChi.Size = new Size(280, 27);

            this.gbThongTin.Controls.AddRange(new Control[]
            {
                lblHoTen, txtHoTen, lblLop, txtLop,
                lblNgaySinh, dtNgaySinh, lblDiaChi, txtDiaChi
            });

            // === CHỨC NĂNG ===
            this.gbChucNang.Text = "Chức năng";
            this.gbChucNang.Location = new Point(20, 210);
            this.gbChucNang.Size = new Size(760, 70);

            this.btnThem.Text = "Thêm";
            this.btnThem.Location = new Point(90, 25);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            this.btnSua.Text = "Sửa";
            this.btnSua.Location = new Point(220, 25);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            this.btnXoa.Text = "Xóa";
            this.btnXoa.Location = new Point(350, 25);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            this.btnThoat.Text = "Thoát";
            this.btnThoat.Location = new Point(480, 25);
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);

            this.gbChucNang.Controls.AddRange(new Control[] { btnThem, btnSua, btnXoa, btnThoat });

            // === DANH SÁCH ===
            this.gbDanhSach.Text = "Thông tin chung sinh viên";
            this.gbDanhSach.Location = new Point(20, 290);
            this.gbDanhSach.Size = new Size(760, 280);

            this.dgvSinhVien.Location = new Point(10, 25);
            this.dgvSinhVien.Size = new Size(740, 240);
            this.dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvSinhVien.AllowUserToAddRows = false;

            this.gbDanhSach.Controls.Add(dgvSinhVien);

            // === ADD CONTROLS ===
            this.Controls.AddRange(new Control[] {
                lblTitle, gbThongTin, gbChucNang, gbDanhSach
            });
        }
    }
}
