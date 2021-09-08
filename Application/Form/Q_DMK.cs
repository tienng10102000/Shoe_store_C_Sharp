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
    public partial class Q_DMK : Form
    {
        SQLConnection conn = new SQLConnection();
        DataTable data = new DataTable();
        String tk = SignIn.tk;
        String mk = SignIn.mk;
        public static Boolean DMK = false;
        public static Boolean home = false;
        public Q_DMK()
        {
            InitializeComponent();
        }

        public void SetData ()
        {
            ttk.Text = tk;
            String sql = "Select TenTK, MK, CHDB from TaiKhoan where TenTK='" + tk + "';";
            conn.GetIn4(sql);
            data = conn.data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Q_ĐMK_Load(object sender, EventArgs e)
        {
            SetData();
            if (DMK)
            {
                title.Text = "ĐỔI MẬT KHẨU";
                db_old.Text = "MK cũ:";
                chdb_old.PasswordChar = '●';
            }
        }

        private void btok_Click(object sender, EventArgs e)
        {
            ktdb.Visible = false;
            ktmkm.Visible = false;
            if (!DMK)
            {
                if (chdb_old.Text.Trim().ToLower() == data.Rows[0][2].ToString().Trim().ToLower())
                {
                    if (mkmoi.Text == "" || mkmoi.Text.Length < 8)
                    {
                        ktmkm.Visible = true;
                        MessageBox.Show("Mật khẩu ít nhất 8 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        String sql = "Update TaiKhoan Set MK='" + mkmoi.Text + "' where TenTK='" + tk + "';";
                        if (conn.ChangeData(sql))
                        {
                            SignIn.mk = mkmoi.Text;
                            MessageBox.Show("Cập nhật mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else MessageBox.Show("Cập nhật mật khẩu không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 
                else
                {
                    ktdb.Visible = true;
                    MessageBox.Show("Câu trả lời đặc biệt không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (chdb_old.Text == data.Rows[0][1].ToString())
                {
                    if (mkmoi.Text.Trim() == "" || mkmoi.Text.Length < 8)
                    {
                        ktmkm.Visible = true;
                        MessageBox.Show("Mật khẩu ít nhất 8 ký tự.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        String sql = "Update TaiKhoan Set MK='" + mkmoi.Text + "' where TenTK='" + tk + "';";
                        if (conn.ChangeData(sql))
                        {
                            SignIn.mk = mkmoi.Text;
                            MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else MessageBox.Show("Đổi mật khẩu không thành công.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    ktdb.Visible = true;
                    MessageBox.Show("Câu trả lời đặc biệt không đúng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Q_ĐMK_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!home) new SignIn().Show();
        }
    }
}
