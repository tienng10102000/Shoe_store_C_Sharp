using App.NET.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.NET
{
    public partial class SP : Form
    {
        SQLConnection conn = new SQLConnection();
        DataTable data = new DataTable();
        DataGridViewRow row;
        String masp = "", get = "", source = "", img = "", img1 = "";
        public static int tt = 0;

        public void SetData ()
        {
            String sql = "Select Mancc from NCC";
            if (conn.GetIn4(sql))
            {
                data = conn.data;
                cbncc.Items.Clear();
                foreach (DataRow dtRow in data.Rows)
                {
                    cbncc.Items.Add(dtRow[0].ToString());
                }
            }
            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            sql = "Select masp as 'Mã', tensp as 'Tên sản phẩm', sl as 'Số lượng', loai as Loại, dgnhap as 'Đơn giá nhập', dgban as 'Đơn giá bán', mancc as 'Mã NCC', anh as Ảnh from SanPham";
            if (conn.GetIn4(sql))
            {
                data = conn.data;
                cbmasp.Items.Clear();
                foreach (DataRow dtRow in data.Rows)
                {
                    cbmasp.Items.Add(dtRow[0].ToString());
                }
                dtgv.DataSource = data;
            }
            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);        
        }
        public SP()
        {
            InitializeComponent();
        }
        private void SP_Load(object sender, EventArgs e)
        {
            cbmasp.Enabled = false;
            SetData();
            if (tt == 3)
            {
                btthem.Enabled = false;
                bthuy.Enabled = true;
                btcn.Enabled = false;
                btxoa.Enabled = false;
                bttk.Enabled = false;
                tbma.Enabled = true;
                tbten.Enabled = true;
                ranam.Enabled = true;
                ranu.Enabled = true;
                cbncc.Enabled = true;
                bttim.Visible = true;
                cbmasp.Visible = true;

                cbmasp.Text = "";
                tbma.Text = "";
                tbten.Text = "";
                tbsl.Value = 0;
                ranam.Checked = true;
                tbgn.Value = 1000;
                tbgb.Value = 0;
                cbncc.Text = "";
                pbanh.Image = null;
            }
        }
        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                row = this.dtgv.Rows[e.RowIndex];
                masp = row.Cells[0].Value.ToString();
                tbma.Text = row.Cells[0].Value.ToString();
                cbmasp.Text = row.Cells[0].Value.ToString();
                tbten.Text = row.Cells[1].Value.ToString();
                tbsl.Text = row.Cells[2].Value.ToString();
                if (String.Compare(row.Cells[3].Value.ToString(), "Nam", true) == 0) ranam.Checked = true;
                else ranu.Checked = true;
                tbgn.Text = row.Cells[4].Value.ToString();
                tbgb.Text = row.Cells[5].Value.ToString();
                cbncc.Text = row.Cells[6].Value.ToString();
                img1 = row.Cells[7].Value.ToString();
                try
                {
                    if (img1 != "")
                    {
                        pbanh.Image = new Bitmap(Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "Img/" + img1);
                        pbanh.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                catch (Exception ie)
                {
                    MessageBox.Show("loi");
                }
            }
        }
        private void SP_FormClosed(object sender, FormClosedEventArgs e)
        {
            tt = 0;
            new Home().Show();
        }
        private void btthem_Click(object sender, EventArgs e)
        {
            tt = 1;

            btthem.Enabled = false;
            bthuy.Enabled = true;
            btcn.Enabled = false;
            btxoa.Enabled = false;
            bththi.Enabled = false;
            bttk.Enabled = false;
            tbma.Enabled = true;
            tbten.Enabled = true;
            tbsl.Enabled = true;
            ranam.Enabled = true;
            ranu.Enabled = true;
            tbgn.Enabled = true;
            tbgb.Enabled = true;
            cbncc.Enabled = true;
            btopen.Enabled = true;
            btluu.Enabled = true;
            dtgv.Enabled = false;

            tbma.Text = "";
            tbten.Text = "";
            tbsl.Value = 0;
            ranam.Checked = true;
            tbgn.Value = 1000;
            tbgb.Value = 0;
            cbncc.Text = "";
            pbanh.Image = null;
        }
        private void bthuy_Click(object sender, EventArgs e)
        {
            tt = 0;
            masp = "";
            bthuy.Enabled = false;
            btthem.Enabled = true;
            btcn.Enabled = true;
            btxoa.Enabled = true;
            bththi.Enabled = true;
            bttk.Enabled = true;
            tbma.Enabled = false;
            tbten.Enabled = false;
            tbsl.Enabled = false;
            ranam.Enabled = false;
            ranu.Enabled = false;
            tbgn.Enabled = false;
            tbgb.Enabled = false;
            cbncc.Enabled = false;
            btopen.Enabled = false;
            btluu.Enabled = false;
            dtgv.Enabled = true;
            bttim.Visible = false;
            cbmasp.Visible = false;

            tbma.Text = "";
            tbten.Text = "";
            tbsl.Text = "";
            ranam.Checked = true;
            tbgn.Text = "";
            tbgb.Text = "";
            cbncc.Text = "";
            pbanh.Image = null;
        }

        private void btcn_Click(object sender, EventArgs e)
        {
            if (masp == "") MessageBox.Show("Hãy chọn dòng để cập nhật!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                tt = 2;
                btthem.Enabled = false;
                bthuy.Enabled = true;
                btcn.Enabled = false;
                btxoa.Enabled = false;
                bththi.Enabled = false;
                bttk.Enabled = false;
                tbma.Enabled = true;
                tbten.Enabled = true;
                tbsl.Enabled = true;
                ranam.Enabled = true;
                ranu.Enabled = true;
                tbgn.Enabled = true;
                tbgb.Enabled = true;
                cbncc.Enabled = true;
                btopen.Enabled = true;
                btluu.Enabled = true;
                dtgv.Enabled = false;
            }
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (masp == "") MessageBox.Show("Hãy chọn dòng để thực hiện xóa!!!");
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa mẫu tin?", "Xóa SP", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    String sql = "Delete from SanPham where masp='" + masp + "';";
                    if (conn.ChangeData(sql))
                    {
                        tt = 0;
                        masp = "";
                        tbma.Text = "";
                        tbten.Text = "";
                        tbsl.Text = "";
                        ranam.Checked = true;
                        tbgn.Value = 1000;
                        tbgb.Value = 0;
                        cbncc.Text = "";
                        pbanh.Image = null;
                        SetData();
                        MessageBox.Show("Xóa sản phẩm thành công.", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btluu_Click(object sender, EventArgs e)
        {
            Boolean kttt = true;
            ktma.Visible = false;
            ktten.Visible = false;
            ktgn.Visible = false;
            ktncc.Visible = false;
            ktanh.Visible = false;
            
            {
                if (tt == 1)
                {
                    for (int i = 0; i < cbmasp.Items.Count; i++)
                    {
                        if (tbma.Text.Trim().ToLower() == cbmasp.Items[i].ToString().Trim().ToLower() || tbma.Text == "")
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
                    if (cbncc.Text == "")
                    {
                        kttt = false;
                        ktncc.Visible = true;
                    }
                    if (kttt)
                    {
                        String loai, anh;
                        if (ranam.Checked) loai = "Nam";
                        else loai = "Nữ";
                        if (tbgb.Value == 0 || tbgb.Value < tbgn.Value) tbgb.Value = tbgn.Value * 110 / 100;
                        if (!File.Exists(source))
                        {
                            if (pbanh == null) anh = "";
                            else anh = img;
                            if (pbanh.Image != null)
                            {
                                File.Copy(get, source);
                            }
                            String sql = "Insert into SanPham values ('" + tbma.Text + "',N'" + tbten.Text + "',N'" + loai + "'," + tbsl.Value + "," + tbgn.Value + ",'" + tbgb.Value.ToString() + "','" + cbncc.Text + "',N'" + anh + "');";

                            if (conn.ChangeData(sql))
                            {
                                SetData();
                                MessageBox.Show("Thêm sản phẩm thành công.", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else ktanh.Visible = true;
                    }
                    else MessageBox.Show("Vui lòng điền đúng thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            {
                if (tt == 2)
                {
                    for (int i = 0; i < cbmasp.Items.Count; i++)
                    {
                        if (tbma.Text.Trim().ToLower() == cbmasp.Items[i].ToString().Trim().ToLower() && tbma.Text.Trim().ToLower() != masp.Trim().ToLower() || tbma.Text == "")
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
                    if (cbncc.Text == "")
                    {
                        kttt = false;
                        ktncc.Visible = true;
                    }
                    if (kttt)
                    {
                        if (!File.Exists(source))
                        {
                            String loai;
                            if (ranam.Checked) loai = "Nam";
                            else loai = "Nữ";
                            if (tbgb.Value == 0 || tbgb.Value < tbgn.Value) tbgb.Value = tbgn.Value * 110 / 100;

                            if (source != "")
                            {
                                try
                                {

                                    File.Delete(Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "Img/" + img1);
                                    File.Copy(get, source);
                                }
                                catch(Exception ie)
                                {
                                    MessageBox.Show("Có lỗi trong quá trình nạp ảnh");
                                }
                            }
                            if (img != "") img1 = img;
                            String sql = "Update SanPham Set masp='" + tbma.Text + "',tensp=N'" + tbten.Text + "',loai=N'" + loai + "',sl='" + tbsl.Value + "',dgnhap='" + tbgn.Value + "',dgban='" + tbgb.Value.ToString() + "',mancc='" + cbncc.Text + "',anh=N'" + img1 + "' where masp='" + masp + "'";

                            if (conn.ChangeData(sql))
                            {
                                SetData();
                                tt = 0;
                                masp = "";
                                source = "";
                                img = "";
                                {
                                    bthuy.Enabled = false;
                                    btthem.Enabled = true;
                                    btcn.Enabled = true;
                                    btxoa.Enabled = true;
                                    bththi.Enabled = true;
                                    bttk.Enabled = true;
                                    tbma.Enabled = false;
                                    tbten.Enabled = false;
                                    tbsl.Enabled = false;
                                    ranam.Enabled = false;
                                    ranu.Enabled = false;
                                    tbgn.Enabled = false;
                                    tbgb.Enabled = false;
                                    cbncc.Enabled = false;
                                    btopen.Enabled = false;
                                    btluu.Enabled = false;
                                    dtgv.Enabled = true;

                                    tbma.Text = "";
                                    tbten.Text = "";
                                    tbsl.Text = "";
                                    ranam.Checked = true;
                                    tbgn.Value = 1000;
                                    tbgb.Value = 0;
                                    cbncc.Text = "";
                                    pbanh.Image = null;
                                }
                                MessageBox.Show("Cập nhật sản phẩm thành công.", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                        else ktanh.Visible = true;
                    }
                    else MessageBox.Show("Vui lòng điền đúng thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            img = "";
            source = "";
            if (open.ShowDialog() == DialogResult.OK)
            {
                get = @open.FileName;
                String[] link = get.Split('\\');
                img = link[link.Length - 1];
                source = Application.StartupPath.Substring(0, Application.StartupPath.Length - 9) + "Img/" + img;

                pbanh.Image = Image.FromFile(get);
                pbanh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void bththi_Click(object sender, EventArgs e)
        {
            SetData();
        }

        private void bttk_Click(object sender, EventArgs e)
        {
            tt = 3;
            btthem.Enabled = false;
            bthuy.Enabled = true;
            btcn.Enabled = false;
            btxoa.Enabled = false;
            bttk.Enabled = false;
            tbma.Enabled = true;
            tbten.Enabled = true;
            ranam.Enabled = true;
            ranu.Enabled = true;
            cbncc.Enabled = true;
            bttim.Visible = true;
            cbmasp.Visible = true;

            cbmasp.Text = "";
            tbma.Text = "";
            tbten.Text = "";
            tbsl.Value = 0;
            ranam.Checked = true;
            tbgn.Value = 1000;
            tbgb.Value = 0;
            cbncc.Text = "";
            pbanh.Image = null;
        }

        private void bttim_Click(object sender, EventArgs e)
        {
            SetData();
            Boolean kt;
            for (int i = data.Rows.Count - 1; i >= 0; i--)
            {
                kt = false;
                if (!data.Rows[i][0].ToString().ToLower().Contains(cbmasp.Text.ToLower())) kt = true;
                if (!data.Rows[i][1].ToString().ToLower().Contains(tbten.Text.ToLower())) kt = true;
                String loai;
                if (ranam.Checked) loai = "Nam";
                else loai = "Nữ";
                if (data.Rows[i][3].ToString() != loai) kt = true;
                if (!data.Rows[i][6].ToString().ToLower().Contains(cbncc.Text.ToLower())) kt = true;
                if (kt) data.Rows[i].Delete();           
            }
            dtgv.DataSource = data;
        }
    }
}