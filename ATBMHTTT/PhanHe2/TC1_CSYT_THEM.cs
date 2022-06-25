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

namespace ATBMHTTT.PhanHe2
{
    public partial class TC1_CSYT_THEM : Form
    {
        public TC1_CSYT_THEM()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String maCSYT = this.maCSYT.Text;
            String ten = this.ten.Text;
            String diachi = this.diachi.Text;
            String sdt = this.sdt.Text;



            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                string query = "insert into DBA_ATBM.csyt(MACSYT, TENCSYT, DCCSYT, SDTCSYT) values(:MACSYT, :TENCSYT, :DCCSYT, :SDTCSYT)";


                OracleCommand command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("MACSYT", maCSYT));
                command.Parameters.Add(new OracleParameter("TENCSYT", ten));
                command.Parameters.Add(new OracleParameter("DCCSYT", diachi));
                command.Parameters.Add(new OracleParameter("SDTCSYT", sdt));

                command.Connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
