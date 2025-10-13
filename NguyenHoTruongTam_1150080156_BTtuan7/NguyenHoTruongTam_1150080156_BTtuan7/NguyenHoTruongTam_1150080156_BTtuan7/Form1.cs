using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_BTtuan7
{
    public partial class Form1 : Form
    {
        // Chuỗi kết nối .mdf của bạn
        private readonly string _connStr =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=""D:\A.MÔN HỌC\DACN\PPPT_PMHDT\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\QuanlySinhvien.mdf"";
              Integrated Security=True";

        private SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        // Hàm mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(_connStr); // <<< SỬA: dùng _connStr thay vì strCon

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

                using (SqlCommand sqlCmd = new SqlCommand("SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop FROM SinhVien", sqlCon))
                using (SqlDataReader reader = sqlCmd.ExecuteReader())
                {
                    lsvDanhSachSV.Items.Clear();

                    while (reader.Read())
                    {
                        string maSv = reader.GetString(0);
                        string tenSv = reader.GetString(1);
                        string gioiTinh = reader.GetString(2);
                        string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                        string queQuan = reader.IsDBNull(4) ? "" : reader.GetString(4); // <<< tránh lỗi NULL
                        string maLop = reader.GetString(5);

                        ListViewItem lvi = new ListViewItem(maSv);
                        lvi.SubItems.Add(tenSv);
                        lvi.SubItems.Add(gioiTinh);
                        lvi.SubItems.Add(ngaySinh);
                        lvi.SubItems.Add(queQuan);
                        lvi.SubItems.Add(maLop);

                        lsvDanhSachSV.Items.Add(lvi);
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

        // Nút Thêm sinh viên (không dùng Parameter)
        private void btnThemSinhVien_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();

                string maSV = txtMaSV.Text.Trim();
                string tenSV = txtTenSV.Text.Trim();
                string gioiTinh = cbGioiTinh.Text.Trim();
                string ngaySinh = dtpNgaySinh.Value.ToString("MM/dd/yyyy"); // an toàn cho DATE
                string queQuan = txtQueQuan.Text.Trim();
                string maLop = txtMaLop.Text.Trim();

                if (maSV == "" || tenSV == "" || gioiTinh == "" || maLop == "")
                {
                    MessageBox.Show("Nhập đủ: Mã SV, Tên SV, Giới tính, Mã lớp!");
                    return;
                }

                using (SqlCommand sqlCmd = new SqlCommand(
                    "INSERT INTO SinhVien VALUES (N'" + maSV + "', N'" + tenSV + "', N'" +
                    gioiTinh + "', '" + ngaySinh + "', N'" + queQuan + "', N'" + maLop + "')", sqlCon))
                {
                    int kq = sqlCmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Thêm sinh viên thành công!" : "Không có bản ghi nào được thêm!");
                }

                HienThiDanhSach();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message);
            }
            finally
            {
                DongKetNoi();
            }
        }

        // Khi form load
        private void Form1_Load(object sender, EventArgs e)
        {
            if (cbGioiTinh.Items.Count == 0)
            {
                cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
                cbGioiTinh.Items.Add("Nam");
                cbGioiTinh.Items.Add("Nữ");
            }
            HienThiDanhSach();
        }
    }
}
