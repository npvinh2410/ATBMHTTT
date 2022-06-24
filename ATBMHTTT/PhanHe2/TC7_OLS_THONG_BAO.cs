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
    public partial class TC7_OLS_THONG_BAO : Form
    {
        public TC7_OLS_THONG_BAO()
        {
            InitializeComponent();
        }

        private void xemBtn_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection_OLS(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                string query = "select NOIDUNG, NGAYGIO, DIADIEM from OLS_DATA.THONG_BAO";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                foreach(DataRow row in dataTable.Rows)
                {
                    GridThongBao.Rows.Add(row["NOIDUNG"].ToString(), row["NGAYGIO"].ToString(), row["DIADIEM"].ToString());
                }
                
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                conn.Close();
            }
        }

        private void TC7_OLS_THONG_BAO_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
