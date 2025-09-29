using System;
using System.Media;
using System.Windows.Forms;

namespace Lab2_BT1_AD2_nhttam_1150080156
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Tao cot cho DataGridView neu chua co
            dgvLog.AutoGenerateColumns = false;
            if (dgvLog.Columns.Count == 0)
            {
                dgvLog.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "TimeCol",
                    HeaderText = "Ngay gio",
                    FillWeight = 40
                });
                dgvLog.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "GroupCol",
                    HeaderText = "Nhom",
                    FillWeight = 30
                });
                dgvLog.Columns.Add(new DataGridViewTextBoxColumn
                {
                    Name = "ResultCol",
                    HeaderText = "Ket qua",
                    FillWeight = 30
                });

                dgvLog.RowHeadersVisible = false;
                dgvLog.ReadOnly = true;
                dgvLog.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvLog.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }

            // Gan handler cho cac phim so
            btn1.Click += Num_Click; btn2.Click += Num_Click; btn3.Click += Num_Click;
            btn4.Click += Num_Click; btn5.Click += Num_Click; btn6.Click += Num_Click;
            btn7.Click += Num_Click; btn8.Click += Num_Click; btn9.Click += Num_Click;
            if (btn0 != null) btn0.Click += Num_Click; // neu co nut 0

            btnClear.Click += btnClear_Click;
            btnEnter.Click += btnEnter_Click;
            btnRing.Click += btnRing_Click;
        }

        private void Num_Click(object sender, EventArgs e)
        {
            if (sender is Button b) txtPass.AppendText(b.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPass.Clear();
            txtPass.Focus();
        }

        private string ResolveGroup(string pass)
        {
            // Map theo de bai
            if (pass == "1496" || pass == "2673") return "Phat trien cong nghe";
            if (pass == "7462") return "Nghien cuu vien";
            if (pass == "8884" || pass == "3842" || pass == "3383") return "Thiet ke mo hinh";
            return "Khong co";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string pass = txtPass.Text.Trim();
            string group = ResolveGroup(pass);
            string result = group == "Khong co" ? "Tu choi!" : "Chap nhan!";

            dgvLog.Rows.Add(DateTime.Now.ToString("M/d/yyyy h:mm:ss tt"), group, result);

            txtPass.Clear();
            txtPass.Focus();
        }

        private void btnRing_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            dgvLog.Rows.Add(DateTime.Now.ToString("M/d/yyyy h:mm:ss tt"), "RING", "Chuong keu");
        }

        private void grpPassword_Enter(object sender, EventArgs e)
        {
            // khong dung -> de trong
        }
    }
}
