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

                string query = "select * from DBA_ATBM.NV_NC WHERE MABS = '" + Login_Info.USERNAME.ToUpper() + "'";

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

        public static DataTable Xem_TT_NV(string maNV)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                string query = "select MANV, HOTEN, PHAI, TO_CHAR(NGAYSINH, 'dd/mm/yyyy') NGSINH, CMND, QUEQUAN, SODT,CSYT, VAITRO, CHUYENKHOA from DBA_ATBM.NHAN_VIEN WHERE MANV = '" + Login_Info.USERNAME.ToUpper() + "'";

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

        private void XemTT_Click(object sender, EventArgs e)
        {
            DataTable dt = Xem_TT_NV(Login_Info.USERNAME);
            DataRow row = dt.Rows[0];
            string ma = row["MANV"].ToString();
            string ten = row["HOTEN"].ToString();
            string phai = row["PHAI"].ToString();
            string ngaysinh = row["NGSINH"].ToString();
            string cmnd = row["CMND"].ToString();
            string que = row["QUEQUAN"].ToString();
            string sdt = row["SODT"].ToString();
            string csyt = row["CSYT"].ToString();
            string vaitro = row["VAITRO"].ToString();
            string chuyenkhoa = row["CHUYENKHOA"].ToString();

            ThongTinNV tt = new ThongTinNV(ma, ten, phai, ngaysinh, que, sdt, cmnd, csyt, vaitro, chuyenkhoa);
            tt.Show();
        }
    }
}
