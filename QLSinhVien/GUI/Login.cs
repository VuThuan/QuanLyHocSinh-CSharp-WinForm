using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace QLHocSinh
{
    public partial class Login : Form
    {
        
        public static bool flag;
        public string SAVEUSER, SAVEPASS;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Select();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult ok;
                ok = MessageBox.Show("Bạn Có Chắc Muốn Thoát khỏi Chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (ok == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Bắt Lỗi: Exception  ");

            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Tên Đăng Nhập không được để trống");
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống");
            }
            else
            {
				//try
				//{
				//    if (login(txtuser.Text, txtpass.Text) == true)
				//    {
				//        MessageBox.Show("Đăng nhập thành công");
				//        flag = true;
				//        this.Close();
				//    }
				//    else
				//        MessageBox.Show("Tên Đăng Nhập hoặc Mật Khẩu sai");
				//}
				//catch (Exception ex)
				//{
				//    MessageBox.Show(ex.Message);
				//}
				if (txtUsername.Text =="admin" && txtPassword.Text=="admin")
				{
					MessageBox.Show("Đăng nhập thành công");
					flag = true;
					this.Close();
				}
				else
				{
					MessageBox.Show("Tên Đăng Nhập hoặc Mật Khẩu sai");
				}
			}
        }
    }
}
