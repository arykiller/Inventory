namespace inventory
{
    partial class LoginFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsernameTx = new System.Windows.Forms.TextBox();
            this.PwdTx = new System.Windows.Forms.TextBox();
            this.LoginBt = new System.Windows.Forms.Button();
            this.ShowPwdCb = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdminLogin = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tajawal ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(848, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "تسجيل الدخول";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(1019, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم المستخدم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(1051, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "كلمة المرور";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // UsernameTx
            // 
            this.UsernameTx.AcceptsReturn = true;
            this.UsernameTx.AcceptsTab = true;
            this.UsernameTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.UsernameTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameTx.Font = new System.Drawing.Font("Tajawal Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.UsernameTx.Location = new System.Drawing.Point(840, 296);
            this.UsernameTx.Margin = new System.Windows.Forms.Padding(5);
            this.UsernameTx.Multiline = true;
            this.UsernameTx.Name = "UsernameTx";
            this.UsernameTx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsernameTx.Size = new System.Drawing.Size(300, 35);
            this.UsernameTx.TabIndex = 4;
            this.UsernameTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UsernameTx.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.UsernameTx.Validating += new System.ComponentModel.CancelEventHandler(this.UsernameTx_Validating);
            // 
            // PwdTx
            // 
            this.PwdTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.PwdTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PwdTx.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PwdTx.Location = new System.Drawing.Point(840, 370);
            this.PwdTx.Multiline = true;
            this.PwdTx.Name = "PwdTx";
            this.PwdTx.PasswordChar = '*';
            this.PwdTx.Size = new System.Drawing.Size(300, 35);
            this.PwdTx.TabIndex = 5;
            this.PwdTx.TabStop = false;
            this.PwdTx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PwdTx.TextChanged += new System.EventHandler(this.PwdTx_TextChanged);
            // 
            // LoginBt
            // 
            this.LoginBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.LoginBt.FlatAppearance.BorderSize = 0;
            this.LoginBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginBt.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.LoginBt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LoginBt.Location = new System.Drawing.Point(890, 464);
            this.LoginBt.Name = "LoginBt";
            this.LoginBt.Size = new System.Drawing.Size(200, 35);
            this.LoginBt.TabIndex = 6;
            this.LoginBt.Text = "تسجيل الدخول";
            this.LoginBt.UseVisualStyleBackColor = false;
            this.LoginBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowPwdCb
            // 
            this.ShowPwdCb.AutoSize = true;
            this.ShowPwdCb.BackColor = System.Drawing.Color.Transparent;
            this.ShowPwdCb.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowPwdCb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowPwdCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowPwdCb.Location = new System.Drawing.Point(1015, 409);
            this.ShowPwdCb.Name = "ShowPwdCb";
            this.ShowPwdCb.Size = new System.Drawing.Size(125, 23);
            this.ShowPwdCb.TabIndex = 7;
            this.ShowPwdCb.Text = "أظهار كلمة المرور";
            this.ShowPwdCb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowPwdCb.UseVisualStyleBackColor = false;
            this.ShowPwdCb.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.label4.Location = new System.Drawing.Point(823, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(334, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "_________________________________________________________________";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(827, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(326, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "______________________________ او ______________________________";
            // 
            // AdminLogin
            // 
            this.AdminLogin.AutoSize = true;
            this.AdminLogin.BackColor = System.Drawing.Color.Transparent;
            this.AdminLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminLogin.Font = new System.Drawing.Font("Tajawal Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AdminLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AdminLogin.Location = new System.Drawing.Point(923, 547);
            this.AdminLogin.Name = "AdminLogin";
            this.AdminLogin.Size = new System.Drawing.Size(135, 18);
            this.AdminLogin.TabIndex = 10;
            this.AdminLogin.Text = "تسجيل الدخول كزائر";
            this.AdminLogin.Click += new System.EventHandler(this.AdminLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inventory.Properties.Resources.Sign_in_amico;
            this.pictureBox1.Location = new System.Drawing.Point(108, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 651);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(771, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 19);
            this.label6.TabIndex = 11;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AdminLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowPwdCb);
            this.Controls.Add(this.LoginBt);
            this.Controls.Add(this.PwdTx);
            this.Controls.Add(this.UsernameTx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsernameTx;
        private System.Windows.Forms.TextBox PwdTx;
        private System.Windows.Forms.Button LoginBt;
        private System.Windows.Forms.CheckBox ShowPwdCb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AdminLogin;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
    }
}

