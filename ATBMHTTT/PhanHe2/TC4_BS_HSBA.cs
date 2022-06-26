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
    public partial class TC4_BS_HSBA : Form
    {
        public TC4_BS_HSBA()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
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

                dataGridViewHSBA.DataSource = dataTable;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTimKiemBN_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();
                string searchInfo = txtMaBN.Text.ToUpper();
                string query;
                if (searchInfo.Contains("BN"))
                {
                    query = "select * from DBA_ATBM.BENHNHANENCRYPT_VIEW WHERE MABN = '" + searchInfo + "' ";
                }
                else if (searchInfo == "")
                {
                    query = "select * from DBA_ATBM.BENHNHANENCRYPT_VIEW";
                }
                else
                {
                    query = "select * from DBA_ATBM.BENHNHANENCRYPT_VIEW WHERE CMND LIKE '%" + searchInfo + "%'";
                }
                

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                dataGridViewBN.DataSource = dataTable;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void XemTT_Click(object sender, EventArgs e)
        {
            ThongTinNV tt = new ThongTinNV();
            tt.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String maHSBA = dataGridViewHSBA.SelectedRows[0].Cells[0].Value.ToString();

            TC4_HSBA_DV f = new TC4_HSBA_DV(maHSBA);
            f.ShowDialog();
        }
    }
}
