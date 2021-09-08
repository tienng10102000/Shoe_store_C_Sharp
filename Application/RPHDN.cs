using App.NET.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.NET
{
    public partial class RPHDN : Form
    {
        SQLConnection conn = new SQLConnection();
        DataTable dt = new DataTable();
        public static String MaHD = "";
        public RPHDN()
        {
            InitializeComponent();
        }

        private void RPHDN_Load(object sender, EventArgs e)
        {
            ReportHDN rp = new ReportHDN();
            String sql = "Select * from HDN where mahd='" + MaHD +"';";
            conn.GetIn4(sql);
            dt = conn.data;
            rp.Database.Tables["HDN"].SetDataSource(dt);
            dt.Clear();
            sql = "Select * from NhanVien;";
            conn.GetIn4(sql);
            dt = conn.data;
            rp.Database.Tables["NhanVien"].SetDataSource(dt);
            dt.Clear();
            sql = "Select * from SanPham;";
            conn.GetIn4(sql);
            dt = conn.data;
            rp.Database.Tables["SanPham"].SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
