using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lap2_BT3_nguyenhotruongtam_1150080156
{
    public partial class Form1 : Form
    {
        private IContainer components = null;

        private Panel pnlHeader;
        private Label lblHeader;

        private Label lblNhap;
        private TextBox txtSo;
        private Button btnNhap;

        private ListBox lsbDaySo;
        private Label lblList;
        private Label lblChucNang;

        private Button btnTang2;
        private Button btnChonChanDau;
        private Button btnChonLeCuoi;
        private Button btnXoaDangChon;
        private Button btnXoaDau;
        private Button btnXoaCuoi;

        private Button btnKetThuc;
        private Button btnXoaDay;

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

            this.lblNhap = new Label();
            this.txtSo = new TextBox();
            this.btnNhap = new Button();

            this.lsbDaySo = new ListBox();
            this.lblList = new Label();
            this.lblChucNang = new Label();

            this.btnTang2 = new Button();
            this.btnChonChanDau = new Button();
            this.btnChonLeCuoi = new Button();
            this.btnXoaDangChon = new Button();
            this.btnXoaDau = new Button();
            this.btnXoaCuoi = new Button();

            this.btnKetThuc = new Button();
            this.btnXoaDay = new Button();

            // ==== FORM ====
            this.SuspendLayout();
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.White;
            this.ClientSize = new Size(580, 560);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Form1";

            // ==== HEADER ====
            this.pnlHeader.BackColor = Color.Teal;
            this.pnlHeader.Location = new Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new Size(556, 70);

            this.lblHeader.Dock = DockStyle.Fill;
            this.lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            this.lblHeader.ForeColor = Color.White;
            this.lblHeader.Text = "Ứng dụng xử lý dãy số";
            this.lblHeader.TextAlign = ContentAlignment.MiddleCenter;

            this.pnlHeader.Controls.Add(this.lblHeader);

            // ==== NHẬP SỐ ====
            this.lblNhap.AutoSize = true;
            this.lblNhap.Location = new Point(24, 100);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Text = "Nhập số nguyên:";

            this.txtSo.Location = new Point(140, 96);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new Size(160, 23);

            this.btnNhap.Location = new Point(335, 92);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new Size(110, 32);
            this.btnNhap.Text = "Nhập số";
            this.btnNhap.UseVisualStyleBackColor = true;

            // ==== LISTBOX + TIÊU ĐỀ ====
            this.lblList.AutoSize = true;
            this.lblList.Location = new Point(24, 140);
            this.lblList.Name = "lblList";
            this.lblList.Text = "lsbDaySo";

            this.lblChucNang.AutoSize = true;
            this.lblChucNang.Location = new Point(300, 140);
            this.lblChucNang.Name = "lblChucNang";
            this.lblChucNang.Text = "Chức năng:";

            this.lsbDaySo.Location = new Point(24, 160);
            this.lsbDaySo.Name = "lsbDaySo";
            this.lsbDaySo.Size = new Size(240, 320);

            // ==== NÚT CHỨC NĂNG BÊN PHẢI ====
            this.btnTang2.Location = new Point(300, 160);
            this.btnTang2.Name = "btnTang2";
            this.btnTang2.Size = new Size(230, 36);
            this.btnTang2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTang2.UseVisualStyleBackColor = true;

            this.btnChonChanDau.Location = new Point(300, 215);
            this.btnChonChanDau.Name = "btnChonChanDau";
            this.btnChonChanDau.Size = new Size(230, 36);
            this.btnChonChanDau.Text = "Chọn số chẵn đầu";
            this.btnChonChanDau.UseVisualStyleBackColor = true;

            this.btnChonLeCuoi.Location = new Point(300, 270);
            this.btnChonLeCuoi.Name = "btnChonLeCuoi";
            this.btnChonLeCuoi.Size = new Size(230, 36);
            this.btnChonLeCuoi.Text = "Chọn số lẻ cuối";
            this.btnChonLeCuoi.UseVisualStyleBackColor = true;

            this.btnXoaDangChon.Location = new Point(300, 325);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new Size(230, 36);
            this.btnXoaDangChon.Text = "Xóa phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = true;

            this.btnXoaDau.Location = new Point(300, 380);
            this.btnXoaDau.Name = "btnXoaDau";
            this.btnXoaDau.Size = new Size(230, 36);
            this.btnXoaDau.Text = "Xóa phần tử đầu";
            this.btnXoaDau.UseVisualStyleBackColor = true;

            this.btnXoaCuoi.Location = new Point(300, 435);
            this.btnXoaCuoi.Name = "btnXoaCuoi";
            this.btnXoaCuoi.Size = new Size(230, 36);
            this.btnXoaCuoi.Text = "Xóa phần tử cuối";
            this.btnXoaCuoi.UseVisualStyleBackColor = true;

            // ==== NÚT DƯỚI CÙNG ====
            this.btnKetThuc.Location = new Point(24, 500);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new Size(200, 36);
            this.btnKetThuc.Text = "Kết thúc ứng dụng";
            this.btnKetThuc.BackColor = Color.Firebrick;
            this.btnKetThuc.ForeColor = Color.White;
            this.btnKetThuc.FlatStyle = FlatStyle.Flat;

            this.btnXoaDay.Location = new Point(330, 500);
            this.btnXoaDay.Name = "btnXoaDay";
            this.btnXoaDay.Size = new Size(200, 36);
            this.btnXoaDay.Text = "Xóa dãy số";
            this.btnXoaDay.BackColor = Color.DimGray;
            this.btnXoaDay.ForeColor = Color.White;
            this.btnXoaDay.FlatStyle = FlatStyle.Flat;

            // ==== ADD TO FORM ====
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.lblNhap);
            this.Controls.Add(this.txtSo);
            this.Controls.Add(this.btnNhap);

            this.Controls.Add(this.lblList);
            this.Controls.Add(this.lblChucNang);
            this.Controls.Add(this.lsbDaySo);

            this.Controls.Add(this.btnTang2);
            this.Controls.Add(this.btnChonChanDau);
            this.Controls.Add(this.btnChonLeCuoi);
            this.Controls.Add(this.btnXoaDangChon);
            this.Controls.Add(this.btnXoaDau);
            this.Controls.Add(this.btnXoaCuoi);

            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnXoaDay);

            this.ResumeLayout(false);
        }
    }
}
