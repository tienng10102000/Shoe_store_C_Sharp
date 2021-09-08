namespace App.NET
{
    partial class NV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NV));
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.kttk = new System.Windows.Forms.Label();
            this.cbtk = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.bthuy = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btadd = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btcn = new System.Windows.Forms.Button();
            this.refesh = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgv.Location = new System.Drawing.Point(0, 25);
            this.dtgv.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.Size = new System.Drawing.Size(758, 263);
            this.dtgv.TabIndex = 3;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "Mã NV";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên NV";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "SĐT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tài khoản";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kttk);
            this.groupBox1.Controls.Add(this.cbtk);
            this.groupBox1.Controls.Add(this.label5);
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
            this.groupBox1.Location = new System.Drawing.Point(39, 24);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(759, 283);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // kttk
            // 
            this.kttk.AutoSize = true;
            this.kttk.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kttk.ForeColor = System.Drawing.Color.Red;
            this.kttk.Location = new System.Drawing.Point(475, 232);
            this.kttk.Name = "kttk";
            this.kttk.Size = new System.Drawing.Size(35, 31);
            this.kttk.TabIndex = 39;
            this.kttk.Text = "* ";
            this.kttk.Visible = false;
            // 
            // cbtk
            // 
            this.cbtk.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbtk.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbtk.Enabled = false;
            this.cbtk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtk.FormattingEnabled = true;
            this.cbtk.Location = new System.Drawing.Point(215, 232);
            this.cbtk.Name = "cbtk";
            this.cbtk.Size = new System.Drawing.Size(254, 34);
            this.cbtk.TabIndex = 38;
            this.cbtk.SelectedIndexChanged += new System.EventHandler(this.cbtk_SelectedIndexChanged);
            this.cbtk.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbtk_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(62, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 26);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tài khoản:";
            // 
            // sdttt
            // 
            this.sdttt.AutoSize = true;
            this.sdttt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sdttt.ForeColor = System.Drawing.Color.Red;
            this.sdttt.Location = new System.Drawing.Point(390, 202);
            this.sdttt.Name = "sdttt";
            this.sdttt.Size = new System.Drawing.Size(88, 20);
            this.sdttt.TabIndex = 36;
            this.sdttt.Text = "Đã tồn tại";
            this.sdttt.Visible = false;
            // 
            // ktsdt
            // 
            this.ktsdt.AutoSize = true;
            this.ktsdt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktsdt.ForeColor = System.Drawing.Color.Red;
            this.ktsdt.Location = new System.Drawing.Point(475, 167);
            this.ktsdt.Name = "ktsdt";
            this.ktsdt.Size = new System.Drawing.Size(35, 31);
            this.ktsdt.TabIndex = 32;
            this.ktsdt.Text = "* ";
            this.ktsdt.Visible = false;
            // 
            // ktten
            // 
            this.ktten.AutoSize = true;
            this.ktten.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktten.ForeColor = System.Drawing.Color.Red;
            this.ktten.Location = new System.Drawing.Point(475, 78);
            this.ktten.Name = "ktten";
            this.ktten.Size = new System.Drawing.Size(35, 31);
            this.ktten.TabIndex = 31;
            this.ktten.Text = "* ";
            this.ktten.Visible = false;
            // 
            // ktma
            // 
            this.ktma.AutoSize = true;
            this.ktma.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktma.ForeColor = System.Drawing.Color.Red;
            this.ktma.Location = new System.Drawing.Point(475, 32);
            this.ktma.Name = "ktma";
            this.ktma.Size = new System.Drawing.Size(35, 31);
            this.ktma.TabIndex = 30;
            this.ktma.Text = "* ";
            this.ktma.Visible = false;
            // 
            // masksdt
            // 
            this.masksdt.Enabled = false;
            this.masksdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masksdt.Location = new System.Drawing.Point(215, 171);
            this.masksdt.Mask = "(999) 000-0000";
            this.masksdt.Name = "masksdt";
            this.masksdt.Size = new System.Drawing.Size(254, 32);
            this.masksdt.TabIndex = 17;
            this.masksdt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.masksdt_MaskInputRejected);
            this.masksdt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.masksdt_KeyUp);
            // 
            // cbma
            // 
            this.cbma.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbma.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbma.FormattingEnabled = true;
            this.cbma.Location = new System.Drawing.Point(215, 36);
            this.cbma.Name = "cbma";
            this.cbma.Size = new System.Drawing.Size(254, 34);
            this.cbma.TabIndex = 16;
            this.cbma.Visible = false;
            this.cbma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbma_KeyUp);
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.Image = global::App.NET.Properties.Resources.logout;
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexit.Location = new System.Drawing.Point(553, 127);
            this.btexit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btexit.Name = "btexit";
            this.btexit.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btexit.Size = new System.Drawing.Size(151, 49);
            this.btexit.TabIndex = 15;
            this.btexit.Text = "Thoát";
            this.btexit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btexit.UseVisualStyleBackColor = true;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // btluu
            // 
            this.btluu.Enabled = false;
            this.btluu.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btluu.Image = global::App.NET.Properties.Resources.iconfinder_floppy_285657;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(553, 202);
            this.btluu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btluu.Name = "btluu";
            this.btluu.Padding = new System.Windows.Forms.Padding(5, 0, 30, 0);
            this.btluu.Size = new System.Drawing.Size(151, 49);
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
            this.tbdc.Location = new System.Drawing.Point(215, 127);
            this.tbdc.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbdc.Name = "tbdc";
            this.tbdc.Size = new System.Drawing.Size(254, 32);
            this.tbdc.TabIndex = 13;
            this.tbdc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbdc_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(62, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Địa chỉ:";
            // 
            // bttk
            // 
            this.bttk.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttk.Image = global::App.NET.Properties.Resources.Search;
            this.bttk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttk.Location = new System.Drawing.Point(553, 54);
            this.bttk.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(151, 49);
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
            this.tbten.Location = new System.Drawing.Point(215, 82);
            this.tbten.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(254, 32);
            this.tbten.TabIndex = 7;
            this.tbten.TextChanged += new System.EventHandler(this.tbten_TextChanged);
            this.tbten.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbten_KeyUp);
            // 
            // tbma
            // 
            this.tbma.Enabled = false;
            this.tbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbma.Location = new System.Drawing.Point(215, 37);
            this.tbma.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbma.Name = "tbma";
            this.tbma.Size = new System.Drawing.Size(254, 32);
            this.tbma.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // bthuy
            // 
            this.bthuy.Enabled = false;
            this.bthuy.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.Image = global::App.NET.Properties.Resources.cancel;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.Location = new System.Drawing.Point(582, 324);
            this.bthuy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bthuy.Name = "bthuy";
            this.bthuy.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.bthuy.Size = new System.Drawing.Size(139, 48);
            this.bthuy.TabIndex = 11;
            this.bthuy.Text = "Hủy";
            this.bthuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 415);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(758, 288);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhân viên";
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Image = global::App.NET.Properties.Resources.anhadd;
            this.btadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btadd.Location = new System.Drawing.Point(40, 324);
            this.btadd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btadd.Name = "btadd";
            this.btadd.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btadd.Size = new System.Drawing.Size(151, 49);
            this.btadd.TabIndex = 15;
            this.btadd.Text = "Thêm";
            this.btadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Image = global::App.NET.Properties.Resources.Delete;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(417, 324);
            this.btxoa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btxoa.Name = "btxoa";
            this.btxoa.Padding = new System.Windows.Forms.Padding(5, 0, 10, 0);
            this.btxoa.Size = new System.Drawing.Size(136, 49);
            this.btxoa.TabIndex = 16;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btcn
            // 
            this.btcn.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcn.Image = global::App.NET.Properties.Resources.Update;
            this.btcn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcn.Location = new System.Drawing.Point(223, 324);
            this.btcn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btcn.Name = "btcn";
            this.btcn.Size = new System.Drawing.Size(163, 49);
            this.btcn.TabIndex = 17;
            this.btcn.Text = "Cập nhật";
            this.btcn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcn.UseVisualStyleBackColor = true;
            this.btcn.Click += new System.EventHandler(this.btcn_Click);
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
            this.refesh.Location = new System.Drawing.Point(687, 376);
            this.refesh.Name = "refesh";
            this.refesh.Size = new System.Drawing.Size(123, 22);
            this.refesh.TabIndex = 25;
            this.refesh.TabStop = true;
            this.refesh.Text = "Làm mới";
            this.refesh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refesh.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.refesh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refesh_LinkClicked_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(806, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(758, 605);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách tài khoản";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(758, 573);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 60F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Họ tên";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Tài khoản";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Mật khẩu";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Câu trả lời đặc biệt";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Nhớ tài khoản";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // NV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 701);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.refesh);
            this.Controls.Add(this.btcn);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "NV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NHÂN VIÊN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NV_FormClosed);
            this.Load += new System.EventHandler(this.NV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.TextBox tbma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.TextBox tbdc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btcn;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.ComboBox cbma;
        private System.Windows.Forms.MaskedTextBox masksdt;
        private System.Windows.Forms.Label ktsdt;
        private System.Windows.Forms.Label ktten;
        private System.Windows.Forms.Label ktma;
        private System.Windows.Forms.Label sdttt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.LinkLabel refesh;
        private System.Windows.Forms.Label kttk;
        private System.Windows.Forms.ComboBox cbtk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

