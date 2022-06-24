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
    public partial class TC3_QL_HSBA_DV : Form
    {
        private String maHSBA_global;
        public TC3_QL_HSBA_DV(String maHSBA)
        {
            InitializeComponent();
            this.maHSBA_global = maHSBA;
            HSBAlabel.Text = maHSBA;
            getThongtinHSBA_DV(maHSBA);
        }

        private void getThongtinHSBA_DV(String maHSBA)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from DBA_ATBM.hsba_dv where MAHSBA='" + maHSBA + "'";

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
        private void TC3_QL_HSBA_DV_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String maDV = this.maDV.Text;
            String ketqua = this.ketqua.Text;
            String ngay = this.ngay.Value.Date.ToString("dd/MM/yyy");


            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                string query = "insert into DBA_ATBM.HSBA_DV(MAHSBA, MADV, NGAY, MAKTV, KETQUA) values(:MAHSBA, :MADV, to_date(:NGAY, 'dd/mm/yyyy'), user, :KETQUA)";

                OracleCommand command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("MAHSBA", maHSBA_global));
                command.Parameters.Add(new OracleParameter("MADV", maDV));
                command.Parameters.Add(new OracleParameter("NGAY", ngay));
                command.Parameters.Add(new OracleParameter("KETQUA", ketqua));

                command.Connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Thêm thành công");
                getThongtinHSBA_DV(maHSBA_global);
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String maHSBA = GridHSBA_DV.SelectedRows[0].Cells[0].Value.ToString();
            String maDV = GridHSBA_DV.SelectedRows[0].Cells[1].Value.ToString();
            String ngay = DateTime.Parse(GridHSBA_DV.SelectedRows[0].Cells[2].Value.ToString()).ToString("dd/MM/yyyy") ;

            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                string query = "delete from DBA_ATBM.HSBA_DV"
                                + " where MAHSBA = :MAHSBA and MADV = :MADV and NGAY = to_date(:NGAY, 'dd/mm/yyyy')";

                OracleCommand command = new OracleCommand(query, conn);
                command.Parameters.Add(new OracleParameter("MAHSBA", maHSBA_global));
                command.Parameters.Add(new OracleParameter("MADV", maDV));
                command.Parameters.Add(new OracleParameter("NGAY", ngay));

                command.Connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Xóa thành công");
                getThongtinHSBA_DV(maHSBA_global);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
