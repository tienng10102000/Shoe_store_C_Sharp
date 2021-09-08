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
    public partial class QLTK : Form
    {
        SQLConnection conn = new SQLConnection();
        String tk = SignIn.tk;
        String mk = SignIn.mk;
        DataTable dt = new DataTable();
        Boolean db = false;
        public QLTK()
        {
            InitializeComponent();
        }

        public void SetData()
        {
            String sql = "Select * from TaiKhoan where tentk='" + tk + "';";
            conn.GetIn4(sql);
            dt = conn.data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btsua_Click(object sender, EventArgs e)
        {
            ktht.Visible = false;
            ktdb.Visible = false;
            Boolean kt = true;
            String chdb = "";
            if (hoten.Text.Trim() == "")
            {
                ktht.Visible = true;
                kt = false;
            }
            if (db)
            {
                if (ctldb.Text.Trim() == "")
                {
                    ktdb.Visible = true;
                    kt = false;
                }
                chdb = ctldb.Text.Trim();
            }
            if (kt)
            {
                String sql = "Update TaiKhoan set hoten=N'" + hoten.Text.Trim() + "'";
                if (db) sql += ", chdb=N'" + chdb + "' where tentk='" + tk + "';";
                else sql += " where tentk='" + tk + "';";
                if (conn.ChangeData(sql))
                {
                    SetData();
                    MessageBox.Show("Thông tin được cập nhật thành công.", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else MessageBox.Show("Vui lòng điền đúng thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void hien_Click(object sender, EventArgs e)
        {
            if (tbmk.Text == mk)
            {
                ctldb.Enabled = true;
                ctldb.Text = dt.Rows[0][3].ToString().Trim();
                db = true;
            } else
            {
                ctldb.Enabled = false;
                ctldb.Text = "";
                db = false;
            }
        }

        private void QLTK_Load(object sender, EventArgs e)
        {
            SetData();
            hoten.Text = dt.Rows[0][0].ToString();
            if (dt.Rows[0][1].ToString() == "admin")
                quyen.Text = "Admin";
            else quyen.Text = "User";
            ttk.Text = dt.Rows[0][1].ToString();
        }
    }
}
