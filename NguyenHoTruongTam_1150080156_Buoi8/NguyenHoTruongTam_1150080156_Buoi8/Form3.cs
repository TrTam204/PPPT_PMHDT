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

namespace NguyenHoTruongTam_1150080156_Buoi8
{
    public partial class Form3 : Form
    {
        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLyBanSach;Integrated Security=True;Connect Timeout=30";

        private SqlConnection sqlCon;

        public Form3()
        {
            InitializeComponent();
        }

        // --- KẾT NỐI ---
        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open) sqlCon.Close();
        }

        // --- LOAD FORM ---
        private void Form3_Load(object sender, EventArgs e)
        {
            NapDanhSach();
            txtMaXB.Focus();
        }

        // --- NẠP DANH SÁCH BÊN TRÁI ---
        // SP yêu cầu: HienThiXB (SELECT MaXB, TenXB, DiaChi FROM NhaXuatBan ORDER BY TenXB)
        private void NapDanhSach()
        {
            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand("HienThiXB", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var r = cmd.ExecuteReader())
                    {
                        lsvDanhSach.Items.Clear();
                        while (r.Read())
                        {
                            string ma = r.GetString(0);
                            string ten = r.GetString(1);
                            string dia = r.IsDBNull(2) ? "" : r.GetString(2);

                            var it = new ListViewItem(ma);
                            it.SubItems.Add(ten);
                            it.SubItems.Add(dia);
                            lsvDanhSach.Items.Add(it);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }

        // --- CHỌN MỘT DÒNG → ĐỔ LÊN Ô BÊN PHẢI ---
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;
            var it = lsvDanhSach.SelectedItems[0];
            txtMaXB.Text = it.SubItems[0].Text;   // KHÔNG cho sửa mã khi cập nhật
            txtTenXB.Text = it.SubItems[1].Text;
            txtDiaChi.Text = it.SubItems[2].Text;
        }

        // --- NÚT CẬP NHẬT ---
        // Gọi SP: CapNhatThongTin (trả về @@ROWCOUNT → ExecuteScalar)
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaXB.Text))
            {
                MessageBox.Show("Vui lòng chọn Mã NXB từ danh sách (hoặc nhập chính xác).");
                return;
            }

            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand("CapNhatThongTin", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@maNXB", SqlDbType.Char, 10)).Value = txtMaXB.Text.Trim();
                    cmd.Parameters.Add(new SqlParameter("@tenNXB", SqlDbType.NVarChar, 100)).Value = txtTenXB.Text.Trim();
                    cmd.Parameters.Add(new SqlParameter("@diaChi", SqlDbType.NVarChar, 500)).Value =
                        string.IsNullOrWhiteSpace(txtDiaChi.Text) ? (object)DBNull.Value : txtDiaChi.Text.Trim();

                    object scalar = cmd.ExecuteScalar();  // do NOCOUNT ON
                    int rows = 0;
                    if (scalar != null && int.TryParse(scalar.ToString(), out var r)) rows = r;

                    if (rows > 0)
                    {
                        MessageBox.Show("Cập nhật thành công!");
                        NapDanhSach();     // refresh lại danh sách
                    }
                    else
                    {
                        MessageBox.Show("Không có bản ghi nào được cập nhật.");
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("SQL error: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }
    }
}