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
    public partial class Form4 : Form
    {
        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLyBanSach;Integrated Security=True;Connect Timeout=30";

        private SqlConnection sqlCon;

        public Form4()
        {
            InitializeComponent();
        }

        // --- Kết nối ---
        private void MoKetNoi()
        {
            if (sqlCon == null) sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == ConnectionState.Closed) sqlCon.Open();
        }
        private void DongKetNoi()
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open) sqlCon.Close();
        }

        // --- Load ---
        private void Form4_Load(object sender, EventArgs e)
        {
            btnXoa.Enabled = false;
            NapDanhSach();
        }

        // --- Nạp danh sách (SP: HienThiXB) ---
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

        // --- Chọn dòng ---
        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = lsvDanhSach.SelectedItems.Count > 0;
        }

        // --- Xóa (SP: XoaNXB, trả @@ROWCOUNT) ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0) return;

            var it = lsvDanhSach.SelectedItems[0];
            string maXB = it.SubItems[0].Text;
            string ten = it.SubItems[1].Text;

            var confirm = MessageBox.Show(
                $"Bạn chắc chắn muốn xóa NXB \"{ten}\" (Mã: {maXB})?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes) return;

            try
            {
                MoKetNoi();
                using (var cmd = new SqlCommand("XoaNXB", sqlCon))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Nếu SP dùng tham số @MaNXB (biến thể B) thì đổi tên tham số ở đây
                    cmd.Parameters.Add(new SqlParameter("@MaXB", SqlDbType.Char, 10)).Value = maXB;

                    object scalar = cmd.ExecuteScalar(); // do NOCOUNT ON
                    int rows = 0;
                    if (scalar != null && int.TryParse(scalar.ToString(), out var r)) rows = r;

                    if (rows > 0)
                    {
                        MessageBox.Show("Đã xóa thành công!");
                        NapDanhSach();
                        btnXoa.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy bản ghi để xóa.");
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("SQL error: " + sqlex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
            }
            finally { DongKetNoi(); }
        }
    }
}