using My_IPOS.Model;
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
    public partial class OrderTakeAway : Form
    {
        Bitmap back, hour, minute, dot, second;

        int stt = 0;

        private void btnTX_M_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt ,btnTX_M.Text, soluong, giamgia, dongia, ghichu, time, soluong*dongia - (soluong * dongia*giamgia), MaMon);
        }

        private void btnTXXoai_M_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXXoai_M.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXDuaHongHac_M_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXDuaHongHac_M.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTX_L_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTX_L.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXXoai_L_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXXoai_L.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXDauTamPhaLeTuyet_L_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXDauTamPhaLeTuyet_L.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXDuaHongHac_L_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXDuaHongHac_L.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXKiwiChanhLeo_M_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXKiwiChanhLeo_M.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXChanhLeo_M_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXChanhLeo_M.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXDuaNhietDoi_M_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXDuaNhietDoi_M.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXHongLongPhaLeTuyet_M_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXHongLongPhaLeTuyet_M.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXKiwiChanhLeo_L_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXKiwiChanhLeo_L.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXChanhLeo_L_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXChanhLeo_L.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXDuaNhietDoi_L_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXDuaNhietDoi_L.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXHongLongPhaLeTuyet_L_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXHongLongPhaLeTuyet_L.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        private void btnTXDauTamPhaLeTuyet_M_Click(object sender, EventArgs e)
        {
            int soluong = 1;
            float giamgia = 0;
            int dongia = 32000;
            string ghichu = "";
            string time = DateTime.Now.ToString();
            string MaMon = "";
            addMon(++stt, btnTXDauTamPhaLeTuyet_M.Text, soluong, giamgia, dongia, ghichu, time, soluong * dongia - (soluong * dongia * giamgia), MaMon);
        }

        public OrderTakeAway()
        {
            InitializeComponent();

            back = new Bitmap(".\\image\\back.png");
            hour = new Bitmap(".\\image\\hour.png");
            minute = new Bitmap(".\\image\\minute.png");
            dot = new Bitmap(".\\image\\dot.png");
            second = new Bitmap(".\\image\\second.png");
        }

        private Bitmap rotateImage(Bitmap rotateMe, float angle)
        {
            Bitmap rotatedImage = new Bitmap(rotateMe.Width, rotateMe.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateMe.Width / 2, rotateMe.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateMe.Width / 2, -rotateMe.Height / 2);
                g.DrawImage(rotateMe, new Point(0, 0));
            }
            return rotatedImage;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime Now = DateTime.Now;
            int Hour = Now.Hour;
            int Minute = Now.Minute;
            int Second = Now.Second;

            Single AngleS = Second * 6;
            Single AngleM = Minute * 6 + AngleS / 60;
            Single AngleH = Hour * 30 + AngleM / 12;

            backBox.Image = back;
            backBox.Controls.Add(hourBox);
            hourBox.Location = new Point(0, 0);
            hourBox.Image = rotateImage(hour, AngleH);


            hourBox.Controls.Add(minuteBox);
            minuteBox.Location = new Point(0, 0);
            minuteBox.Image = rotateImage(minute, AngleM);

            minuteBox.Controls.Add(dotBox);
            dotBox.Location = new Point(0, 0);
            dotBox.Image = dot;

            dotBox.Controls.Add(secondBox);
            secondBox.Location = new Point(0, 0);
            secondBox.Image = rotateImage(second, AngleS);
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            TongTien tongtien = new TongTien(this);
            tongtien.ShowDialog();
        }

        void addMon(int stt, string TenMon, int SoLuong, float GiamGia, int DonGia, string GhiChu, string GioGoi, float ThanhTien, string MaMon)
        { 
            dgvxTakeAway.Rows.Add(stt, TenMon, SoLuong, GiamGia, DonGia, GhiChu, GioGoi, ThanhTien, MaMon);
        }

        public void updateCell(int a, int b, int values)
        {
            dgvxTakeAway.Rows[a].Cells[b].Value = values;
            dgvxTakeAway.Rows[a].Cells[7].Value = Convert.ToInt32(dgvxTakeAway.Rows[a].Cells[7].Value.ToString()) * values;
        }

        private void bntBoMon_Click(object sender, EventArgs e)
        {
            if (stt > 0)
            {
                int rowIndex = dgvxTakeAway.CurrentCell.RowIndex;
                int sttIndex = Convert.ToInt32(dgvxTakeAway.Rows[rowIndex].Cells[0].Value.ToString());
                dgvxTakeAway.Rows.RemoveAt(rowIndex);
                stt--;
                for(int i = rowIndex; i < dgvxTakeAway.RowCount; i++)
                {
                    dgvxTakeAway.Rows[i].Cells[0].Value = sttIndex++;
                }
            }
        }

        private void dgvxTakeAway_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2 && dgvxTakeAway.RowCount != 0)
            {
                edit ed = new edit(this, e.RowIndex, e.ColumnIndex);
                ed.ShowDialog();
            }
        }

    }
}
