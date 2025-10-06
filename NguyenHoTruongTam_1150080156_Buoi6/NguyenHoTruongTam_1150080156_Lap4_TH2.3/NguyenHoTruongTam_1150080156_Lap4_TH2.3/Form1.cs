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

namespace NguyenHoTruongTam_1150080156_Lap4_TH2._3
{
    public partial class Form1 : Form
    {
        private string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        private SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Mở kết nối
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // 2. Tạo đối tượng thực thi truy vấn
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT MaSV, TenSV, GioiTinh, QueQuan, MaLop FROM SinhVien";
                sqlCmd.Connection = sqlCon;

                // 3. Thực thi truy vấn và đọc dữ liệu
                SqlDataReader reader = sqlCmd.ExecuteReader();

                // Xóa dữ liệu cũ trên ListView trước khi hiển thị lại
                lsvSinhVien.Items.Clear();

                // 4. Duyệt từng dòng dữ liệu
                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string tenSV = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string queQuan = reader.GetString(3);
                    string maLop = reader.GetString(4);

                    // 5. Hiển thị dữ liệu lên ListView
                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(tenSV);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(queQuan);
                    lvi.SubItems.Add(maLop);

                    lsvSinhVien.Items.Add(lvi);
                }

                // 6. Đóng reader + connection
                reader.Close();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi");
            }
        }

        private void lsvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}