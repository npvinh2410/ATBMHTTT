using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBMHTTT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void viewPrivilegesBtn_Click(object sender, EventArgs e)
        {
            string roleName = roleNameTextBox.Text;
            string userName = userNameTextBox.Text;
            if(roleName != "" && userName != ""){
                MessageBox.Show("Chỉ nhập duy nhất user hoặc role", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
