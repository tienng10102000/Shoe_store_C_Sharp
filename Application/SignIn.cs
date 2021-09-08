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
    public partial class SignIn : Form
    {
        SQLConnection conn = new SQLConnection();
        DataTable data = new DataTable();
        public static String tk = "";
        public static String mk = "";
        public SignIn()
        {
            InitializeComponent();
        }
        
        private void lb_exit_MouseHover(object sender, EventArgs e)
        {
            lb_exit.BackColor = Color.DarkSlateBlue;
        }

        private void lb_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lb_exit_MouseLeave(object sender, EventArgs e)
        {
            lb_exit.BackColor = Color.Transparent;
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            tk = tb_si.Text;
            mk = tb_pw.Text;
            int kt = 0;
            String sql = "Select tentk, mk from TaiKhoan";
            if (conn.GetIn4(sql))
            {
                data = conn.data;
                foreach (DataRow row in data.Rows)
                {
                    if (row.Field<String>(0) == tk)
                    {
                        if (row.Field<String>(1) == mk)
                        {
                            kt = 1;
                        }
                        else
                        {
                            kt = -1;
                            MessageBox.Show("Sai mat khau!");
                        }
                    }
                    if (kt != 0)
                    {
                        break;
                    }
                }
                if (kt == 0) MessageBox.Show("Tai khoan khong ton tai.");
                if (kt == 1)
                {
                    sql = "Update TaiKhoan set ntk='0'";
                    conn.ChangeData(sql);
                    if (cb_ntk.Checked)
                    {
                        sql = "Update TaiKhoan set ntk='1' where tentk='" + tk +"';";
                        conn.ChangeData(sql);
                    }
                    new Home().Show();
                    this.Hide();
                }
            }
            else MessageBox.Show("Không thể kết nối.");
        }
            
        private void SignIn_Load(object sender, EventArgs e)
        {
            String sql = "Select tentk, ntk from TaiKhoan";
            if (conn.GetIn4(sql))
            {
                data = conn.data;
                foreach (DataRow dtRow in data.Rows)
                {
                    if (dtRow[1].ToString() == "1")
                    {
                        tb_si.Text = dtRow[0].ToString();
                        cb_ntk.Checked = true;
                        break;
                    }
                }
            }
            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lbl_qmk_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tk = tb_si.Text;
            Q_DMK.DMK = false;
            new Q_DMK().Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tb_pw.PasswordChar = '\0';
            }
            else
            {
                tb_pw.PasswordChar = '●';
            }
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tb_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_pw_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_ok.PerformClick();
            }
        }

        private void tb_si_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_ok.PerformClick();
            }
        }

        private void SignIn_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_ok.PerformClick();
            }
        }
    }
}
