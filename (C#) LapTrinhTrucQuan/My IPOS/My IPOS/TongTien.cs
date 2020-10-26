using DevComponents.DotNetBar.Controls;
using My_IPOS.Model;
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
        DataBase data = new DataBase();
        OrderTakeAway od;

        public TongTien(DataGridView a, OrderTakeAway od)
        {
            InitializeComponent();
            dt = a;
            this.od = od;
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

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            if (tbTheGiamGia.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập voucher!");
            }
            else if (tbTheGiamGia.Text == "GF50")
            {
                tbThanhToan.Text = "" + (Convert.ToInt32(tbThanhToan.Text) * (1 - 0.5));
                try
                {
                    MessageBox.Show("Đã áp dụng voucher");
                    tbTienThua.Text = "" + (Convert.ToInt32(tbKhachDua.Text.ToString()) - Convert.ToInt32(tbThanhToan.Text.ToString()));
                }
                catch { }
            }
            else MessageBox.Show("Không Có Voucher Này!");
        }

        private void tbKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbTienThua.Text = "" + (Convert.ToInt32(tbKhachDua.Text.ToString()) - Convert.ToInt32(tbThanhToan.Text.ToString()));
                if (Convert.ToInt32(tbKhachDua.Text.ToString()) - Convert.ToInt32(tbThanhToan.Text.ToString()) >= 0) btnInHoaDon.Enabled = true;
                else btnInHoaDon.Enabled = false;
            }
            catch { }
        }

        private void tbKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string ID_HoaDon, TongTien, ID_KhachHang, ID_Voucher;
            int soluong = 1;
            DataTable dt ;
            DateTime dateTime = DateTime.Now;
            string date = "" + dateTime;


            if (tbTheGiamGia.Text == "") ID_Voucher = "None";
            else ID_Voucher = tbTheGiamGia.Text;
            TongTien = tbThanhToan.Text;
            ID_HoaDon = "" + random.Next(1, 100);
            ID_KhachHang = "TakeAway";

            data.dataChange("insert into HoaDon values('"+ID_HoaDon+"','"+ date +"','" + TongTien+"','"+ID_KhachHang+"','"+ID_Voucher+"')");
            dt = data.dataReaderTable("select * from TraSua where TenTraSua = N'"+dgvTongTien.Rows[0].Cells[1].Value.ToString()+"'");
            data.dataChange("insert into ChiTietHoaDon values('50','"+soluong+"','" + ID_HoaDon + "','" + dt.Rows[0]["ID_TraSua"].ToString() + "')");
            this.Close();
            od.outOrder();
        }
    }
}
