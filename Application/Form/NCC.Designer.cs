namespace App.NET
{
    partial class NCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NCC));
            this.btcn = new System.Windows.Forms.Button();
            this.btxoa = new System.Windows.Forms.Button();
            this.btadd = new System.Windows.Forms.Button();
            this.bthuy = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ktten = new System.Windows.Forms.Label();
            this.ktma = new System.Windows.Forms.Label();
            this.cbma = new System.Windows.Forms.ComboBox();
            this.btexit = new System.Windows.Forms.Button();
            this.btluu = new System.Windows.Forms.Button();
            this.tbten = new System.Windows.Forms.TextBox();
            this.tbma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refesh = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // btcn
            // 
            this.btcn.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcn.Image = global::App.NET.Properties.Resources.Update;
            this.btcn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btcn.Location = new System.Drawing.Point(191, 197);
            this.btcn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btcn.Name = "btcn";
            this.btcn.Size = new System.Drawing.Size(113, 40);
            this.btcn.TabIndex = 31;
            this.btcn.Text = "Cập nhật";
            this.btcn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btcn.UseVisualStyleBackColor = true;
            this.btcn.Click += new System.EventHandler(this.btcn_Click);
            // 
            // btxoa
            // 
            this.btxoa.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxoa.Image = global::App.NET.Properties.Resources.Delete;
            this.btxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btxoa.Location = new System.Drawing.Point(327, 197);
            this.btxoa.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btxoa.Name = "btxoa";
            this.btxoa.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.btxoa.Size = new System.Drawing.Size(113, 40);
            this.btxoa.TabIndex = 30;
            this.btxoa.Text = "Xóa";
            this.btxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btadd
            // 
            this.btadd.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btadd.Image = global::App.NET.Properties.Resources.anhadd;
            this.btadd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btadd.Location = new System.Drawing.Point(57, 197);
            this.btadd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btadd.Name = "btadd";
            this.btadd.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.btadd.Size = new System.Drawing.Size(113, 40);
            this.btadd.TabIndex = 29;
            this.btadd.Text = "Thêm";
            this.btadd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btadd.UseVisualStyleBackColor = true;
            this.btadd.Click += new System.EventHandler(this.btadd_Click);
            // 
            // bthuy
            // 
            this.bthuy.Enabled = false;
            this.bthuy.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bthuy.Image = global::App.NET.Properties.Resources.cancel;
            this.bthuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bthuy.Location = new System.Drawing.Point(152, 114);
            this.bthuy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bthuy.Name = "bthuy";
            this.bthuy.Padding = new System.Windows.Forms.Padding(8, 0, 22, 0);
            this.bthuy.Size = new System.Drawing.Size(113, 39);
            this.bthuy.TabIndex = 28;
            this.bthuy.Text = "Hủy";
            this.bthuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bthuy.UseVisualStyleBackColor = true;
            this.bthuy.Click += new System.EventHandler(this.bthuy_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ktten);
            this.groupBox1.Controls.Add(this.ktma);
            this.groupBox1.Controls.Add(this.cbma);
            this.groupBox1.Controls.Add(this.btexit);
            this.groupBox1.Controls.Add(this.bthuy);
            this.groupBox1.Controls.Add(this.btluu);
            this.groupBox1.Controls.Add(this.tbten);
            this.groupBox1.Controls.Add(this.tbma);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(423, 168);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // ktten
            // 
            this.ktten.AutoSize = true;
            this.ktten.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktten.ForeColor = System.Drawing.Color.Red;
            this.ktten.Location = new System.Drawing.Point(346, 72);
            this.ktten.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ktten.Name = "ktten";
            this.ktten.Size = new System.Drawing.Size(23, 20);
            this.ktten.TabIndex = 31;
            this.ktten.Text = "* ";
            this.ktten.Visible = false;
            // 
            // ktma
            // 
            this.ktma.AutoSize = true;
            this.ktma.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ktma.ForeColor = System.Drawing.Color.Red;
            this.ktma.Location = new System.Drawing.Point(346, 34);
            this.ktma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ktma.Name = "ktma";
            this.ktma.Size = new System.Drawing.Size(23, 20);
            this.ktma.TabIndex = 30;
            this.ktma.Text = "* ";
            this.ktma.Visible = false;
            // 
            // cbma
            // 
            this.cbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbma.FormattingEnabled = true;
            this.cbma.Location = new System.Drawing.Point(152, 34);
            this.cbma.Margin = new System.Windows.Forms.Padding(2);
            this.cbma.Name = "cbma";
            this.cbma.Size = new System.Drawing.Size(192, 25);
            this.cbma.TabIndex = 16;
            this.cbma.Visible = false;
            // 
            // btexit
            // 
            this.btexit.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexit.Image = global::App.NET.Properties.Resources.logout;
            this.btexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btexit.Location = new System.Drawing.Point(287, 113);
            this.btexit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btexit.Name = "btexit";
            this.btexit.Padding = new System.Windows.Forms.Padding(8, 0, 11, 0);
            this.btexit.Size = new System.Drawing.Size(113, 40);
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
            this.btluu.Location = new System.Drawing.Point(17, 115);
            this.btluu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btluu.Name = "btluu";
            this.btluu.Padding = new System.Windows.Forms.Padding(4, 0, 22, 0);
            this.btluu.Size = new System.Drawing.Size(113, 40);
            this.btluu.TabIndex = 14;
            this.btluu.Text = "Lưu";
            this.btluu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btluu.UseVisualStyleBackColor = true;
            this.btluu.Click += new System.EventHandler(this.btluu_Click);
            // 
            // tbten
            // 
            this.tbten.Enabled = false;
            this.tbten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbten.Location = new System.Drawing.Point(152, 72);
            this.tbten.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbten.Name = "tbten";
            this.tbten.Size = new System.Drawing.Size(192, 24);
            this.tbten.TabIndex = 7;
            // 
            // tbma
            // 
            this.tbma.Enabled = false;
            this.tbma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbma.Location = new System.Drawing.Point(152, 35);
            this.tbma.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbma.Name = "tbma";
            this.tbma.Size = new System.Drawing.Size(192, 24);
            this.tbma.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NCC:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã NCC:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(40, 260);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(423, 207);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhà cung cấp";
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgv.BackgroundColor = System.Drawing.Color.LightGray;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dtgv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtgv.Location = new System.Drawing.Point(0, 20);
            this.dtgv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.Size = new System.Drawing.Size(423, 186);
            this.dtgv.TabIndex = 3;
            this.dtgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaNCC";
            this.Column1.FillWeight = 60F;
            this.Column1.HeaderText = "Mã NCC";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenNCC";
            this.Column2.HeaderText = "Tên NCC";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            this.refesh.Location = new System.Drawing.Point(380, 240);
            this.refesh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.refesh.Name = "refesh";
            this.refesh.Size = new System.Drawing.Size(92, 18);
            this.refesh.TabIndex = 34;
            this.refesh.TabStop = true;
            this.refesh.Text = "Làm mới";
            this.refesh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.refesh.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.refesh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.refesh_LinkClicked_1);
            // 
            // NCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 488);
            this.Controls.Add(this.refesh);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btcn);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btadd);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà cung cấp";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NCC_FormClosed);
            this.Load += new System.EventHandler(this.NCC_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btcn;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btadd;
        private System.Windows.Forms.Button bthuy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ktten;
        private System.Windows.Forms.Label ktma;
        private System.Windows.Forms.ComboBox cbma;
        private System.Windows.Forms.Button btexit;
        private System.Windows.Forms.Button btluu;
        private System.Windows.Forms.TextBox tbten;
        private System.Windows.Forms.TextBox tbma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.LinkLabel refesh;
    }
}