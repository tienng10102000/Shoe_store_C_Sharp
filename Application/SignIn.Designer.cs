namespace App.NET
{
    partial class SignIn
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
            this.bt_ok = new System.Windows.Forms.Button();
            this.lb_exit = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_si = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cb_ntk = new System.Windows.Forms.CheckBox();
            this.lbl_qmk = new System.Windows.Forms.LinkLabel();
            this.cachedCrystalReport21 = new App.NET.CachedCrystalReport2();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bt_ok
            // 
            this.bt_ok.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_ok.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_ok.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bt_ok.Location = new System.Drawing.Point(91, 328);
            this.bt_ok.Margin = new System.Windows.Forms.Padding(2);
            this.bt_ok.Name = "bt_ok";
            this.bt_ok.Size = new System.Drawing.Size(146, 42);
            this.bt_ok.TabIndex = 6;
            this.bt_ok.Text = "Đăng nhập";
            this.bt_ok.UseVisualStyleBackColor = false;
            this.bt_ok.Click += new System.EventHandler(this.bt_ok_Click);
            // 
            // lb_exit
            // 
            this.lb_exit.AutoSize = true;
            this.lb_exit.BackColor = System.Drawing.Color.Transparent;
            this.lb_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exit.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_exit.Location = new System.Drawing.Point(302, 0);
            this.lb_exit.Margin = new System.Windows.Forms.Padding(2);
            this.lb_exit.MaximumSize = new System.Drawing.Size(38, 41);
            this.lb_exit.MinimumSize = new System.Drawing.Size(32, 32);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(32, 32);
            this.lb_exit.TabIndex = 6;
            this.lb_exit.Text = "X";
            this.lb_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_exit.Click += new System.EventHandler(this.lb_exit_Click);
            this.lb_exit.MouseLeave += new System.EventHandler(this.lb_exit_MouseLeave);
            this.lb_exit.MouseHover += new System.EventHandler(this.lb_exit_MouseHover);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::App.NET.Properties.Resources.pass1;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Enabled = false;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(59, 218);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(33, 31);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tb_pw
            // 
            this.tb_pw.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tb_pw.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pw.Location = new System.Drawing.Point(91, 219);
            this.tb_pw.Margin = new System.Windows.Forms.Padding(2);
            this.tb_pw.MaximumSize = new System.Drawing.Size(376, 35);
            this.tb_pw.MinimumSize = new System.Drawing.Size(180, 35);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '●';
            this.tb_pw.Size = new System.Drawing.Size(197, 29);
            this.tb_pw.TabIndex = 2;
            this.tb_pw.Text = "18004135";
            this.tb_pw.TextChanged += new System.EventHandler(this.tb_pw_TextChanged);
            this.tb_pw.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_pw_KeyUp);
            // 
            // tb_si
            // 
            this.tb_si.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tb_si.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_si.Location = new System.Drawing.Point(91, 171);
            this.tb_si.Margin = new System.Windows.Forms.Padding(2);
            this.tb_si.MaximumSize = new System.Drawing.Size(376, 35);
            this.tb_si.MinimumSize = new System.Drawing.Size(180, 35);
            this.tb_si.Name = "tb_si";
            this.tb_si.Size = new System.Drawing.Size(197, 29);
            this.tb_si.TabIndex = 1;
            this.tb_si.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_si_KeyUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::App.NET.Properties.Resources.account1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 31);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::App.NET.Properties.Resources.user2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(119, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 103);
            this.panel1.TabIndex = 15;
            // 
            // cb_ntk
            // 
            this.cb_ntk.AutoSize = true;
            this.cb_ntk.BackColor = System.Drawing.Color.Transparent;
            this.cb_ntk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb_ntk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ntk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cb_ntk.Location = new System.Drawing.Point(59, 256);
            this.cb_ntk.Margin = new System.Windows.Forms.Padding(2);
            this.cb_ntk.Name = "cb_ntk";
            this.cb_ntk.Size = new System.Drawing.Size(114, 23);
            this.cb_ntk.TabIndex = 3;
            this.cb_ntk.Text = "Nhớ tài khoản";
            this.cb_ntk.UseVisualStyleBackColor = false;
            // 
            // lbl_qmk
            // 
            this.lbl_qmk.ActiveLinkColor = System.Drawing.Color.White;
            this.lbl_qmk.AutoSize = true;
            this.lbl_qmk.BackColor = System.Drawing.Color.Transparent;
            this.lbl_qmk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_qmk.DisabledLinkColor = System.Drawing.Color.White;
            this.lbl_qmk.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qmk.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_qmk.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbl_qmk.LinkColor = System.Drawing.Color.Silver;
            this.lbl_qmk.Location = new System.Drawing.Point(102, 292);
            this.lbl_qmk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_qmk.Name = "lbl_qmk";
            this.lbl_qmk.Size = new System.Drawing.Size(108, 19);
            this.lbl_qmk.TabIndex = 5;
            this.lbl_qmk.TabStop = true;
            this.lbl_qmk.Text = "Quên mật khẩu?";
            this.lbl_qmk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_qmk_LinkClicked_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(202, 256);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 23);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Hiện MK";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.NET.Properties.Resources.SIBKG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(333, 395);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbl_qmk);
            this.Controls.Add(this.cb_ntk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_si);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lb_exit);
            this.Controls.Add(this.bt_ok);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignIn_FormClosed);
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SignIn_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_ok;
        private System.Windows.Forms.Label lb_exit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_si;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cb_ntk;
        private System.Windows.Forms.LinkLabel lbl_qmk;
        private CachedCrystalReport2 cachedCrystalReport21;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}