using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lap2_BT3_AD4_nhttam_1150080156
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Gán sự kiện
            btnChon1.Click += btnChon1_Click;
            btnChonAll.Click += btnChonAll_Click;
            btnXoa1.Click += btnXoa1_Click;
            btnXoaAll.Click += btnXoaAll_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo dữ liệu danh sách mặt hàng
            lstDanhSach.Items.AddRange(new object[]
            {
                "CPU",
                "MainBoard",
                "RAM",
                "Keyboard",
                "Mouse",
                "NIC",
                "FAN"
            });
        }

        // Nút >
        private void btnChon1_Click(object sender, EventArgs e)
        {
            while (lstDanhSach.SelectedItems.Count > 0)
            {
                var item = lstDanhSach.SelectedItems[0];
                lstDaChon.Items.Add(item);
                lstDanhSach.Items.Remove(item);
            }
        }

        // Nút >>
        private void btnChonAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstDanhSach.Items)
            {
                lstDaChon.Items.Add(item);
            }
            lstDanhSach.Items.Clear();
        }

        // Nút <
        private void btnXoa1_Click(object sender, EventArgs e)
        {
            while (lstDaChon.SelectedItems.Count > 0)
            {
                var item = lstDaChon.SelectedItems[0];
                lstDanhSach.Items.Add(item);
                lstDaChon.Items.Remove(item);
            }
        }

        // Nút <<
        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            foreach (var item in lstDaChon.Items)
            {
                lstDanhSach.Items.Add(item);
            }
            lstDaChon.Items.Clear();
        }
    }
}
