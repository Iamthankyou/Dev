using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_IPOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string userName = "admin", password = "admin";
            if (tbUserName.Text != "" && tbPassword.Text != "")
            {
                if (userName != tbUserName.Text || password != tbPassword.Text)
                {
                    MessageBox.Show("Sai User Name hoặc Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    NewCa newCa = new NewCa();
                    this.Hide();
                    newCa.ShowDialog();
                    if(newCa.Visible == false) 
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập User hoặc Password!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btThoatDangNhap_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
