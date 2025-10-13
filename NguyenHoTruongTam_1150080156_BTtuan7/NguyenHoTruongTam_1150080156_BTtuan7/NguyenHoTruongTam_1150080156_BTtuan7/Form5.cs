using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_BTtuan7
{
    public partial class Form5 : Form
    {
        private readonly string _connStr =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=""D:\A.MÔN HỌC\DACN\PPPT_PMHDT\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\QuanlySinhvien.mdf"";
              Integrated Security=True";

        private SqlConnection sqlCon = null;

        public Form5()
        {
            InitializeComponent();
        }

        // ===== Mở kết nối =====
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(_connStr);   // <— sửa strCon -> _connStr
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // ===== Đóng kết nối =====
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        // ===== Hiển thị danh sách sinh viên =====
        private void HienThiDSSinhVien()
        {
            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand("SELECT * FROM SinhVien", sqlCon))
                using (var reader = cmd.ExecuteReader())
                {
                    lsvDanhSach.Items.Clear();
                    while (reader.Read())
                    {
                        var lvi = new ListViewItem(reader["MaSV"].ToString());
                        lvi.SubItems.Add(reader["TenSV"].ToString());
                        lvi.SubItems.Add(reader["GioiTinh"].ToString());
                        lvi.SubItems.Add(Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"));
                        lvi.SubItems.Add(reader["QueQuan"].ToString());
                        lvi.SubItems.Add(reader["MaLop"].ToString());
                        lsvDanhSach.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị sinh viên: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            HienThiDSSinhVien();
        }

        // ===== Nút xóa sinh viên (không dùng Parameter theo yêu cầu) =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            string maSV = lsvDanhSach.SelectedItems[0].SubItems[0].Text;

            if (MessageBox.Show($"Xóa sinh viên {maSV}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                MoKetNoi();
                string sql = "DELETE FROM SinhVien WHERE MaSV='" + maSV + "'";
                using (var cmd = new SqlCommand(sql, sqlCon))
                {
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Đã xóa sinh viên!" : "Không tìm thấy bản ghi để xóa!");
                }
                HienThiDSSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa sinh viên: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }
    }
}
