    using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace NguyenHoTruongTam_1150080156_Lap3_TH1
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, decimal> _menu = new Dictionary<string, decimal>()
        {
            {"Cơm chiên trứng", 30000},
            {"Bánh mì ốp la", 25000},
            {"Coca", 15000},
            {"Lipton", 15000},
            {"Ốc rang muối", 45000},
            {"Khoai tây chiên", 25000},
            {"7 up", 15000},
            {"Cam", 15000},
            {"Mỳ xào hải sản", 50000},
            {"Cá viên chiên", 25000},
            {"Pepsi", 15000},
            {"Cafe", 20000},
            {"Buger bò nướng", 55000},
            {"Đùi gà rán", 45000},
            {"Bún bò Huế", 40000}
        };

        private readonly Dictionary<string, Tuple<int, decimal>> _cart =
            new Dictionary<string, Tuple<int, decimal>>();

        public Form1()
        {
            InitializeComponent();
            // Nếu không dùng Resource trong Designer, có thể gán ở đây:
            // picLogo.Image = Properties.Resources.LOGO1;

            BuildMenuButtons();
            cbBan.Items.AddRange(Enumerable.Range(1, 20).Select(i => "Bàn " + i).ToArray());
            cbBan.SelectedIndex = 0;
            BindGrid();
        }

        private void BuildMenuButtons()
        {
            flpMon.Controls.Clear();
            foreach (var kv in _menu)
            {
                var b = new Button();
                b.Text = kv.Key;
                b.Width = 150;
                b.Height = 36;
                b.Margin = new Padding(10, 8, 10, 8);
                b.BackColor = Color.Gainsboro;
                b.FlatStyle = FlatStyle.Standard;
                b.Tag = kv.Key;
                b.Click += (s, e) => AddItem((string)((Button)s).Tag);
                flpMon.Controls.Add(b);
            }
        }

        private void AddItem(string name)
        {
            decimal price = _menu[name];
            if (_cart.ContainsKey(name))
            {
                var cur = _cart[name];
                _cart[name] = Tuple.Create(cur.Item1 + 1, price);
            }
            else
            {
                _cart[name] = Tuple.Create(1, price);
            }
            BindGrid();
        }

        private void BindGrid()
        {
            var dt = new DataTable();
            dt.Columns.Add("Món", typeof(string));
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Đơn giá", typeof(decimal));
            dt.Columns.Add("Thành tiền", typeof(decimal));

            decimal total = 0;
            foreach (var kv in _cart)
            {
                decimal thanhTien = kv.Value.Item1 * kv.Value.Item2;
                total += thanhTien;
                dt.Rows.Add(kv.Key, kv.Value.Item1, kv.Value.Item2, thanhTien);
            }

            dgvOrder.DataSource = dt;
            lblTotal.Text = "Tổng: " + total.ToString("n0") + " đ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvOrder.CurrentRow == null) return;
            var name = Convert.ToString(dgvOrder.CurrentRow.Cells[0].Value);
            if (!string.IsNullOrWhiteSpace(name) && _cart.ContainsKey(name))
            {
                _cart.Remove(name);
                BindGrid();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Chưa có món nào.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string ban = cbBan.SelectedItem != null ? cbBan.SelectedItem.ToString() : "Bàn ?";
            string ts = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string file = "Order_" + ban.Replace(' ', '_') + "_" + ts + ".txt";

            using (var sw = new StreamWriter(file))
            {
                sw.WriteLine("Quán ăn nhanh Trường Tam - " + ban);
                sw.WriteLine("Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                sw.WriteLine(new string('-', 48));
                decimal total = 0;
                foreach (var kv in _cart)
                {
                    decimal tt = kv.Value.Item1 * kv.Value.Item2;
                    total += tt;
                    sw.WriteLine(string.Format("{0,-25} x{1,2}  {2,8:n0}  => {3,10:n0}",
                        kv.Key, kv.Value.Item1, kv.Value.Item2, tt));
                }
                sw.WriteLine(new string('-', 48));
                sw.WriteLine("TỔNG: " + total.ToString("n0") + " đ");
            }

            MessageBox.Show("Đã ghi " + file + " cạnh file .exe", "Order thành công");
            _cart.Clear();
            BindGrid();
        }

        private void flpMon_Paint(object sender, PaintEventArgs e) { }

        private void pnlBottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
