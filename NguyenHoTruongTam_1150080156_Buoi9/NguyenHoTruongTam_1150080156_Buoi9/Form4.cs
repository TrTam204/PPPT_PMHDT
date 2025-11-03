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
    public partial class Form4 : Form
    {
        private readonly string _strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLyBanSach;Integrated Security=True;Connect Timeout=30";
        // Hoặc dùng file .mdf:
        // private readonly string _strCon =
        //   @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SQL\QuanLyBanSach.mdf;Integrated Security=True;Connect Timeout=30";

        public Form4()
        {
            InitializeComponent();
            this.panelBottom.Resize += (_, __) => CenterDeleteButton();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterDeleteButton();
            NapDanhSach();
        }

        private void CenterDeleteButton()
        {
            // canh giữa nút xóa theo chiều ngang như ảnh
            btnXoa.Left = (panelBottom.ClientSize.Width - btnXoa.Width) / 2;
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

        private string GetSelectedMaXB()
        {
            if (dgvNhaXB.CurrentRow == null) return null;
            var cell = dgvNhaXB.CurrentRow.Cells["MaXB"];
            return cell?.Value?.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = GetSelectedMaXB();
            if (string.IsNullOrEmpty(ma))
            {
                MessageBox.Show("Hãy chọn 1 dòng trong danh sách để xóa.");
                return;
            }

            var confirm = MessageBox.Show($"Bạn chắc chắn xóa NXB có mã: {ma}?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                using (var conn = new SqlConnection(_strCon))
                using (var cmd = new SqlCommand(
                    "DELETE FROM dbo.NhaXuatBan WHERE MaXB = @Ma", conn))
                {
                    cmd.Parameters.Add("@Ma", SqlDbType.NVarChar, 10).Value = ma;
                    conn.Open();
                    int n = cmd.ExecuteNonQuery();
                    conn.Close();

                    if (n > 0)
                    {
                        MessageBox.Show("Xóa thành công!");
                        NapDanhSach();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi để xóa.");
                    }
                }
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                // Ràng buộc khóa ngoại
                MessageBox.Show("Không thể xóa do dữ liệu đang được tham chiếu ở bảng khác.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu:\n" + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}