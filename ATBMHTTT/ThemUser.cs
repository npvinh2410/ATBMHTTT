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
    public partial class ThemUser : Form
    {
        public ThemUser()
        {
            InitializeComponent();
        }

        string create_user = "create user ";

        private void Them_Click(object sender, EventArgs e)
        {
            

            create_user += tbuser.Text + " identified by " + tbpass.Text + ";";

            OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = create_user;


                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            DialogResult rs = MessageBox.Show(create_user, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

            if (rs == DialogResult.OK)
                this.Close();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
