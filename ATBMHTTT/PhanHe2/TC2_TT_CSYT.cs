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
    public partial class TC2_TT_CSYT : Form
    {
        public TC2_TT_CSYT()
        {
            InitializeComponent();
        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                string query;
                String chon = (CbbChonViewXem.SelectedItem as dynamic).ToString();
                if (chon == "Hồ sơ bệnh án")
                {
                    query = "select * from DBA_ATBM.HSBA";
                }
                else if (chon == "Hồ sơ bệnh án dịch vụ")
                {
                    query = "select * from DBA_ATBM.HSBA_DV";
                }
                else if (chon == "Bệnh nhân")
                {
                    query = "select * from DBA_ATBM.BenhNhanEncrypt_view";
                }
                else if (chon == "Cơ sở y tế")
                {
                    query = "select * from DBA_ATBM.CSYT";
                }
                else
                {
                    query = "select * from DBA_ATBM.NHAN_VIEN";
                }

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
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
    }
}
