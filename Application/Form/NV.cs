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
    public partial class NV : Form
    {
        public static Boolean tknv = false;
        public static String MANV = "", TENNV = "";
        SQLConnection conn = new SQLConnection();
        DataTable data = new DataTable();
        DataGridViewRow row;
        int tt = 0;
        String msnv = "", phone = "";
        public void SetData()
        {
            String sql = "Select * from NhanVien";
            if (conn.GetIn4(sql))
            {
                data = conn.data;
                cbma.Items.Clear();
                cbtk.Items.Clear();
                foreach (DataRow dtRow in data.Rows)
                {
                    cbma.Items.Add(dtRow[0].ToString());
                    cbtk.Items.Add(dtRow[4].ToString());
                    if (dtRow[4].ToString() == SignIn.tk)
                    {
                        MANV = dtRow[0].ToString();
                        TENNV = dtRow[1].ToString();
                    }
                }
                dtgv.Rows.Clear();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    dtgv.Rows.Add(data.Rows[i][0], data.Rows[i][1], data.Rows[i][2], data.Rows[i][3], data.Rows[i][4]);
                }               
            }
            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


            String sql_tk = "SELECT * FROM TAIKHOAN";
            if (conn.GetIn4(sql_tk))
            {
                data = conn.data;
                cbma.Items.Clear();
                cbtk.Items.Clear();
                foreach (DataRow dtRow in data.Rows)
                {

                    cbma.Items.Add(dtRow[0].ToString());
                    cbtk.Items.Add(dtRow[1].ToString());
                    if (dtRow[4].ToString() == SignIn.tk)
                    {
                        MANV = dtRow[0].ToString();
                        TENNV = dtRow[1].ToString();
                    }
                }

                dataGridView1.Rows.Clear();
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    dataGridView1.Rows.Add(data.Rows[i][0], data.Rows[i][1], data.Rows[i][2], data.Rows[i][3], data.Rows[i][4]);
                }
            }
            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NV_Load(object sender, EventArgs e)
        {
            SetData();
            if (tknv)
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
                cbtk.Enabled = true;
            }
            
        }

        public NV()
        {
            InitializeComponent();
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            tt = 1;

            btadd.Enabled = false;
            bthuy.Enabled = true;
            btcn.Enabled = false;
            btxoa.Enabled = false;
            btexit.Enabled = false;
            bttk.Enabled = false;
            tbma.Enabled = true;
            tbten.Enabled = true;
            tbdc.Enabled = true;
            masksdt.Enabled = true;
            cbtk.Enabled = true;
            btluu.Enabled = true;
            dtgv.Enabled = false;

            tbma.Text = "";
            tbten.Text = "";
            tbdc.Text = "";
            masksdt.Text = "";
            cbtk.Text = "";
        }

        private void NV_FormClosed(object sender, FormClosedEventArgs e)
        {
            tknv = false;
            new Home().Show();
        }

        private void btcn_Click(object sender, EventArgs e)
        {
            if (msnv == "") MessageBox.Show("Hãy chọn dòng để cập nhật!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                tt = 2;
                btadd.Enabled = false;
                bthuy.Enabled = true;
                btcn.Enabled = false;
                btxoa.Enabled = false;
                btexit.Enabled = false;
                bttk.Enabled = false;
                tbma.Enabled = true;
                tbten.Enabled = true;
                tbdc.Enabled = true;
                masksdt.Enabled = true;
                cbtk.Enabled = true;
                btluu.Enabled = true;
                dtgv.Enabled = false;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (msnv == "") MessageBox.Show("Hãy chọn dòng để thực hiện xóa!!!");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mẫu tin?", "Xóa NV", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    String sql = "Delete from NhanVien where manv='" + msnv + "';";
                    if (conn.ChangeData(sql))
                    {
                        msnv = "";
                        tbma.Text = "";
                        tbten.Text = "";
                        tbdc.Text = "";
                        masksdt.Text = "";
                        cbtk.Text = "";
                        SetData();
                        MessageBox.Show("Xóa nhân viên thành công.", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            tt = 0;
            tknv = false;
            msnv = "";
            bthuy.Enabled = false;
            btadd.Enabled = true;
            btcn.Enabled = true;
            btxoa.Enabled = true;
            tbma.Enabled = false;
            tbten.Enabled = false;
            tbdc.Enabled = false;
            masksdt.Enabled = false;
            cbtk.Enabled = false;
            btluu.Enabled = false;
            dtgv.Enabled = true;

            tbma.Text = "";
            tbten.Text = "";
            tbdc.Text = "";
            masksdt.Text = "";
            cbtk.Text = "";
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            tknv = false;
            this.Close();
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = this.dtgv.Rows[e.RowIndex];
                msnv = row.Cells[0].Value.ToString();
                tbma.Text = row.Cells[0].Value.ToString();
                cbma.Text = row.Cells[0].Value.ToString();
                tbten.Text = row.Cells[1].Value.ToString();
                tbdc.Text = row.Cells[2].Value.ToString();
                phone = (row.Cells[3].Value.ToString()).Trim();
                masksdt.Text = row.Cells[3].Value.ToString();
                cbtk.Text = row.Cells[4].Value.ToString();
            }
            else
            {
                msnv = "";
                phone = "";
            }
        }

        private void bttk_Click(object sender, EventArgs e)
        {
            if (tknv)
            {
                String phone1 = "";
                for (int i = 0; i < masksdt.Text.Length; i++)
                {
                    if (i != 0 && i != 4 && i != 5 && i != 9 && masksdt.Text[i].ToString() != " ")
                    {
                        phone1 += masksdt.Text[i];
                    }
                }
                String sql = "Select * from NhanVien where manv like '%" + tbma.Text.Trim() + "%' and tennv like N'%" + tbten.Text.Trim() + "%' and diachi like N'%" + tbdc.Text.Trim() + "%' and sdt like '%" + phone1 + "%' and tentk like '%" + cbtk.Text.Trim() + "%';";
                if (conn.GetIn4(sql))
                {
                    data = conn.data;
                    dtgv.Rows.Clear();
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        dtgv.Rows.Add(data.Rows[i][0], data.Rows[i][1], data.Rows[i][2], data.Rows[i][3], data.Rows[i][4]);
                    }
                }
            } 
            else
            {
                tknv = true;
                btadd.Enabled = false;
                bthuy.Enabled = true;
                btcn.Enabled = false;
                btxoa.Enabled = false;
                btexit.Enabled = false;
                tbma.Enabled = true;
                tbten.Enabled = true;
                tbdc.Enabled = true;
                masksdt.Enabled = true;
                cbtk.Enabled = true;
                btluu.Enabled = false;
                dtgv.Enabled = false;

                tbma.Text = "";
                tbten.Text = "";
                tbdc.Text = "";
                masksdt.Text = "";
                cbtk.Text = "";
            }
        }

        private void cbma_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttk.PerformClick();
            }
        }

        private void tbten_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbten_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttk.PerformClick();
            }
        }

        private void tbdc_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttk.PerformClick();
            }
        }

        private void masksdt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void masksdt_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttk.PerformClick();
            }
        }

        private void cbtk_SelectedIndexChanged(object sender, EventArgs e)
        {

            //row = this.dataGridView1.Rows[0];
            tbten.Text = "Đặt lại tên";
        }

        private void cbtk_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bttk.PerformClick();
            }
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void refesh_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetData();
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            Boolean kttt = true;
            ktma.Visible = false;
            ktten.Visible = false;
            ktsdt.Visible = false;
            sdttt.Visible = false;
            kttk.Visible = false;
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
                        if (tbma.Text.Trim().ToLower() == cbma.Items[i].ToString().Trim().ToLower())
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
                    for (int i = 0; i < cbtk.Items.Count; i++)
                    {
                        if (cbtk.Text.Trim().ToLower() == cbtk.Items[i].ToString().Trim().ToLower() || cbtk.Text == "")
                        {
                            break;
                        }
                        kttt = false;
                        kttk.Visible = true;
                    }
                        String sql = "Insert into NhanVien values ('" + tbma.Text + "',N'" + tbten.Text + "',N'" + tbdc.Text + "','" + phone1 + "','" + cbtk.Text.Trim()  +"');";
                        if (conn.ChangeData(sql))
                        {
                            SetData();
                            MessageBox.Show("Thêm nhân viên thành công.", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            {
                if (tt == 2)
                {
                    for (int i = 0; i < cbma.Items.Count; i++)
                    {
                        if (tbma.Text.Trim().ToLower() == cbma.Items[i].ToString().Trim().ToLower() && tbma.Text.Trim().ToLower() != msnv.Trim().ToLower() || tbma.Text == "")
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
                    for (int i = 0; i < cbtk.Items.Count; i++)
                    {
                        if (cbtk.Text.Trim().ToLower() == cbtk.Items[i].ToString().Trim().ToLower())
                        {
                            break;
                        }
                        kttt = false;
                        kttk.Visible = true;
                    }
                    String sql = "Update NhanVien Set manv='" + tbma.Text + "',tennv=N'" + tbten.Text + "',diachi=N'" + tbdc.Text + "',sdt='" + phone1 + "',tentk='" + cbtk.Text.Trim() + "' where manv='" + msnv + "';";
                    if (conn.ChangeData(sql))
                    {
                        SetData();
                        tt = 0;
                        msnv = "";
                        phone = "";
                        {
                            bthuy.Enabled = false;
                            btadd.Enabled = true;
                            btcn.Enabled = true;
                            btxoa.Enabled = true;
                            bttk.Enabled = true;
                            btexit.Enabled = true;
                            tbma.Enabled = false;
                            tbten.Enabled = false;
                            tbdc.Enabled = false;
                            masksdt.Enabled = false;
                            cbtk.Enabled = false;
                            btluu.Enabled = false;
                            dtgv.Enabled = true;

                            tbma.Text = "";
                            tbten.Text = "";
                            tbdc.Text = "";
                            masksdt.Text = "";
                            cbtk.Text = "";
                        }
                        MessageBox.Show("Cập nhật nhân viên thành công.", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   }
            }
        }
    }
}
