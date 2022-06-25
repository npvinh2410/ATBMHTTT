using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBMHTTT.PhanHe2
{
    public partial class TC1_HOME : Form
    {
        public TC1_HOME()
        {
            InitializeComponent();
        }

        private void btnQLcsyt_Click(object sender, EventArgs e)
        {
            TC1_CSYT f = new TC1_CSYT();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnQNbn_Click(object sender, EventArgs e)
        {
            TC1_NHAN_VIEN f = new TC1_NHAN_VIEN();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnQLbn_Click(object sender, EventArgs e)
        {
            TC1_BENH_NHAN f = new TC1_BENH_NHAN();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
