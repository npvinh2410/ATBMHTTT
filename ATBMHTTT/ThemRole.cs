using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using ATBMHTTT.Connection;

namespace ATBMHTTT
{
    public partial class ThemRole : Form
    {
        public ThemRole()
        {
            InitializeComponent();
        }

        string create_role = "create role ";

        private void Them_Click(object sender, EventArgs e)
        {
            create_role += tbrole.Text;

            OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                OracleCommand cmd2 = conn.CreateCommand();
                cmd2.CommandType = CommandType.Text;
                cmd2.CommandText = "alter session set \"_ORACLE_SCRIPT\"=true";
                cmd2.ExecuteNonQuery();

                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = create_role;
                cmd.ExecuteNonQuery();
                DialogResult rs = MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (rs == DialogResult.OK)
                    this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            finally
            {
                conn.Close();
            }

           

            
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
