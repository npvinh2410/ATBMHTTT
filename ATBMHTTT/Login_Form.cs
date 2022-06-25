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
using ATBMHTTT.PhanHe2;

namespace ATBMHTTT
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtTaiKhoan.Text;
            string password = txtMatKhau.Text;

            List<String> OLS_user = new List<string>();
            OLS_user.Add("GIAMDOCSO");
            OLS_user.Add("GD_NGOAITRU_TT");
            OLS_user.Add("GD_NOITRU_TP");
            OLS_user.Add("YBS_CHUYENSAU_CTT");
            OLS_user.Add("YBS_NGOAITRU_TT");

            if (OLS_user.Contains(username) && OLS_Login(username, password))
            {

                TC7_OLS_THONG_BAO f = new TC7_OLS_THONG_BAO();
                this.Hide();
                f.ShowDialog();
                this.Show();

            }
            else if (username == "dba_yt" && Login(username, password))
            {
                TC1_HOME f = new TC1_HOME();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (username.Contains("NV") && Login(username, password))
            {
                String vaitro = layVaiTroNV();
                if(vaitro == "QUAN LY HSBA")
                {
                    TC3_QL_HSBA f = new TC3_QL_HSBA();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            } 
            else if (Login(username, password))
            {

                Form1 f = new Form1();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
            }
        }

        String layVaiTroNV()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection("DBA_ATBM", "1212");
            try
            {
                conn.Open();

                string query = "select VAITRO from nhan_vien where manv = '" + Login_Info.USERNAME + "'";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable.Rows[0]["VAITRO"].ToString();

            }
            catch (Exception ex)
            {
                return "";
            }
            finally
            {
                conn.Close();
            }
        }
        bool Login(string username, string password)
        {
            try
            {
                OracleConnection conn = Connection.DBConnection.GetDBConnection(username, password);
                conn.Open();
                Login_Info.USERNAME = username;
                Login_Info.PASSWORD = password;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        bool OLS_Login(string username, string password)
        {
            try
            {
                OracleConnection conn = Connection.DBConnection.GetDBConnection_OLS(username, password);
                conn.Open();
                Login_Info.USERNAME = username;
                Login_Info.PASSWORD = password;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void Form2_Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
