using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBMHTTT.PhanHe2
{
    public partial class TC4_HSBA_DV : Form
    {
        public TC4_HSBA_DV(String maHSBA)
        {
            InitializeComponent();
            loadData(maHSBA);
        }

        private void loadData(String maHSBA)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();
                string query = "select * from DBA_ATBM.hsba_dv_bs where MAHSBA='" + maHSBA + "'";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                GridHSBA_DV.DataSource = dataTable;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

    }
}
