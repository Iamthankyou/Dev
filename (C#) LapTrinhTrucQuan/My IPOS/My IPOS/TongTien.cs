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
    public partial class TongTien : Form
    {
        OrderTakeAway takeAway;

        public TongTien(OrderTakeAway a)
        {
            InitializeComponent();
            takeAway = a;
        }

        private void TongTien_Load(object sender, EventArgs e)
        {

        }
    }
}
