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
    public partial class TC5_NV_NC_Xem_HSBA : Form
    {
        public TC5_NV_NC_Xem_HSBA()
        {
            InitializeComponent();
        }

        public static DataTable Xem_HSBA(string maNV)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from DBA_ATBM.hsba";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);


                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        private void XemHSBA_Click(object sender, EventArgs e)
        {
            DataTable dt = Xem_HSBA(Login_Info.USERNAME);
            dgv_hsba.DataSource = dt;
        }

        private void XemTT_Click(object sender, EventArgs e)
        {
            ThongTinNV tt = new ThongTinNV();
            tt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String maHSBA = dgv_hsba.SelectedRows[0].Cells[0].Value.ToString();

            TC5_NC_Xem_HSBADV f = new TC5_NC_Xem_HSBADV(maHSBA);
            f.ShowDialog();
        }
    }
}
