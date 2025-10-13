using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_BTtuan7
{
    public partial class Form3 : Form
    {
        private readonly string _connStr =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=""D:\A.MÔN HỌC\DACN\PPPT_PMHDT\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\QuanlySinhvien.mdf"";
              Integrated Security=True";

        private SqlConnection sqlCon;   // <<< BỔ SUNG

        public Form3()
        {
            InitializeComponent();
        }

        // ===== KẾT NỐI =====
        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(_connStr);   // <<< dùng _connStr
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }

        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open) sqlCon.Close();
        }

        // ===== HIỂN THỊ DANH SÁCH LỚP =====
        private void HienThiDSMaLop()
        {
            try
            {
                MoKetNoi();
                using (SqlCommand cmd = new SqlCommand("SELECT MaLop, TenLop FROM dbo.Lop ORDER BY MaLop", sqlCon))
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    cbMaLop.Items.Clear();
                    while (rd.Read())
                    {
                        cbMaLop.Items.Add($"{rd.GetString(0)} - {rd.GetString(1)}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị lớp: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }

        // ===== HIỂN THỊ DS SINH VIÊN THEO LỚP =====
        private void HienThiDSSinhVienTheoLop(string maLop)
        {
            try
            {
                MoKetNoi();
                // Có thể dùng Parameter cho SELECT cho an toàn
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan, MaLop FROM dbo.SinhVien WHERE MaLop = @MaLop ORDER BY MaSV", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaLop", maLop);

                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        lsvDanhSach.Items.Clear();
                        while (rd.Read())
                        {
                            var it = new ListViewItem(rd.GetString(0)); // MaSV
                            it.SubItems.Add(rd.GetString(1));            // TenSV
                            it.SubItems.Add(rd.GetString(2));            // GioiTinh
                            it.SubItems.Add(rd.GetDateTime(3).ToString("dd/MM/yyyy")); // NgaySinh
                            it.SubItems.Add(rd.IsDBNull(4) ? "" : rd.GetString(4));    // QueQuan (có thể null)
                            it.SubItems.Add(rd.GetString(5));            // MaLop
                            lsvDanhSach.Items.Add(it);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị sinh viên: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }

        // ===== LOAD FORM =====
        private void Form3_Load(object sender, EventArgs e)
        {
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
            HienThiDSMaLop();
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLop.SelectedIndex < 0) return;
            string ma = cbMaLop.SelectedItem.ToString().Split('-')[0].Trim();
            HienThiDSSinhVienTheoLop(ma);
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;
            var lvi = lsvDanhSach.SelectedItems[0];

            txtMaSV.Text = lvi.SubItems[0].Text;
            txtTenSV.Text = lvi.SubItems[1].Text;
            cbGioiTinh.Text = lvi.SubItems[2].Text;

            DateTime d;
            if (DateTime.TryParseExact(lvi.SubItems[3].Text, "dd/MM/yyyy", null,
                                       System.Globalization.DateTimeStyles.None, out d))
                dtpNgaySinh.Value = d;

            txtQueQuan.Text = lvi.SubItems[4].Text;
            txtMaLop.Text = lvi.SubItems[5].Text;
        }

        // ===== SỬA (KHÔNG DÙNG PARAMETER – escape dấu nháy đơn) =====
        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                string maSV = txtMaSV.Text.Trim();
                string tenSV = txtTenSV.Text.Trim().Replace("'", "''");
                string gioi = cbGioiTinh.Text.Replace("'", "''");
                string ngay = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                string que = txtQueQuan.Text.Trim().Replace("'", "''");
                string maLop = txtMaLop.Text.Trim().Replace("'", "''");

                if (string.IsNullOrWhiteSpace(maSV))
                {
                    MessageBox.Show("Chọn 1 sinh viên hoặc nhập Mã SV để sửa!");
                    txtMaSV.Focus();
                    return;
                }

                string sql = $@"
UPDATE dbo.SinhVien SET
    TenSV = N'{tenSV}',
    GioiTinh = N'{gioi}',
    NgaySinh = '{ngay}',
    QueQuan = N'{que}',
    MaLop = N'{maLop}'
WHERE MaSV = N'{maSV}'";

                MoKetNoi();
                using (SqlCommand cmd = new SqlCommand(sql, sqlCon))
                {
                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Cập nhật thành công!" : "Không có bản ghi nào được cập nhật!");
                }

                // Reload danh sách theo lớp đang chọn
                if (cbMaLop.SelectedIndex >= 0)
                    HienThiDSSinhVienTheoLop(cbMaLop.SelectedItem.ToString().Split('-')[0].Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }
    }
}
