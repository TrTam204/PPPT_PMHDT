using System;
using System.Windows.Forms;

namespace Lap2_AD3_Login_nguyenhotruongtam_1150080156
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // event handlers
            btnLogin.Click += btnLogin_Click;
            btnClear.Click += btnClear_Click;
            btnExit.Click += (s, e) => Close();

            chkShowPass.CheckedChanged += (s, e) =>
            {
                txtPass.UseSystemPasswordChar = !chkShowPass.Checked;
            };

            // nhấn Enter để đăng nhập
            txtUser.KeyDown += TextBox_EnterLogin;
            txtPass.KeyDown += TextBox_EnterLogin;

            // validate trống realtime
            txtUser.TextChanged += (s, e) => errorProvider1.SetError(txtUser,
                string.IsNullOrWhiteSpace(txtUser.Text) ? "Không được để trống" : "");
            txtPass.TextChanged += (s, e) => errorProvider1.SetError(txtPass,
                string.IsNullOrWhiteSpace(txtPass.Text) ? "Không được để trống" : "");
        }

        private void TextBox_EnterLogin(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // kiểm tra không để trống
        private bool ValidateInputs()
        {
            bool ok = true;

            if (string.IsNullOrWhiteSpace(txtUser.Text))
            {
                errorProvider1.SetError(txtUser, "Vui lòng nhập username");
                ok = false;
            }
            else errorProvider1.SetError(txtUser, "");

            if (string.IsNullOrWhiteSpace(txtPass.Text))
            {
                errorProvider1.SetError(txtPass, "Vui lòng nhập password");
                ok = false;
            }
            else errorProvider1.SetError(txtPass, "");

            return ok;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            // Ở lab chỉ yêu cầu kiểm tra trống -> coi như đăng nhập thành công
            // Nếu muốn kiểm tra tài khoản mẫu, thêm đoạn if bên dưới:
            // if (txtUser.Text == "admin" && txtPass.Text == "123") ...

            MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
            errorProvider1.SetError(txtUser, "");
            errorProvider1.SetError(txtPass, "");
            txtUser.Focus();
        }
    }
}
