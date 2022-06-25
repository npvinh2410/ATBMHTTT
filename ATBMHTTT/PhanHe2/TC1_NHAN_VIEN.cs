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
    public partial class TC1_NHAN_VIEN : Form
    {
        public TC1_NHAN_VIEN()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                string query = "select * from DBA_ATBM.nhan_vien";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                GridNhanVien.DataSource = dataTable;
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            TC1_NHANVIEN_THEM f = new TC1_NHANVIEN_THEM();
            f.ShowDialog();
        }

        private void btnNVall_Click(object sender, EventArgs e)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                string query = "DBA_ATBM.USP_CREATEUSER_NV";

                OracleCommand command = new OracleCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Tạo tài khoản nhân viên thành công");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
