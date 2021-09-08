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
    public partial class KH : Form
    {
        public static Boolean tkkh = false;
        SQLConnection conn = new SQLConnection();
        DataTable data = new DataTable();
        DataGridViewRow row;
        int tt = 0;
        String mskh = "", phone = "";
        public void SetData()
        {
            String sql = "Select * from KhachHang";
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
                    dtgv.Rows.Add(data.Rows[i][0], data.Rows[i][1], data.Rows[i][2], data.Rows[i][3]);
                    if (data.Rows[i][4].ToString() == "1") dtgv.Rows[i].Cells[4].Value = true;
                    else dtgv.Rows[i].Cells[4].Value = false;
                }
            }
            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public KH()
        {
            InitializeComponent();
        }

        private void KH_FormClosed(object sender, FormClosedEventArgs e)
        {
            tkkh = false;
            new Home().Show();
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = this.dtgv.Rows[e.RowIndex];
                mskh = row.Cells[0].Value.ToString();
                tbma.Text = row.Cells[0].Value.ToString();
                cbma.Text = row.Cells[0].Value.ToString();
                tbten.Text = row.Cells[1].Value.ToString();
                tbdc.Text = row.Cells[2].Value.ToString();
                phone = (row.Cells[3].Value.ToString()).Trim();
                masksdt.Text = row.Cells[3].Value.ToString();
                cbvip.Checked = (bool)row.Cells[4].Value;
            }
            else
            {
                mskh = "";
                phone = "";
            }
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            tt = 1;
            btadd.Enabled = false;
            bthuy.Enabled = true;
            btcn.Enabled = false;
            btxoa.Enabled = false;
            bttk.Enabled = false;
            btexit.Enabled = false;
            tbma.Enabled = true;
            cbvip.Enabled = true;
            tbten.Enabled = true;
            tbdc.Enabled = true;
            masksdt.Enabled = true;
            btluu.Enabled = true;
            dtgv.Enabled = false;

            tbma.Text = "";
            cbvip.Checked = false;
            tbten.Text = "";
            tbdc.Text = "";
            masksdt.Text = "";
        }

        private void btcn_Click(object sender, EventArgs e)
        {
            if (mskh == "") MessageBox.Show("Hãy chọn dòng để cập nhật!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                tt = 2;
                btadd.Enabled = false;
                bthuy.Enabled = true;
                btcn.Enabled = false;
                btxoa.Enabled = false;
                bttk.Enabled = false;
                btexit.Enabled = false;
                tbma.Enabled = true;
                cbvip.Enabled = true;
                tbten.Enabled = true;
                tbdc.Enabled = true;
                masksdt.Enabled = true;
                btluu.Enabled = true;
                dtgv.Enabled = false;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (mskh == "") MessageBox.Show("Hãy chọn dòng để thực hiện xóa!!!");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mẫu tin?", "Xóa KH", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    String sql = "Delete from KhachHang where makh='" + mskh + "';";
                    if (conn.ChangeData(sql))
                    {
                        mskh = "";
                        cbvip.Checked = false;
                        tbma.Text = "";
                        tbten.Text = "";
                        tbdc.Text = "";
                        masksdt.Text = "";
                        SetData();
                        MessageBox.Show("Xóa khách hàng thành công.", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            tt = 0;
            tkkh = false;
            mskh = "";
            bthuy.Enabled = false;
            btadd.Enabled = true;
            btcn.Enabled = true;
            btxoa.Enabled = true;
            tbma.Enabled = false;
            cbvip.Enabled = false;
            tbten.Enabled = false;
            tbdc.Enabled = false;
            masksdt.Enabled = false;
            btluu.Enabled = false;
            dtgv.Enabled = true;

            tbma.Text = "";
            cbvip.Checked = false;
            tbten.Text = "";
            tbdc.Text = "";
            masksdt.Text = "";
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            tkkh = false;
            this.Close();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            Boolean kttt = true;
            ktma.Visible = false;
            ktten.Visible = false;
            ktsdt.Visible = false;
            sdttt.Visible = false;
            String phone1 = "";
            for (int i = 0; i < masksdt.Text.Length; i++)
            {
                if (i != 0 && i != 4 && i != 5 && i != 9)
                {
                    if (masksdt.Text[i].ToString() == " " || masksdt.Text.Length < 14)
                    {
                        kttt = false;
                        ktsdt.Visible = true;
                        break;
                    }
                    phone1 += masksdt.Text[i];
                }
            }

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
                    for (int i = 0; i < dtgv.Rows.Count; i++)
                    {
                        if (phone1 == (dtgv.Rows[i].Cells[3].Value.ToString()).Trim())
                        {
                            kttt = false;
                            sdttt.Visible = true;
                            break;
                        }
                    }
                    if (kttt)
                    {
                        String ktvip = "0";
                        if (cbvip.Checked == true) 
                            ktvip = "1";
                        String sql = "Insert into KhachHang values ('" + tbma.Text + "',N'" + tbten.Text + "',N'" + tbdc.Text + "','" + phone1 + "','" + ktvip +"');";
                        if (conn.ChangeData(sql))
                        {
                            SetData();
                            MessageBox.Show("Thêm khách hàng thành công.", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        if (tbma.Text.Trim().ToLower() == cbma.Items[i].ToString().Trim().ToLower() && tbma.Text.Trim().ToLower() != mskh.Trim().ToLower() || tbma.Text == "")
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
                    if (masksdt.Text == "")
                    {
                        kttt = false;
                        ktsdt.Visible = true;
                    }
                    for (int i = 0; i < dtgv.Rows.Count; i++)
                    {
                        if (phone1 == (dtgv.Rows[i].Cells[3].Value.ToString()).Trim() && phone != phone1)
                        {
                            kttt = false;
                            sdttt.Visible = true;
                            break;
                        }
                    }
                    if (kttt)
                    {
                        String ktvip = "0";
                        if (cbvip.Checked == true) ktvip = "1";
                        String sql = "Update KhachHang Set makh='" + tbma.Text + "',tenkh=N'" + tbten.Text + "',diachi=N'" + tbdc.Text + "',sdt='" + phone1 + "',vip='" + ktvip + "' where makh='" + mskh + "';";
                        if (conn.ChangeData(sql))
                        {
                            SetData();
                            tt = 0;
                            mskh = "";
                            phone = "";
                            {
                                bthuy.Enabled = false;
                                btadd.Enabled = true;
                                btcn.Enabled = true;
                                btxoa.Enabled = true;
                                bttk.Enabled = true;
                                btexit.Enabled = true;
                                tbma.Enabled = false;
                                cbvip.Enabled = false;
                                tbten.Enabled = false;
                                tbdc.Enabled = false;
                                masksdt.Enabled = false;
                                btluu.Enabled = false;
                                dtgv.Enabled = true;

                                tbma.Text = "";
                                cbvip.Checked = false;
                                tbten.Text = "";
                                tbdc.Text = "";
                                masksdt.Text = "";
                            }
                            MessageBox.Show("Cập nhật khách hàng thành công.", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else MessageBox.Show("Vui lòng điền đúng thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void bttk_Click(object sender, EventArgs e)
        {
            if (tkkh)
            {
                String phone1 = "";
                String ktvip = "0";
                for (int i = 0; i < masksdt.Text.Length; i++)
                {
                    if (i != 0 && i != 4 && i != 5 && i != 9 && masksdt.Text[i].ToString() != " ")
                    {
                        phone1 += masksdt.Text[i];
                    }
                }
                if (cbvip.Checked == true) ktvip = "1";
                String sql = "Select * from KhachHang where makh like '%" + tbma.Text.Trim() + "%' and tenkh like N'%" + tbten.Text.Trim() + "%' and diachi like N'%" + tbdc.Text.Trim() + "%' and sdt like '%" + phone1 + "%' and vip='" + ktvip + "';";
                if (conn.GetIn4(sql))
                {
                    data = conn.data;
                    dtgv.Rows.Clear();
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        dtgv.Rows.Add(data.Rows[i][0], data.Rows[i][1], data.Rows[i][2], data.Rows[i][3]);
                        if (data.Rows[i][4].ToString() == "1") dtgv.Rows[i].Cells[4].Value = true;
                        else dtgv.Rows[i].Cells[4].Value = false;
                    }
                }
            } 
            else
            {
                tkkh = true;
                btadd.Enabled = false;
                bthuy.Enabled = true;
                btcn.Enabled = false;
                btxoa.Enabled = false;
                btexit.Enabled = false;
                tbma.Enabled = true;
                cbvip.Enabled = true;
                tbten.Enabled = true;
                tbdc.Enabled = true;
                masksdt.Enabled = true;
                btluu.Enabled = false;
                dtgv.Enabled = false;

                tbma.Text = "";
                tbten.Text = "";
                tbdc.Text = "";
                masksdt.Text = "";
            }
        }

        private void refesh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetData();
        }

        private void cbma_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KH_Load(object sender, EventArgs e)
        {
            SetData();
            if (tkkh)
            {
                btluu.Visible = false;
                btadd.Visible = false;
                btcn.Visible = false;
                btxoa.Visible = false;
                bthuy.Visible = false;
                cbma.Visible = true;
                tbten.Enabled = true;
                tbdc.Enabled = true;
                masksdt.Enabled = true;
                cbvip.Enabled = true;
            }
        }
    }
}
