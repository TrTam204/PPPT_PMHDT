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

namespace NguyenHoTruongTam_1150080156_Lap4_TH2.AD
{
    public partial class Form1 : Form
    {
        private string strCon = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLySinhVien;Integrated Security=True";
        private SqlConnection sqlCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                // Lấy danh sách lớp
                SqlCommand sqlCmd = new SqlCommand("SELECT MaLop, TenLop FROM Lop", sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    string maLop = reader.GetString(0);
                    string tenLop = reader.GetString(1);
                    lsbDSLop.Items.Add($"{maLop} - {tenLop}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message);
            }
        }

        private void lsbDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbDSLop.SelectedItem == null) return;

            // Lấy mã lớp từ chuỗi "MaLop - TenLop"
            string selected = lsbDSLop.SelectedItem.ToString();
            string maLop = selected.Split('-')[0].Trim();

            try
            {
                if (sqlCon == null)
                    sqlCon = new SqlConnection(strCon);

                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                lsvDSSV.Items.Clear();

                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "SELECT MaSV, TenSV, GioiTinh, NgaySinh, QueQuan FROM SinhVien WHERE MaLop = @MaLop";
                sqlCmd.Parameters.AddWithValue("@MaLop", maLop);
                sqlCmd.Connection = sqlCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    string maSV = reader.GetString(0);
                    string tenSV = reader.GetString(1);
                    string gioiTinh = reader.GetString(2);
                    string ngaySinh = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                    string queQuan = reader.GetString(4);

                    ListViewItem lvi = new ListViewItem(maSV);
                    lvi.SubItems.Add(tenSV);
                    lvi.SubItems.Add(gioiTinh);
                    lvi.SubItems.Add(ngaySinh);
                    lvi.SubItems.Add(queQuan);
                    lsvDSSV.Items.Add(lvi);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị sinh viên: " + ex.Message);
            }
        }
    }
}
