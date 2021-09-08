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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Q_DMK.DMK = true;
            new Q_DMK().ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HDB().Show();
            this.Close();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HDN().Show();
            this.Close();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SP().Show();
            this.Close();
        }

        private void tìmKiếmNhânCiênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NV.tknv = true;
            new NV().Show();
            this.Close();
        }

        private void tìmKiếmSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SP.tt = 3;
            new SP().Show();
            this.Close();
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KH.tkkh = true;
            new KH().Show();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NV().Show();
            this.Close();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new KH().Show();
            this.Close();
        }

        private void btnv_Click(object sender, EventArgs e)
        {
            new NV().Show();
            this.Close();
        }

        private void btsp_Click(object sender, EventArgs e)
        {
            new SP().Show();
            this.Close();
        }

        private void btkhtt_Click(object sender, EventArgs e)
        {
            new KH().Show();
            this.Close();
        }

        private void bthdb_Click(object sender, EventArgs e)
        {
            new HDB().Show();
            this.Close();
        }

        private void btbd_Click(object sender, EventArgs e)
        {
            new Chart().Show();
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QLTK().ShowDialog();
        }

        private void bt_dx_Click(object sender, EventArgs e)
        {
            this.Close();
            new SignIn().Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            new SignIn().Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Q_DMK.DMK = true;
            new Q_DMK().ShowDialog();
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NCC().Show();
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            if (SignIn.tk != "admin")
            {
                nhânViênToolStripMenuItem.Visible = false;
                thêmTàiKhoảnToolStripMenuItem.Visible = false;
                nhàCungCấpToolStripMenuItem.Visible = false;
                btnv.Visible = false;
                label5.Text = "Hóa đơn";
            }
            else
            {
                toolStripMenuItem2.Visible = false;
                toolStripMenuItem3.Visible = false;
                label5.Text = "Nhân viên";
                bthdb.Visible = false;
                
            }
        }

        private void tìmKiếmHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TKHD().Show();
            this.Close();
        }

        private void thêmTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThemTK ttk = new ThemTK();
            ttk.ShowDialog();
        }

        private void biểuĐồKinhOdanhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Chart().Show();
            this.Close();
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TKBC().Show();
            this.Close();
        }

        private void môTảHệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MoTa().ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
