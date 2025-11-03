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

namespace NguyenHoTruongTam_1150080156_Buoi9
    {
        public partial class Form1 : Form
    {
        // KẾT NỐI LocalDB – chọn 1 trong 2, mặc định dùng Initial Catalog:
        private readonly string _strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QuanLyBanSach;Integrated Security=True;Connect Timeout=30";
        // private readonly string _strCon =
        //   @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SQL\QuanLyBanSach.mdf;Integrated Security=True;Connect Timeout=30";

        private SqlConnection _conn;
        private SqlDataAdapter _adp;
        private DataTable _tbl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterButton();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterButton();
        }

        private void CenterButton()
        {
            // canh giữa nút theo chiều ngang giống ảnh
            btnHienThi.Left = (this.ClientSize.Width - btnHienThi.Width) / 2;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            try
            {
                using (_conn = new SqlConnection(_strCon))
                {
                    _conn.Open();
                    string sql = "SELECT MaXB, TenXB, DiaChi FROM dbo.NhaXuatBan";
                    _adp = new SqlDataAdapter(sql, _conn);
                    _tbl = new DataTable();
                    _adp.Fill(_tbl);
                    dgvNhaXB.DataSource = _tbl;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không tải được dữ liệu.\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}