using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATBMHTTT.Connection;
using Oracle.ManagedDataAccess.Client;

namespace ATBMHTTT
{
    public partial class Form2_Login : Form
    {
        public Form2_Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            if (Login(username, password))
            {
                Login_Info.USERNAME = username;
                Login_Info.PASSWORD = password;
                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }

        bool Login(string username, string password)
        {
            try
            {
                OracleConnection conn = Connection.DBConnection.GetDBConnection(username, password);
                conn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
