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

namespace KTCK
{
    public partial class frmTraCuuHoaDonMuaHang : Form
    {
        SqlConnection conn;
        SqlDataAdapter daHoaDon, daChiTiet;
        DataTable dtHoaDon, dtChiTiet;
        string sql = "";
        public frmTraCuuHoaDonMuaHang()
        {
            InitializeComponent();
        }
        private void frmTraCuuHoaDonBanHang_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectDB();
            DateTime curdate = DateTime.Now;
            curdate = curdate.AddDays(-30);
            dtpNgayLapDen.Value = DateTime.Now;
            dtpNgayLapTu.Value = curdate;
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string dieukien = "";
            string sql = "SELECT T_HoaDonMH.MaHDMH, T_HoaDonMH.NgayNhap, T_NhanVien.MaNV, T_NhaCungCap.MaNCC, T_NhaCungCap.TenNCC, T_ChiTietMH.CK, T_PhieuChi.SoTien " +
                         "FROM (((T_HoaDonMH " +
                         "JOIN T_ChiTietMH ON T_HoaDonMH.MaHDMH = T_ChiTietMH.MaHDMH) " +
                         "JOIN T_NhanVien ON T_NhanVien.MaNV = T_HoaDonMH.MaNV) " +
                         "JOIN T_PhieuChi ON T_PhieuChi.MaNV = T_NhanVien.MaNV) " +
                         "JOIN T_NhaCungCap ON T_NhaCungCap.MaNCC = T_PhieuChi.MaNCC";

            dieukien = " T_HoaDonMH.NgayNhap >= '" + dtpNgayLapTu.Value.ToString("yyyy-MM-dd") + "' AND T_HoaDonMH.NgayNhap <= '" + dtpNgayLapDen.Value.ToString("yyyy-MM-dd") + "'";
            if (txtSoHD.Text != "")
                dieukien += " AND T_HoaDonMH.MaHDMH LIKE '%" + txtSoHD.Text + "%'";
            if (txtNguoiLap.Text != "")
                dieukien += " AND T_NhanVien.MaNV LIKE '%" + txtNguoiLap.Text + "%'";

            sql += " WHERE " + dieukien;

            daHoaDon = new SqlDataAdapter(sql, conn);
            dtHoaDon = new DataTable();
            daHoaDon.Fill(dtHoaDon);
            dgDanhMuc.DataSource = dtHoaDon;
            lblThongBao.Text = "Có " + (dgDanhMuc.RowCount - 1) + " hóa đơn.";
            xoachitiet();
        }

        private void dgDanhMuc_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dgDanhMuc.RowCount > 0)
                {
                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = dgDanhMuc.Rows[e.RowIndex];
                        txtTongTien.Text = row.Cells[4].Value.ToString();
                        txtChietKhau.Text = row.Cells[5].Value.ToString();
                        txtThanhTien.Text = row.Cells[6].Value.ToString();
                        sohd = row.Cells[0].Value.ToString();
                        laynguonchitiet();
                    }
                }
            }
            catch (Exception ev)
            {
                MessageBox.Show("Lỗi : " + ev.Message, "Thông Báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string sohd = "";

        private void txtNguoiLap_TextChanged(object sender, EventArgs e)
        {

        }

        public void xoachitiet()
        {
            dgCTHoaDon.DataSource = null;
            txtTongTien.Text = ""; 
            txtChietKhau.Text = ""; txtThanhTien.Text = "";
        }

        public void laynguonchitiet()// inner join trả về các dòng của 2 bảng thỏa mãn đk kết nối
        {
            sql = "Select TenHang, SLNhap, DGNhap, (SLNhap*DGNhap) As Tien " +
                "From T_HangHoa inner join T_ChiTietMH on T_HangHoa.MaHang=T_ChiTietMH.MaHang " +
                "Where MaHDMH = N'" + sohd + "'";
            daChiTiet = new SqlDataAdapter(sql, conn);
            dtChiTiet = new DataTable();
            daChiTiet.Fill(dtChiTiet);
            dgCTHoaDon.DataSource = dtChiTiet;
        }
    }
}
