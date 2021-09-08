namespace App.NET
{
    partial class KH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KH));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbvip = new System.Windows.Forms.CheckBox();
            this.sdttt = new System.Windows.Forms.Label();
            this.ktsdt = new System.Windows.Forms.Label();
            this.ktten = new System.Windows.Forms.Label();
            this.ktma = new System.Windows.Forms.Label();
            this.masksdt = new System.Windows.Forms.MaskedTextBox();
            this.cbma = new System.Windows.Forms.ComboBox();
            this.btexit = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.tbdc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttk = new System.Windows.Forms.Button();
            this.tbten = new System.Windows.Forms.TextBox();
            this.tbma = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refesh = new System.Windows.Forms.LinkLabel();
            this.btcn = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.manv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vip = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 428);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(912, 394);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manv,
            this.tennv,
            this.diachi,
            this.sdt,
            this.vip});
            this.dtgv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgv.Location = new System.Drawing.Point(0, 31);
            this.dtgv.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.Size = new System.Drawing.Size(912, 363);
            this.dtgv.TabIndex = 3;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbvip);
            this.groupBox1.Controls.Add(this.sdttt);
            this.groupBox1.Controls.Add(this.ktsdt);
            this.groupBox1.Controls.Add(this.ktten);
            this.groupBox1.Controls.Add(this.ktma);
            this.groupBox1.Controls.Add(this.masksdt);
            this.groupBox1.Controls.Add(this.cbma);
            this.groupBox1.Controls.Add(this.btexit);
            this.groupBox1.Controls.Add(this.btluu);
            this.groupBox1.Controls.Add(this.tbdc);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.bttk);
            this.groupBox1.Controls.Add(this.tbten);
            this.groupBox1.Controls.Add(this.tbma);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(912, 289);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // cbvip
            // 
            this.cbvip.AutoSize = true;
            this.cbvip.Enabled = false;
            this.cbvip.Location = new System.Drawing.Point(564, 57);
            this.cbvip.Name = "cbvip";
            this.cbvip.Size = new System.Drawing.Size(74, 29);
            this.cbvip.TabIndex = 37;
            this.cbvip.Text = "VIP";
            this.cbvip.UseVisualStyleBackColor = true;
            // 
            // sdttt
            // 
            this.sdttt.AutoSize = true;
            this.sdttt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdttt.ForeColor = System.Drawing.Color.Red;
            this.sdttt.Location = new System.Drawing.Point(426, 258);
            this.sdttt.Name = "sdttt";
            this.sdttt.Size = new System.Drawing.Size(88, 20);
            this.sdttt.TabIndex = 36;
            this.sdttt.Text = "Đã tồn tại";
            this.sdttt.Visible = false;
            // 
            // ktsdt
            // 
            this.ktsdt.AutoSize = true;
            this.ktsdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktsdt.ForeColor = System.Drawing.Color.Red;
            this.ktsdt.Location = new System.Drawing.Point(522, 217);
            this.ktsdt.Name = "ktsdt";
            this.ktsdt.Size = new System.Drawing.Size(35, 32);
            this.ktsdt.TabIndex = 32;
            this.ktsdt.Text = "* ";
            this.ktsdt.Visible = false;
            // 
            // ktten
            // 
            this.ktten.AutoSize = true;
            this.ktten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktten.ForeColor = System.Drawing.Color.Red;
            this.ktten.Location = new System.Drawing.Point(522, 105);
            this.ktten.Name = "ktten";
            this.ktten.Size = new System.Drawing.Size(35, 32);
            this.ktten.TabIndex = 31;
            this.ktten.Text = "* ";
            this.ktten.Visible = false;
            // 
            // ktma
            // 
            this.ktma.AutoSize = true;
            this.ktma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktma.ForeColor = System.Drawing.Color.Red;
            this.ktma.Location = new System.Drawing.Point(522, 49);
            this.ktma.Name = "ktma";
            this.ktma.Size = new System.Drawing.Size(35, 32);
            this.ktma.TabIndex = 30;
            this.ktma.Text = "* ";
            this.ktma.Visible = false;
            // 
            // masksdt
            // 
            this.masksdt.Enabled = false;
            this.masksdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masksdt.Location = new System.Drawing.Point(228, 222);
            this.masksdt.Mask = "(999) 000-0000";
            this.masksdt.Name = "masksdt";
            this.masksdt.Size = new System.Drawing.Size(288, 32);
            this.masksdt.TabIndex = 17;
            // 
            // cbma
            // 
            this.cbma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbma.FormattingEnabled = true;
            this.cbma.Location = new System.Drawing.Point(228, 54);
            this.cbma.Name = "cbma";
            this.cbma.Size = new System.Drawing.Size(286, 34);
            this.cbma.TabIndex = 16;
            this.cbma.Visible = false;
            this.cbma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbma_KeyUp);
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btexit.Image = global::App.NET.Properties.Resources.logout;
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexit.Location = new System.Drawing.Point(663, 120);
            this.btexit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btexit.Name = "btexit";
            this.btexit.Padding = new System.Windows.Forms.Padding(0, 0, 22, 0);
            this.btexit.Size = new System.Drawing.Size(170, 62);
            this.btexit.TabIndex = 15;
            this.btexit.Text = "Thoát";
            this.btexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btluu
            // 
            this.btluu.Enabled = false;
            this.btluu.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btluu.Image = global::App.NET.Properties.Resources.iconfinder_floppy_285657;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(663, 202);
            this.btluu.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btluu.Name = "btluu";
            this.btluu.Padding = new System.Windows.Forms.Padding(0, 0, 45, 0);
            this.btluu.Size = new System.Drawing.Size(170, 62);
            this.btluu.TabIndex = 14;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // tbdc
            // 
            this.tbdc.Enabled = false;
            this.tbdc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbdc.Location = new System.Drawing.Point(228, 166);
            this.tbdc.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbdc.Name = "tbdc";
            this.tbdc.Size = new System.Drawing.Size(288, 32);
            this.tbdc.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa chỉ:";
            // 
            // bttk
            // 
            this.bttk.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bttk.Image = global::App.NET.Properties.Resources.Search;
            this.bttk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttk.Location = new System.Drawing.Point(663, 37);
            this.bttk.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(170, 62);
            this.bttk.TabIndex = 9;
            this.bttk.Text = "Tìm kiếm";
            this.bttk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.bttk_Click);
            // 
            // tbten
            // 
            this.tbten.Enabled = false;
            this.tbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbten.Location = new System.Drawing.Point(228, 111);
            this.tbten.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(288, 32);
            this.tbten.TabIndex = 7;
            // 
            // tbma
            // 
            this.tbma.Enabled = false;
            this.tbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbma.Location = new System.Drawing.Point(228, 54);
            this.tbma.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.tbma.Name = "tbma";
            this.tbma.Size = new System.Drawing.Size(286, 32);
            this.tbma.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã khách hàng:";
            // 
            // refesh
            // 
            this.refesh.ActiveLinkColor = System.Drawing.Color.Red;
            this.refesh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refesh.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refesh.Image = global::App.NET.Properties.Resources.Re_fesh;
            this.refesh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.refesh.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.refesh.LinkColor = System.Drawing.Color.Blue;
            this.refesh.Location = new System.Drawing.Point(831, 409);
            this.refesh.Name = "refesh";
            this.refesh.Size = new System.Drawing.Size(138, 28);
            this.refesh.TabIndex = 24;
            this.refesh.TabStop = true;
            this.refesh.Text = "Làm mới";
            this.refesh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refesh.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.refesh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refesh_LinkClicked);
            // 
            // btcn
            // 
            this.btcn.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btcn.Image = global::App.NET.Properties.Resources.Update;
            this.btcn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcn.Location = new System.Drawing.Point(308, 343);
            this.btcn.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btcn.Name = "btcn";
            this.btcn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btcn.Size = new System.Drawing.Size(183, 62);
            this.btcn.TabIndex = 23;
            this.btcn.Text = "Cập nhật";
            this.btcn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcn.UseVisualStyleBackColor = true;
            this.btcn.Click += new System.EventHandler(this.btcn_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btxoa.Image = global::App.NET.Properties.Resources.Delete;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(524, 343);
            this.btxoa.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btxoa.Name = "btxoa";
            this.btxoa.Padding = new System.Windows.Forms.Padding(12, 0, 16, 0);
            this.btxoa.Size = new System.Drawing.Size(153, 62);
            this.btxoa.TabIndex = 22;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btadd.Image = global::App.NET.Properties.Resources.anhadd;
            this.btadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btadd.Location = new System.Drawing.Point(111, 343);
            this.btadd.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btadd.Name = "btadd";
            this.btadd.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.btadd.Size = new System.Drawing.Size(170, 62);
            this.btadd.TabIndex = 21;
            this.btadd.Text = "Thêm";
            this.btadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // bthuy
            // 
            this.bthuy.Enabled = false;
            this.bthuy.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bthuy.Image = global::App.NET.Properties.Resources.cancel;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.Location = new System.Drawing.Point(708, 343);
            this.bthuy.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.bthuy.Name = "bthuy";
            this.bthuy.Padding = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.bthuy.Size = new System.Drawing.Size(150, 60);
            this.bthuy.TabIndex = 20;
            this.bthuy.Text = "Hủy";
            this.bthuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // manv
            // 
            this.manv.FillWeight = 61.49732F;
            this.manv.HeaderText = "Mã KH";
            this.manv.MinimumWidth = 6;
            this.manv.Name = "manv";
            this.manv.ReadOnly = true;
            // 
            // tennv
            // 
            this.tennv.FillWeight = 120.2499F;
            this.tennv.HeaderText = "Tên khách hàng";
            this.tennv.MinimumWidth = 6;
            this.tennv.Name = "tennv";
            this.tennv.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.FillWeight = 120.2499F;
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.FillWeight = 120.2499F;
            this.sdt.HeaderText = "SĐT";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // vip
            // 
            this.vip.FillWeight = 37.75289F;
            this.vip.HeaderText = "VIP";
            this.vip.MinimumWidth = 6;
            this.vip.Name = "vip";
            this.vip.ReadOnly = true;
            this.vip.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.vip.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // KH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 849);
            this.Controls.Add(this.refesh);
            this.Controls.Add(this.btcn);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KHÁCH HÀNG";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KH_FormClosed);
            this.Load += new System.EventHandler(this.KH_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btcn;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label sdttt;
        private System.Windows.Forms.Label ktsdt;
        private System.Windows.Forms.Label ktten;
        private System.Windows.Forms.Label ktma;
        private System.Windows.Forms.MaskedTextBox masksdt;
        private System.Windows.Forms.ComboBox cbma;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.TextBox tbdc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.TextBox tbma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbvip;
        private System.Windows.Forms.LinkLabel refesh;
        private System.Windows.Forms.DataGridViewTextBoxColumn manv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewCheckBoxColumn vip;
    }
}

