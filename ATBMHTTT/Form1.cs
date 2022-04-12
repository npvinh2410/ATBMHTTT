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
            loadHideTextbox();
        }

        private void loadHideTextbox()
        {
            textBox4.Hide();
        }


        private void viewPrivilegesBtn_Click(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text.ToUpper();

            if (userName == "")
            {
                MessageBox.Show("Bạn cần nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                loadPrivilegesOfUser(userName);
                userNameTextBox.Text = "";
                textBox2.Text = textBox3.Text = comboBox1.Text = "";
            }
        }

        private void loadPrivilegesOfUser(string userNameOrRole)
        {
            OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();
                string sqlString = "";

                sqlString += "SELECT GRANTEE, TABLE_NAME, GRANTOR, PRIVILEGE, COMMON, TYPE FROM DBA_TAB_PRIVS" +
                                    " WHERE GRANTEE = '" + userNameOrRole + "'" +
                                    " OR GRANTEE IN(SELECT granted_role FROM DBA_ROLE_PRIVS" +
                                    " WHERE GRANTEE = '" + userNameOrRole + "') ";
                textBox1.Text = userNameOrRole;

                OracleCommand command = new OracleCommand(sqlString, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                privilegesGridView.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void themuser_Click(object sender, EventArgs e)
        {
            ThemUser user = new ThemUser();
            user.Show();
        }

        private void themrole_Click(object sender, EventArgs e)
        {
            ThemRole role = new ThemRole();
            role.Show();
        }

        private void privilegesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = textBox3.Text = comboBox1.Text = "";

            string roleText = privilegesGridView["GRANTEE", e.RowIndex].Value.ToString();
            if (!roleText.Equals(textBox1.Text))
            {
                textBox3.Text = roleText;
            }

            textBox2.Text = privilegesGridView["TABLE_NAME", e.RowIndex].Value.ToString();
            comboBox1.SelectedItem = null;
            comboBox1.Text = privilegesGridView["PRIVILEGE", e.RowIndex].Value.ToString();
            textBox4.Text = comboBox1.Text;
        }

        private void edit_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            string oldPrivilege = textBox4.Text;
            string newPrivilege = comboBox1.Text;
            string assignedRole = textBox3.Text;
            if (oldPrivilege.Equals(newPrivilege) || assignedRole != "")
            {
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn muốn cập nhật quyền này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }


            try
            {
                conn.Open();


                string user;
                string privilege;
                user = textBox1.Text;

                privilege = oldPrivilege;
                string objectTable = textBox2.Text;

                string revokeQuery = "REVOKE " + oldPrivilege + " ON " + objectTable + " FROM " + user;
                string grantQuery = "GRANT " + newPrivilege + " ON " + objectTable + " TO " + user;


                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                //Thu hồi quyền
                cmd.CommandText = revokeQuery;
                cmd.ExecuteNonQuery();

                //Gán quyền
                OracleCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = grantQuery;
                cmd2.ExecuteNonQuery();

                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }

            loadPrivilegesOfUser(textBox1.Text);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);

            DialogResult dialogResult;
            string roleName = textBox3.Text;

            if (roleName == "")
            {
                dialogResult = MessageBox.Show("Bạn muốn thu hồi quyền này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else
            {
                dialogResult = MessageBox.Show("Bạn muốn thu hồi role trên user này", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }

            if (dialogResult == DialogResult.No)
            {
                return;
            }


            try
            {
                conn.Open();

                string revokeQuery;
                string user;
                string privilege;
                user = textBox1.Text;
                if (textBox3.Text == "")
                {
                    privilege = comboBox1.Text;
                    string objectTable = textBox2.Text;
                    revokeQuery = "REVOKE " + privilege + " ON " + objectTable + " FROM " + user;
                }
                else
                {
                    privilege = textBox3.Text;
                    revokeQuery = "REVOKE " + privilege + " FROM " + user;
                }


                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = revokeQuery;


                cmd.ExecuteNonQuery();

                MessageBox.Show("Thu hồi quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            loadPrivilegesOfUser(textBox1.Text);
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            dataGridViewUser.DataSource = null;
            OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();
                string sqlString = "";
                sqlString = "SELECT USERNAME, USER_ID, CREATED, DEFAULT_COLLATION FROM ALL_USERS";
                OracleCommand command = new OracleCommand(sqlString, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                dataGridViewUser.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void btnViewTable_Click(object sender, EventArgs e)
        {
            dataGridViewUser.DataSource = null;
            OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();
                string sqlString = "";
                sqlString = "SELECT TABLE_NAME, OWNER, TABLESPACE_NAME, CLUSTER_NAME FROM ALL_TABLES WHERE OWNER = '" + Login_Info.USERNAME + "'";
                OracleCommand command = new OracleCommand(sqlString, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                dataGridViewUser.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void btnViewRole_Click(object sender, EventArgs e)
        {
            dataGridViewUser.DataSource = null;
            OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();
                string sqlString = "";
                sqlString = "SELECT GRANTEE, GRANTED_ROLE FROM DBA_ROLE_PRIVS WHERE GRANTED_ROLE = '" + Login_Info.USERNAME + "'";
                OracleCommand command = new OracleCommand(sqlString, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                dataGridViewUser.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dataGridViewUser.DataSource = null;
            OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();
                string sqlString = "";
                sqlString = "SELECT VIEW_NAME, OWNER, TEXT_LENGTH FROM all_Views WHERE OWNER = '" + Login_Info.USERNAME + "'";
                OracleCommand command = new OracleCommand(sqlString, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                dataGridViewUser.DataSource = dataTable;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThemBang tb = new ThemBang();
            tb.Show();
        }
    }
}
