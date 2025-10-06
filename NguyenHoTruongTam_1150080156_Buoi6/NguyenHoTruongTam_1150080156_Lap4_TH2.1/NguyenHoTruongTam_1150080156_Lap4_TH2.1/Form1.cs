using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_Lap4_TH2._1
{
    public partial class Form1 : Form
    {
        private readonly string strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLySinhVien;Integrated Security=True";

        private SqlConnection sqlCon;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Chưa cần xử lý khi load form
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State != ConnectionState.Open)
                    sqlCon.Open();

                using (SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM SinhVien", sqlCon))
                {
                    int soLuongSV = (int)sqlCmd.ExecuteScalar();
                    MessageBox.Show($"Số lượng sinh viên là: {soLuongSV}",
                        "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}
