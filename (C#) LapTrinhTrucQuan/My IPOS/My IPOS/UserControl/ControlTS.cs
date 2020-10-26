using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_IPOS
{
    public partial class ControlTS : UserControl
    {
        OrderTakeAway away;

        public ControlTS(OrderTakeAway a)
        {
            InitializeComponent();
            away = a;
        }

        private void btnTS_M_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            away.addMon(++away.stt, btnTS_M.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }
    }
}
