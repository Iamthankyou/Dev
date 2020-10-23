using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_IPOS
{
    public partial class Home : Form
    {
        Login homeLogin;
        public Home(Login a)
        {
            InitializeComponent();
            homeLogin = a;
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnTakeAway_Click_1(object sender, EventArgs e)
        {
            OrderTakeAway orderTakeAway = new OrderTakeAway();
            orderTakeAway.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
