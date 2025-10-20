using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_Buoi8
{
    public partial class Form1 : Form
    {
        // --- Chuỗi kết nối ---
        // CÁCH 1: dùng tên database (nếu DB đã attach trong LocalDB)
        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLyBanSach;Integrated Security=True;Connect Timeout=30";

        // CÁCH 2 (thay cho CÁCH 1 nếu muốn đính kèm file .mdf):
        // private readonly string strCon =
        //     @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\QuanLyBanSach.mdf;Integrated Security=True;Connect Timeout=30";

        // Đối tượng kết nối dùng lại trong form
        private SqlConnection sqlCon;

        public Form1()
        {
            InitializeComponent();
        }

        // --- MỞ KẾT NỐI ---
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // --- ĐÓNG KẾT NỐI ---
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        // --- HIỂN THỊ DANH SÁCH NHÀ XUẤT BẢN ---
        // Yêu cầu bạn đã tạo SP:  CREATE PROCEDURE HienThiXB AS SELECT MaXB, TenXB, DiaChi FROM NhaXuatBan;
        private void HienThiDanhSachXB()
        {
            try
            {
                MoKetNoi();

                using (var cmd = new SqlCommand("HienThiXB", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (var reader = cmd.ExecuteReader())
                    {
                        lsvDanhSach.Items.Clear();

                        while (reader.Read())
                        {
                            string maXB = reader.GetString(0);
                            string tenXB = reader.GetString(1);
                            string diaChi = reader.GetString(2);

                            var lvi = new ListViewItem(maXB);
                            lvi.SubItems.Add(tenXB);
                            lvi.SubItems.Add(diaChi);
                            lsvDanhSach.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        // --- FORM LOAD: gọi hiển thị danh sách ---
        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSachXB();
        }

        // --- SỰ KIỆN CHỌN DÒNG TRONG LISTVIEW: hiển thị chi tiết ---
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            string maXB = lvi.SubItems[0].Text;

            HienThiThongTinXBTheoMa(maXB);
        }

        // --- HIỂN THỊ THÔNG TIN CHI TIẾT THEO MÃ ---
        // Yêu cầu bạn đã tạo SP:
        // CREATE PROCEDURE HienThiChiTietXB @maXB CHAR(10) AS SELECT MaXB, TenXB, DiaChi FROM NhaXuatBan WHERE MaXB=@maXB;
        private void HienThiThongTinXBTheoMa(string maXB)
        {
            try
            {
                MoKetNoi();

                using (var cmd = new SqlCommand("HienThiChiTietXB", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@maXB", SqlDbType.Char, 10) { Value = maXB });

                    using (var reader = cmd.ExecuteReader())
                    {
                        // Clear trước
                        txtMaXB.Text = txtTenXB.Text = txtDiaChi.Text = string.Empty;

                        if (reader.Read())
                        {
                            string _maXB = reader.GetString(0);
                            string tenXB = reader.GetString(1);
                            string diaChi = reader.GetString(2);

                            txtMaXB.Text = _maXB;
                            txtTenXB.Text = tenXB;
                            txtDiaChi.Text = diaChi;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị chi tiết: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
    }
}