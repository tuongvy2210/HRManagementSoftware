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
    public partial class frmMatHang : Form
    {
        SqlConnection conn;
        SqlDataAdapter da, daMaNhom, daKhoaTim;
        DataTable dt, dtMaNhom, dtKhoaTim;
        bool kiemTraThem = true;
        string maCu = "";
        DataGridViewCellMouseEventArgs vt;
        string sql = "";
        string maNhomHang = "";
        public frmMatHang()
        {
            InitializeComponent();
        }

        private void frmMatHang_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectDB();
            LayMaNhomHang();
            LayMaNhomHangChiTiet();
            maNhomHang = "";
            LayDuLieu();
            TrangThaiNutChucNang(true);
        }

        private void cboNhomMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maNhomHang = cboNhomMatHang.SelectedValue.ToString();
                LayDuLieu();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvQuanLyMatHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvQuanLyMatHang.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgvQuanLyMatHang.Rows[e.RowIndex];
                        txtMaHang.Text = row.Cells[0].Value.ToString();
                        cboMaNhom.Text = row.Cells[1].Value.ToString();
                        txtTenHang.Text = row.Cells[2].Value.ToString();
                        txtMaNCC.Text = row.Cells[3].Value.ToString();
                        txtDonViTinh.Text = row.Cells[4].Value.ToString();
                        txtTonDK.Text = row.Cells[5].Value.ToString();
                        txtTGTonDK.Text = row.Cells[6].Value.ToString();

                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHienTatCa_Click(object sender, EventArgs e)
        {
            try
            {
                maNhomHang = "";
                LayDuLieu();
            }
            catch (Exception ex) { }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            XoaDuLieu();
            kiemTraThem = true;
            TrangThaiNutChucNang(false);
            txtMaHang.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "") return;
            maCu = txtMaHang.Text;
            kiemTraThem = false;
            TrangThaiNutChucNang(false);
            txtMaHang.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "") return;
            DialogResult kq = MessageBox.Show(" xóa tên hàng " + txtTenHang.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from T_HangHoa where MaHang = N'" + txtMaHang.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.ExecuteNonQuery();
                txtMaHang.Clear();
                txtTenHang.Clear();
                txtDonViTinh.Clear();
                txtMaNCC.Clear();
                txtTonDK.Clear();
                txtTGTonDK.Clear();
                LayDuLieu();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text == "")
            {
                txtMaHang.Focus(); return;
            }
            if (cboMaNhom.Text == "")
            {
                cboMaNhom.Focus(); return;
            }
            if (txtTenHang.Text == "")
            {
                txtTenHang.Focus(); return;
            }
            if (txtDonViTinh.Text == "")
            {
                txtDonViTinh.Focus(); return;
            }
            if (txtTonDK.Text == "")
            {
                txtTonDK.Focus(); return;
            }
            if (txtTGTonDK.Text == "")
            {
                txtTGTonDK.Focus(); return;
            }

            if (kiemTraThem == true)
            {
                if (KiemTraTrungThem(txtMaHang.Text) == true)
                {
                    MessageBox.Show("trùng mã thêm ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (KiemTraTrungSua(txtMaHang.Text) == true)
                {
                    MessageBox.Show("trùng mã Sửa ", "thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (kiemTraThem == true)
            {
                sql = "insert into T_HangHoa(MaNhom,MaHang,TenHang,MaNCC,DVT,SLTonDK,TGTonDK) values(N'" + cboMaNhom.SelectedValue.ToString() + "',N'" + txtMaHang.Text + "',N'"
                    + txtTenHang.Text + "',N'" + txtMaNCC.Text + "',N'" + txtDonViTinh.Text + "',N'" + txtTonDK.Text + "',N'" + txtTGTonDK.Text + "')";
            }
            else
            {
                sql = "UPDATE T_HangHoa SET MaNhom=N'" + cboMaNhom.SelectedValue.ToString() + "', MaHang=N' " + txtMaHang.Text + "',TenHang=N'"
               + txtTenHang.Text + "',DVT=N'" + txtDonViTinh.Text + "',SLTonDK=N'" + txtTonDK.Text + "',TGTonDK=N'"
               + txtTGTonDK.Text + "' WHERE MaHang=N'" + maCu + "'";
            }
            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            TrangThaiNutChucNang(true);
            XoaDuLieu();
            LayDuLieu();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            TrangThaiNutChucNang(true);
            //xoatrang();
            dgvQuanLyMatHang_CellMouseClick(sender, vt);
            return;
        }

        public void TrangThaiNutChucNang(bool b)
        {
            dgvQuanLyMatHang.Enabled = b;
            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;

            txtMaHang.ReadOnly = b;
            txtTenHang.ReadOnly = b;
            txtDonViTinh.ReadOnly = b;
            txtTonDK.ReadOnly = b;
            txtTGTonDK.ReadOnly = b;
            txtMaNCC.ReadOnly = b;

            cboMaNhom.Enabled = !b;

            btnLuu.Enabled = !b;
            btnKhong.Enabled = !b;
        }

        public void LayMaNhomHang()
        {
            daKhoaTim = new SqlDataAdapter("Select * from T_NhomHang", conn);
            dtKhoaTim = new DataTable();
            daKhoaTim.Fill(dtKhoaTim);

            cboNhomMatHang.DataSource = dtKhoaTim;
            cboNhomMatHang.DisplayMember = "TenNhom";
            cboNhomMatHang.ValueMember = "MaNhom";
        }

        public void LayDuLieu()
        {
            if (maNhomHang == "")
                sql = "Select * from T_HangHoa";
            else
                sql = "Select * from T_HangHoa where MaNhom=N'" + maNhomHang + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            dgvQuanLyMatHang.DataSource = dt;
            lblMatHang.Text = "có " + (dt.Rows.Count) + " mặt hàng";
        }

       

        public void LayMaNhomHangChiTiet()
        {
            daMaNhom = new SqlDataAdapter("Select * from T_NhomHang", conn);
            dtMaNhom = new DataTable();
            daMaNhom.Fill(dtMaNhom);

            cboMaNhom.DataSource = dtMaNhom;
            cboMaNhom.DisplayMember = "MaNhom";
            cboMaNhom.ValueMember = "MaNhom";
        }

        public void XoaDuLieu()
        {
            txtMaHang.Clear();
            txtTenHang.Clear();
            txtDonViTinh.Clear();
            txtTonDK.Clear();
            txtTGTonDK.Clear();
            txtMaNCC.Clear();
        }

        public bool KiemTraTrungThem(string manhap)
        {
            sql = "Select * from T_HangHoa where MaHang=N'" + manhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }
        public bool KiemTraTrungSua(string manhap)
        {
            sql = "Select * from T_HangHoa where MaHang =N'" + manhap + "' and MaHang<> N'" + maCu + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }
    }
}
