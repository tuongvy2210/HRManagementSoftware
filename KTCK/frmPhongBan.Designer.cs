namespace KTCK
{
    partial class frmPhongBan
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
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.txtTenPhongBan = new System.Windows.Forms.TextBox();
            this.txtMaPhongBan = new System.Windows.Forms.TextBox();
            this.lblTenNhom = new System.Windows.Forms.Label();
            this.lblMaNhom = new System.Windows.Forms.Label();
            this.grpCongCuHoTro = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKhong = new System.Windows.Forms.Button();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.lblNhomHang = new System.Windows.Forms.Label();
            this.lblSoNhomHang = new System.Windows.Forms.Label();
            this.MaNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpThongTin.SuspendLayout();
            this.grpCongCuHoTro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // grpThongTin
            // 
            this.grpThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpThongTin.Controls.Add(this.txtTenPhongBan);
            this.grpThongTin.Controls.Add(this.txtMaPhongBan);
            this.grpThongTin.Controls.Add(this.lblTenNhom);
            this.grpThongTin.Controls.Add(this.lblMaNhom);
            this.grpThongTin.Location = new System.Drawing.Point(63, 329);
            this.grpThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpThongTin.Size = new System.Drawing.Size(691, 118);
            this.grpThongTin.TabIndex = 0;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông Tin";
            // 
            // txtTenPhongBan
            // 
            this.txtTenPhongBan.Location = new System.Drawing.Point(158, 60);
            this.txtTenPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenPhongBan.Name = "txtTenPhongBan";
            this.txtTenPhongBan.Size = new System.Drawing.Size(277, 22);
            this.txtTenPhongBan.TabIndex = 3;
            // 
            // txtMaPhongBan
            // 
            this.txtMaPhongBan.Location = new System.Drawing.Point(158, 19);
            this.txtMaPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaPhongBan.Name = "txtMaPhongBan";
            this.txtMaPhongBan.Size = new System.Drawing.Size(277, 22);
            this.txtMaPhongBan.TabIndex = 2;
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.Location = new System.Drawing.Point(35, 64);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(103, 16);
            this.lblTenNhom.TabIndex = 1;
            this.lblTenNhom.Text = "Tên Phòng Ban:";
            // 
            // lblMaNhom
            // 
            this.lblMaNhom.AutoSize = true;
            this.lblMaNhom.Location = new System.Drawing.Point(35, 22);
            this.lblMaNhom.Name = "lblMaNhom";
            this.lblMaNhom.Size = new System.Drawing.Size(101, 16);
            this.lblMaNhom.TabIndex = 0;
            this.lblMaNhom.Text = "Mã Phòng Ban :";
            // 
            // grpCongCuHoTro
            // 
            this.grpCongCuHoTro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpCongCuHoTro.Controls.Add(this.btnXoa);
            this.grpCongCuHoTro.Controls.Add(this.btnKhong);
            this.grpCongCuHoTro.Controls.Add(this.btnGhi);
            this.grpCongCuHoTro.Controls.Add(this.btnSua);
            this.grpCongCuHoTro.Controls.Add(this.btnThem);
            this.grpCongCuHoTro.Location = new System.Drawing.Point(63, 486);
            this.grpCongCuHoTro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCongCuHoTro.Name = "grpCongCuHoTro";
            this.grpCongCuHoTro.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCongCuHoTro.Size = new System.Drawing.Size(691, 111);
            this.grpCongCuHoTro.TabIndex = 1;
            this.grpCongCuHoTro.TabStop = false;
            this.grpCongCuHoTro.Text = "Công Cụ Hỗ Trợ";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnXoa.Image = global::KTCK.Properties.Resources.btXoa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(290, 34);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 49);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnKhong
            // 
            this.btnKhong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnKhong.Image = global::KTCK.Properties.Resources.Go_back_icon;
            this.btnKhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhong.Location = new System.Drawing.Point(595, 34);
            this.btnKhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhong.Name = "btnKhong";
            this.btnKhong.Size = new System.Drawing.Size(75, 49);
            this.btnKhong.TabIndex = 3;
            this.btnKhong.Text = "Không";
            this.btnKhong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhong.UseVisualStyleBackColor = false;
            this.btnKhong.Click += new System.EventHandler(this.btnKhong_Click);
            // 
            // btnGhi
            // 
            this.btnGhi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnGhi.Image = global::KTCK.Properties.Resources.btSave1;
            this.btnGhi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGhi.Location = new System.Drawing.Point(446, 34);
            this.btnGhi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.Size = new System.Drawing.Size(89, 49);
            this.btnGhi.TabIndex = 2;
            this.btnGhi.Text = "Ghi";
            this.btnGhi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGhi.UseVisualStyleBackColor = false;
            this.btnGhi.Click += new System.EventHandler(this.btnGhi_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSua.Image = global::KTCK.Properties.Resources.hp_customization_control_panel_icon;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(158, 34);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(81, 49);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThem.Image = global::KTCK.Properties.Resources.btThem;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.ImageKey = "(none)";
            this.btnThem.Location = new System.Drawing.Point(23, 34);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 49);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvPhongBan
            // 
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNhom,
            this.TenNhom});
            this.dgvPhongBan.Location = new System.Drawing.Point(63, 114);
            this.dgvPhongBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.RowHeadersWidth = 51;
            this.dgvPhongBan.RowTemplate.Height = 24;
            this.dgvPhongBan.Size = new System.Drawing.Size(691, 150);
            this.dgvPhongBan.TabIndex = 2;
            this.dgvPhongBan.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvNhomHang_CellMouseClick);
            // 
            // lblNhomHang
            // 
            this.lblNhomHang.AutoSize = true;
            this.lblNhomHang.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhomHang.Location = new System.Drawing.Point(283, 31);
            this.lblNhomHang.Name = "lblNhomHang";
            this.lblNhomHang.Size = new System.Drawing.Size(262, 45);
            this.lblNhomHang.TabIndex = 3;
            this.lblNhomHang.Text = "PHÒNG BAN";
            // 
            // lblSoNhomHang
            // 
            this.lblSoNhomHang.AutoSize = true;
            this.lblSoNhomHang.Location = new System.Drawing.Point(589, 292);
            this.lblSoNhomHang.Name = "lblSoNhomHang";
            this.lblSoNhomHang.Size = new System.Drawing.Size(96, 16);
            this.lblSoNhomHang.TabIndex = 4;
            this.lblSoNhomHang.Text = "Có  Phòng Ban";
            // 
            // MaNhom
            // 
            this.MaNhom.DataPropertyName = "MaPB";
            this.MaNhom.HeaderText = "Mã phòng ban";
            this.MaNhom.MinimumWidth = 6;
            this.MaNhom.Name = "MaNhom";
            this.MaNhom.ReadOnly = true;
            // 
            // TenNhom
            // 
            this.TenNhom.DataPropertyName = "TenPB";
            this.TenNhom.HeaderText = "Tên phòng ban";
            this.TenNhom.MinimumWidth = 6;
            this.TenNhom.Name = "TenNhom";
            this.TenNhom.ReadOnly = true;
            // 
            // frmPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 644);
            this.Controls.Add(this.lblSoNhomHang);
            this.Controls.Add(this.lblNhomHang);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.grpCongCuHoTro);
            this.Controls.Add(this.grpThongTin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Quản Lý Phòng Ban";
            this.Load += new System.EventHandler(this.frmQuanLyNhomHang_Load);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.grpCongCuHoTro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblTenNhom;
        private System.Windows.Forms.Label lblMaNhom;
        private System.Windows.Forms.GroupBox grpCongCuHoTro;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKhong;
        private System.Windows.Forms.Button btnGhi;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenPhongBan;
        private System.Windows.Forms.TextBox txtMaPhongBan;
        private System.Windows.Forms.DataGridView dgvPhongBan;
        private System.Windows.Forms.Label lblNhomHang;
        private System.Windows.Forms.Label lblSoNhomHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNhom;
    }
}