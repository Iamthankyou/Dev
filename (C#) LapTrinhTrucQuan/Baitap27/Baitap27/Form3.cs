using CoSoDuLieu.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitap27
{
    public partial class Form3 : Form
    {
        DataBase dtBase = new DataBase();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cbChatLieu.DataSource = dtBase.DataReader("select * from tblChatLieu");
            cbChatLieu.DisplayMember = "TenhChatLieu";
            cbChatLieu.ValueMember = "MaChatLieu";

            dgvHang.DataSource = dtBase.DataReader("select * from tblHang");
            dgvHang.Columns[0].HeaderText = "Mã Hàng";
            dgvHang.Columns[1].HeaderText = "Mã Hàng";
            dgvHang.Columns[2].HeaderText = "Mã Hàng";
            dgvHang.Columns[3].HeaderText = "Mã Hàng";
            dgvHang.Columns[4].HeaderText = "Mã Hàng";
            dgvHang.Columns[5].HeaderText = "Mã Hàng";
            dgvHang.Columns[6].HeaderText = "Mã Hàng";
            dgvHang.Columns[7].HeaderText = "Mã Hàng";
        }

        private void btAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
                if(dlgOpen.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(dlgOpen.FileName);
            }    
        }
    }
}
