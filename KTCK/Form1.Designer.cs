namespace KTCK
{
    partial class frmQuanLyDonHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLyDonHang));
            this.MenuStripquanLyDonHang = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDM_NhomHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDM_MatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDM_KhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLHD_LapHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLHD_TimKiemHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuLapHoaDonMuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiemHoaDonMuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC_LapBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLapBaoCaoThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBC_TraCuuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLapBaoCaoCongNo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoBanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStripquanLyDonHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStripquanLyDonHang
            // 
            this.MenuStripquanLyDonHang.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripquanLyDonHang.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuHeThong,
            this.toolStripMenuDanhMuc,
            this.quảnLýHóaĐơnToolStripMenuItem,
            this.baoCaoToolStripMenuItem});
            this.MenuStripquanLyDonHang.Location = new System.Drawing.Point(0, 0);
            this.MenuStripquanLyDonHang.Name = "MenuStripquanLyDonHang";
            this.MenuStripquanLyDonHang.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.MenuStripquanLyDonHang.Size = new System.Drawing.Size(880, 28);
            this.MenuStripquanLyDonHang.TabIndex = 0;
            this.MenuStripquanLyDonHang.Text = "Quản Lý Hóa Đơn Hàng";
            this.MenuStripquanLyDonHang.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuStripquanLyDonHang_ItemClicked);
            // 
            // toolStripMenuHeThong
            // 
            this.toolStripMenuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.toolStripMenuHeThong.Name = "toolStripMenuHeThong";
            this.toolStripMenuHeThong.Size = new System.Drawing.Size(88, 24);
            this.toolStripMenuHeThong.Text = "Hệ Thống";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = ((System.Drawing.Image)(resources.GetObject("mnuThoat.Image")));
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.Size = new System.Drawing.Size(224, 26);
            this.mnuThoat.Text = "Thoát Hệ Thống";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // toolStripMenuDanhMuc
            // 
            this.toolStripMenuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDM_NhomHang,
            this.toolStripMenuItem1,
            this.mnuDM_MatHang,
            this.toolStripMenuItem2,
            this.mnuDM_KhachHang,
            this.toolStripMenuItem4,
            this.mnuNhanVien});
            this.toolStripMenuDanhMuc.Name = "toolStripMenuDanhMuc";
            this.toolStripMenuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.toolStripMenuDanhMuc.Text = "Danh Mục";
            // 
            // mnuDM_NhomHang
            // 
            this.mnuDM_NhomHang.Image = ((System.Drawing.Image)(resources.GetObject("mnuDM_NhomHang.Image")));
            this.mnuDM_NhomHang.Name = "mnuDM_NhomHang";
            this.mnuDM_NhomHang.Size = new System.Drawing.Size(224, 26);
            this.mnuDM_NhomHang.Text = "Phòng Ban";
            this.mnuDM_NhomHang.Click += new System.EventHandler(this.mnuDM_NhomHang_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuDM_MatHang
            // 
            this.mnuDM_MatHang.Image = ((System.Drawing.Image)(resources.GetObject("mnuDM_MatHang.Image")));
            this.mnuDM_MatHang.Name = "mnuDM_MatHang";
            this.mnuDM_MatHang.Size = new System.Drawing.Size(224, 26);
            this.mnuDM_MatHang.Text = "Mặt Hàng";
            this.mnuDM_MatHang.Click += new System.EventHandler(this.mnuDM_MatHang_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuDM_KhachHang
            // 
            this.mnuDM_KhachHang.Image = ((System.Drawing.Image)(resources.GetObject("mnuDM_KhachHang.Image")));
            this.mnuDM_KhachHang.Name = "mnuDM_KhachHang";
            this.mnuDM_KhachHang.Size = new System.Drawing.Size(224, 26);
            this.mnuDM_KhachHang.Text = "Khách Hàng";
            this.mnuDM_KhachHang.Click += new System.EventHandler(this.mnuDM_KhachHang_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Image = global::KTCK.Properties.Resources.Users_icon;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(224, 26);
            this.mnuNhanVien.Text = "Nhân Viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // quảnLýHóaĐơnToolStripMenuItem
            // 
            this.quảnLýHóaĐơnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLHD_LapHoaDon,
            this.mnuQLHD_TimKiemHoaDon,
            this.toolStripMenuItem3,
            this.mnuLapHoaDonMuaHang,
            this.mnuTimKiemHoaDonMuaHang});
            this.quảnLýHóaĐơnToolStripMenuItem.Name = "quảnLýHóaĐơnToolStripMenuItem";
            this.quảnLýHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.quảnLýHóaĐơnToolStripMenuItem.Text = "Quản Lý Hóa Đơn";
            // 
            // mnuQLHD_LapHoaDon
            // 
            this.mnuQLHD_LapHoaDon.Image = global::KTCK.Properties.Resources.laphoadon;
            this.mnuQLHD_LapHoaDon.Name = "mnuQLHD_LapHoaDon";
            this.mnuQLHD_LapHoaDon.Size = new System.Drawing.Size(292, 26);
            this.mnuQLHD_LapHoaDon.Text = "Lập Hóa Đơn Bán Hàng";
            this.mnuQLHD_LapHoaDon.Click += new System.EventHandler(this.mnuQLHD_LapHoaDon_Click);
            // 
            // mnuQLHD_TimKiemHoaDon
            // 
            this.mnuQLHD_TimKiemHoaDon.Image = global::KTCK.Properties.Resources.timkiemhoadon;
            this.mnuQLHD_TimKiemHoaDon.Name = "mnuQLHD_TimKiemHoaDon";
            this.mnuQLHD_TimKiemHoaDon.Size = new System.Drawing.Size(292, 26);
            this.mnuQLHD_TimKiemHoaDon.Text = "Tìm Kiếm Hóa Đơn Bán Hàng";
            this.mnuQLHD_TimKiemHoaDon.Click += new System.EventHandler(this.mnuQLHD_TimKiemHoaDon_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(289, 6);
            // 
            // mnuLapHoaDonMuaHang
            // 
            this.mnuLapHoaDonMuaHang.Image = global::KTCK.Properties.Resources.clipboard_invoice_icon;
            this.mnuLapHoaDonMuaHang.Name = "mnuLapHoaDonMuaHang";
            this.mnuLapHoaDonMuaHang.Size = new System.Drawing.Size(292, 26);
            this.mnuLapHoaDonMuaHang.Text = "Lập Hóa Đơn Mua Hàng";
            this.mnuLapHoaDonMuaHang.Click += new System.EventHandler(this.mnuLapHoaDonMuaHang_Click);
            // 
            // mnuTimKiemHoaDonMuaHang
            // 
            this.mnuTimKiemHoaDonMuaHang.Image = global::KTCK.Properties.Resources.zoom_seach_icon__1_;
            this.mnuTimKiemHoaDonMuaHang.Name = "mnuTimKiemHoaDonMuaHang";
            this.mnuTimKiemHoaDonMuaHang.Size = new System.Drawing.Size(292, 26);
            this.mnuTimKiemHoaDonMuaHang.Text = "Tìm Kiếm Hóa Đơn Mua Hàng";
            this.mnuTimKiemHoaDonMuaHang.Click += new System.EventHandler(this.mnuTimKiemHoaDonMuaHang_Click);
            // 
            // baoCaoToolStripMenuItem
            // 
            this.baoCaoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBC_LapBaoCao,
            this.mnuLapBaoCaoThu,
            this.mnuBC_TraCuuBaoCao,
            this.mnuLapBaoCaoCongNo,
            this.mnuBaoCaoBanHang});
            this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            this.baoCaoToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.baoCaoToolStripMenuItem.Text = "Báo Cáo";
            // 
            // mnuBC_LapBaoCao
            // 
            this.mnuBC_LapBaoCao.Image = global::KTCK.Properties.Resources.to_do_list_cheked_1_icon;
            this.mnuBC_LapBaoCao.Name = "mnuBC_LapBaoCao";
            this.mnuBC_LapBaoCao.Size = new System.Drawing.Size(312, 26);
            this.mnuBC_LapBaoCao.Text = "Lập Báo Cáo Chi";
            this.mnuBC_LapBaoCao.Click += new System.EventHandler(this.mnuBC_LapBaoCao_Click);
            // 
            // mnuLapBaoCaoThu
            // 
            this.mnuLapBaoCaoThu.Image = ((System.Drawing.Image)(resources.GetObject("mnuLapBaoCaoThu.Image")));
            this.mnuLapBaoCaoThu.Name = "mnuLapBaoCaoThu";
            this.mnuLapBaoCaoThu.Size = new System.Drawing.Size(312, 26);
            this.mnuLapBaoCaoThu.Text = "Lập Báo Cáo Thu";
            this.mnuLapBaoCaoThu.Click += new System.EventHandler(this.mnuLapBaoCaoThu_Click);
            // 
            // mnuBC_TraCuuBaoCao
            // 
            this.mnuBC_TraCuuBaoCao.Image = global::KTCK.Properties.Resources.to_do_list_cheked_1_icon;
            this.mnuBC_TraCuuBaoCao.Name = "mnuBC_TraCuuBaoCao";
            this.mnuBC_TraCuuBaoCao.Size = new System.Drawing.Size(312, 26);
            this.mnuBC_TraCuuBaoCao.Text = "Lập Báo Cáo Tồn";
            this.mnuBC_TraCuuBaoCao.Click += new System.EventHandler(this.mnuBC_TraCuuBaoCao_Click);
            // 
            // mnuLapBaoCaoCongNo
            // 
            this.mnuLapBaoCaoCongNo.Image = global::KTCK.Properties.Resources.to_do_list_cheked_1_icon;
            this.mnuLapBaoCaoCongNo.Name = "mnuLapBaoCaoCongNo";
            this.mnuLapBaoCaoCongNo.Size = new System.Drawing.Size(312, 26);
            this.mnuLapBaoCaoCongNo.Text = "Lập Báo Cáo Công Nợ";
            this.mnuLapBaoCaoCongNo.Click += new System.EventHandler(this.mnuLapBaoCaoCongNo_Click);
            // 
            // mnuBaoCaoBanHang
            // 
            this.mnuBaoCaoBanHang.Image = global::KTCK.Properties.Resources.to_do_list_cheked_1_icon;
            this.mnuBaoCaoBanHang.Name = "mnuBaoCaoBanHang";
            this.mnuBaoCaoBanHang.Size = new System.Drawing.Size(312, 26);
            this.mnuBaoCaoBanHang.Text = "Lập Báo Cáo Tình Hình Bán Hàng";
            this.mnuBaoCaoBanHang.Click += new System.EventHandler(this.mnuBaoCaoBanHang_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(880, 557);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(880, 99);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phần Mềm Quản Lý Nhân Sự";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmQuanLyDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MenuStripquanLyDonHang);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStripquanLyDonHang;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmQuanLyDonHang";
            this.Text = "Form Quản Lý Đơn Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLyDonHang_Load);
            this.MenuStripquanLyDonHang.ResumeLayout(false);
            this.MenuStripquanLyDonHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripquanLyDonHang;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuHeThong;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQLHD_LapHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuQLHD_TimKiemHoaDon;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuBC_LapBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuBC_TraCuuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuDM_NhomHang;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuDM_MatHang;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuDM_KhachHang;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuLapHoaDonMuaHang;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiemHoaDonMuaHang;
        private System.Windows.Forms.ToolStripMenuItem mnuLapBaoCaoThu;
        private System.Windows.Forms.ToolStripMenuItem mnuLapBaoCaoCongNo;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoBanHang;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

