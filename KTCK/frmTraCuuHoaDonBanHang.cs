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
    public partial class frmTraCuuHoaDonBanHang : Form
    {
        SqlConnection conn;
        SqlDataAdapter daHoaDon, daChiTiet;
        DataTable dtHoaDon, dtChiTiet;
        string sql = "";
        public frmTraCuuHoaDonBanHang()
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
            sql = "SELECT T_HoaDonBH.MaHDBH, NgayLHD, T_HoaDonBH.MaNV, T_KhachHang.MaKH, T_KhachHang.TenKH, Thue, T_ChiTietBH.CK, SoTienTT " +
                    "FROM ((T_HoaDonBH JOIN T_ChiTietBH ON T_HoaDonBH.MaHDBH = T_ChiTietBH.MaHDBH) " +
                    "JOIN T_KhachHang ON T_KhachHang.MaKH = T_HoaDonBH.MaKH) " +
                    "JOIN T_PhieuThu ON T_PhieuThu.MaKH = T_KhachHang.MaKH";

            dieukien = " NgayLHD>='" + dtpNgayLapTu.Value.Date.ToString("MM/dd/yyyy") + "' and NgayLHD<='" + dtpNgayLapDen.Value.Date.ToString("MM/dd/yyyy") + "'";
            if (txtSoHD.Text != "") dieukien = dieukien + " And T_HoaDonBH.MaHDBH LIKE '%" + txtSoHD.Text + "%'";
            if (txtNguoiLap.Text != "") dieukien = dieukien + " And T_HoaDonBH.MaNV LIKE '%" + txtNguoiLap.Text + "%'";
            sql = sql + " WHERE " + dieukien;
            daHoaDon = new SqlDataAdapter(sql, conn);
            dtHoaDon = new DataTable();
            daHoaDon.Fill(dtHoaDon);
            dgDanhMuc.DataSource = dtHoaDon;
            lblThongBao.Text = "Có " + (dgDanhMuc.RowCount-1) + " hóa đơn.";
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
                        txtThue.Text = row.Cells[5].Value.ToString();
                        txtChietKhau.Text = row.Cells[6].Value.ToString();
                        txtThanhTien.Text = row.Cells[7].Value.ToString();
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
            txtTongTien.Text = ""; txtThue.Text = "";
            txtChietKhau.Text = ""; txtThanhTien.Text = "";
        }

        public void laynguonchitiet()// inner join trả về các dòng của 2 bảng thỏa mãn đk kết nối
        {
            sql = "Select TenHang,SLBan, DGBan, (SLBan*DGBan) As Tien " +
                "From T_HangHoa inner join T_ChiTietBH on T_HangHoa.MaHang=T_ChiTietBH.MaHang " +
                "Where MaHDBH = N'" + sohd + "'";
            daChiTiet = new SqlDataAdapter(sql, conn);
            dtChiTiet = new DataTable();
            daChiTiet.Fill(dtChiTiet);
            dgCTHoaDon.DataSource = dtChiTiet;
        }
    }
}
