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

namespace NguyenHoTruongTam_1150080156_Buoi9
{
    public partial class Form2 : Form
    {
        // === Chuỗi kết nối LocalDB (sửa cho phù hợp) ===
        private readonly string _strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLyBanSach;Integrated Security=True;Connect Timeout=30";
        // Nếu dùng file .mdf:
        // private readonly string _strCon =
        //   @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SQL\QuanLyBanSach.mdf;Integrated Security=True;Connect Timeout=30";

        public Form2()
        {
            InitializeComponent();
        }

        // Nạp danh sách bên trái
        private void Form1_Load(object sender, EventArgs e)
        {
            NapDanhSach();
        }

        private void NapDanhSach()
        {
            try
            {
                using (var conn = new SqlConnection(_strCon))
                using (var adp = new SqlDataAdapter(
                    "SELECT MaXB, TenXB, DiaChi FROM dbo.NhaXuatBan ORDER BY MaXB", conn))
                {
                    var tbl = new DataTable();
                    adp.Fill(tbl);
                    dgvNhaXB.DataSource = tbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách.\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Xử lý nút Thêm dữ liệu (bên phải)
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaXB.Text) ||
                string.IsNullOrWhiteSpace(txtTenXB.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã NXB và Tên NXB!");
                return;
            }

            try
            {
                using (var conn = new SqlConnection(_strCon))
                using (var cmd = new SqlCommand(
                    @"INSERT INTO dbo.NhaXuatBan(MaXB, TenXB, DiaChi)
                      VALUES (@Ma, @Ten, @DiaChi)", conn))
                {
                    cmd.Parameters.Add("@Ma", SqlDbType.NVarChar, 10).Value = txtMaXB.Text.Trim();
                    cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 100).Value = txtTenXB.Text.Trim();
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = (object)txtDiaChi.Text.Trim() ?? DBNull.Value;

                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (n > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        ClearInputs();
                        NapDanhSach();
                    }
                    else
                    {
                        MessageBox.Show("Không có dòng nào được thêm.");
                    }
                }
            }
            catch (SqlException sqlEx) when (sqlEx.Number == 2627 || sqlEx.Number == 2601)
            {
                MessageBox.Show("Mã NXB đã tồn tại! Vui lòng nhập mã khác.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaXB.Clear();
            txtTenXB.Clear();
            txtDiaChi.Clear();
            txtMaXB.Focus();
        }
    }
}