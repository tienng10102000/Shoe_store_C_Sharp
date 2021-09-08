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
    public partial class NCC : Form
    {
        SQLConnection conn = new SQLConnection();
        DataTable data = new DataTable();
        DataGridViewRow row;
        int tt = 0;
        String msncc = "";
        public NCC()
        {
            InitializeComponent();
        }
        public void SetData()
        {
            String sql = "Select * from NCC";
            if (conn.GetIn4(sql))
            {
                data = conn.data;
                cbma.Items.Clear();
                foreach (DataRow dtRow in data.Rows)
                {
                    cbma.Items.Add(dtRow[0].ToString());
                }
                dtgv.Rows.Clear();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    dtgv.Rows.Add(data.Rows[i][0], data.Rows[i][1]);
                }
            }
            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void NCC_Load(object sender, EventArgs e)
        {
            SetData();
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            tt = 1;

            btadd.Enabled = false;
            bthuy.Enabled = true;
            btcn.Enabled = false;
            btxoa.Enabled = false;
            btexit.Enabled = false;
            tbma.Enabled = true;
            tbten.Enabled = true;
            btluu.Enabled = true;
            dtgv.Enabled = false;

            tbma.Text = "";
            tbten.Text = "";
        }

        private void NCC_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Home().Show();
        }

        private void btcn_Click(object sender, EventArgs e)
        {
            if (msncc == "") MessageBox.Show("Hãy chọn dòng để cập nhật!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                tt = 2;
                btadd.Enabled = false;
                bthuy.Enabled = true;
                btcn.Enabled = false;
                btxoa.Enabled = false;
                btexit.Enabled = false;
                tbma.Enabled = true;
                tbten.Enabled = true;
                btluu.Enabled = true;
                dtgv.Enabled = false;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (msncc == "") MessageBox.Show("Hãy chọn dòng để thực hiện xóa!!!");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mẫu tin?", "Xóa NCC", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    String sql = "Delete from NCC where mancc='" + msncc + "';";
                    if (conn.ChangeData(sql))
                    {
                        msncc = "";
                        tbma.Text = "";
                        tbten.Text = "";
                        SetData();
                        MessageBox.Show("Xóa nhà cung cấp thành công.", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Xóa nhà cung cấp thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            tt = 0;
            msncc = "";
            bthuy.Enabled = false;
            btadd.Enabled = true;
            btcn.Enabled = true;
            btxoa.Enabled = true;
            tbma.Enabled = false;
            tbten.Enabled = false;
            btluu.Enabled = false;
            dtgv.Enabled = true;

            tbma.Text = "";
            tbten.Text = "";
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = this.dtgv.Rows[e.RowIndex];
                msncc = row.Cells[0].Value.ToString();
                tbma.Text = row.Cells[0].Value.ToString();
                cbma.Text = row.Cells[0].Value.ToString();
                tbten.Text = row.Cells[1].Value.ToString();
            }
            else
            {
                msncc = "";
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            Boolean kttt = true;
            ktma.Visible = false;
            ktten.Visible = false;
            {
                if (tt == 1)
                {
                    for (int i = 0; i < cbma.Items.Count; i++)
                    {
                        if (tbma.Text.Trim().ToLower() == cbma.Items[i].ToString().Trim().ToLower() || tbma.Text == "")
                        {
                            kttt = false;
                            ktma.Visible = true;
                            break;
                        }
                    }
                    if (tbten.Text == "")
                    {
                        kttt = false;
                        ktten.Visible = true;
                    }
                    if (kttt)
                    {
                        String sql = "Insert into NCC values ('" + tbma.Text + "',N'" + tbten.Text + "');";
                        if (conn.ChangeData(sql))
                        {
                            SetData();
                            MessageBox.Show("Thêm nhà cung cấp thành công.", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Vui lòng điền đúng thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            {
                if (tt == 2)
                {
                    for (int i = 0; i < cbma.Items.Count; i++)
                    {
                        if (tbma.Text.Trim().ToLower() == cbma.Items[i].ToString().Trim().ToLower() && tbma.Text.Trim().ToLower() != msncc.Trim().ToLower() || tbma.Text == "")
                        {
                            kttt = false;
                            ktma.Visible = true;
                            break;
                        }
                    }
                    if (tbten.Text == "")
                    {
                        kttt = false;
                        ktten.Visible = true;
                    }
                    if (kttt)
                    {
                        String sql = "Update NCC Set mancc='" + tbma.Text + "',tenncc=N'" + tbten.Text + "' where mancc='" + msncc + "';";
                        if (conn.ChangeData(sql))
                        {
                            SetData();
                            tt = 0;
                            msncc = "";
                            {
                                bthuy.Enabled = false;
                                btadd.Enabled = true;
                                btcn.Enabled = true;
                                btxoa.Enabled = true;
                                btexit.Enabled = true;
                                tbma.Enabled = false;
                                tbten.Enabled = false;
                                btluu.Enabled = false;
                                dtgv.Enabled = true;

                                tbma.Text = "";
                                tbten.Text = "";
                            }
                            MessageBox.Show("Cập nhật nhà cung cấp thành công.", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Vui lòng điền đúng thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void refesh_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetData();
        }
    }
}
