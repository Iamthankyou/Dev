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

        private void tbUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Enter) tbPassword.Focus();
        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) btnDangNhap.Focus();
            else if (e.KeyCode == Keys.Up) tbUserName.Focus();
            else if (e.KeyCode == Keys.Enter) btnDangNhap_Click(sender,e);
        }
    }
}
