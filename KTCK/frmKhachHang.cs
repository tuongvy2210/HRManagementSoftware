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
    public partial class frmKhachHang : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        bool kiemTraThem = true;
        string maCu = "";
        DataGridViewCellMouseEventArgs vt;
        string sql = "";
        public frmKhachHang()
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
            txtMaKhachHang.Clear();
            txtTenKhachHang.Clear();
            txtDiaChi.Clear();
            txtThanhPho.Clear();
            txtDienThoai.Clear();
            txtMaSoThue.Clear();

            kiemTraThem = true;
            TrangThaiNutChucNang(false);
            txtMaKhachHang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //ktra chua co ma thì không làm gì cả thoát khỏi thr tục
            if (txtMaKhachHang.Text == "") return;
            //luu ma cu de biet minh sua tren ban ghi nao
            maCu = txtMaKhachHang.Text;

            kiemTraThem = false;
            TrangThaiNutChucNang(false);
            txtMaKhachHang.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "") return;
            DialogResult kq = MessageBox.Show("Xóa khách hàng có mã " + txtMaKhachHang.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from T_KhachHang where MaKH = N'" + txtMaKhachHang.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                txtMaKhachHang.Clear();
                txtTenKhachHang.Clear();
                txtDiaChi.Clear();
                txtThanhPho.Clear();
                txtDienThoai.Clear();
                txtMaSoThue.Clear();

                LayDuLieu();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaKhachHang.Text == "")
            {
                MessageBox.Show("Chưa nhập mã khách hàng.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaKhachHang.Focus(); return;
            }
            if (txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Chưa nhập tên khách hàng.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenKhachHang.Focus(); return;
            }
            if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Chưa nhập địa chỉ.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDiaChi.Focus(); return;
            }
            if (txtThanhPho.Text == "")
            {
                MessageBox.Show("Chưa nhập thành phố/tỉnh.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtThanhPho.Focus(); return;
            }
            if (txtDienThoai.Text == "")
            {
                MessageBox.Show("Chưa nhập số điện thoại.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDienThoai.Focus(); return;
            }
            if (txtMaSoThue.Text == "")
            {
                MessageBox.Show("Chưa nhập mã số thuế.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaSoThue.Focus(); return;
            }
            if (kiemTraThem == true)
            {
                if (KiemTraTrungThem(txtMaKhachHang.Text) == true)
                {
                    MessageBox.Show("trùng mã thêm.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (KiemTraTrungSua(txtMaKhachHang.Text) == true)
                {
                    MessageBox.Show("trùng mã sửa.", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (kiemTraThem == true)
                sql = "insert into T_KhachHang(MaKH,TenKH,DiaChiKH,TP_Tinh,DienThoaiKH,MST) values(N'" + txtMaKhachHang.Text + "',N'" + txtTenKhachHang.Text + "',N'" + txtDiaChi.Text + "',N'" + txtThanhPho.Text + "',N'" + txtDienThoai.Text + "',N'" + txtMaSoThue.Text + "')";
            else
                sql = "update T_KhachHang set MaKH = N'" + txtMaKhachHang.Text + "',TenKH = N'" + txtTenKhachHang.Text + "',DiaChiKH = N'" + txtDiaChi.Text + "',TP_Tinh = N'" + txtThanhPho.Text + "',DienThoaiKH = N'" + txtDienThoai.Text + "',MST = N'" + txtMaSoThue.Text + "'where MaKH = N'" + maCu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

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
            dgvKhachHang.Enabled = b;
            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;

            txtMaKhachHang.ReadOnly = b;
            txtTenKhachHang.ReadOnly = b;
            txtDiaChi.ReadOnly = b;
            txtThanhPho.ReadOnly = b;
            txtDienThoai.ReadOnly = b;
            txtMaSoThue.ReadOnly = b;

            btnLuu.Enabled = !b;
            btnBoQua.Enabled = !b;
        }

        public void LayDuLieu()
        {
            string maKH = txtMaKhachHangTimKiem.Text;
            string tenKH = txtTenKhachHangTimKiem.Text;

            // Xử lý khi cả hai trường tìm kiếm đều rỗng
            if (string.IsNullOrEmpty(maKH) && string.IsNullOrEmpty(tenKH))
            {
                // Lấy toàn bộ dữ liệu
                da = new SqlDataAdapter("SELECT * FROM T_KhachHang", conn);
            }
            else
            {
                // Lấy dữ liệu tương ứng với maKH và tenKH
                string query = "SELECT * FROM T_KhachHang WHERE ";

                // Xử lý tìm kiếm theo maKH
                if (!string.IsNullOrEmpty(maKH))
                {
                    query += "MaKH LIKE N'%" + maKH + "%' ";
                }

                // Xử lý tìm kiếm theo tenKH
                if (!string.IsNullOrEmpty(tenKH))
                {
                    if (!string.IsNullOrEmpty(maKH))
                    {
                        query += "OR ";
                    }
                    query += "TenKH LIKE N'%" + tenKH + "%' ";
                }

                da = new SqlDataAdapter(query, conn);
            }

            dt = new DataTable();
            da.Fill(dt);

            dgvKhachHang.DataSource = dt;
            lblSoLuongKhachHang.Text = "Số lượng khách hàng là: " + (dgvKhachHang.RowCount - 1);

        }

        public bool KiemTraTrungThem(string manhap)
        {
            sql = "Select * from T_KhachHang where MaKH=N'" + manhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)//KIEM TRA có dữ liệu hay không có dữ liệu thì true
                return true;
            else
                return false;
        }
        public bool KiemTraTrungSua(string manhap)
        {
            sql = "Select * from T_KhachHang where MaKH =N'" + manhap + "' and MaKH<> N'" + maCu + "'";
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
                if (dgvKhachHang.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgvKhachHang.Rows[e.RowIndex];
                        txtMaKhachHang.Text = row.Cells[0].Value.ToString();
                        txtTenKhachHang.Text = row.Cells[1].Value.ToString();
                        txtDiaChi.Text = row.Cells[2].Value.ToString();
                        txtThanhPho.Text = row.Cells[3].Value.ToString();
                        txtDienThoai.Text = row.Cells[4].Value.ToString();
                        txtMaSoThue.Text = row.Cells[5].Value.ToString();

                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblKhachHang_Click(object sender, EventArgs e)
        {

        }
    }
}
