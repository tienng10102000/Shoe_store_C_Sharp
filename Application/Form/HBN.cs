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
    public partial class HDN : Form
    {
        SQLConnection conn = new SQLConnection();
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        String MaHD = "";
        int index = -1;
        
        public HDN()
        {
            InitializeComponent();
        }
        public void SetData()
        {
            String sql = "Select manv, tennv, tentk from NhanVien;";
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
            sql = "Select sp.masp, sp.tensp, sp.mancc, NCC.tenncc from SanPham sp, NCC where sp.mancc = NCC.mancc order by sp.masp;";
            if (conn.GetIn4(sql))
            {
                dt2 = conn.data;
                cbmsp.Items.Clear();
                foreach (DataRow dtRow in dt2.Rows)
                {
                    cbmsp.Items.Add(dtRow[0].ToString());
                }
            }
            else MessageBox.Show("Không thể kết nối.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void HDN_Load(object sender, EventArgs e)
        {
            mahd.Enabled = false;
            SetData();
            dt.Columns.Add("MaNV");
            dt.Columns.Add("MaSP");
            dt.Columns.Add("NN");
            dt.Columns.Add("SL");
            dt.Columns.Add("DGN");
            dt.Columns.Add("DGB");
        }

        private void HDN_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Home().Show();
        }

        private void cbmsp_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbmsp.SelectedIndex != -1)
            {
                String masp = cbmsp.SelectedItem.ToString();
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    if (masp == dt2.Rows[i][0].ToString())
                    {
                        tbsp.Text = dt2.Rows[i][1].ToString();
                        cbncc.Text = dt2.Rows[i][2].ToString();
                        tbncc.Text = dt2.Rows[i][3].ToString();
                        break;
                    }
                }
            }
        }

        private void btnhap_Click(object sender, EventArgs e)
        {
            String tennv = tbtnv.Text.Trim();
            String tensp = tbsp.Text.Trim();
            String nn = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString();
            String sl = tbsl.Value.ToString();
            String dgn = tbgn.Value.ToString();
            String dgb;
            cbmnv.Enabled = false;
            ktnv.Visible = false;
            ktsp.Visible = false;
            Boolean kt = true;
            if (tennv == "")
            {
                ktnv.Visible = true;
                kt = false;
            }
            if (tensp == "")
            {
                ktsp.Visible = true;
                kt = false;
            }
            if (kt)
            {
                if (tbgb.Value <= tbgn.Value)
                {
                    dgb = (tbgn.Value * 110 / 100).ToString();
                }
                else dgb = tbgb.Value.ToString();
                dtgv.Rows.Add(tennv, tensp, nn, sl, dgn, dgb);
                dt.Rows.Add(cbmnv.Text, cbmsp.Text, nn, sl, dgn, dgb);
                cbmsp.SelectedIndex = -1;
                cbncc.Text = "";
                tbncc.Text = "";
                tbsp.Text = "";
                tbsl.Value = 1;
                tbgn.Value = 1000;
                tbgb.Value = 0;
                btlhd.Enabled = true;
                btxoa.Enabled = true;
                bthuy.Enabled = true;

                ktnn.Enabled = false;
            }
            else MessageBox.Show("Vui lòng điền đúng thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btdate_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            MaHD = "HDN" + date.Day + date.Month + date.Year + date.Hour + date.Minute + date.Second;
            mahd.Text = MaHD;
            tbnn.Text = date.ToString();
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
                    String sql = "Insert into HDN(mahd,manv,masp,ngaynhap,soluong,dgnhap,dgban) values ('" + MaHD + "','";
                    String sql1 = "Update SanPham Set sl=sl+" + dt.Rows[row][3].ToString().Trim() + ",dgnhap='" + dt.Rows[row][4].ToString().Trim() + "',dgban='" + dt.Rows[row][5].ToString().Trim() + "' where masp='" + dt.Rows[row][1].ToString().Trim() + "';";
                    for(int i = 0; i < 5; i++)
                    {
                        sql += dt.Rows[row][i].ToString().Trim() + "','";
                    }
                    sql += dt.Rows[row][5].ToString().Trim() + "');";
                    if (conn.ChangeData(sql) && conn.ChangeData(sql1))
                    { }
                    else
                    {
                        kt = false;
                        MessageBox.Show(dtgv.Rows[row].Cells[1].Value.ToString().Trim() + " thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (kt)
                {
                    RPHDN.MaHD = MaHD;
                    MessageBox.Show("Lập hóa đơn thành công.", "LHĐ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btlhd.Enabled = false;
                    btxoa.Enabled = false;
                    ktnn.Enabled = true;
                    cbmnv.Enabled = true;
                    bthuy.Enabled = false;
                    ktnn.Visible = false;
                    dt.Rows.Clear();
                    dtgv.Rows.Clear();
                    MaHD = "";
                    mahd.Text = "";
                    tbnn.Text = "";
                    new RPHDN().ShowDialog();
                }
                else MessageBox.Show("Vui lòng điền đúng thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            if (index > -1)
            {
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
                    cbncc.SelectedIndex = -1;
                    tbncc.Text = "";
                    cbmsp.SelectedIndex = -1;
                    tbsp.Text = "";
                    tbsl.Value = 1;
                    tbgn.Value = 1000;
                    tbgb.Value = 0;
                }
            }
            else MessageBox.Show("Vui lòng chọn dữ liệu cần xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn hủy hóa đơn?", "Hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                ktnn.Enabled = true;
                cbmnv.Enabled = true;
                mahd.Text = "";
                MaHD = "";
                dtgv.Rows.Clear();
                dt.Rows.Clear();
                index = -1;
                btlhd.Enabled = false;
                bthuy.Enabled = false;
                btxoa.Enabled = false;
                tbnn.Text = "";
                cbncc.SelectedIndex = -1;
                tbncc.Text = "";
                cbmsp.SelectedIndex = -1;
                tbsp.Text = "";
                tbsl.Value = 1;
                tbgn.Value = 1000;
                tbgb.Value = 0;
            }
        }
        private void tbsl_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
