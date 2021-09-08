using App.NET.Class;
using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace App.NET
{
    public partial class HDB : Form
    {
        public static Boolean tkkh = false;
        SQLConnection conn = new SQLConnection();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        String MaHD = "";
        int index = -1;
        
        public HDB()
        {
            InitializeComponent();
        }
        public void SetData()
        {
            String sql = "Select manv, tennv, tentk from NhanVien";
            if (conn.GetIn4(sql))
            {
                dt1 = conn.data;
                cbmnv.Items.Clear();
                foreach (DataRow dtRow in dt1.Rows)
                {
                    cbmnv.Items.Add(dtRow[0].ToString());
                    if (SignIn.tk == dtRow[2].ToString())
                    {
                        cbmnv.Text = dtRow[0].ToString();
                        tbtnv.Text = dtRow[1].ToString();
                    }
                }
            }
            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            sql = "Select * from KhachHang";
            if (conn.GetIn4(sql))
            {
                dt2 = conn.data;
                cbmkh.Items.Clear();
                foreach (DataRow dtRow in dt2.Rows)
                {
                    cbmkh.Items.Add(dtRow[0].ToString());
                }
            }
            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            sql = "Select masp, tensp, dgban, sl from SanPham";
            if (conn.GetIn4(sql))
            {
                dt3 = conn.data;
                cbmsp.Items.Clear();
                foreach (DataRow dtRow in dt3.Rows)
                {
                    cbmsp.Items.Add(dtRow[0].ToString());
                }
            }
            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbsl_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Home().Show();
        }

        private void tbsl_Load(object sender, EventArgs e)
        {
            tbtt.Enabled = false;
            tbsum.Enabled = false;
            mahd.Enabled = false;
            dt.Columns.Add("MaNV");
            dt.Columns.Add("MaKH");
            dt.Columns.Add("MaSP");
            dt.Columns.Add("NgayNhap");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("DGia");
            dt.Columns.Add("GG");
            dt.Columns.Add("TT");
            SetData();
        }

        private void btdate_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            MaHD = "HDB" + date.Day + date.Month + date.Year +"_"+ date.Hour + date.Minute + date.Second;
            mahd.Text = MaHD;
            tbnn.Text = date.ToString();
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void cbmnv_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbmnv.SelectedIndex != -1)
            {
                String manv = cbmnv.SelectedItem.ToString();
                for (int i = 0; i < dt1.Rows.Count; i++)
                {
                    if (manv == dt1.Rows[i][0].ToString())
                    {
                        tbtnv.Text = dt1.Rows[i][1].ToString();
                        break;
                    }
                }
            }
        }

        private void cbmkh_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbmkh.SelectedIndex != -1)
            {
                String makh = cbmkh.SelectedItem.ToString();
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if (makh == dt2.Rows[i][0].ToString())
                    {
                        tbtkh.Text = dt2.Rows[i][1].ToString();
                        tbdc.Text = dt2.Rows[i][2].ToString();
                        tbsdt.Text = dt2.Rows[i][3].ToString();
                        if (dt2.Rows[i][4].ToString() == "1")
                        {
                            cbvip.Checked = true;
                            tbgg.Value = 10;
                        }
                        else 
                        {
                            cbvip.Checked = false;
                            tbgg.Value = 0;
                        } 
                        break;
                    }
                }
            }
        }

        private void cbmsp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbmsp.SelectedIndex != -1)
            {
                String masp = cbmsp.SelectedItem.ToString();
                for (int i = 0; i < dt3.Rows.Count; i++)
                {
                    if (masp == dt3.Rows[i][0].ToString())
                    {
                        tbtsp.Text = dt3.Rows[i][1].ToString();
                        tbdg.Value = decimal.Parse(dt3.Rows[i][2].ToString());
                        tbsl.Maximum = int.Parse(dt3.Rows[i][3].ToString());
                        break;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbtt.Value = (tbdg.Value * tbsl.Value) * (100 - tbgg.Value) / 100;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (index > -1)
            {
                tbsum.Value = tbsum.Value - decimal.Parse(dtgv.Rows[index].Cells[6].Value.ToString().Trim());
                dtgv.Rows.RemoveAt(index);
                dt.Rows[index].Delete();
                if (index == 0) index = 0;
                else index -= 1;
                if (dtgv.Rows.Count == 0)
                {
                    MaHD = "";
                    dtgv.Rows.Clear();
                    dt.Rows.Clear();
                    index = -1;
                    btlhd.Enabled = false;
                    bthuy.Enabled = false;
                    btxoa.Enabled = false;
                    tbnn.Text = "";
                    cbmsp.SelectedIndex = -1;
                    tbtsp.Text = "";
                    tbsl.Value = 1;
                    tbdg.Value = 0;
                    tbgg.Value = 0;
                    tbtt.Value = 0;
                    tbsum.Value = 0;
                }
            }
            else MessageBox.Show("Vui lòng chọn dữ liệu cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnhap_Click(object sender, EventArgs e)
        {
            btdate.Enabled = false;
            cbmnv.Enabled = false;
            cbmkh.Enabled = false;
            String tennv = tbtnv.Text.Trim();
            String tensp = tbtsp.Text.Trim();
            String tenkh = tbtkh.Text.Trim();
            String nn = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString();
            String sl = tbsl.Value.ToString();
            String dg = tbdg.Value.ToString();
            String tt;
            ktnv.Visible = false;
            ktkh.Visible = false;
            ktsp.Visible = false;
            Boolean kt = true;
            if (tennv == "")
            {
                ktnv.Visible = true;
                kt = false;
            }
            if (tenkh == "")
            {
                ktkh.Visible = true;
                kt = false;
            }
            if (tensp == "")
            {
                ktsp.Visible = true;
                kt = false;
            }
            try
            {
                if (kt)
                {
                    if (tbtt.Value <= tbdg.Value)
                    {
                        tt = ((tbdg.Value * tbsl.Value) * (100 - tbgg.Value) / 100).ToString();
                    }
                    else tt = tbtt.Value.ToString();
                    dtgv.Rows.Add(tennv, tenkh, tensp, nn, dg, sl, tt);
                    dt.Rows.Add(cbmnv.Text, cbmkh.Text, cbmsp.Text, nn, sl, dg, tbgg.Value.ToString(), tt);
                    tbsum.Value = tbsum.Value + decimal.Parse(tt);
                    cbmsp.SelectedIndex = -1;
                    tbtsp.Text = "";
                    tbsl.Value = 1;
                    tbdg.Value = 0;
                    tbtt.Value = 0;
                    bthuy.Enabled = true;
                    btlhd.Enabled = true;
                    btxoa.Enabled = true;
                }
                else MessageBox.Show("Vui lòng điền đúng thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }catch (Exception ie)
                {
                    MessageBox.Show("Có lỗi trong quá trình nhập hóa đơn");
                }
            }

        private void btlhd_Click(object sender, EventArgs e)
        {
            if (tbnn.Text == "")
            {
                ktnn.Visible = true;
            }
            else
            {
                Boolean kt = true;
                for (int row = 0; row < dt.Rows.Count; row++)
                {
                    String sql = "Insert into HDB(mahd,manv,makh,masp,ngaynhap,soluong,dgia,gg,tt) values ('" + MaHD + "','";
                    String sql1 = "Update SanPham Set sl=sl-" + dt.Rows[row][4].ToString().Trim() + " where masp='" + dt.Rows[row][2].ToString().Trim() + "';";
                    for (int i = 0; i < 7; i++)
                    {
                        sql += dt.Rows[row][i].ToString().Trim() + "','";
                    }
                    sql += dt.Rows[row][7].ToString().Trim() + "');";
                    if (conn.ChangeData(sql) && conn.ChangeData(sql1))
                    { }
                    else
                    {
                        kt = false;
                        MessageBox.Show(dtgv.Rows[row].Cells[2].Value.ToString().Trim() + " thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (kt)
                {
                    RPHDB.MaHD = MaHD;
                    dt.Rows.Clear();
                    dtgv.Rows.Clear();
                    cbvip.Checked = false;
                    cbmnv.Enabled = true;
                    btdate.Enabled = true;
                    cbmkh.Enabled = true;
                    cbmsp.Enabled = true;
                    RPHDB r = new RPHDB();
                    r.ShowDialog();
                    
                }
                else MessageBox.Show("Vui lòng điền đúng thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy hóa đơn?", "Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                mahd.Text = "";
                MaHD = "";
                dtgv.Rows.Clear();
                dt.Rows.Clear();
                index = -1;
                btlhd.Enabled = false;
                bthuy.Enabled = false;
                btxoa.Enabled = false;
                tbnn.Text = "";
                cbmkh.SelectedIndex = -1;
                tbtkh.Text = "";
                tbdc.Text = "";
                tbsdt.Text = "";
                cbvip.Checked = false;
                cbmsp.SelectedIndex = -1;
                tbtsp.Text = "";
                tbsl.Value = 1;
                tbdg.Value = 0;
                tbgg.Value = 0;
                tbtt.Value = 0;
                tbsum.Value = 0;
            }
        }

        private void cbmsp_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void tbsl_ValueChanged(object sender, EventArgs e)
        {
            try
            {

                tbtt.Value = (tbdg.Value * tbsl.Value) * (100 - tbgg.Value) / 100;
            }catch(Exception ie)
            {
                MessageBox.Show("Hết hàng");
            }
        }

        private void tbdg_ValueChanged(object sender, EventArgs e)
        {
            tbtt.Value = (tbdg.Value * tbsl.Value) * (100 - tbgg.Value) / 100;
        }

        private void tbgg_ValueChanged(object sender, EventArgs e)
        {
            tbtt.Value = (tbdg.Value * tbsl.Value) * (100 - tbgg.Value) / 100;
        }
    }
}
