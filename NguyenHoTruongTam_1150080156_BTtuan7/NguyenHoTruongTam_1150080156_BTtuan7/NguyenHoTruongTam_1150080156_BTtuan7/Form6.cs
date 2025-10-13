using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_BTtuan7
{
    public partial class Form6 : Form
    {
        private readonly string _connStr =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=""D:\A.MÔN HỌC\DACN\PPPT_PMHDT\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\QuanlySinhvien.mdf"";
              Integrated Security=True";

        private SqlConnection sqlCon = null;

        public Form6()
        {
            InitializeComponent();
        }

        // ===== Mở kết nối =====
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(_connStr); // <— sửa strCon -> _connStr
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
        }

        // ===== Đóng kết nối =====
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == System.Data.ConnectionState.Open)
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

        // ===== Form load =====
        private void Form6_Load(object sender, EventArgs e)
        {
            HienThiDSSinhVien();
        }

        // ===== Nút xóa sinh viên (dùng Parameter) =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            string maSV = lsvDanhSach.SelectedItems[0].SubItems[0].Text;

            if (MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {maSV} không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand("DELETE FROM SinhVien WHERE MaSV = @MaSV", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSV);
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Đã xóa sinh viên thành công!" : "Không tìm thấy sinh viên để xóa!");
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
