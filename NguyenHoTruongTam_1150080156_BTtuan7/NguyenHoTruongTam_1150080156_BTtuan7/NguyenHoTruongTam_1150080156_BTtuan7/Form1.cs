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

        private SqlConnection _conn;

        public Form1()
        {
            InitializeComponent();
        }

        // ====== Helpers mở/đóng kết nối ======
        private void OpenConn()
        {
            if (_conn == null) _conn = new SqlConnection(_connStr);
            if (_conn.State == ConnectionState.Closed) _conn.Open();
        }
        private void CloseConn()
        {
            if (_conn != null && _conn.State == ConnectionState.Open) _conn.Close();
        }

        // ====== Cấu hình cột ListView (lsvDanhSach) ======
        private void ConfigListView()
        {
            if (lsvDanhSach.Columns.Count == 0)
            {
                lsvDanhSach.View = View.Details;
                lsvDanhSach.FullRowSelect = true;
                lsvDanhSach.Columns.Add("Mã SV", 90);
                lsvDanhSach.Columns.Add("Tên SV", 160);
                lsvDanhSach.Columns.Add("Giới tính", 70);
                lsvDanhSach.Columns.Add("Ngày sinh", 90);
                lsvDanhSach.Columns.Add("Quê quán", 140);
                lsvDanhSach.Columns.Add("Mã lớp", 80);
            }
        }

        // ====== Nạp danh sách lớp vào combo cbChonLop ======
        private void LoadComboLop()
        {
            cbChonLop.Items.Clear();
            try
            {
                OpenConn();
                using (var cmd = new SqlCommand("SELECT MaLop, TenLop FROM dbo.Lop ORDER BY MaLop", _conn))
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        cbChonLop.Items.Add($"{rd.GetString(0)} - {rd.GetString(1)}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp lớp: " + ex.Message);
            }
            finally { CloseConn(); }
        }

        // ====== Load sinh viên theo mã lớp vào lsvDanhSach ======
        private void LoadStudentsByClass(string maLop)
        {
            lsvDanhSach.Items.Clear();
            try
            {
                OpenConn();
                using (var cmd = new SqlCommand(
                    "SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop FROM dbo.SinhVien WHERE MaLop = @MaLop",
                    _conn))
                {
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    using (var rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            var lvi = new ListViewItem(rd.GetString(0));
                            lvi.SubItems.Add(rd.GetString(1));
                            lvi.SubItems.Add(rd.GetString(2));
                            lvi.SubItems.Add(rd.GetDateTime(3).ToString("yyyy-MM-dd"));
                            lvi.SubItems.Add(rd.IsDBNull(4) ? "" : rd.GetString(4));
                            lvi.SubItems.Add(rd.GetString(5));
                            lsvDanhSach.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách SV: " + ex.Message);
            }
            finally { CloseConn(); }
        }

        // ====== Form Load (Designer đang gắn FrmSuaKhongParam_Load) ======
        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigListView();

            cbGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            if (cbGioiTinh.Items.Count == 0)
            {
                cbGioiTinh.Items.Add("Nam");
                cbGioiTinh.Items.Add("Nữ");
            }

            LoadComboLop();
            if (cbChonLop.Items.Count > 0) cbChonLop.SelectedIndex = 0;
        }

        // Alias để khớp event name trong Designer
        private void FrmSuaKhongParam_Load(object sender, EventArgs e) => Form1_Load(sender, e);

        // ====== Khi chọn lớp trong cbChonLop ======
        private void cbChonLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbChonLop.SelectedIndex < 0) return;
            var maLop = cbChonLop.Text.Split('-')[0].Trim();
            LoadStudentsByClass(maLop);
        }

        // ====== Click chọn 1 dòng trên ListView: đổ dữ liệu lên các ô bên phải ======
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;
            var it = lsvDanhSach.SelectedItems[0];

            txtMaSV.Text = it.SubItems[0].Text;
            txtTenSV.Text = it.SubItems[1].Text;
            cbGioiTinh.Text = it.SubItems[2].Text;

            if (DateTime.TryParse(it.SubItems[3].Text, out DateTime d))
                dtpNgaySinh.Value = d;

            txtQueQuan.Text = it.SubItems[4].Text;
            txtMaLop.Text = it.SubItems[5].Text;
        }

        // ====== Nút "Sửa thông tin" (update theo MaSV) ======
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                MessageBox.Show("Chọn 1 sinh viên trong danh sách!");
                return;
            }

            try
            {
                string sql = @"
UPDATE dbo.SinhVien SET
 TenSV   = @TenSV,
 GioiTinh= @GioiTinh,
 NgaySinh= @NgaySinh,
 QueQuan = @QueQuan,
 MaLop   = @MaLop
WHERE MaSV = @MaSV";

                OpenConn();
                using (var cmd = new SqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);
                    cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value.Date);
                    if (string.IsNullOrWhiteSpace(txtQueQuan.Text))
                        cmd.Parameters.AddWithValue("@QueQuan", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());

                    int n = cmd.ExecuteNonQuery();
                    MessageBox.Show(n > 0 ? "Cập nhật thành công!" : "Không có bản ghi nào được cập nhật.");
                }

                // Reload danh sách theo lớp đang chọn
                if (cbChonLop.SelectedIndex >= 0)
                    LoadStudentsByClass(cbChonLop.Text.Split('-')[0].Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
            finally { CloseConn(); }
        }
    }
}
