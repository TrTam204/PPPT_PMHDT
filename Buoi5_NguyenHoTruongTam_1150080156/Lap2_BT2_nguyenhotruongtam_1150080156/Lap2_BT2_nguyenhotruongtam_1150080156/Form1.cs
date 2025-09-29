using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lap2_BT2_nguyenhotruongtam_1150080156
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            btnTinh.Click += btnTinh_Click;
            btnThoat.Click += btnThoat_Click;

            // Bật/tắt NumericUpDown theo CheckBox
            chkHanRang.CheckedChanged += (s, e) => numHan.Enabled = chkHanRang.Checked;
            chkBeRang.CheckedChanged += (s, e) => numBe.Enabled = chkBeRang.Checked;
            chkBocRang.CheckedChanged += (s, e) => numBoc.Enabled = chkBocRang.Checked;
        }

        // Đơn giá
        const int GIA_CAO_RANG = 50_000;   // /2 hàm
        const int GIA_TAY_TRANG = 100_000; // /2 hàm
        const int GIA_HAN_RANG = 100_000;  // /1 răng
        const int GIA_BE_RANG = 10_000;    // /1 răng
        const int GIA_BOC_RANG = 1_000_000;// /1 răng

        private void btnTinh_Click(object sender, EventArgs e)
        {
            int tong = 0;

            if (chkCaoRang.Checked) tong += GIA_CAO_RANG;
            if (chkTayTrang.Checked) tong += GIA_TAY_TRANG;
            if (chkHanRang.Checked) tong += GIA_HAN_RANG * (int)numHan.Value;
            if (chkBeRang.Checked) tong += GIA_BE_RANG * (int)numBe.Value;
            if (chkBocRang.Checked) tong += GIA_BOC_RANG * (int)numBoc.Value;

            // Hiển thị tiền VNĐ
            txtTong.Text = tong.ToString("#,0 VNĐ", CultureInfo.GetCultureInfo("vi-VN"));
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtTong.Clear();

            chkCaoRang.Checked = false;
            chkTayTrang.Checked = false;
            chkHanRang.Checked = false;
            chkBeRang.Checked = false;
            chkBocRang.Checked = false;

            numHan.Value = 1;
            numBe.Value = 1;
            numBoc.Value = 1;

            txtName.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show("Thoát chương trình?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
