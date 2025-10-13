using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_BTtuan7
{
    public partial class Form4 : Form
    {
        private readonly string _connStr =
            @"Data Source=(LocalDB)\MSSQLLocalDB;
              AttachDbFilename=""D:\A.MÔN HỌC\DACN\PPPT_PMHDT\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\NguyenHoTruongTam_1150080156_BTtuan7\QuanlySinhvien.mdf"";
              Integrated Security=True";

        private SqlConnection sqlCon;   // <- đã có

        public Form4()
        {
            InitializeComponent();
        }

        // Mở kết nối
        private void MoKetNoi()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(_connStr);   // <-- ĐỔI strCon -> _connStr
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();
        }

        // Đóng kết nối
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                sqlCon.Close();
        }

        private void HienThiDSMaLop()
        {
            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand("SELECT MaLop, TenLop FROM Lop", sqlCon))
                using (var reader = cmd.ExecuteReader())
                {
                    cbMaLop.Items.Clear();
                    while (reader.Read())
                        cbMaLop.Items.Add($"{reader.GetString(0)} - {reader.GetString(1)}");
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hiển thị lớp: " + ex.Message); }
            finally { DongKetNoi(); }
        }

        private void HienThiDSSVTheoLop(string maLop)
        {
            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand("SELECT * FROM SinhVien WHERE MaLop=@MaLop", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaLop", maLop);
                    using (var reader = cmd.ExecuteReader())
                    {
                        lsvDanhSach.Items.Clear();
                        while (reader.Read())
                        {
                            var lvi = new ListViewItem(reader["MaSV"].ToString());
                            lvi.SubItems.Add(reader["TenSV"].ToString());
                            lvi.SubItems.Add(reader["GioiTinh"].ToString());
                            lvi.SubItems.Add(Convert.ToDateTime(reader["NgaySinh"]).ToString("dd/MM/yyyy"));
                            lvi.SubItems.Add(reader["QueQuan"] == DBNull.Value ? "" : reader["QueQuan"].ToString());
                            lvi.SubItems.Add(reader["MaLop"].ToString());
                            lsvDanhSach.Items.Add(lvi);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Lỗi hiển thị sinh viên: " + ex.Message); }
            finally { DongKetNoi(); }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            HienThiDSMaLop();
            cbGioiTinh.Items.Clear();
            cbGioiTinh.Items.Add("Nam");
            cbGioiTinh.Items.Add("Nữ");
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaLop.SelectedIndex == -1) return;
            var maLop = cbMaLop.Text.Split('-')[0].Trim();
            HienThiDSSVTheoLop(maLop);
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;
            var it = lsvDanhSach.SelectedItems[0];
            txtMaSV.Text = it.SubItems[0].Text;
            txtTenSV.Text = it.SubItems[1].Text;
            cbGioiTinh.Text = it.SubItems[2].Text;
            DateTime d; if (DateTime.TryParse(it.SubItems[3].Text, out d)) dtpNgaySinh.Value = d;
            txtQueQuan.Text = it.SubItems[4].Text;
            txtMaLop.Text = it.SubItems[5].Text;
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand(
@"UPDATE SinhVien 
  SET TenSV=@TenSV, GioiTinh=@GioiTinh, NgaySinh=@NgaySinh, QueQuan=@QueQuan, MaLop=@MaLop 
WHERE MaSV=@MaSV", sqlCon))
                {
                    cmd.Parameters.AddWithValue("@MaSV", txtMaSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenSV", txtTenSV.Text.Trim());
                    cmd.Parameters.AddWithValue("@GioiTinh", cbGioiTinh.Text);
                    cmd.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dtpNgaySinh.Value.Date;
                    if (string.IsNullOrWhiteSpace(txtQueQuan.Text))
                        cmd.Parameters.AddWithValue("@QueQuan", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@QueQuan", txtQueQuan.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaLop", txtMaLop.Text.Trim());

                    int kq = cmd.ExecuteNonQuery();
                    MessageBox.Show(kq > 0 ? "Cập nhật thành công!" : "Không có bản ghi nào được cập nhật!");
                }

                if (!string.IsNullOrWhiteSpace(txtMaLop.Text))
                    HienThiDSSVTheoLop(txtMaLop.Text.Trim());
            }
            catch (Exception ex) { MessageBox.Show("Lỗi sửa thông tin: " + ex.Message); }
            finally { DongKetNoi(); }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
