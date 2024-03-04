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
    public partial class frmPhongBan : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        bool ktThem = true;
        string maCu = "";
        DataGridViewCellMouseEventArgs vt;
        string sql = "";
        public frmPhongBan()
        {
            InitializeComponent();
        }

        private void frmQuanLyNhomHang_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectDB();
            LayDuLieu();
            KhoaMo(true);
        }

        public void LayDuLieu()
        {
            da = new SqlDataAdapter("Select * From PhongBan", conn);
            dt = new DataTable();
            da.Fill(dt);

            dgvPhongBan.DataSource = dt;
            lblSoNhomHang.Text = "Có " + (dt.Rows.Count) + " phòng ban.";
        }

        public void KhoaMo(bool b)
        {
            dgvPhongBan.Enabled = b;
            btnThem.Enabled = b;
            btnSua.Enabled = b;
            btnXoa.Enabled = b;

            txtMaPhongBan.ReadOnly = b;
            txtTenPhongBan.ReadOnly = b;

            btnGhi.Enabled = !b;
            btnKhong.Enabled = !b;
        }

        public bool ktTrungThem(string maNhap)
        {

            sql = "Select * From PhongBan Where MaPB =N'" + maNhap + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }

        public bool ktTrungSua(string maNhap)
        {

            sql = "Select *From PhongBan Where MaPB =N'" + maNhap + "'and MaPB<> N'" + maCu + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                return true;
            else
                return false;

        }

        private void dgvNhomHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvPhongBan.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgvPhongBan.Rows[e.RowIndex];
                        txtMaPhongBan.Text = row.Cells[0].Value.ToString();
                        txtTenPhongBan.Text = row.Cells[1].Value.ToString();
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaPhongBan.Clear();
            txtTenPhongBan.Clear();
            ktThem = true;
            KhoaMo(false);
            txtMaPhongBan.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaPhongBan.Text == "") return;
            maCu = txtMaPhongBan.Text;
            ktThem = false;
            KhoaMo(false);
            txtMaPhongBan.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaPhongBan.Text == "") return;
            DialogResult kq = MessageBox.Show("Xác nhận xóa nhóm hàng " + txtMaPhongBan.Text + " không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                sql = "Delete from PhongBan where MaPB = N'" + txtMaPhongBan.Text + "'";
                if (conn.State != ConnectionState.Open) conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                txtMaPhongBan.Text = "";
                txtTenPhongBan.Text = "";
                LayDuLieu();
            }
        }

        private void btnGhi_Click(object sender, EventArgs e)
        {
            if (txtMaPhongBan.Text == "")
            {
                MessageBox.Show("Chưa nhập mã nhóm.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMaPhongBan.Focus(); 
                return;
            }
            if (txtTenPhongBan.Text == "")
            {
                MessageBox.Show("Chưa nhập tên nhóm.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTenPhongBan.Focus(); 
                return;
            }
            if (ktThem == true)
            {
                if (ktTrungThem(txtMaPhongBan.Text) == true)
                {
                    MessageBox.Show("Mã nhóm đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            else
            {
                if (ktTrungSua(txtMaPhongBan.Text) == true)
                {
                    MessageBox.Show("Mã nhóm đã tồn tại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            if (ktThem == true)
                sql = "insert into PhongBan(MaPB,TenPB) values(N'" + txtMaPhongBan.Text + "',N'" + txtTenPhongBan.Text + "')";
            else
                sql = "update PhongBan set MaPB=N'" + txtMaPhongBan.Text + "', TenPB=N'" + txtTenPhongBan.Text + "' where MaPB=N'" + maCu + "'";
            if (conn.State != ConnectionState.Open) conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();

            KhoaMo(true);
            LayDuLieu();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            KhoaMo(true);
            dgvNhomHang_CellMouseClick(sender, vt);
            return;
        }

        
    }
}
