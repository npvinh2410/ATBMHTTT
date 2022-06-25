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
    public partial class TC1_CSYT : Form
    {
        public TC1_CSYT()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from DBA_ATBM.csyt";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                GridCSYT.DataSource = dataTable;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void GridCSYT_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            maCSYT.Text = GridCSYT.SelectedRows[0].Cells[0].Value.ToString();
            ten.Text = GridCSYT.SelectedRows[0].Cells[1].Value.ToString();
            diachi.Text = GridCSYT.SelectedRows[0].Cells[2].Value.ToString();
            sdt.Text = GridCSYT.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            TC1_CSYT_THEM f = new TC1_CSYT_THEM();
            f.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String maCSYT = this.maCSYT.Text;
            String ten = this.ten.Text;
            String diachi = this.diachi.Text;
            String sdt = this.sdt.Text;
            


            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                string query = "update DBA_ATBM.csyt"
                            +" set TENCSYT = :TEN, DCCSYT = :DC, SDTCSYT = :SDT" 
                            +" where MACSYT = :MA ";

                OracleCommand command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("TEN", ten));
                command.Parameters.Add(new OracleParameter("DCCSYT", diachi));
                command.Parameters.Add(new OracleParameter("SDTCSYT", sdt));
                command.Parameters.Add(new OracleParameter("MACSYT", maCSYT));

                command.Connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
