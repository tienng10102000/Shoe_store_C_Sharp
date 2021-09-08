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
    public partial class TKHD : Form
    {
        SQLConnection conn = new SQLConnection();
        DataTable data = new DataTable();
        public TKHD()
        {
            InitializeComponent();
        }

        private void TKHD_Load(object sender, EventArgs e)
        {

        }

        private void bttk_Click(object sender, EventArgs e)
        {
            String sql = "";
            if (HDN.Checked)
            {
                sql = "Select MaHD as 'Mã HD', MaNV as 'Mã NV', MaSP as 'Mã SP', NgayNhap as 'Ngày nhập', Soluong as 'Số lượng', DGNhap as 'ĐG nhâp', DGBan as 'ĐG bán' from HDN where MaHD like '%" + mahd.Text.Trim() + "%' and NgayNhap='" + date.Value.ToString("yyyy/MM/dd") + "';";
            }
            else
            {
                sql = "Select MaHD as 'Mã HD', MaNV as 'Mã NV', MaKH as 'Mã KH', MaSP as 'Mã SP', NgayNhap as 'Ngày nhập', Soluong as 'Số lượng', DGia as 'Đơn giá', GG as 'Giảm giá' from HDB where MaHD like '%" + mahd.Text.Trim() + "%' and NgayNhap='" + date.Value.ToString("yyyy/MM/dd") + "';";
            }
            if (conn.GetIn4(sql))
            {
                data = conn.data;
                dtgv.DataSource = data;
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TKHD_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Home().Show();
        }

        private void mahd_TextChanged(object sender, EventArgs e)
        {
            String sql = "";
            if (HDN.Checked)
            {
                sql = "Select MaHD as 'Mã HD', MaNV as 'Mã NV', MaSP as 'Mã SP', NgayNhap as 'Ngày nhập', Soluong as 'Số lượng', DGNhap as 'ĐG nhâp', DGBan as 'ĐG bán' from HDN where MaHD like '%" + mahd.Text.Trim() + "%' and NgayNhap='" + date.Value.ToString("yyyy/MM/dd") + "';";
            }
            else
            {
                sql = "Select MaHD as 'Mã HD', MaNV as 'Mã NV', MaKH as 'Mã KH', MaSP as 'Mã SP', NgayNhap as 'Ngày nhập', Soluong as 'Số lượng', DGia as 'Đơn giá', GG as 'Giảm giá' from HDB where MaHD like '%" + mahd.Text.Trim() + "%' and NgayNhap='" + date.Value.ToString("yyyy/MM/dd") + "';";
            }
            if (conn.GetIn4(sql))
            {
                data = conn.data;
                dtgv.DataSource = data;
            }
        }
    }
}
