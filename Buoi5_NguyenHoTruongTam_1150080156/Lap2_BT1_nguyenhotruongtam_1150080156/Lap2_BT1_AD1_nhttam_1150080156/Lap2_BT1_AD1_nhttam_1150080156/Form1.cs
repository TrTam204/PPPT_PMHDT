using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap2_BT1_AD1_nhttam_1150080156
{
    public partial class Form1 : Form
    {
        public Form1()
 public Form1()
        {
            InitializeComponent();
        }

        int USCLN(int a, int b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            if (a == 0) return b;
            if (b == 0) return a;
            while (b != 0)
            {
                int r = a % b;
                a = b; b = r;
            }
            return a;
        }

        int BSCNN(int a, int b)
        {
            a = Math.Abs(a); b = Math.Abs(b);
            if (a == 0 || b == 0) return 0;
            return (a / USCLN(a, b)) * b;
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text.Trim(), out int a) ||
                !int.TryParse(txtB.Text.Trim(), out int b))
            {
                MessageBox.Show("Vui long nhap so nguyen hop le!");
                return;
            }

            if (rdoUSCLN.Checked)
                txtKQ.Text = USCLN(a, b).ToString();
            else if (rdoBSCNN.Checked)
                txtKQ.Text = BSCNN(a, b).ToString();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}