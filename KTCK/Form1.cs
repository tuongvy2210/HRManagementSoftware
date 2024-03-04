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
using Microsoft.Reporting.WinForms;

namespace KTCK
{
    public partial class frmQuanLyDonHang : Form
    {
        SqlConnection conn;
        SqlDataAdapter daPhieuChi;
        DataTable dtPhieuChi;
        public frmQuanLyDonHang()
        {
            InitializeComponent();
        }

        private void frmQuanLyDonHang_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectDB();
        }

        private void MenuStripquanLyDonHang_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mnuDM_NhomHang_Click(object sender, EventArgs e)
        {
            frmPhongBan frm = new frmPhongBan();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDM_MatHang_Click(object sender, EventArgs e)
        {
            frmMatHang frm = new frmMatHang();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void mnuDM_KhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frm = new frmKhachHang();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQLHD_LapHoaDon_Click(object sender, EventArgs e)
        {
            frmLapHoaDon frm = new frmLapHoaDon();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien frm = new frmNhanVien();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void mnuQLHD_TimKiemHoaDon_Click(object sender, EventArgs e)
        {
            frmTraCuuHoaDonBanHang frm = new frmTraCuuHoaDonBanHang();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void mnuLapHoaDonMuaHang_Click(object sender, EventArgs e)
        {
            frmLapHoaDonMuaHang frm = new frmLapHoaDonMuaHang();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void mnuTimKiemHoaDonMuaHang_Click(object sender, EventArgs e)
        {
            frmTraCuuHoaDonMuaHang frm = new frmTraCuuHoaDonMuaHang();
            //frm.MdiParent = this;
            frm.Show();
        }
        
        private void mnuBC_LapBaoCao_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM T_PhieuChi";
            moBaoCao("rPhieuChi", sql);
        }

        private void moBaoCao(string tenBaoCao, string sql)
        {
            frmReport frm = new frmReport();
            ReportDataSource rds = new ReportDataSource("DataSet1");
            frm.reportViewer1.LocalReport.ReportEmbeddedResource = $"KTCK.Reports.{tenBaoCao}.rdlc";
            daPhieuChi = new SqlDataAdapter(sql, conn);
            dtPhieuChi = new DataTable();
            daPhieuChi.Fill(dtPhieuChi);
            rds.Value = dtPhieuChi;
            frm.reportViewer1.LocalReport.DataSources.Add(rds);
            frm.reportViewer1.RefreshReport();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void mnuLapBaoCaoCongNo_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM V_NhaCungCap_CongNo";
            moBaoCao("rBaoCaoCongNo", sql);
        }

        private void mnuLapBaoCaoThu_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM T_PhieuThu";
            moBaoCao("rPhieuThu", sql);
        }

        private void mnuBC_TraCuuBaoCao_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM V_SanPham_TonKho";
            moBaoCao("rTonKho", sql);
        }

        private void mnuBaoCaoBanHang_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM V_TinhHinhBanHang";
            moBaoCao("rTinhHinhBanHang", sql);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
