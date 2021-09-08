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
    public partial class TKBC : Form
    {
        SQLConnection conn = new SQLConnection();
        DataTable dt = new DataTable();
        public TKBC()
        {
            InitializeComponent();
        }

        private void TKBC_Load(object sender, EventArgs e)
        {
            CrystalReport2 rp = new CrystalReport2();
            String sql = "Select * from HDB where YEAR(ngaynhap)=YEAR(GETDATE())";
            conn.GetIn4(sql);
            dt = conn.data;
            rp.Database.Tables["HDB"].SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }

        private void TKBC_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Home().Show();
        }
    }
}
