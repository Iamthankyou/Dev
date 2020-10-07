using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoSoDuLieu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lấy dữ liệu đổ ra form
            //B1: tạo chuỗi kết nối
            string strConnect = "Data Source=DESKTOP-OH9IU5S\\SQLEXPRESS;DataBase=DataBaseTestCSharp;Integrated Security = true";
            //B2: mở kết nối 
            SqlConnection sqlConnection = new SqlConnection(strConnect);
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
                MessageBox.Show("Thành công!");
            }
            //B3: Tạo lệnh SQL
            string sqlSelect = "select * from tblChatLieu";
                /*"insert into tblChatLieu (MaChatLieu,TenChatLieu)" +
                "value (1431,N'sắt')";*/
            //B4: Thực thi lệnh Sql
            SqlDataAdapter dt = new SqlDataAdapter(sqlSelect, sqlConnection);
            DataTable tbChatLieu = new DataTable();
            dt.Fill(tbChatLieu);
            /*dt.Update(tbChatLieu);*/

            //B5: Đóng kết nối và hủy đối tượng
            if (sqlConnection.State != ConnectionState.Closed)
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
            }
            //Đổ dữ liệu bào gridview
            dtgChatLieu.DataSource = tbChatLieu;
        }
    }
}
