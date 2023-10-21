using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NhanVien
{
    public partial class thongtinkhachhang : Form
    {
        SqlConnection conn;
        SqlDataAdapter ad;
        DataSet daset;
        public thongtinkhachhang()
        {
            conn = new SqlConnection("Data Source=DESKTOP-F109BTE;Initial Catalog=QUANLYKHACHHANG;Integrated Security=True");
            InitializeComponent();
        }
        DataTable DSLop()
        {
            ad = new SqlDataAdapter("Select*from KHACHHANG", conn);
            daset = new DataSet();
            ad.Fill(daset);
            return daset.Tables[0];
        }
        private void thongtinkhachhang_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dslop;
            dslop = DSLop();
        }
    }
}
