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
    public partial class Form3 : Form
    {
        private readonly string _strCon =
             @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLyBanSach;Integrated Security=True;Connect Timeout=30";
        // Hoặc dùng .mdf:
        // private readonly string _strCon =
        //   @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SQL\QuanLyBanSach.mdf;Integrated Security=True;Connect Timeout=30";

        // Lưu mã gốc của bản ghi đang chọn (để update đúng hàng khi đổi MaXB trên form)
        private string _maGoc = null;

        public Form3()
        {
            InitializeComponent();
        }

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
                _maGoc = null;
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được danh sách.\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvNhaXB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dgvNhaXB.CurrentRow == null) return;

            var row = dgvNhaXB.Rows[e.RowIndex];
            txtMaXB.Text = row.Cells["MaXB"].Value?.ToString();
            txtTenXB.Text = row.Cells["TenXB"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();

            _maGoc = txtMaXB.Text; // lưu khóa hiện tại
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (_maGoc == null)
            {
                MessageBox.Show("Vui lòng chọn một dòng ở danh sách để chỉnh sửa.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaXB.Text) ||
                string.IsNullOrWhiteSpace(txtTenXB.Text))
            {
                MessageBox.Show("Mã NXB và Tên NXB không được để trống!");
                return;
            }

            try
            {
                using (var conn = new SqlConnection(_strCon))
                using (var cmd = new SqlCommand(
                    @"UPDATE dbo.NhaXuatBan
                      SET MaXB = @MaMoi, TenXB = @Ten, DiaChi = @DiaChi
                      WHERE MaXB = @MaGoc", conn))
                {
                    cmd.Parameters.Add("@MaMoi", SqlDbType.NVarChar, 10).Value = txtMaXB.Text.Trim();
                    cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 100).Value = txtTenXB.Text.Trim();
                    cmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar, 200).Value = (object)txtDiaChi.Text.Trim() ?? DBNull.Value;
                    cmd.Parameters.Add("@MaGoc", SqlDbType.NVarChar, 10).Value = _maGoc;

                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (n > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        NapDanhSach();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi để cập nhật.");
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                // Vi phạm unique/primary key khi đổi MaXB trùng
                MessageBox.Show("Mã NXB mới đã tồn tại. Hãy chọn mã khác.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaXB.Clear();
            txtTenXB.Clear();
            txtDiaChi.Clear();
        }
    }
}