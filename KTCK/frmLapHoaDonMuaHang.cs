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
    public partial class frmLapHoaDonMuaHang : Form
    {
        SqlConnection conn;
        SqlDataAdapter da, daNhom, daHang, daKhach, daNhanVien;
        DataTable dt, dtNhom, dtHang, dtKhach, dtNhanVien;
        string maCu = "", maNhom = "", maHangHoa = "";
        DataGridViewCellMouseEventArgs vt;
        string sql = "";
        float iSoLuong, iDonGia, iTongTien, iThanhTien, iCK, iCP;
        ListView.SelectedListViewItemCollection itemHoaDon;
        ListViewItem itemLV;
        public frmLapHoaDonMuaHang()
        {
            InitializeComponent();
        }
        private void frmLapHoaDon_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectDB();
            dtpNgayLap.Value = DateTime.Now;
            LayDuLieuNhomHang();
            LayDuLieuNhaCungCap();
            LayDuLieuNhanVien();
            maNhom = "";
            LayDuLieu();
        }

        

        private void btnBoHang_Click(object sender, EventArgs e)
        {
            if (itemHoaDon == null) return;
            if (itemHoaDon.Count <= 0)
                return;
            if (MessageBox.Show("Bạn có muốn hủy mặt hàng đang chọn không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lvLapHoaDon.Items.Remove(itemHoaDon[0]);
                TinhThanhTien();
            }
        }

        private void btnGhiHoaDon_Click(object sender, EventArgs e)
        {
            if (lvLapHoaDon.Items.Count <= 0) return;
            if (txtSoHoaDon.Text == "") txtSoHoaDon.Text = LaySoHoaDonMoi();
            if (cboNCC.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Chưa chọn nhà cung cấp.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboNCC.Focus(); return;
            }
            if (cboNhanVien.Text == "")
            {
                MessageBox.Show("Chưa nhập người lập hóa đơn.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboNhanVien.Focus(); return;
            }
            SqlCommand cmd;
            if (MessageBox.Show("Bạn có muốn ghi lại hóa đơn không?", "Ghi Hóa Đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Ghi hóa đơn
                sql = "INSERT INTO T_HoaDonMH(MaHDMH,NgayNhap,MaNV,MaNCC) VALUES(N'" + txtSoHoaDon.Text + "','" + dtpNgayLap.Value.Date.ToString("MM/dd/yyyy") + "','" + cboNhanVien.SelectedValue.ToString() + "','" + cboNCC.SelectedValue.ToString() + "')";
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                //ghi chi tiết hóa đơn
                for (int i = 0; i < lvLapHoaDon.Items.Count; i++)
                {
                    maHangHoa = lvLapHoaDon.Items[i].Text;
                    iDonGia = float.Parse(lvLapHoaDon.Items[i].SubItems[2].Text);
                    iSoLuong = float.Parse(lvLapHoaDon.Items[i].SubItems[3].Text);
                    sql = "INSERT INTO T_ChiTietMH(MaHDMH, MaHang, SLNhap, DGNhap, CK, CP) VALUES (N'" + txtSoHoaDon.Text
                          + "',N'" + maHangHoa + "'," + iSoLuong + "," + iDonGia + "," + iCK + "," + iCP + ")";

                    if (conn.State != ConnectionState.Open) conn.Open();
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }

                //Ghi phiếu thu tiền
               
                sql = "INSERT INTO T_PhieuChi(MaPC, MaNV, MaNCC, NgayChi, SoTien) " +
                    "VALUES(N'" + txtMaPTT.Text + "','" + cboNhanVien.SelectedValue.ToString() + "','" + cboNCC.SelectedValue.ToString() + "','" + dtpNgayLap.Value.Date.ToString("MM/dd/yyyy") + "',N'" + txtTongThanhTien.Text + "')";
                if (conn.State != ConnectionState.Open) conn.Open();
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                //kết thúc
                MessageBox.Show("Bạn ghi hóa đơn thành công.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LamMoiONhap();
            }
        }

        private void lvLapHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemHoaDon = lvLapHoaDon.SelectedItems;
            if (itemHoaDon.Count > 0)
            {
                txtDGiaSua.Text = itemHoaDon[0].SubItems[2].Text;
                txtSLSua.Text = itemHoaDon[0].SubItems[3].Text;
            }
        }

        private void dgvMatHang_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgvMatHang.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        vt = e;
                        DataGridViewRow row = dgvMatHang.Rows[e.RowIndex];
                        maCu = row.Cells[0].Value.ToString();
                        txtTenHang.Text = row.Cells[2].Value.ToString();
                       
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (itemHoaDon == null) return;
            if (txtSLSua.Text == "") return;
            if (txtDGiaSua.Text == "") return;
            iSoLuong = float.Parse(txtSLSua.Text);
            if (iSoLuong <= 0) return;
            iDonGia = float.Parse(txtDGiaSua.Text);
            if (iDonGia <= 0) return;
            if (itemHoaDon.Count > 0)
            {
                itemHoaDon[0].SubItems[2].Text = txtDGiaSua.Text;
                itemHoaDon[0].SubItems[3].Text = txtSLSua.Text;
                txtSLSua.Text = ""; txtDGiaSua.Text = "";
                TinhThanhTien();
            }
        }

       

        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Xóa hóa đơn đang lập?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                LamMoiONhap();
            }
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (lvLapHoaDon.Items.Count <= 0)
                return;
            if (float.Parse(txtTongTien.Text) <= 0) return;
            iTongTien = float.Parse(txtTongTien.Text);
            
            if (txtChietKhau.Text == "") txtChietKhau.Text = "0";
            iCK = float.Parse(txtChietKhau.Text);
            iThanhTien = iTongTien - iCK;
            txtTongThanhTien.Text = iThanhTien.ToString();
            btnGhiHoaDon.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenHang.Text == "" || txtDonGia.Text == "" || txtSoLuong.Text == "")
                return;
            iSoLuong = float.Parse(txtSoLuong.Text);
            if (iSoLuong <= 0)
                return;
            itemLV = new ListViewItem(maCu);
            itemLV.SubItems.Add(txtTenHang.Text);
            itemLV.SubItems.Add(txtDonGia.Text);
            itemLV.SubItems.Add(txtSoLuong.Text);
            lvLapHoaDon.Items.Add(itemLV);
            TinhThanhTien();
        }

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            txtSoHoaDon.Text = LaySoHoaDonMoi();
            txtMaPTT.Text = LaySoHoaPhieuTTMoi();
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            maNhom = "";
            LayDuLieu();
        }

        private void cboTenNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                maNhom = cboTenNhom.SelectedValue.ToString();
                LayDuLieu();
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LamMoiONhap()
        {
            txtSoHoaDon.Clear();
            txtMaPTT.Clear();
            txtTenHang.Clear();
            cboNhanVien.Text = "";
            cboNCC.Text = "";
            txtDonGia.Clear();
            txtSoLuong.Clear();
            lvLapHoaDon.Items.Clear();
            txtSLSua.Clear();
            txtDGiaSua.Clear();
            txtTongThanhTien.Text = "0";
            txtChietKhau.Text = "0"; 
            txtTongThanhTien.Text = "";
            btnGhiHoaDon.Enabled = false;
        }

        public void XoaHoaDonDangLap()
        {
            txtSoHoaDon.Clear();
            txtSoLuong.Clear();
            txtTenHang.Clear();
            txtSoLuong.Clear();
            lvLapHoaDon.Items.Clear();
            txtDonGia.Text = ""; 
            txtTongTien.Text = "0"; 
            txtChietKhau.Text = "0"; 
            txtTongThanhTien.Clear();
            btnGhiHoaDon.Enabled = false;
        }
      
        public string LaySoHoaDonMoi()
        {
            double sohd = 1;
            sql = "Select TOP 1 MaHDMH From T_HoaDonMH Order By MaHDMH Desc";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                sohd = Double.Parse(dt.Rows[0]["MaHDMH"].ToString()) + 1;
            return sohd.ToString("000000");
        }

        public string LaySoHoaPhieuTTMoi()
        {
            double sohd = 1;
            sql = "Select TOP 1 MaPC From T_PhieuChi Order By MaPC Desc";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                sohd = Double.Parse(dt.Rows[0]["MaPC"].ToString()) + 1;
            return sohd.ToString("000000");
        }

        public void LayDuLieu()
        {
            if (maNhom == "")
                sql = "SELECT * FROM T_HangHoa ORDER BY T_HangHoa.TenHang";
            else
                sql = "SELECT * FROM T_HangHoa Where MaNhom = N'" + maNhom + "' Order By TenHang";
            daHang = new SqlDataAdapter(sql, conn);
            dtHang = new DataTable();
            daHang.Fill(dtHang);
            dgvMatHang.DataSource = dtHang;
        }

        public void LayDuLieuNhomHang()
        {
            sql = "Select * From T_NhomHang";
            daNhom = new SqlDataAdapter(sql, conn);
            dtNhom = new DataTable();
            daNhom.Fill(dtNhom);
            cboTenNhom.DataSource = dtNhom;
            cboTenNhom.DisplayMember = "TenNhom";
            cboTenNhom.ValueMember = "MaNhom";
        }

        public void LayDuLieuNhaCungCap()
        {
            sql = "Select * From T_NhaCungCap";
            daKhach = new SqlDataAdapter(sql, conn);
            dtKhach = new DataTable();
            daKhach.Fill(dtKhach);
            cboNCC.DataSource = dtKhach;
            cboNCC.DisplayMember = "TenNCC";
            cboNCC.ValueMember = "MaNCC";
            cboNCC.SelectedValue = "KL";
        }

        public void LayDuLieuNhanVien()
        {
            sql = "Select * From T_NhanVien";
            daNhanVien = new SqlDataAdapter(sql, conn);
            dtNhanVien = new DataTable();
            daNhanVien.Fill(dtNhanVien);
            cboNhanVien.DataSource = dtNhanVien;
            cboNhanVien.DisplayMember = "HoTen";
            cboNhanVien.ValueMember = "MaNV";
            //cboKhachHang.SelectedValue = "KL";
        }

        public void LayDuLieuHangHoa()
        {
            if (maNhom == "")
                sql = "Select * From T_HangHoa Order By TenHang";
            else
                sql = "Select * From T_HangHoa Where MaNhom = N'" + maNhom + "' Order By TenHang";
            daHang = new SqlDataAdapter(sql, conn);
            dtHang = new DataTable();
            daHang.Fill(dtHang);
            dgvMatHang.DataSource = dtHang;
        }

        public void TinhThanhTien()
        {
            txtTongTien.Text = "";
            if (lvLapHoaDon.Items.Count <= 0)
                return;
            iTongTien = 0;
            for (int i = 0; i < lvLapHoaDon.Items.Count; i++)
            {
                iSoLuong = float.Parse(lvLapHoaDon.Items[i].SubItems[2].Text);
                iDonGia = float.Parse(lvLapHoaDon.Items[i].SubItems[3].Text);
                iTongTien += (iSoLuong * iDonGia);
            }
            txtTongTien.Text = iTongTien.ToString();
            btnGhiHoaDon.Enabled = false;
        }



    }
}
