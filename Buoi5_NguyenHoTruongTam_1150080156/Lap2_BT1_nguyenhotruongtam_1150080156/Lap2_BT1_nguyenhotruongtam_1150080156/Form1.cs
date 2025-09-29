using System;
using System.Windows.Forms;

namespace Lap2_BT1_nguyenhotruongtam_1150080156
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // goi ham trong Designer
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtA.Text, out decimal a) && decimal.TryParse(txtB.Text, out decimal b))
                txtKQ.Text = (a + b).ToString();
            else
                MessageBox.Show("Vui long nhap so hop le!");
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtA.Text, out decimal a) && decimal.TryParse(txtB.Text, out decimal b))
                txtKQ.Text = (a - b).ToString();
            else
                MessageBox.Show("Vui long nhap so hop le!");
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtA.Text, out decimal a) && decimal.TryParse(txtB.Text, out decimal b))
                txtKQ.Text = (a * b).ToString();
            else
                MessageBox.Show("Vui long nhap so hop le!");
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtA.Text, out decimal a) && decimal.TryParse(txtB.Text, out decimal b))
            {
                if (b == 0)
                    MessageBox.Show("Khong the chia cho 0!");
                else
                    txtKQ.Text = (a / b).ToString();
            }
            else
            {
                MessageBox.Show("Vui long nhap so hop le!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            txtKQ.Clear();
            txtA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
