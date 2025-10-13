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

namespace NguyenHoTruongTam_1150080156_BTtuan7
{
    public partial class Form3 : Form
    {
        private readonly string _connStr =
                   @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=""D:\A.MÔN HỌC\DACN\PPPT_PMHDT\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\QuanlySinhvien.mdf"";
              Integrated Security=True";
        private SqlConnection sqlCon = null;


        public Form3()
        {
            InitializeComponent();
        }

        // Mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM SinhVien", sqlCon);
                SqlDataReader reader = cmd.ExecuteReader();

                lsvDanhSach.Items.Clear();
                while (reader.Read())
                {
                    ListViewItem lvi = new ListViewItem(reader["MaSV"].ToString());
                    lvi.SubItems.Add(reader["TenSV"].ToString());
                    lvi.SubItems.Add(reader["GioiTinh"].ToString());
                    lvi.SubItems.Add(Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(reader["QueQuan"].ToString());
                    lvi.SubItems.Add(reader["MaLop"].ToString());
                    lsvDanhSach.Items.Add(lvi);
                }

                reader.Close();
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
        private void Form5_Load(object sender, EventArgs e)
        {
            HienThiDSSinhVien();
        }

        // ===== Nút xóa sinh viên =====
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!");
                return;
            }

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            string maSV = lvi.SubItems[0].Text;

            DialogResult dr = MessageBox.Show($"Bạn có chắc muốn xóa sinh viên {maSV} không?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    MoKetNoi();
                    // ⚠️ Không dùng Parameter — nối chuỗi trực tiếp (theo yêu cầu bài)
                    string sql = "DELETE FROM SinhVien WHERE MaSV='" + maSV + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlCon);
                    int kq = cmd.ExecuteNonQuery();

                    if (kq > 0)
                    {
                        MessageBox.Show("Đã xóa sinh viên thành công!");
                        HienThiDSSinhVien(); // reload lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên để xóa!");
                    }
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

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}