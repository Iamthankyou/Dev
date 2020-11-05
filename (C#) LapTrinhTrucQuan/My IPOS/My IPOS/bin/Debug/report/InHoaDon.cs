using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_IPOS.bin.Debug.report
{
    public partial class InHoaDon : Form
    {
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'My_IPos.DataTable1' table. You can move, or remove it, as needed.
            try
            {
                this.DataTable1TableAdapter.FillBy(this.My_IPos.DataTable1, textBox1.Text);
            }
            catch { }
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reportViewer1.PrintDialog();
        }
    }
}
