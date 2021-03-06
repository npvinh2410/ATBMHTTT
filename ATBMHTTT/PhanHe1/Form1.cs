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
            if(cbbuser_table.Text=="")
            {
                cbbuser_collum.Text = "none";
                cbbuser_collum.Enabled = false;
            }
            if (cbbrole_table.Text == "")
            {
                cbbrole_collum.Text = "none";
                cbbrole_collum.Enabled = false;
            }

            //
            //loadData();
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

                sqlString += "SELECT GRANTEE AS \"USER/GRANTED ROLE\", TABLE_NAME, GRANTOR, PRIVILEGE, TYPE FROM DBA_TAB_PRIVS" +
                                    " WHERE GRANTEE = '" + userNameOrRole + "'" +
                                    " OR GRANTEE IN(SELECT granted_role FROM DBA_ROLE_PRIVS" +
                                    " WHERE GRANTEE = '" + userNameOrRole + "') ORDER BY GRANTEE";
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

            string roleText = privilegesGridView["USER/GRANTED ROLE", e.RowIndex].Value.ToString();
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

                textBox3.Text = textBox2.Text = comboBox1.Text = "";
                comboBox1.Items.Clear();

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
                sqlString = "SELECT TABLE_NAME, OWNER, TABLESPACE_NAME, CLUSTER_NAME FROM ALL_TABLES WHERE OWNER = '" + Login_Info.USERNAME.ToUpper() + "'";
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
                //sqlString = "SELECT GRANTEE, OWNER, TABLE_NAME, GRANTOR, PRIVILEGE FROM DBA_TAB_PRIVS WHERE OWNER = '" + Login_Info.USERNAME.ToUpper() + "'";
                sqlString = "SELECT GRANTED_ROLE, ADMIN_OPTION, DELEGATE_OPTION, DEFAULT_ROLE, COMMON FROM USER_ROLE_PRIVS WHERE USERNAME= '" + Login_Info.USERNAME.ToUpper() + "' AND GRANTED_ROLE != 'DBA' AND GRANTED_ROLE != 'CONNECT' AND GRANTED_ROLE != 'RESOURCE'";
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
                sqlString = "SELECT VIEW_NAME, OWNER, TEXT_LENGTH FROM all_Views WHERE OWNER = '" + Login_Info.USERNAME.ToUpper() + "'";
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

        private void btuser_capquyen_Click(object sender, EventArgs e)
        {
            
            if (cbbuser_permission.Text == "" || cbbuser_table.Text == "" || cbbuser_user.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Bạn có đồng ý cấp quyền này cho user không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.No)
                    return;

                try
                {
                    conn.Open();
                    string grantQuery;
                    string grantQuery1;
                    string name_user = cbbuser_user.Text;
                    string table = cbbuser_table.Text;
                    string collumn = cbbuser_collum.Text;
                    string permission = cbbuser_permission.Text;
                    bool check = ckbgrant.CheckState == CheckState.Checked ? true : false;
                    string grantOption = "";
                    if (check == true)
                    {
                        grantOption = " WITH GRANT OPTION";
                    }

                    if(cbbuser_permission.Text=="UPDATE")
                    {
                        if(collumn == "")
                        {
                            grantQuery = "GRANT " + permission + " ON " + table + " TO " + name_user + grantOption;
                        }
                        else
                        {
                            grantQuery = "GRANT " + permission + "(" + collumn + ") ON " + table + " TO " + name_user + grantOption;
                        }
                    }
                    else if (cbbuser_permission.Text =="SELECT")
                    {
                        if(collumn != "")
                        {
                            grantQuery1 = "CREATE OR REPLACE VIEW " + name_user + "_" + table + "_" + collumn + " AS SELECT " + collumn + " FROM " + table;
                            grantQuery = "GRANT " + permission + " ON " + name_user + "_" + table + "_" + collumn + " TO " + name_user + grantOption;
                        }
                        else
                        {
                            grantQuery1 = "CREATE OR REPLACE VIEW " + name_user + "_" + table + " AS SELECT * FROM " + table;
                            grantQuery = "GRANT " + permission + " ON " + name_user + "_" + table + " TO " + name_user + grantOption;
                        }
                        
                        OracleCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = grantQuery1;


                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Tạo view cho việc phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        
                    }
                    else
                    {
                        grantQuery = "GRANT " + permission + " ON " + table + " TO " + name_user + grantOption;
                    }
                    
                    

                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = grantQuery; 


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cấp quyền cho user thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btrole_capquyen_Click(object sender, EventArgs e)
        {
            
            if ( cbbrole_permission.Text == "" || cbbrole_table.Text == "" || roleNamePrivilege.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Bạn có đồng ý cấp quyền này cho role không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.No)
                    return;
                try
                {
                    conn.Open();
                    string grantQuery;
                    string grantQuery1;
                    string name_role = roleNamePrivilege.Text;
                    string table = cbbrole_table.Text;
                    string collumn = cbbrole_collum.Text;
                    string permission = cbbrole_permission.Text;
                    if (cbbrole_permission.Text == "UPDATE")
                    {
                        if (collumn == "")
                        {
                            grantQuery = "GRANT " + permission + " ON " + table + " TO " + name_role ;
                        }
                        else
                        {
                            grantQuery = "GRANT " + permission + "(" + collumn + ") ON " + table + " TO " + name_role;
                        }
                    }
                    else if(cbbrole_permission.Text=="SELECT")
                    {
                        if (collumn != "")
                        {
                            grantQuery1 = "CREATE OR REPLACE VIEW " + name_role + "_" + table + "_" + collumn + " AS SELECT " + collumn + " FROM " + table;
                            grantQuery = "GRANT " + permission + " ON " + name_role + "_" + table + "_" + collumn + " TO " + name_role;
                        }
                        else
                        {
                            grantQuery1 = "CREATE OR REPLACE VIEW " + name_role + "_" + table + " AS SELECT * FROM " + table;
                            grantQuery = "GRANT " + permission + " ON " + name_role + "_" + table + " TO " + name_role;
                        }
                        
                        OracleCommand cmd1 = conn.CreateCommand();
                        cmd1.CommandType = CommandType.Text;
                        cmd1.CommandText = grantQuery1;


                        cmd1.ExecuteNonQuery();

                        MessageBox.Show("Tạo view cho việc phân quyền thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                       
                    }    
                    else
                    {
                        grantQuery = "GRANT " + permission + " ON " + table + " TO " + name_role;
                    }

                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = grantQuery;


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cấp quyền cho role thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        }

        private void bt_capquyen_Click(object sender, EventArgs e)
        {
            if (cbbuser.Text == "" || cbbrole.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
                DialogResult dialogResult;
                dialogResult = MessageBox.Show("Bạn có đồng ý cấp role này cho user không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.No)
                    return;
                try
                {
                    conn.Open();
                    string grantQuery;
                    string name_role = cbbrole.Text;
                    string name_user = cbbuser.Text;
                    grantQuery = "GRANT " + name_role +" TO " + name_user;

                    OracleCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = grantQuery;


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cấp role cho user thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        }

        private void cbbuser_permission_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                if (cbbuser_permission.Text == "DELETE" || cbbuser_permission.Text == "INSERT"||cbbuser_table.Text=="")
                {
                    cbbuser_collum.Text = "none";
                    cbbuser_collum.Enabled = false;
                }
                else
                {
                    cbbuser_collum.Enabled = true;
                    cbbuser_collum.Text = null;
                }
            }
        }

        private void cbbrole_permission_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                if (cbbrole_permission.Text == "DELETE" || cbbrole_permission.Text == "INSERT"||cbbrole_table.Text=="")
                {
                    cbbrole_collum.Text = "none";
                    cbbrole_collum.Enabled = false;
                }
                else
                {
                    cbbrole_collum.Enabled = true;
                    cbbrole_collum.Text = null;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT TABLE_NAME FROM ALL_TABLES WHERE OWNER = '" + Login_Info.USERNAME.ToUpper() + "'";
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    cbbrole_table.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                    cbbuser_table.Items.Add(ds.Tables[0].Rows[i][0].ToString());                    
                }
                cbbuser_collum.Text = "";
                cmd.CommandText = "SELECT USERNAME FROM ALL_USERS";
                OracleDataAdapter da1 = new OracleDataAdapter(cmd);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                for (int i = 0; i < ds1.Tables[0].Rows.Count; i++)
                {
                    cbbuser_user.Items.Add(ds1.Tables[0].Rows[i][0].ToString());
                    cbbuser.Items.Add(ds1.Tables[0].Rows[i][0].ToString());
                }


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

        private void cbbuser_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                if (cbbuser_table.Text != ""&& cbbuser_permission.Text != "DELETE" && cbbuser_permission.Text != "INSERT"&& cbbuser_permission.Text !="")
                {
                    cbbuser_collum.Enabled = true;
                    cbbuser_collum.Text=null;
                    OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
                    try
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT COLUMN_NAME FROM USER_TAB_COLUMNS WHERE TABLE_NAME= '" + cbbuser_table.Text +"'";
                        OracleDataAdapter da = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        cbbuser_collum.Items.Clear();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            cbbuser_collum.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                        }


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
            }

        }

        private void cbbuser_collum_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void cbbrole_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem != null)
            {
                if (cbbrole_table.Text != ""&& cbbrole_permission.Text != "DELETE" && cbbrole_permission.Text != "INSERT"&& cbbrole_permission.Text !="")
                {
                    cbbrole_collum.Enabled = true;
                    cbbrole_collum.Text = null;
                    OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
                    try
                    {
                        conn.Open();
                        OracleCommand cmd = new OracleCommand();
                        cmd.Connection = conn;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "SELECT COLUMN_NAME FROM USER_TAB_COLUMNS WHERE TABLE_NAME= '" + cbbrole_table.Text + "'";
                        OracleDataAdapter da = new OracleDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        da.Fill(ds);
                        cbbrole_collum.Items.Clear();
                        for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                        {
                            cbbrole_collum.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                        }                       
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
            }
        }
    }
}
