namespace KTCK
{
    partial class frmTraCuuHoaDonBanHang
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
            this.grpTimKiemHoaDon = new System.Windows.Forms.GroupBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dtpNgayLapDen = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayLapTu = new System.Windows.Forms.DateTimePicker();
            this.txtNguoiLap = new System.Windows.Forms.TextBox();
            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgDanhMuc = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCTHoaDon = new System.Windows.Forms.DataGridView();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTinThanhToan = new System.Windows.Forms.GroupBox();
            this.txtThue = new System.Windows.Forms.TextBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpTimKiemHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCTHoaDon)).BeginInit();
            this.grpThongTinThanhToan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpTimKiemHoaDon
            // 
            this.grpTimKiemHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpTimKiemHoaDon.Controls.Add(this.lblThongBao);
            this.grpTimKiemHoaDon.Controls.Add(this.btnTimKiem);
            this.grpTimKiemHoaDon.Controls.Add(this.dtpNgayLapDen);
            this.grpTimKiemHoaDon.Controls.Add(this.dtpNgayLapTu);
            this.grpTimKiemHoaDon.Controls.Add(this.txtNguoiLap);
            this.grpTimKiemHoaDon.Controls.Add(this.txtSoHD);
            this.grpTimKiemHoaDon.Controls.Add(this.label5);
            this.grpTimKiemHoaDon.Controls.Add(this.label4);
            this.grpTimKiemHoaDon.Controls.Add(this.label3);
            this.grpTimKiemHoaDon.Controls.Add(this.label2);
            this.grpTimKiemHoaDon.Location = new System.Drawing.Point(1, 62);
            this.grpTimKiemHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.grpTimKiemHoaDon.Name = "grpTimKiemHoaDon";
            this.grpTimKiemHoaDon.Padding = new System.Windows.Forms.Padding(4);
            this.grpTimKiemHoaDon.Size = new System.Drawing.Size(1217, 123);
            this.grpTimKiemHoaDon.TabIndex = 1;
            this.grpTimKiemHoaDon.TabStop = false;
            this.grpTimKiemHoaDon.Text = "Tìm Kiếm Hóa Đơn";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(899, 91);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(120, 17);
            this.lblThongBao.TabIndex = 9;
            this.lblThongBao.Text = "Số lượng hóa đơn";
            this.lblThongBao.UseMnemonic = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnTimKiem.Image = global::KTCK.Properties.Resources.zoom_seach_icon__1_;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(903, 27);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(211, 50);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dtpNgayLapDen
            // 
            this.dtpNgayLapDen.Location = new System.Drawing.Point(551, 70);
            this.dtpNgayLapDen.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayLapDen.Name = "dtpNgayLapDen";
            this.dtpNgayLapDen.Size = new System.Drawing.Size(265, 22);
            this.dtpNgayLapDen.TabIndex = 7;
            // 
            // dtpNgayLapTu
            // 
            this.dtpNgayLapTu.Location = new System.Drawing.Point(99, 79);
            this.dtpNgayLapTu.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgayLapTu.Name = "dtpNgayLapTu";
            this.dtpNgayLapTu.Size = new System.Drawing.Size(263, 22);
            this.dtpNgayLapTu.TabIndex = 6;
            // 
            // txtNguoiLap
            // 
            this.txtNguoiLap.Location = new System.Drawing.Point(551, 32);
            this.txtNguoiLap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNguoiLap.Name = "txtNguoiLap";
            this.txtNguoiLap.Size = new System.Drawing.Size(265, 22);
            this.txtNguoiLap.TabIndex = 5;
            this.txtNguoiLap.TextChanged += new System.EventHandler(this.txtNguoiLap_TextChanged);
            // 
            // txtSoHD
            // 
            this.txtSoHD.Location = new System.Drawing.Point(99, 32);
            this.txtSoHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoHD.Name = "txtSoHD";
            this.txtSoHD.Size = new System.Drawing.Size(263, 22);
            this.txtSoHD.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 79);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Từ Ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(420, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Người lập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến Ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số HD:";
            // 
            // dgDanhMuc
            // 
            this.dgDanhMuc.AllowUserToOrderColumns = true;
            this.dgDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgDanhMuc.Location = new System.Drawing.Point(1, 192);
            this.dgDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.dgDanhMuc.Name = "dgDanhMuc";
            this.dgDanhMuc.RowHeadersWidth = 51;
            this.dgDanhMuc.Size = new System.Drawing.Size(1217, 185);
            this.dgDanhMuc.TabIndex = 2;
            this.dgDanhMuc.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgDanhMuc_CellMouseClick);
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaHDBH";
            this.Column2.HeaderText = "Số HĐ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NgayLHD";
            this.Column3.HeaderText = "Ngày Lập";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaNV";
            this.Column4.HeaderText = "Người Lập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MaKH";
            this.Column5.HeaderText = "Mã KH";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TenKH";
            this.Column6.HeaderText = "Tên Khách Hàng";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Thue";
            this.Column8.HeaderText = "Thuế";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "CK";
            this.Column9.HeaderText = "C.Khấu";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "SoTienTT";
            this.Column10.HeaderText = "Tổng Tiền ";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 125;
            // 
            // dgCTHoaDon
            // 
            this.dgCTHoaDon.AllowUserToOrderColumns = true;
            this.dgCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCTHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenHang,
            this.SoLuong,
            this.GiaBan,
            this.Tien});
            this.dgCTHoaDon.Location = new System.Drawing.Point(5, 384);
            this.dgCTHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgCTHoaDon.Name = "dgCTHoaDon";
            this.dgCTHoaDon.RowHeadersWidth = 51;
            this.dgCTHoaDon.Size = new System.Drawing.Size(593, 213);
            this.dgCTHoaDon.TabIndex = 3;
            // 
            // TenHang
            // 
            this.TenHang.DataPropertyName = "TenHang";
            this.TenHang.HeaderText = "Tên Hàng";
            this.TenHang.MinimumWidth = 6;
            this.TenHang.Name = "TenHang";
            this.TenHang.Width = 200;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SLBan";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 60;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "DGBan";
            this.GiaBan.HeaderText = "Giá Bán ";
            this.GiaBan.MinimumWidth = 6;
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 60;
            // 
            // Tien
            // 
            this.Tien.DataPropertyName = "Tien";
            this.Tien.HeaderText = "Tiền";
            this.Tien.MinimumWidth = 6;
            this.Tien.Name = "Tien";
            this.Tien.Width = 125;
            // 
            // grpThongTinThanhToan
            // 
            this.grpThongTinThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpThongTinThanhToan.Controls.Add(this.txtThue);
            this.grpThongTinThanhToan.Controls.Add(this.txtThanhTien);
            this.grpThongTinThanhToan.Controls.Add(this.txtChietKhau);
            this.grpThongTinThanhToan.Controls.Add(this.txtTongTien);
            this.grpThongTinThanhToan.Controls.Add(this.label9);
            this.grpThongTinThanhToan.Controls.Add(this.label8);
            this.grpThongTinThanhToan.Controls.Add(this.label7);
            this.grpThongTinThanhToan.Controls.Add(this.label6);
            this.grpThongTinThanhToan.Location = new System.Drawing.Point(607, 384);
            this.grpThongTinThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.grpThongTinThanhToan.Name = "grpThongTinThanhToan";
            this.grpThongTinThanhToan.Padding = new System.Windows.Forms.Padding(4);
            this.grpThongTinThanhToan.Size = new System.Drawing.Size(612, 213);
            this.grpThongTinThanhToan.TabIndex = 4;
            this.grpThongTinThanhToan.TabStop = false;
            this.grpThongTinThanhToan.Text = "Thông tin thanh toán";
            // 
            // txtThue
            // 
            this.txtThue.Location = new System.Drawing.Point(228, 81);
            this.txtThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtThue.Name = "txtThue";
            this.txtThue.Size = new System.Drawing.Size(268, 22);
            this.txtThue.TabIndex = 7;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(228, 174);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(268, 22);
            this.txtThanhTien.TabIndex = 6;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(228, 124);
            this.txtChietKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.Size = new System.Drawing.Size(268, 22);
            this.txtChietKhau.TabIndex = 5;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(228, 34);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(268, 22);
            this.txtTongTien.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 85);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Tiền Thuế:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Chiết khấu:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 177);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tổng tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Khách Hàng:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1215, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "TRA CỨU HÓA ĐƠN BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Turquoise;
            this.pictureBox1.Image = global::KTCK.Properties.Resources.folder_search_icon1;
            this.pictureBox1.Location = new System.Drawing.Point(359, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 58);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmTraCuuHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 615);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.grpThongTinThanhToan);
            this.Controls.Add(this.dgCTHoaDon);
            this.Controls.Add(this.dgDanhMuc);
            this.Controls.Add(this.grpTimKiemHoaDon);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTraCuuHoaDonBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Tra Cứu Hóa Đơn Bán Hàng";
            this.Load += new System.EventHandler(this.frmTraCuuHoaDonBanHang_Load);
            this.grpTimKiemHoaDon.ResumeLayout(false);
            this.grpTimKiemHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDanhMuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCTHoaDon)).EndInit();
            this.grpThongTinThanhToan.ResumeLayout(false);
            this.grpThongTinThanhToan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpTimKiemHoaDon;
        private System.Windows.Forms.DateTimePicker dtpNgayLapDen;
        private System.Windows.Forms.DateTimePicker dtpNgayLapTu;
        private System.Windows.Forms.TextBox txtNguoiLap;
        private System.Windows.Forms.TextBox txtSoHD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgDanhMuc;
        private System.Windows.Forms.DataGridView dgCTHoaDon;
        private System.Windows.Forms.GroupBox grpThongTinThanhToan;
        private System.Windows.Forms.TextBox txtThue;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tien;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}