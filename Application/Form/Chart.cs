using App.NET.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.NET
{
    public partial class Chart : Form
    {
        SQLConnection conn = new SQLConnection();
        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            if (conn.SetDataReader("select month(ngaynhap), sum(TT) from HDB group by MONTH(NGAYNHAP)"))
            {
                chart1.Series["Doanh thu"].Points.Clear();
                SqlDataReader dr = conn.dr;
                while (dr.Read())
                {
                    chart1.Series["Doanh thu"].Points.AddXY(dr[0].ToString(), dr[1].ToString());
                }
                conn.dongKN();
            }
            String sql = "select top 3 h.Masp, s.TenSP, sum(h.SOLUONG) as SLBan, s.ANH from HDB h, SanPham s where h.masp=s.masp and MONTH(ngaynhap)=MONTH(GETDATE()) group by h.MASP, s.TENSP, s.anh order by SLBan desc;";
            try
            {
                if (conn.GetIn4(sql))
                {
                    DataTable dt = new DataTable();
                    dt = conn.data;
                    foreach (DataRow row in dt.Rows)
                    {
                        masp.Text = row[0].ToString().Trim();
                        tensp.Text = row[1].ToString().Trim();
                        pbbcn.Image = new Bitmap(Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "Img/" + row[3].ToString().Trim());
                        pbbcn.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    }
                    dtgv.DataSource = dt;
                }
            }catch(Exception ie)
            {
                MessageBox.Show("Lỗi chạy báo cáo");
            }
            
        }

        private void Chart_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Home().Show();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
