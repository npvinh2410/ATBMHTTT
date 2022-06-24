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
    public partial class TC3_QL_HSBA : Form
    {

        private String maCSYT_Global;
        public TC3_QL_HSBA()
        {
            InitializeComponent();
            loadCSYT();
        }

        private void loadCSYT()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection("DBA_ATBM", "1212");
            try
            {
                conn.Open();

                string query = "select cs.MACSYT, cs.TENCSYT from csyt cs inner join nhan_vien nv on nv.csyt = cs.macsyt where nv.manv = '" + Login_Info.USERNAME + "'";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                csytLabel.Text = dataTable.Rows[0]["TENCSYT"].ToString();
                maCSYT_Global = dataTable.Rows[0]["MACSYT"].ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void xemBtn_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from DBA_ATBM.HSBA";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                GridHSBA.DataSource = dataTable;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String maHSBA = this.maHSBA.Text;
            String maBN = this.maBN.Text;
            String ngay = this.ngay.Value.Date.ToString("dd/MM/yyy");
            String chuanDoan = this.chuanDoan.Text;
            String maBs = this.maBs.Text;
            String maKhoa = this.maKhoa.Text;
            String maCSYT = maCSYT_Global;
            String ketLuan = this.ketLuan.Text;

            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                string query = "insert into DBA_ATBM.HSBA(MAHSBA, MABN, NGAY, CHANDOAN, MABS, MAKHOA, MACSYT, KETLUAN) values(:MAHSBA, :MABN, to_date(:NGAY, 'dd/mm/yyyy'), :CHANDOAN, :MABS, :MAKHOA, :MACSYT, :KETLUAN)";

                OracleCommand command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("MAHSBA", maHSBA));
                command.Parameters.Add(new OracleParameter("MABN", maBN));
                command.Parameters.Add(new OracleParameter("NGAY", ngay));
                command.Parameters.Add(new OracleParameter("CHANDOAN", chuanDoan));
                command.Parameters.Add(new OracleParameter("MABS", maBs));
                command.Parameters.Add(new OracleParameter("MAKHOA", maKhoa));
                command.Parameters.Add(new OracleParameter("MACSYT", maCSYT));
                command.Parameters.Add(new OracleParameter("KETLUAN", ketLuan));

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

        private void button4_Click(object sender, EventArgs e)
        {
            String maHSBA = GridHSBA.SelectedRows[0].Cells[0].Value.ToString();
            TC3_QL_HSBA_DV f = new TC3_QL_HSBA_DV(maHSBA);
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String maHSBA = GridHSBA.SelectedRows[0].Cells[0].Value.ToString();

            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            OracleTransaction transaction = null;
            try
            {
                conn.Open();
                transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);

                string query = "delete from DBA_ATBM.HSBA_DV"
                                + " where MAHSBA = :MAHSBA";

                OracleCommand command = conn.CreateCommand();

                command.Transaction = transaction;
                command.CommandText = query;
                command.Parameters.Add(new OracleParameter("MAHSBA", maHSBA));
                command.ExecuteNonQuery();

                command.CommandText = "delete from DBA_ATBM.HSBA where MAHSBA = :MAHSBA";
                command.ExecuteNonQuery();

                transaction.Commit();

                MessageBox.Show("Xóa thành công");
                
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                MessageBox.Show("Xóa thất bại");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
