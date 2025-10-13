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
    public partial class Form2 : Form
    {
        // Chuỗi kết nối
        private readonly string _connStr =
                @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=""D:\A.MÔN HỌC\DACN\PPPT_PMHDT\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\QuanlySinhvien.mdf"";
              Integrated Security=True";

        private SqlConnection sqlCon = null;

        public Form2()
        {
            InitializeComponent();
        }

        // Hàm mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);

            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // Hàm đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        // Hàm hiển thị danh sách sinh viên
        private void HienThiDanhSach()
        {
            try
            {
                MoKetNoi();

                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM SinhVien", sqlCon);

                lsvDanhSachSV.Items.Clear();
                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string maSv = reader.GetString(0);
                    string tenSv = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    string queQuan = reader.GetString(4);
                    string maLop = reader.GetString(5);

                    ListViewItem lvi = new ListViewItem(maSv);
                    lvi.SubItems.Add(tenSv);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(ngaySinh);
                    lvi.SubItems.Add(queQuan);
                    lvi.SubItems.Add(maLop);
                    lsvDanhSachSV.Items.Add(lvi);
                }

                reader.Close();
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

        // Nút Thêm sinh viên (có dùng Parameter)
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                string maSV = txtMaSV.Text.Trim();
                string tenSV = txtTenSV.Text.Trim();
                string gioiTinh = cbGioiTinh.Text.Trim();
                DateTime ngaySinh = dtpNgaySinh.Value.Date;
                string queQuan = txtQueQuan.Text.Trim();
                string maLop = txtMaLop.Text.Trim();

                if (maSV == "" || tenSV == "")
                {
                    MessageBox.Show("Mã sinh viên và Tên sinh viên không được bỏ trống!");
                    return;
                }

                string sql = @"INSERT INTO SinhVien (MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop)
                               VALUES (@MaSV, @TenSV, @GioiTinh, @NgaySinh, @QueQuan, @MaLop)";

                SqlCommand cmd = new SqlCommand(sql, sqlCon);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@MaSV", maSV);
                cmd.Parameters.AddWithValue("@TenSV", tenSV);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = ngaySinh;
                cmd.Parameters.AddWithValue("@QueQuan", queQuan);
                cmd.Parameters.AddWithValue("@MaLop", maLop);

                int kq = cmd.ExecuteNonQuery();

                if (kq > 0)
                {
                    MessageBox.Show("Thêm sinh viên (parameter) thành công!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Không có bản ghi nào được thêm!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu (parameter): " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        // Khi form load
        private void Form2_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            HienThiDanhSach();
        }
    }
}