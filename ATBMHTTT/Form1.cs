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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void viewPrivilegesBtn_Click(object sender, EventArgs e)
        {
            string roleName = roleNameTextBox.Text.ToUpper();
            string userName = userNameTextBox.Text.ToUpper();

            if (roleName != "" && userName != "")
            {
                MessageBox.Show("Chỉ nhập role hoặc user", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                roleNameTextBox.Text = "";
                userNameTextBox.Text = "";
            }else if (roleName == "" && userName == "") {
                MessageBox.Show("Bạn cần nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
                try
                {
                    conn.Open();
                    string sqlString = "";

                    if (roleName != "")
                    {
                        sqlString += "SELECT GRANTEE, TABLE_NAME, GRANTOR, PRIVILEGE, TYPE FROM DBA_TAB_PRIVS WHERE GRANTEE = '" + roleName + "'";
                    }else if(userName != "")
                    {
                        sqlString += "SELECT GRANTEE, TABLE_NAME, GRANTOR, PRIVILEGE, TYPE FROM DBA_TAB_PRIVS" +
                                            " WHERE GRANTEE = '" + userName + "'" +
                                            " OR GRANTEE IN(SELECT granted_role FROM DBA_ROLE_PRIVS" +
                                            " WHERE GRANTEE = '" + userName + "') ";
                    }
                    OracleCommand command = new OracleCommand(sqlString, conn);
                    DataTable dataTable = new DataTable();
                    OracleDataAdapter adapter = new OracleDataAdapter(command);
                    adapter.Fill(dataTable);

                    privilegesGridView.DataSource = dataTable;

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                roleNameTextBox.Text = "";
                userNameTextBox.Text = "";
                conn.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name_user = tbuser_user.Text;
            string table = tbuser_bang.Text;
            string collum = tbuser_cot.Text;
            string permissiom = tbuser_quyen.Text;
            bool check = ckbgrant.CheckState == CheckState.Checked ? true : false;
            if (check==true)
            {
                MessageBox.Show("with grant option");
            }
            else
                MessageBox.Show("with no grant option");
        }

        private void btrole_capquyen_Click(object sender, EventArgs e)
        {
            string name_user = tbrole_user.Text;
            string table = tbrole_bang.Text;
            string collum = tbrole_cot.Text;
            string permissiom = tbrole_quyen.Text;
        }

        private void bt_capquyen_Click(object sender, EventArgs e)
        {
            string name_role = tbrole.Text;
            string name_user = tbuser.Text;
        }
    }
}
