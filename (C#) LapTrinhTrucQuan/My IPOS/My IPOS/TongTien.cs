using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Hosting;
using System.Windows.Forms;

namespace My_IPOS
{
    public partial class TongTien : Form
    {
        DataGridView dt;

        public TongTien(DataGridView a)
        {
            InitializeComponent();
            dt = a;
        }

        private void TongTien_Load(object sender, EventArgs e)
        {
            int thanhtoan = 0, khachdua = 0, tienthua = 0;
           int n = 0;
           foreach(DataGridViewRow row in dt.Rows)
            {
                dgvTongTien.Rows.Add();
                dgvTongTien.Rows[n].Cells[0].Value = row.Cells[0].Value.ToString();
                dgvTongTien.Rows[n].Cells[1].Value = row.Cells[1].Value.ToString();
                dgvTongTien.Rows[n].Cells[2].Value = row.Cells[2].Value.ToString();
                dgvTongTien.Rows[n].Cells[3].Value = row.Cells[7].Value.ToString();
                thanhtoan += Convert.ToInt32(row.Cells[7].Value.ToString());
                n++;
            }
            khachdua = thanhtoan;
            tienthua = khachdua - thanhtoan;
            tbThanhToan.Text = thanhtoan.ToString();
            tbKhachDua.Text = khachdua.ToString();
            tbTienThua.Text = tienthua.ToString();
        }

        private void btTAorDI_Click(object sender, EventArgs e)
        {
            if (btTAorDI.Text.ToString() == "TA")
            {
                btTAorDI.Text = "DI";
            }
            else btTAorDI.Text = "TA";
        }

        private void tbKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar.ToString() != Keys.Enter.ToString() && tbKhachDua.Text != null)
            {
                tbTienThua.Text = "" + (Convert.ToInt32(tbKhachDua.Text.ToString()) - Convert.ToInt32(tbThanhToan.Text.ToString()));
            } else btnInHoaDon.Focus();
        }
    }
}
