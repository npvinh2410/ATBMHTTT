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
    public partial class TC1_NHANVIEN_THEM : Form
    {
        public TC1_NHANVIEN_THEM()
        {
            InitializeComponent();
            loadCSYT();
        }

        private void loadCSYT()
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                string query = "select MACSYT from DBA_ATBM.csyt order by MACSYT ASC";

                OracleCommand command = new OracleCommand(query, conn);
                DataTable dataTable = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dataTable);

                foreach(DataRow row in dataTable.Rows)
                {
                    comboBoxCSYT.Items.Add(row[0].ToString());
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String ma = this.ma.Text;
            String ten = this.ten.Text;
            String phai = this.phai.Text;
            DateTime ngaysinh =this.ngay.Value;
            String cmnd = this.cmnd.Text;
            String quequan = this.quequan.Text;
            String sdt = this.sdt.Text;
            String csyt = this.comboBoxCSYT.Text;
            String vaitro = this.comboBoxVaitro.Text;
            String chuyenkhoa = this.comboBoxChuyenKhoa.Text;


            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                string query = "DBA_ATBM.themnhanvien";

                OracleCommand command = new OracleCommand(query, conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("MANV", OracleDbType.Char).Value = ma;
                command.Parameters.Add("HOTEN", OracleDbType.Varchar2).Value = ten;
                command.Parameters.Add("PHAI", OracleDbType.Varchar2).Value = phai;
                command.Parameters.Add("NGAYSINH", OracleDbType.Date).Value = ngaysinh;
                command.Parameters.Add("CMND", OracleDbType.Char).Value = cmnd;
                command.Parameters.Add("QUEQUAN", OracleDbType.Varchar2).Value = quequan;
                command.Parameters.Add("SODT", OracleDbType.Varchar2).Value = sdt;
                command.Parameters.Add("CSYT", OracleDbType.Char).Value = csyt;
                command.Parameters.Add("VAITRO", OracleDbType.Varchar2).Value = vaitro;
                command.Parameters.Add("CHUYENKHOA", OracleDbType.Varchar2).Value = chuyenkhoa;

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
