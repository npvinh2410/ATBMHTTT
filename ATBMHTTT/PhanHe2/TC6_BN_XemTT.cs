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

                string query = "select MABN, MACSYT, TENBN, CMND, TO_CHAR(NGAYSINH, 'dd/mm/yyyy') NGSINH, SONHA, TENDUONG, QUANHUYEN, TINHTP, TIENSUBENH, TIENSUBENHGD, DIUNGTHUOC from DBA_ATBM.BENHNHANENCRYPT_VIEW WHERE MABN = '" + maBN + "'";
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
                        
                        string query = "DBA_ATBM.CapNhatBenhNhan";

                        OracleCommand command = new OracleCommand(query, conn);
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.Add("MABN1", OracleDbType.Char).Value = t1.Text.Trim();
                        command.Parameters.Add("MACSYT1", OracleDbType.Char).Value = t3.Text;
                        command.Parameters.Add("TENBN1", OracleDbType.Varchar2).Value = t2.Text;
                        command.Parameters.Add("CMND1", OracleDbType.Varchar2).Value = t5.Text;
                        command.Parameters.Add("NGAYSINH1", OracleDbType.Date).Value = DateTime.Parse(t4.Text);
                        command.Parameters.Add("SONHA1", OracleDbType.Char).Value = t6.Text;
                        command.Parameters.Add("TENDUONG1", OracleDbType.Char).Value = t7.Text;
                        command.Parameters.Add("QUANHUYEN1", OracleDbType.Varchar2).Value = t8.Text;
                        command.Parameters.Add("TINHTP1", OracleDbType.Varchar2).Value = t9.Text;
                        command.Parameters.Add("TIENSUBENH1", OracleDbType.Varchar2).Value = t10.Text;
                        command.Parameters.Add("TIENSUBENHGD1", OracleDbType.Varchar2).Value = t11.Text;
                        command.Parameters.Add("DIUNGTHUOC1", OracleDbType.Varchar2).Value = t12.Text;

                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Bạn đã cập nhật thành công");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi");
                    }
                    finally
                    {
                        conn.Close();
                    }
                    
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
    }
}
