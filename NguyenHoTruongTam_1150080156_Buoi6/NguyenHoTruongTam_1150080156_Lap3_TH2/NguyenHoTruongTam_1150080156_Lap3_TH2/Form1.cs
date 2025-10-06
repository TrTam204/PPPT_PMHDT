using System;
using System.Data;
using System.Windows.Forms;

namespace NguyenHoTruongTam_1150080156_Lap3_TH2
{
    public partial class Form1 : Form
    {
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
            KhoiTaoBang();
        }

        private void KhoiTaoBang()
        {
            dt = new DataTable();
            dt.Columns.Add("Họ tên");
            dt.Columns.Add("Ngày sinh");
            dt.Columns.Add("Lớp");
            dt.Columns.Add("Địa chỉ");
            dgvSinhVien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            dt.Rows.Add(txtHoTen.Text, dtNgaySinh.Value.ToShortDateString(),
                        txtLop.Text, txtDiaChi.Text);
            ClearFields();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
            {
                dgvSinhVien.CurrentRow.Cells[0].Value = txtHoTen.Text;
                dgvSinhVien.CurrentRow.Cells[1].Value = dtNgaySinh.Value.ToShortDateString();
                dgvSinhVien.CurrentRow.Cells[2].Value = txtLop.Text;
                dgvSinhVien.CurrentRow.Cells[3].Value = txtDiaChi.Text;
                ClearFields();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSinhVien.CurrentRow != null)
                dgvSinhVien.Rows.Remove(dgvSinhVien.CurrentRow);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearFields()
        {
            txtHoTen.Clear();
            txtLop.Clear();
            txtDiaChi.Clear();
            txtHoTen.Focus();
        }
    }
}
