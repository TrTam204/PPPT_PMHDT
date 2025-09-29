using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lap2_BT2_nguyenhotruongtam_1150080156
{
    public partial class Form1 : Form
    {
        private IContainer components = null;

        // Header
        private Panel pnlHeader;
        private Label lblHeader;

        // Thông tin KH
        private GroupBox grpInfo;
        private Label lblName;
        private TextBox txtName;
        private ErrorProvider errorProvider1;

        // Dịch vụ
        private GroupBox grpServices;
        private CheckBox chkCaoRang;
        private CheckBox chkTayTrang;
        private CheckBox chkHanRang;
        private CheckBox chkBeRang;
        private CheckBox chkBocRang;
        private Label lblGiaCaoRang;
        private Label lblGiaTayTrang;
        private Label lblGiaHanRang;
        private Label lblGiaBeRang;
        private Label lblGiaBocRang;
        private NumericUpDown numHan;
        private NumericUpDown numBe;
        private NumericUpDown numBoc;

        // Chức năng
        private GroupBox grpButtons;
        private Button btnTinh;
        private Button btnThoat;
        private TextBox txtTong;   // <-- ô kết quả tiền

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();

            this.pnlHeader = new Panel();
            this.lblHeader = new Label();

            this.grpInfo = new GroupBox();
            this.lblName = new Label();
            this.txtName = new TextBox();
            this.errorProvider1 = new ErrorProvider(this.components);

            this.grpServices = new GroupBox();
            this.chkCaoRang = new CheckBox();
            this.chkTayTrang = new CheckBox();
            this.chkHanRang = new CheckBox();
            this.chkBeRang = new CheckBox();
            this.chkBocRang = new CheckBox();
            this.lblGiaCaoRang = new Label();
            this.lblGiaTayTrang = new Label();
            this.lblGiaHanRang = new Label();
            this.lblGiaBeRang = new Label();
            this.lblGiaBocRang = new Label();
            this.numHan = new NumericUpDown();
            this.numBe = new NumericUpDown();
            this.numBoc = new NumericUpDown();

            this.grpButtons = new GroupBox();
            this.btnTinh = new Button();
            this.btnThoat = new Button();
            this.txtTong = new TextBox();

            ((ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((ISupportInitialize)(this.numHan)).BeginInit();
            ((ISupportInitialize)(this.numBe)).BeginInit();
            ((ISupportInitialize)(this.numBoc)).BeginInit();
            this.SuspendLayout();

            // ===== FORM =====
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(720, 520);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form1";

            // ===== HEADER =====
            this.pnlHeader.BackColor = Color.FromArgb(0, 176, 80);
            this.pnlHeader.Location = new Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new Size(696, 60);

            this.lblHeader.Dock = DockStyle.Fill;
            this.lblHeader.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Text = "PHÒNG KHÁM NHA KHOA HẢI ÂU";
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;

            this.pnlHeader.Controls.Add(this.lblHeader);

            // ===== INFO =====
            this.grpInfo.BackColor = Color.Gainsboro;
            this.grpInfo.Location = new Point(12, 80);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new Size(696, 70);
            this.grpInfo.TabStop = true;
            this.grpInfo.Text = "Tên khách hàng:";

            this.lblName.AutoSize = true;
            this.lblName.Location = new Point(16, 33);
            this.lblName.Text = "Tên khách hàng:";

            this.txtName.Location = new Point(130, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new Size(520, 23);

            this.grpInfo.Controls.Add(this.lblName);
            this.grpInfo.Controls.Add(this.txtName);

            this.errorProvider1.ContainerControl = this;

            // ===== SERVICES =====
            this.grpServices.BackColor = Color.WhiteSmoke;
            this.grpServices.Location = new Point(12, 156);
            this.grpServices.Name = "grpServices";
            this.grpServices.Size = new Size(696, 240);
            this.grpServices.TabStop = true;
            this.grpServices.Text = "Dịch vụ tại phòng khám:";

            // CheckBox vị trí giống ảnh
            this.chkCaoRang.Location = new Point(32, 40);
            this.chkCaoRang.Text = "Lấy cao răng";
            this.chkTayTrang.Location = new Point(32, 76);
            this.chkTayTrang.Text = "Tẩy trắng răng";
            this.chkHanRang.Location = new Point(32, 112);
            this.chkHanRang.Text = "Hàn răng";
            this.chkBeRang.Location = new Point(32, 148);
            this.chkBeRang.Text = "Bẻ răng";
            this.chkBocRang.Location = new Point(32, 184);
            this.chkBocRang.Text = "Bọc răng";

            // Giá cột giữa
            this.lblGiaCaoRang.Location = new Point(260, 40);
            this.lblGiaCaoRang.AutoSize = true;
            this.lblGiaCaoRang.Text = "50.000đ/2 hàm";
            this.lblGiaTayTrang.Location = new Point(260, 76);
            this.lblGiaTayTrang.AutoSize = true;
            this.lblGiaTayTrang.Text = "100.000đ/2 hàm";
            this.lblGiaHanRang.Location = new Point(260, 112);
            this.lblGiaHanRang.AutoSize = true;
            this.lblGiaHanRang.Text = "100.000đ/1 răng";
            this.lblGiaBeRang.Location = new Point(260, 148);
            this.lblGiaBeRang.AutoSize = true;
            this.lblGiaBeRang.Text = "10.000đ/1 răng";
            this.lblGiaBocRang.Location = new Point(260, 184);
            this.lblGiaBocRang.AutoSize = true;
            this.lblGiaBocRang.Text = "1.000.000đ/1 răng";

            // NumericUpDown cột phải (cho dịch vụ theo răng)
            this.numHan.Location = new Point(620, 110);
            this.numHan.Minimum = 1; this.numHan.Maximum = 32; this.numHan.Value = 1;
            this.numHan.Enabled = false; this.numHan.Size = new Size(50, 23);

            this.numBe.Location = new Point(620, 146);
            this.numBe.Minimum = 1; this.numBe.Maximum = 32; this.numBe.Value = 1;
            this.numBe.Enabled = false; this.numBe.Size = new Size(50, 23);

            this.numBoc.Location = new Point(620, 182);
            this.numBoc.Minimum = 1; this.numBoc.Maximum = 32; this.numBoc.Value = 1;
            this.numBoc.Enabled = false; this.numBoc.Size = new Size(50, 23);

            this.grpServices.Controls.Add(this.chkCaoRang);
            this.grpServices.Controls.Add(this.chkTayTrang);
            this.grpServices.Controls.Add(this.chkHanRang);
            this.grpServices.Controls.Add(this.chkBeRang);
            this.grpServices.Controls.Add(this.chkBocRang);
            this.grpServices.Controls.Add(this.lblGiaCaoRang);
            this.grpServices.Controls.Add(this.lblGiaTayTrang);
            this.grpServices.Controls.Add(this.lblGiaHanRang);
            this.grpServices.Controls.Add(this.lblGiaBeRang);
            this.grpServices.Controls.Add(this.lblGiaBocRang);
            this.grpServices.Controls.Add(this.numHan);
            this.grpServices.Controls.Add(this.numBe);
            this.grpServices.Controls.Add(this.numBoc);

            // ===== BUTTONS + Ô TỔNG TIỀN =====
            this.grpButtons.Location = new Point(12, 404);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new Size(696, 80);
            this.grpButtons.TabStop = true;
            this.grpButtons.Text = "Chức năng:";

            this.btnTinh.Location = new Point(160, 32);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new Size(120, 30);
            this.btnTinh.Text = "Tính tiền";
            this.btnTinh.UseVisualStyleBackColor = true;

            this.txtTong.Location = new Point(300, 35);
            this.txtTong.Name = "txtTong";
            this.txtTong.ReadOnly = true;
            this.txtTong.Size = new Size(150, 23);
            this.txtTong.TextAlign = HorizontalAlignment.Right;

            this.btnThoat.Location = new Point(470, 32);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new Size(120, 30);
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;

            this.grpButtons.Controls.Add(this.btnTinh);
            this.grpButtons.Controls.Add(this.txtTong);
            this.grpButtons.Controls.Add(this.btnThoat);

            // ===== ADD TO FORM =====
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.grpServices);
            this.Controls.Add(this.grpButtons);

            ((ISupportInitialize)(this.errorProvider1)).EndInit();
            ((ISupportInitialize)(this.numHan)).EndInit();
            ((ISupportInitialize)(this.numBe)).EndInit();
            ((ISupportInitialize)(this.numBoc)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
