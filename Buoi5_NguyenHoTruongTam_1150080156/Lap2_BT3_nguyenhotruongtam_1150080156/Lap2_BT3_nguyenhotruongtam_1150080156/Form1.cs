using System;
using System.Linq;
using System.Windows.Forms;

namespace Lap2_BT3_nguyenhotruongtam_1150080156
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gắn sự kiện
            btnNhap.Click += btnNhap_Click;
            btnTang2.Click += btnTang2_Click;
            btnChonChanDau.Click += btnChonChanDau_Click;
            btnChonLeCuoi.Click += btnChonLeCuoi_Click;
            btnXoaDangChon.Click += btnXoaDangChon_Click;
            btnXoaDau.Click += btnXoaDau_Click;
            btnXoaCuoi.Click += btnXoaCuoi_Click;
            btnXoaDay.Click += (s, e) => lsbDaySo.Items.Clear();
            btnKetThuc.Click += (s, e) =>
            {
                if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Close();
            };

            // Enter để nhập nhanh
            txtSo.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { btnNhap.PerformClick(); e.SuppressKeyPress = true; }
            };
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int n;
            if (!int.TryParse(txtSo.Text.Trim(), out n))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSo.SelectAll();
                txtSo.Focus();
                return;
            }
            lsbDaySo.Items.Add(n);
            txtSo.Clear();
            txtSo.Focus();
        }

        private void btnTang2_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) return;
            var mang = lsbDaySo.Items.Cast<object>().Select(x => Convert.ToInt32(x) + 2).ToArray();
            lsbDaySo.Items.Clear();
            foreach (var x in mang) lsbDaySo.Items.Add(x);
        }

        private void btnChonChanDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) return;
            int idx = -1;
            for (int i = 0; i < lsbDaySo.Items.Count; i++)
            {
                if (Convert.ToInt32(lsbDaySo.Items[i]) % 2 == 0) { idx = i; break; }
            }
            if (idx >= 0) lsbDaySo.SelectedIndex = idx;
            else MessageBox.Show("Không có số chẵn trong dãy.", "Thông báo");
        }

        private void btnChonLeCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count == 0) return;
            int idx = -1;
            for (int i = lsbDaySo.Items.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(lsbDaySo.Items[i]) % 2 != 0) { idx = i; break; }
            }
            if (idx >= 0) lsbDaySo.SelectedIndex = idx;
            else MessageBox.Show("Không có số lẻ trong dãy.", "Thông báo");
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.SelectedIndex >= 0)
                lsbDaySo.Items.RemoveAt(lsbDaySo.SelectedIndex);
            else
                MessageBox.Show("Hãy chọn một phần tử để xóa.", "Thông báo");
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0) lsbDaySo.Items.RemoveAt(0);
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            if (lsbDaySo.Items.Count > 0) lsbDaySo.Items.RemoveAt(lsbDaySo.Items.Count - 1);
        }
    }
}
