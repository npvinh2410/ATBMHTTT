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
    public partial class ThongTinNV : Form
    {
        public ThongTinNV(string ma, string ten, string phai, string ngaysinh, string que, string sdt, string cmnd, string csyt, string vaitro, string chuyenkhoa)
        {
            InitializeComponent();

            t1.Text = ma;
            t2.Text = ten;
            t3.Text = phai;
            t4.Text = ngaysinh;
            t5.Text = cmnd;
            t6.Text = que;
            t7.Text = sdt;
            t8.Text = csyt;
            t9.Text = vaitro;
            t10.Text = chuyenkhoa;
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
                        string phai = t3.Text;
                        string ngaysinh = t4.Text;
                        string cmnd = t5.Text;
                        string que = t6.Text;
                        string sdt = t7.Text;

                        string query = "update DBA_ATBM.NHAN_VIEN set HOTEN = '" + ten + "', PHAI = '" + phai + "', NGAYSINH = to_date('" + ngaysinh + "', 'dd/mm/yyyy'), CMND = '" + cmnd + "', QUEQUAN = '" + que + "', SODT = '" + sdt + "' where MANV = '" + Login_Info.USERNAME.ToUpper() + "'"; 
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
