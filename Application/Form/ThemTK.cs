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
    public partial class ThemTK : Form
    {
        SQLConnection conn = new SQLConnection();
        DataTable data = new DataTable();
        public ThemTK()
        {
            InitializeComponent();
        }
        public void SetData()
        {
            String sql = "Select TenTK from TaiKhoan;";
            conn.GetIn4(sql);
            data = conn.data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btok_Click(object sender, EventArgs e)
        {
            Boolean kt = true;
            ktht.Visible = false;
            kttk.Visible = false;
            ktmk.Visible = false;
            ktnl.Visible = false;
            ktcdb.Visible = false;
            
            if (tbht.Text.Trim() == "")
            {
                ktht.Visible = true;
                kt = false;
            }
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (tbtk.Text.ToLower().Trim() == data.Rows[i][0].ToString().ToLower())
                {
                    kttk.Visible = true;
                    kt = false;
                }
            }
            if (tbmk.Text.Trim() == "" || tbmk.Text.Trim().Length < 8)
            {
                ktmk.Visible = true;
                kt = false;
            }
            if (tbmk.Text != tbnl.Text)
            {
                ktnl.Visible = true;
                kt = false;
            }
            if (ctldb.Text.Trim() == "")
            {
                ktcdb.Visible = true;
                kt = false;
            }
            if (kt)
            {
                String sql = "Insert into TaiKhoan values(N'" + tbht.Text.Trim() + "','" + tbtk.Text.Trim() + "','" + tbmk.Text.Trim() + "',N'" + ctldb.Text.Trim() + "','0');";
                if (conn.ChangeData(sql))
                {
                    MessageBox.Show("Thêm tài khoản thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else MessageBox.Show("Thêm tài khoản không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else MessageBox.Show("Vui lòng điền đúng thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);


        }
    }
}
