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
    public partial class frmLogin : Form
    {
        SqlConnection conn;
        SqlDataAdapter da;
        DataTable dt;
        string sql = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Chưa nhập tên đăng nhập.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus(); return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPassword.Focus(); return;
            }
            sql = $"Select * From TaiKhoan Where TenDangNhap='{txtUsername.Text}' And MatKhau='{txtPassword.Text}'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                frmQuanLyDonHang frm = new frmQuanLyDonHang();
                this.Hide();
                frm.ShowDialog();
                this.Show();
            } 
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu chưa đúng. Vui lòng kiểm tra lại.", "Thông Báo",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsername.Focus(); return;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn = Connect.ConnectDB();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?.", "Thông Báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        
    }
}
