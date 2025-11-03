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
    public partial class FormPhan4 : Form
    {
        // === CHUỖI KẾT NỐI: sửa cho phù hợp máy bạn ===
        private readonly string _strCon =
            @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=QLBanHang;Integrated Security=True;Connect Timeout=30";
        // Hoặc dùng .mdf:
        // private readonly string _strCon =
        //   @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\SQL\QLBanHang.mdf;Integrated Security=True;Connect Timeout=30";

        private enum UIMode { Idle, Search, Add, Edit, Delete }
        private UIMode _mode = UIMode.Idle;
        private string _keySelected = null; // MaSP đang chọn

        public FormPhan4()
        {
            InitializeComponent();
        }

        // ===== Helpers =====
        private void SetTitle(string text)
        {
            lblTitle.Text = text;
        }

        private void EnableDetailInputs(bool enable)
        {
            txtMa.ReadOnly = !enable;
            txtTen.ReadOnly = !enable;
            dtNgaySX.Enabled = enable;
            dtNgayHH.Enabled = enable;
            txtDonVi.ReadOnly = !enable;
            numDonGia.Enabled = enable;
            txtGhiChu.ReadOnly = !enable;
        }

        private void ShowSaveCancel(bool show)
        {
            btnLuu.Enabled = show;
            btnHuy.Enabled = show;
            btnLuu.Visible = show;
            btnHuy.Visible = show;
        }

        private void ClearDetail()
        {
            txtMa.Clear();
            txtTen.Clear();
            dtNgaySX.Value = DateTime.Today;
            dtNgayHH.Value = DateTime.Today;
            txtDonVi.Clear();
            numDonGia.Value = 0;
            txtGhiChu.Clear();
        }

        private void SetMode(UIMode m)
        {
            _mode = m;

            btnTim.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            EnableDetailInputs(false);
            ShowSaveCancel(false);

            switch (m)
            {
                case UIMode.Search:
                    SetTitle("TÌM KIẾM MẶT HÀNG");
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    EnableDetailInputs(false);
                    ShowSaveCancel(false);
                    break;

                case UIMode.Add:
                    SetTitle("THÊM MẶT HÀNG");
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    EnableDetailInputs(true);
                    ShowSaveCancel(true);
                    ClearDetail();
                    txtMa.Focus();
                    break;

                case UIMode.Edit:
                    SetTitle("CẬP NHẬT MẶT HÀNG");
                    btnThem.Enabled = false;
                    btnXoa.Enabled = false;
                    EnableDetailInputs(true);
                    ShowSaveCancel(true);
                    break;

                case UIMode.Delete:
                    SetTitle("XOÁ MẶT HÀNG");
                    btnThem.Enabled = false;
                    btnSua.Enabled = false;
                    EnableDetailInputs(false);
                    ShowSaveCancel(true);
                    break;
            }
        }

        private void BindGrid(DataTable tbl)
        {
            dgvDanhSach.DataSource = tbl;
        }

        private void LoadAll()
        {
            using (var conn = new SqlConnection(_strCon))
            using (var adp = new SqlDataAdapter(
                "SELECT MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu FROM dbo.tblMatHang ORDER BY MaSP", conn))
            {
                var tbl = new DataTable();
                adp.Fill(tbl);
                BindGrid(tbl);
            }
        }

        private void FillDetailFromGrid(int rowIndex)
        {
            if (rowIndex < 0 || dgvDanhSach.CurrentRow == null) return;

            var r = dgvDanhSach.Rows[rowIndex];

            txtMa.Text = Convert.ToString(r.Cells["MaSP"].Value);
            txtTen.Text = Convert.ToString(r.Cells["TenSP"].Value);

            DateTime nsx, nhh;
            if (!DateTime.TryParse(Convert.ToString(r.Cells["NgaySX"].Value), out nsx)) nsx = DateTime.Today;
            if (!DateTime.TryParse(Convert.ToString(r.Cells["NgayHH"].Value), out nhh)) nhh = DateTime.Today;
            dtNgaySX.Value = nsx;
            dtNgayHH.Value = nhh;

            txtDonVi.Text = Convert.ToString(r.Cells["DonVi"].Value);

            decimal dg;
            if (!decimal.TryParse(Convert.ToString(r.Cells["DonGia"].Value), out dg)) dg = 0;
            numDonGia.Value = dg < numDonGia.Minimum ? 0 : dg;

            txtGhiChu.Text = Convert.ToString(r.Cells["GhiChu"].Value);

            _keySelected = txtMa.Text;

            if (_mode == UIMode.Idle || _mode == UIMode.Search)
            {
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                EnableDetailInputs(false);
                ShowSaveCancel(false);
            }
        }

        private void SaveAdd()
        {
            using (var conn = new SqlConnection(_strCon))
            using (var cmd = new SqlCommand(
                @"INSERT INTO dbo.tblMatHang(MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu)
                  VALUES (@Ma,@Ten,@NSX,@NHH,@DonVi,@DonGia,@GhiChu)", conn))
            {
                cmd.Parameters.Add("@Ma", SqlDbType.NChar, 5).Value = txtMa.Text.Trim();
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 30).Value = txtTen.Text.Trim();
                cmd.Parameters.Add("@NSX", SqlDbType.Date).Value = dtNgaySX.Value.Date;
                cmd.Parameters.Add("@NHH", SqlDbType.Date).Value = dtNgayHH.Value.Date;
                cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar, 10).Value = (object)txtDonVi.Text.Trim() ?? DBNull.Value;
                cmd.Parameters.Add("@DonGia", SqlDbType.Float).Value = (double)numDonGia.Value;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 200).Value = (object)txtGhiChu.Text.Trim() ?? DBNull.Value;

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void SaveEdit()
        {
            using (var conn = new SqlConnection(_strCon))
            using (var cmd = new SqlCommand(
                @"UPDATE dbo.tblMatHang
                  SET MaSP=@MaMoi, TenSP=@Ten, NgaySX=@NSX, NgayHH=@NHH, DonVi=@DonVi, DonGia=@DonGia, GhiChu=@GhiChu
                  WHERE MaSP=@MaCu", conn))
            {
                cmd.Parameters.Add("@MaMoi", SqlDbType.NChar, 5).Value = txtMa.Text.Trim();
                cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 30).Value = txtTen.Text.Trim();
                cmd.Parameters.Add("@NSX", SqlDbType.Date).Value = dtNgaySX.Value.Date;
                cmd.Parameters.Add("@NHH", SqlDbType.Date).Value = dtNgayHH.Value.Date;
                cmd.Parameters.Add("@DonVi", SqlDbType.NVarChar, 10).Value = (object)txtDonVi.Text.Trim() ?? DBNull.Value;
                cmd.Parameters.Add("@DonGia", SqlDbType.Float).Value = (double)numDonGia.Value;
                cmd.Parameters.Add("@GhiChu", SqlDbType.NVarChar, 200).Value = (object)txtGhiChu.Text.Trim() ?? DBNull.Value;
                cmd.Parameters.Add("@MaCu", SqlDbType.NChar, 5).Value = _keySelected;

                conn.Open();
                int n = cmd.ExecuteNonQuery();
                if (n == 0) throw new Exception("Không tìm thấy bản ghi để cập nhật.");
            }
        }

        private void SaveDelete()
        {
            using (var conn = new SqlConnection(_strCon))
            using (var cmd = new SqlCommand("DELETE FROM dbo.tblMatHang WHERE MaSP=@Ma", conn))
            {
                cmd.Parameters.Add("@Ma", SqlDbType.NChar, 5).Value = _keySelected;
                conn.Open();
                int n = cmd.ExecuteNonQuery();
                if (n == 0) throw new Exception("Không tìm thấy bản ghi để xoá.");
            }
        }

        private bool ValidateDetailForSave()
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text) || txtMa.Text.Trim().Length != 5)
            {
                MessageBox.Show("Mã SP phải đủ 5 ký tự.", "Cảnh báo");
                txtMa.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Tên SP không được trống.", "Cảnh báo");
                txtTen.Focus();
                return false;
            }
            if (dtNgayHH.Value.Date < dtNgaySX.Value.Date)
            {
                MessageBox.Show("Ngày hết hạn phải >= ngày sản xuất.", "Cảnh báo");
                dtNgayHH.Focus();
                return false;
            }
            return true;
        }

        // ======= Cấu hình gợi ý tìm kiếm (tuỳ chọn nhưng đã bật) =======
        private void SetupAutoComplete()
        {
            var acMa = new AutoCompleteStringCollection();
            var acTen = new AutoCompleteStringCollection();

            using (var conn = new SqlConnection(_strCon))
            using (var cmd = new SqlCommand("SELECT MaSP, TenSP FROM dbo.tblMatHang", conn))
            {
                conn.Open();
                using (var rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        acMa.Add(rd.GetString(0).Trim());
                        acTen.Add(rd.GetString(1));
                    }
                }
            }

            txtTKMa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTKMa.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTKMa.AutoCompleteCustomSource = acMa;

            txtTKTên.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTKTên.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtTKTên.AutoCompleteCustomSource = acTen;
        }

        // ===== Events =====
        private void FormPhan4_Load(object sender, EventArgs e)
        {
            // Enter để tìm
            this.AcceptButton = btnTim;

            // Nếu dùng 2 DateTimePicker tìm nâng cao, vẫn bật checkbox
            dtTKNgaySX.Format = DateTimePickerFormat.Short; dtTKNgaySX.ShowCheckBox = true;
            dtTKNgayHH.Format = DateTimePickerFormat.Short; dtTKNgayHH.ShowCheckBox = true;

            SetMode(UIMode.Search);
            LoadAll();
            SetupAutoComplete(); // gợi ý khi gõ Mã/Tên
        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            FillDetailFromGrid(e.RowIndex);
        }

        // ======= TÌM KIẾM CỰC NHANH: chỉ Mã hoặc Tên =======
        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                SetMode(UIMode.Search);

                string ma = (txtTKMa.Text ?? "").Trim();
                string ten = (txtTKTên.Text ?? "").Trim();

                string sql = @"
                    SELECT MaSP, TenSP, NgaySX, NgayHH, DonVi, DonGia, GhiChu
                    FROM dbo.tblMatHang
                    WHERE (@Ma = '' AND @Ten = '')
                       OR (MaSP LIKE @MaLike)
                       OR (TenSP COLLATE Vietnamese_CI_AI LIKE N'%'+@Ten+N'%')
                    ORDER BY MaSP;";

                using (var conn = new SqlConnection(_strCon))
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.Add("@Ma", SqlDbType.NVarChar, 50).Value = ma;
                    cmd.Parameters.Add("@Ten", SqlDbType.NVarChar, 100).Value = ten;
                    cmd.Parameters.Add("@MaLike", SqlDbType.NVarChar, 50).Value =
                        ma == "" ? "%" : "%" + ma + "%";

                    using (var adp = new SqlDataAdapter(cmd))
                    {
                        var tbl = new DataTable();
                        adp.Fill(tbl);
                        dgvDanhSach.DataSource = tbl;
                    }
                }

                // Đúng yêu cầu: ở chế độ tìm → không cho sửa
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                EnableDetailInputs(false);
                ShowSaveCancel(false);
                _keySelected = null;
                SetTitle("TÌM KIẾM MẶT HÀNG");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm:\n" + ex.Message);
            }
        }

        // b) Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            SetMode(UIMode.Add);
        }

        // c) Sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_keySelected))
            {
                MessageBox.Show("Hãy chọn một bản ghi trong danh sách để sửa.");
                return;
            }
            SetMode(UIMode.Edit);
        }

        // d) Xoá
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_keySelected))
            {
                MessageBox.Show("Hãy chọn một bản ghi trong danh sách để xoá.");
                return;
            }
            SetMode(UIMode.Delete);
        }

        // Lưu (tuỳ mode)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                if (_mode == UIMode.Add || _mode == UIMode.Edit)
                {
                    if (!ValidateDetailForSave()) return;
                }

                switch (_mode)
                {
                    case UIMode.Add:
                        SaveAdd();
                        MessageBox.Show("Thêm mới thành công!");
                        break;

                    case UIMode.Edit:
                        SaveEdit();
                        MessageBox.Show("Cập nhật thành công!");
                        break;

                    case UIMode.Delete:
                        DialogResult cf = MessageBox.Show(
                            "Bạn chắc chắn xoá " + _keySelected + "?",
                            "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (cf != DialogResult.Yes) return;
                        SaveDelete();
                        MessageBox.Show("Xoá thành công!");
                        break;

                    default:
                        return;
                }

                LoadAll();
                SetMode(UIMode.Search);
                _keySelected = null;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    MessageBox.Show("Mã SP đã tồn tại, vui lòng chọn mã khác.");
                }
                else if (ex.Number == 547 && _mode == UIMode.Delete)
                {
                    MessageBox.Show("Không thể xoá do bản ghi đang được tham chiếu.");
                }
                else
                {
                    MessageBox.Show("Lỗi SQL:\n" + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lưu dữ liệu:\n" + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            SetMode(UIMode.Search);
            ClearDetail();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}