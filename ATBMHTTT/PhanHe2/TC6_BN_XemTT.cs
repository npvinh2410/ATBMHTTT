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
    public partial class TC6_BN_XemTT : Form
    {
        public TC6_BN_XemTT(string maBN, string csyt, string ten, string cmnd, string ngaysinh, string sonha, string tenduong, string quanhuyen, string tinhtp, string tiensubenh, string tiensubenhgd, string diung)
        {
            InitializeComponent();

            t1.Text = maBN;
            t2.Text = ten;
            t3.Text = csyt;
            t4.Text = ngaysinh;
            t5.Text = cmnd;
            t6.Text = sonha;
            t7.Text = tenduong;
            t8.Text = quanhuyen;
            t9.Text = tinhtp;
            t10.Text = tiensubenh;
            t11.Text = tiensubenhgd;
            t12.Text = diung;
        }

        public static bool LayTTBN(string maBN)
        {
            OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                string query = "select MABN, MACSYT, TENBN, CMND, TO_CHAR(NGAYSINH, 'dd/mm/yyyy') NGSINH, SONHA, TENDUONG, QUANHUYEN, TINHTP, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC from DBA_ATBM.BENHNHAN WHERE MABN = '" + maBN + "'";
                OracleCommand command = new OracleCommand(query, conn);
                DataTable dt = new DataTable();
                OracleDataAdapter adapter = new OracleDataAdapter(command);
                adapter.Fill(dt);


                DataRow row = dt.Rows[0];
                string ma = row["MABN"].ToString();
                string csyt = row["MACSYT"].ToString();
                string ten = row["TENBN"].ToString();
                string sonha = row["SONHA"].ToString();
                string ngaysinh = row["NGSINH"].ToString();
                string cmnd = row["CMND"].ToString();
                string tenduong = row["TENDUONG"].ToString();
                string quanhuyen = row["QUANHUYEN"].ToString();
                string tinhtp = row["TINHTP"].ToString();
                string tiensubenh = row["TIENSUBENH"].ToString();
                string tiensubenhgd = row["TIENSUBENHGD"].ToString();
                string diung = row["DIUNGTHUOC"].ToString();

                TC6_BN_XemTT t6 = new TC6_BN_XemTT(ma, csyt, ten, cmnd, ngaysinh, sonha, tenduong, quanhuyen, tinhtp, tiensubenh, tiensubenhgd, diung);
                t6.Show();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                conn.Close();
            }

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn cập nhật thông tin?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (rs)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    OracleConnection conn = Connection.DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
                    try
                    {
                        conn.Open();

                        string ten = t2.Text;
                        string ngaysinh = t4.Text;
                        string cmnd = t5.Text;
                        string sonha = t6.Text;
                        string tenduong = t7.Text;
                        string quanhuyen = t8.Text;
                        string tinhtp = t9.Text;
                        string tiensubenh = t10.Text;
                        string tiensubenhgd = t11.Text;
                        string diung = t12.Text;

                        string query = "update DBA_ATBM.BENHNHAN set TENBN = '" + ten + "', SONHA = '" + sonha + "', NGAYSINH = to_date('" + ngaysinh + "', 'dd/mm/yyyy'), CMND = '" + cmnd + "', QUANHUYEN = '" + quanhuyen + "', TINHTP = '" + tinhtp + "', TIENSUBENH = '" + tiensubenh + "', TIENSUBENHGD = '" + tiensubenhgd + "', DIUNGTHUOC = '" + diung + "' where MABN = '" + Login_Info.USERNAME.ToUpper() + "'";
                        OracleCommand command = conn.CreateCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = query;
                        command.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        return;
                    }
                    finally
                    {

                        conn.Close();
                    }
                    MessageBox.Show("Bạn đã cập nhật thành công");
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
    }
}
