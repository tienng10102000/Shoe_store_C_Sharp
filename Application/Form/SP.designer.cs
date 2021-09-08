namespace App.NET
{
    partial class SP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SP));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbma = new System.Windows.Forms.TextBox();
            this.tbten = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btopen = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ktanh = new System.Windows.Forms.Label();
            this.ktncc = new System.Windows.Forms.Label();
            this.ktgn = new System.Windows.Forms.Label();
            this.ktten = new System.Windows.Forms.Label();
            this.ktma = new System.Windows.Forms.Label();
            this.bttim = new System.Windows.Forms.Button();
            this.cbmasp = new System.Windows.Forms.ComboBox();
            this.cbncc = new System.Windows.Forms.ComboBox();
            this.tbgb = new System.Windows.Forms.NumericUpDown();
            this.tbsl = new System.Windows.Forms.NumericUpDown();
            this.tbgn = new System.Windows.Forms.NumericUpDown();
            this.pbanh = new System.Windows.Forms.PictureBox();
            this.ranu = new System.Windows.Forms.RadioButton();
            this.ranam = new System.Windows.Forms.RadioButton();
            this.btluu = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.bttk = new System.Windows.Forms.Button();
            this.bththi = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btcn = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbgb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbgn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(29, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1076, 270);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dtgv.Location = new System.Drawing.Point(0, 19);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.Size = new System.Drawing.Size(1076, 251);
            this.dtgv.TabIndex = 0;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá tiền nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá tiền bán:";
            // 
            // tbma
            // 
            this.tbma.Enabled = false;
            this.tbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbma.Location = new System.Drawing.Point(141, 43);
            this.tbma.Name = "tbma";
            this.tbma.Size = new System.Drawing.Size(179, 24);
            this.tbma.TabIndex = 4;
            // 
            // tbten
            // 
            this.tbten.Enabled = false;
            this.tbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbten.Location = new System.Drawing.Point(141, 89);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(179, 24);
            this.tbten.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(392, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(392, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã NCC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(676, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Ảnh:";
            // 
            // btopen
            // 
            this.btopen.Enabled = false;
            this.btopen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btopen.Location = new System.Drawing.Point(724, 34);
            this.btopen.Name = "btopen";
            this.btopen.Size = new System.Drawing.Size(54, 25);
            this.btopen.TabIndex = 15;
            this.btopen.Text = "Mở";
            this.btopen.UseVisualStyleBackColor = true;
            this.btopen.Click += new System.EventHandler(this.btopen_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(138, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "(Mặc định: tăng 10% so với giá nhập)";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ktanh);
            this.groupBox1.Controls.Add(this.ktncc);
            this.groupBox1.Controls.Add(this.ktgn);
            this.groupBox1.Controls.Add(this.ktten);
            this.groupBox1.Controls.Add(this.ktma);
            this.groupBox1.Controls.Add(this.bttim);
            this.groupBox1.Controls.Add(this.cbmasp);
            this.groupBox1.Controls.Add(this.cbncc);
            this.groupBox1.Controls.Add(this.tbgb);
            this.groupBox1.Controls.Add(this.tbsl);
            this.groupBox1.Controls.Add(this.tbgn);
            this.groupBox1.Controls.Add(this.pbanh);
            this.groupBox1.Controls.Add(this.ranu);
            this.groupBox1.Controls.Add(this.ranam);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btluu);
            this.groupBox1.Controls.Add(this.btopen);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbten);
            this.groupBox1.Controls.Add(this.tbma);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1076, 242);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết sản phẩm";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ktanh
            // 
            this.ktanh.AutoSize = true;
            this.ktanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktanh.ForeColor = System.Drawing.Color.Red;
            this.ktanh.Location = new System.Drawing.Point(855, 52);
            this.ktanh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ktanh.Name = "ktanh";
            this.ktanh.Size = new System.Drawing.Size(63, 13);
            this.ktanh.TabIndex = 35;
            this.ktanh.Text = "Đã tồn tại";
            this.ktanh.Visible = false;
            // 
            // ktncc
            // 
            this.ktncc.AutoSize = true;
            this.ktncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktncc.ForeColor = System.Drawing.Color.Red;
            this.ktncc.Location = new System.Drawing.Point(627, 130);
            this.ktncc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ktncc.Name = "ktncc";
            this.ktncc.Size = new System.Drawing.Size(14, 18);
            this.ktncc.TabIndex = 33;
            this.ktncc.Text = "*";
            this.ktncc.Visible = false;
            // 
            // ktgn
            // 
            this.ktgn.AutoSize = true;
            this.ktgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktgn.ForeColor = System.Drawing.Color.Red;
            this.ktgn.Location = new System.Drawing.Point(320, 130);
            this.ktgn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ktgn.Name = "ktgn";
            this.ktgn.Size = new System.Drawing.Size(18, 24);
            this.ktgn.TabIndex = 32;
            this.ktgn.Text = "*";
            this.ktgn.Visible = false;
            // 
            // ktten
            // 
            this.ktten.AutoSize = true;
            this.ktten.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktten.ForeColor = System.Drawing.Color.Red;
            this.ktten.Location = new System.Drawing.Point(320, 85);
            this.ktten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ktten.Name = "ktten";
            this.ktten.Size = new System.Drawing.Size(18, 24);
            this.ktten.TabIndex = 30;
            this.ktten.Text = "*";
            this.ktten.Visible = false;
            // 
            // ktma
            // 
            this.ktma.AutoSize = true;
            this.ktma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktma.ForeColor = System.Drawing.Color.Red;
            this.ktma.Location = new System.Drawing.Point(320, 40);
            this.ktma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ktma.Name = "ktma";
            this.ktma.Size = new System.Drawing.Size(24, 24);
            this.ktma.TabIndex = 29;
            this.ktma.Text = "* ";
            this.ktma.Visible = false;
            // 
            // bttim
            // 
            this.bttim.BackgroundImage = global::App.NET.Properties.Resources.icons8_search_64;
            this.bttim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttim.Location = new System.Drawing.Point(955, 153);
            this.bttim.Margin = new System.Windows.Forms.Padding(2);
            this.bttim.Name = "bttim";
            this.bttim.Size = new System.Drawing.Size(85, 84);
            this.bttim.TabIndex = 28;
            this.bttim.UseVisualStyleBackColor = true;
            this.bttim.Visible = false;
            this.bttim.Click += new System.EventHandler(this.bttim_Click);
            // 
            // cbmasp
            // 
            this.cbmasp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmasp.FormattingEnabled = true;
            this.cbmasp.Location = new System.Drawing.Point(141, 43);
            this.cbmasp.Margin = new System.Windows.Forms.Padding(2);
            this.cbmasp.Name = "cbmasp";
            this.cbmasp.Size = new System.Drawing.Size(179, 25);
            this.cbmasp.TabIndex = 27;
            this.cbmasp.Visible = false;
            // 
            // cbncc
            // 
            this.cbncc.DropDownHeight = 200;
            this.cbncc.Enabled = false;
            this.cbncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbncc.FormattingEnabled = true;
            this.cbncc.IntegralHeight = false;
            this.cbncc.Location = new System.Drawing.Point(502, 133);
            this.cbncc.Margin = new System.Windows.Forms.Padding(2);
            this.cbncc.Name = "cbncc";
            this.cbncc.Size = new System.Drawing.Size(125, 25);
            this.cbncc.TabIndex = 26;
            // 
            // tbgb
            // 
            this.tbgb.Enabled = false;
            this.tbgb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgb.Location = new System.Drawing.Point(141, 184);
            this.tbgb.Margin = new System.Windows.Forms.Padding(2);
            this.tbgb.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.tbgb.Name = "tbgb";
            this.tbgb.Size = new System.Drawing.Size(178, 24);
            this.tbgb.TabIndex = 25;
            // 
            // tbsl
            // 
            this.tbsl.Enabled = false;
            this.tbsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsl.Location = new System.Drawing.Point(503, 89);
            this.tbsl.Margin = new System.Windows.Forms.Padding(2);
            this.tbsl.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.tbsl.Name = "tbsl";
            this.tbsl.Size = new System.Drawing.Size(61, 24);
            this.tbsl.TabIndex = 24;
            // 
            // tbgn
            // 
            this.tbgn.Enabled = false;
            this.tbgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbgn.Location = new System.Drawing.Point(141, 134);
            this.tbgn.Margin = new System.Windows.Forms.Padding(2);
            this.tbgn.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.tbgn.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.tbgn.Name = "tbgn";
            this.tbgn.Size = new System.Drawing.Size(178, 24);
            this.tbgn.TabIndex = 23;
            this.tbgn.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // pbanh
            // 
            this.pbanh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbanh.Location = new System.Drawing.Point(724, 72);
            this.pbanh.Margin = new System.Windows.Forms.Padding(2);
            this.pbanh.Name = "pbanh";
            this.pbanh.Size = new System.Drawing.Size(190, 153);
            this.pbanh.TabIndex = 21;
            this.pbanh.TabStop = false;
            // 
            // ranu
            // 
            this.ranu.AutoSize = true;
            this.ranu.Enabled = false;
            this.ranu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranu.Location = new System.Drawing.Point(588, 43);
            this.ranu.Margin = new System.Windows.Forms.Padding(2);
            this.ranu.Name = "ranu";
            this.ranu.Size = new System.Drawing.Size(45, 22);
            this.ranu.TabIndex = 20;
            this.ranu.Text = "Nữ";
            this.ranu.UseVisualStyleBackColor = true;
            // 
            // ranam
            // 
            this.ranam.AutoSize = true;
            this.ranam.Checked = true;
            this.ranam.Enabled = false;
            this.ranam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ranam.Location = new System.Drawing.Point(503, 44);
            this.ranam.Margin = new System.Windows.Forms.Padding(2);
            this.ranam.Name = "ranam";
            this.ranam.Size = new System.Drawing.Size(58, 22);
            this.ranam.TabIndex = 19;
            this.ranam.TabStop = true;
            this.ranam.Text = "Nam";
            this.ranam.UseVisualStyleBackColor = true;
            // 
            // btluu
            // 
            this.btluu.Enabled = false;
            this.btluu.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btluu.Image = global::App.NET.Properties.Resources.iconfinder_floppy_285657;
            this.btluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btluu.Location = new System.Drawing.Point(955, 69);
            this.btluu.Name = "btluu";
            this.btluu.Size = new System.Drawing.Size(85, 79);
            this.btluu.TabIndex = 16;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // bttk
            // 
            this.bttk.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bttk.Image = global::App.NET.Properties.Resources.Search;
            this.bttk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttk.Location = new System.Drawing.Point(254, 34);
            this.bttk.Name = "bttk";
            this.bttk.Padding = new System.Windows.Forms.Padding(2, 0, 4, 0);
            this.bttk.Size = new System.Drawing.Size(134, 46);
            this.bttk.TabIndex = 5;
            this.bttk.Text = "Tìm kiếm";
            this.bttk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.bttk_Click);
            // 
            // bththi
            // 
            this.bththi.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bththi.Image = global::App.NET.Properties.Resources.Show;
            this.bththi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bththi.Location = new System.Drawing.Point(83, 34);
            this.bththi.Name = "bththi";
            this.bththi.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.bththi.Size = new System.Drawing.Size(128, 46);
            this.bththi.TabIndex = 4;
            this.bththi.Text = "Hiển thị";
            this.bththi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bththi.UseVisualStyleBackColor = true;
            this.bththi.Click += new System.EventHandler(this.bththi_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btxoa.Image = global::App.NET.Properties.Resources.Delete;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(790, 34);
            this.btxoa.Name = "btxoa";
            this.btxoa.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.btxoa.Size = new System.Drawing.Size(98, 46);
            this.btxoa.TabIndex = 3;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btcn
            // 
            this.btcn.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btcn.Image = global::App.NET.Properties.Resources.Update;
            this.btcn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcn.Location = new System.Drawing.Point(610, 34);
            this.btcn.Name = "btcn";
            this.btcn.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.btcn.Size = new System.Drawing.Size(136, 46);
            this.btcn.TabIndex = 2;
            this.btcn.Text = "Cập nhật";
            this.btcn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcn.UseVisualStyleBackColor = true;
            this.btcn.Click += new System.EventHandler(this.btcn_Click);
            // 
            // bthuy
            // 
            this.bthuy.Enabled = false;
            this.bthuy.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.bthuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bthuy.Image = global::App.NET.Properties.Resources.cancel;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.Location = new System.Drawing.Point(932, 34);
            this.bthuy.Name = "bthuy";
            this.bthuy.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.bthuy.Size = new System.Drawing.Size(98, 46);
            this.bthuy.TabIndex = 1;
            this.bthuy.Text = "Hủy";
            this.bthuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // btthem
            // 
            this.btthem.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btthem.Image = global::App.NET.Properties.Resources.anhadd;
            this.btthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btthem.Location = new System.Drawing.Point(430, 34);
            this.btthem.Name = "btthem";
            this.btthem.Padding = new System.Windows.Forms.Padding(4, 0, 8, 0);
            this.btthem.Size = new System.Drawing.Size(140, 46);
            this.btthem.TabIndex = 0;
            this.btthem.Text = "Thêm mới";
            this.btthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // SP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 570);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bttk);
            this.Controls.Add(this.bththi);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btcn);
            this.Controls.Add(this.bthuy);
            this.Controls.Add(this.btthem);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SẢN PHẨM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SP_FormClosed);
            this.Load += new System.EventHandler(this.SP_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbgb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbsl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbgn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbanh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.Button btcn;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button bththi;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbma;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btopen;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton ranu;
        private System.Windows.Forms.RadioButton ranam;
        private System.Windows.Forms.PictureBox pbanh;
        private System.Windows.Forms.NumericUpDown tbgb;
        private System.Windows.Forms.NumericUpDown tbsl;
        private System.Windows.Forms.NumericUpDown tbgn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox cbncc;
        private System.Windows.Forms.ComboBox cbmasp;
        private System.Windows.Forms.Button bttim;
        private System.Windows.Forms.Label ktncc;
        private System.Windows.Forms.Label ktten;
        private System.Windows.Forms.Label ktma;
        private System.Windows.Forms.Label ktgn;
        private System.Windows.Forms.Label ktanh;
    }
}

