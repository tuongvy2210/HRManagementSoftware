using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KTCK
{
    public partial class frmNhanVien : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        bool kiemTraThem = true;
        string maCu = "";
        DataGridViewCellMouseEventArgs vt;
        string sql = "";
        bool dtpFlag = false;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LayDuLieu();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectDB();

            LayDuLieu();
            TrangThaiNutChucNang(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Clear();
            txtTenNhanVien.Clear();
            txtPhongBan.Clear();
            txtPhai.Clear();
            txtChucVu.Clear();
            txtDanToc.Clear();
            txtDiaChi.Clear();
            txtTrinhDo.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            txtHeSoLuong.Clear();
            txtTinhTrangHonNhan.Clear();


            kiemTraThem = true;
            TrangThaiNutChucNang(false);
            txtMaNhanVien.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //ktra chua co ma thì không làm gì cả thoát khỏi thr tục
            if (txtMaNhanVien.Text == "") return;
            //luu ma cu de biet minh sua tren ban ghi nao
            maCu = txtMaNhanVien.Text;

            kiemTraThem = false;
            TrangThaiNutChucNang(false);
            txtMaNhanVien.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhanVien.Text == "") return;
            DialogResult kq = MessageBox.Show("Xóa nhân viên có mã " 
                + txtMaNhanVien.Text + " không?", "Xóa",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from NhanVien where MaNhanVien = N'" + txtMaNhanVien.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                txtMaNhanVien.Clear();
                txtTenNhanVien.Clear();
                txtPhongBan.Clear();
                txtPhai.Clear();
                txtChucVu.Clear();
                txtDanToc.Clear();
                txtDiaChi.Clear();
                txtTrinhDo.Clear();
                txtDienThoai.Clear();
                txtEmail.Clear();
                txtHeSoLuong.Clear();
                txtTinhTrangHonNhan.Clear();


                LayDuLieu();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Chưa nhập mã nhân viên.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaNhanVien.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTenNhanVien.Text))
            {
                MessageBox.Show("Chưa nhập tên nhân viên.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenNhanVien.Focus();
                return;
            }

            if (!dtpFlag)
            {
                MessageBox.Show("Chưa nhập ngày sinh nhân viên.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                dtpNgaySinh.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPhai.Text))
            {
                MessageBox.Show("Chưa nhập phái nhân viên.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPhai.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtChucVu.Text))
            {
                MessageBox.Show("Chưa nhập chức vụ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtChucVu.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Chưa nhập địa chỉ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDiaChi.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtTrinhDo.Text))
            {
                MessageBox.Show("Chưa nhập thành phố/tỉnh.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTrinhDo.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtDienThoai.Text))
            {
                MessageBox.Show("Chưa nhập số điện thoại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDienThoai.Focus();
                return;
            }

            // Kiểm tra trùng mã
            if (kiemTraThem)
            {
                if (KiemTraTrungThem(txtMaNhanVien.Text))
                {
                    MessageBox.Show("Trùng mã khi thêm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (KiemTraTrungSua(txtMaNhanVien.Text))
                {
                    MessageBox.Show("Trùng mã khi sửa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            string sql;
            if (kiemTraThem)
            {
                sql = "INSERT INTO NhanVien (MaNhanVien, TenNV, NgaySinh, GioiTinh, ChucVu, DiaChi, TP_Tinh, DienThoai) " +
                      "VALUES (@MaNhanVien, @TenNV, @NgaySinh, @GioiTinh, @ChucVu, @DiaChi, @TP_Tinh, @DienThoai)";
            }
            else
            {
                sql = "UPDATE NhanVien SET MaNhanVien = @MaNhanVien, TenNV = @TenNV, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, " +
                      "ChucVu = @ChucVu, DiaChi = @DiaChi, TP_Tinh = @TP_Tinh, DienThoai = @DienThoai WHERE MaNhanVien = @MaCu";
            }

            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@MaNhanVien", txtMaNhanVien.Text);
                cmd.Parameters.AddWithValue("@TenNV", txtTenNhanVien.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", txtPhai.Text);
                cmd.Parameters.AddWithValue("@ChucVu", txtChucVu.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@TP_Tinh", txtTrinhDo.Text);
                cmd.Parameters.AddWithValue("@DienThoai", txtDienThoai.Text);

                if (!kiemTraThem)
                {
                    cmd.Parameters.AddWithValue("@MaCu", maCu);
                }

                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

                cmd.ExecuteNonQuery();
            }

            TrangThaiNutChucNang(true);
            LayDuLieu();
        }


        private void btnBoQua_Click(object sender, EventArgs e)
        {
            TrangThaiNutChucNang(true);
            dgvKhachHang_CellMouseClick(sender, vt);
            return;
        }
        public void TrangThaiNutChucNang(bool b)
        {
            dgvNhanVien.Enabled = b;
            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;

            txtMaNhanVien.ReadOnly = b;
            txtTenNhanVien.ReadOnly = b;
            txtDiaChi.ReadOnly = b;
            txtTrinhDo.ReadOnly = b;
            txtDienThoai.ReadOnly = b;

            btnLuu.Enabled = !b;
            btnBoQua.Enabled = !b;
        }

        public void LayDuLieu()
        {
                string MaNhanVien = txtMaNhanVienTimKiem.Text;
                string TenNV = txtHoTenTimKiem.Text;

                // Xử lý khi cả hai trường tìm kiếm đều rỗng
                if (string.IsNullOrEmpty(MaNhanVien) && string.IsNullOrEmpty(TenNV))
                {
                    // Lấy toàn bộ dữ liệu
                    da = new SqlDataAdapter("SELECT * FROM NhanVien", conn);
                }
                else
                {
                    // Lấy dữ liệu tương ứng với MaNhanVien và TenNV
                    string query = "SELECT * FROM NhanVien WHERE ";

                    // Xử lý tìm kiếm theo MaNhanVien
                    if (!string.IsNullOrEmpty(MaNhanVien))
                    {
                        query += "MaNhanVien LIKE N'%" + MaNhanVien + "%' ";
                    }

                    // Xử lý tìm kiếm theo TenNV
                    if (!string.IsNullOrEmpty(TenNV))
                    {
                        if (!string.IsNullOrEmpty(MaNhanVien))
                        {
                            query += "OR ";
                        }
                        query += "TenNV LIKE N'%" + TenNV + "%' ";
                    }

                    da = new SqlDataAdapter(query, conn);
                }

                dt = new DataTable();
                da.Fill(dt);

                dgvNhanVien.DataSource = dt;
                lblSoLuongKhachHang.Text = "Số lượng nhân viên là: " + (dgvNhanVien.RowCount - 1);
            


        }

        public bool KiemTraTrungThem(string maNhap)
        {
            sql = "Select * from NhanVien where MaNhanVien=N'" + maNhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)//KIEM TRA có dữ liệu hay không có dữ liệu thì true
                return true;
            else
                return false;
        }
        public bool KiemTraTrungSua(string maNhap)
        {
            sql = "Select * from NhanVien where MaNhanVien =N'" + maNhap + "' and MaNhanVien<> N'" + maCu + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        private void dgvKhachHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvNhanVien.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                        txtMaNhanVien.Text = row.Cells[0].Value.ToString();
                        txtTenNhanVien.Text = row.Cells[1].Value.ToString();
                        dtpNgaySinh.Text = row.Cells[2].Value.ToString();
                        txtPhai.Text = row.Cells[3].Value.ToString();
                        txtChucVu.Text = row.Cells[4].Value.ToString();
                        txtDiaChi.Text = row.Cells[5].Value.ToString();
                        txtTrinhDo.Text = row.Cells[6].Value.ToString();
                        txtDienThoai.Text = row.Cells[7].Value.ToString();

                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {
            dtpFlag = true;
        }

        private void txtMaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {

        }

        
    }
}
