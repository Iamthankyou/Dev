﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My_IPOS.Model;

namespace My_IPOS
{
    public partial class ControlTS : UserControl
    {
        OrderTakeAway away;
        DataBase data = new DataBase();

        public ControlTS(OrderTakeAway a)
        {
            InitializeComponent();
            away = a;
        }

        private void btnTS_M_Click(object sender, EventArgs e)
        {
            DataTable dt = data.dataReaderTable("select DonGiaTraSua from TraSua where TenTraSua = N'" + btnTS_M.Text + "'");
            int dongia = Convert.ToInt32(dt.Rows[0]["DonGiaTraSua"].ToString());
            int soluong = 1;
            float giamgia = 0;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            away.addMon(++away.stt, btnTS_M.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }
    }
}
