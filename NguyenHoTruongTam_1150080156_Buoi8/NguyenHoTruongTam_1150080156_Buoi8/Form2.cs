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
    public partial class Form2 : Form
    {
        // Chuỗi kết nối: đổi Initial Catalog nếu DB của bạn khác
        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLyBanSach;Integrated Security=True;Connect Timeout=30";

        private SqlConnection sqlCon;

        public Form2()
        {
            InitializeComponent();
        }

        // --- Kết nối ---
        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open) sqlCon.Close();
        }

        // --- Form load ---
        private void Form2_Load(object sender, EventArgs e)
        {
            HienThiDanhSachXB();
            txtMaXB.Focus();
        }

        // --- Hiển thị danh sách NXB ---
        // Yêu cầu SP:
        // CREATE OR ALTER PROCEDURE dbo.HienThiXB AS
        // BEGIN SET NOCOUNT ON; SELECT MaXB, TenXB, DiaChi FROM dbo.NhaXuatBan ORDER BY TenXB; END
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
                            string ma = reader.GetString(0);
                            string ten = reader.GetString(1);
                            string diachi = reader.IsDBNull(2) ? "" : reader.GetString(2);

                            var lvi = new ListViewItem(ma);
                            lvi.SubItems.Add(ten);
                            lvi.SubItems.Add(diachi);
                            lsvDanhSach.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị danh sách: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }

        // --- Chọn dòng trong danh sách để đổ vào ô nhập ---
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;
            var it = lsvDanhSach.SelectedItems[0];
            txtMaXB.Text = it.SubItems[0].Text;
            txtTenXB.Text = it.SubItems[1].Text;
            txtDiaChi.Text = it.SubItems[2].Text;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaXB.Text) ||
                string.IsNullOrWhiteSpace(txtTenXB.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã NXB và Tên NXB.");
                return;
            }

            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand("ThemNhaXuatBan", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaXB", SqlDbType.Char, 10)).Value = txtMaXB.Text.Trim();
                    cmd.Parameters.Add(new SqlParameter("@TenXB", SqlDbType.NVarChar, 100)).Value = txtTenXB.Text.Trim();
                    cmd.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.NVarChar, 500)).Value =
                        string.IsNullOrWhiteSpace(txtDiaChi.Text) ? (object)DBNull.Value : txtDiaChi.Text.Trim();

                    // Do NOCOUNT ON, dùng ExecuteScalar lấy @@ROWCOUNT
                    object scalar = cmd.ExecuteScalar();
                    int rows = 0;
                    if (scalar != null && int.TryParse(scalar.ToString(), out var r)) rows = r;

                    if (rows > 0)
                    {
                        MessageBox.Show("Thêm nhà xuất bản thành công!");
                        HienThiDanhSachXB();        // refresh danh sách
                        txtMaXB.Clear(); txtTenXB.Clear(); txtDiaChi.Clear();
                        txtMaXB.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được dữ liệu!");
                    }
                }
            }
            catch (SqlException sqlex)
            {
                // Bắt lỗi RAISERROR từ SP (ví dụ trùng mã)
                MessageBox.Show("SQL Error: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm dữ liệu: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }
    }
}