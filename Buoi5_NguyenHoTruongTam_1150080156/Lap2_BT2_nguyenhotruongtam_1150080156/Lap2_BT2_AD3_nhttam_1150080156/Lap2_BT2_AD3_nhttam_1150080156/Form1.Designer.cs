using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Lap2_AD3_Login_nguyenhotruongtam_1150080156
{
    public partial class Form1 : Form
    {
        private IContainer components = null;

        private Label lblTitle;
        private GroupBox grpLogin;
        private Label lblUser;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox chkShowPass;
        private Button btnLogin;
        private Button btnClear;
        private Button btnExit;
        private ErrorProvider errorProvider1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            this.lblTitle = new Label();
            this.grpLogin = new GroupBox();
            this.lblUser = new Label();
            this.lblPass = new Label();
            this.txtUser = new TextBox();
            this.txtPass = new TextBox();
            this.chkShowPass = new CheckBox();
            this.btnLogin = new Button();
            this.btnClear = new Button();
            this.btnExit = new Button();
            this.errorProvider1 = new ErrorProvider(this.components);

            ((ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();

            // Form
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(420, 300);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = Color.White;

            // Title
            this.lblTitle.Text = "ĐĂNG NHẬP ỨNG DỤNG";
            this.lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.BackColor = Color.FromArgb(0, 176, 80);
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Location = new Point(12, 12);
            this.lblTitle.Size = new Size(396, 42);

            // GroupBox
            this.grpLogin.Text = "Thông tin đăng nhập";
            this.grpLogin.Location = new Point(12, 62);
            this.grpLogin.Size = new Size(396, 160);

            // Labels
            this.lblUser.Text = "Username:";
            this.lblUser.Location = new Point(24, 36);
            this.lblUser.AutoSize = true;

            this.lblPass.Text = "Password:";
            this.lblPass.Location = new Point(24, 74);
            this.lblPass.AutoSize = true;

            // TextBoxes
            this.txtUser.Location = new Point(110, 32);
            this.txtUser.Size = new Size(260, 23);
            this.txtUser.Name = "txtUser";

            this.txtPass.Location = new Point(110, 70);
            this.txtPass.Size = new Size(260, 23);
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.Name = "txtPass";

            // Show password
            this.chkShowPass.Text = "Hiện mật khẩu";
            this.chkShowPass.Location = new Point(110, 100);
            this.chkShowPass.AutoSize = true;

            // Buttons
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Location = new Point(40, 230);
            this.btnLogin.Size = new Size(100, 30);

            this.btnClear.Text = "Xóa";
            this.btnClear.Location = new Point(160, 230);
            this.btnClear.Size = new Size(100, 30);

            this.btnExit.Text = "Thoát";
            this.btnExit.Location = new Point(280, 230);
            this.btnExit.Size = new Size(100, 30);

            // ErrorProvider
            this.errorProvider1.ContainerControl = this;

            // Add controls to group
            this.grpLogin.Controls.Add(this.lblUser);
            this.grpLogin.Controls.Add(this.lblPass);
            this.grpLogin.Controls.Add(this.txtUser);
            this.grpLogin.Controls.Add(this.txtPass);
            this.grpLogin.Controls.Add(this.chkShowPass);

            // Add to form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpLogin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);

            ((ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
