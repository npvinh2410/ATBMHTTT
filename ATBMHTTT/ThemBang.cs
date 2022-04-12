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
using ATBMHTTT.Connection;

namespace ATBMHTTT
{
    public partial class ThemBang : Form
    {
        public ThemBang()
        {
            InitializeComponent();
        }

        int i = 0;
        string createtable;
        string pk = "PRIMARY KEY(";

        private void ThemCot_Click(object sender, EventArgs e)
        {
            CheckBox cb = new CheckBox();
            cb.CheckAlign = ContentAlignment.MiddleCenter;

            createtable += "\t" + tbCol.Text + " " + tbType.Text + ",\n";
            if (cbpk.Checked)
            {
                i++;
                pk += (i > 1 ? ", " : " ") + tbCol.Text;
                cb.Checked = true;
            }

            TextBox t1 = new TextBox();
            TextBox t2 = new TextBox();
            t1.Text = tbCol.Text;
            t2.Text = tbType.Text;

            flp1.Controls.Add(t1);
            flp2.Controls.Add(t2);
            flp3.Controls.Add(cb);

            tbCol.Clear();
            tbType.Clear();
            cbpk.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pk += ")";
            createtable = "create table " + tbTenBang.Text +
                            "\n( " +
                            "\n" + createtable + "\t" + pk + "\n)";

            OracleConnection conn = DBConnection.GetDBConnection(Login_Info.USERNAME, Login_Info.PASSWORD);
            try
            {
                conn.Open();

                OracleCommand command = new OracleCommand(createtable, conn);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            conn.Close();

            

            DialogResult rs = MessageBox.Show("Bạn đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

            if (rs == DialogResult.OK)
                this.Close();
        }

        private void Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
