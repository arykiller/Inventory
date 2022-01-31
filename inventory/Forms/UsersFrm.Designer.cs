namespace inventory
{
    partial class UsersFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.uGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uNameTx = new System.Windows.Forms.TextBox();
            this.uPwdTx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uPwdCTx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.showPwdCh = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.uRole = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.AddBt = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateBt = new System.Windows.Forms.Button();
            this.uPwdTx2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uPwdCTx2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.uRole2 = new System.Windows.Forms.ComboBox();
            this.showPwdCh2 = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.uNameTx2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchBt = new System.Windows.Forms.Button();
            this.searchTx = new System.Windows.Forms.TextBox();
            this.addBtm = new System.Windows.Forms.Button();
            this.updateBtm = new System.Windows.Forms.Button();
            this.deleteBt = new System.Windows.Forms.Button();
            this.BackBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tajawal", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(654, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "المستخدمون";
            // 
            // uGridView
            // 
            this.uGridView.AllowUserToAddRows = false;
            this.uGridView.AllowUserToDeleteRows = false;
            this.uGridView.AllowUserToResizeColumns = false;
            this.uGridView.AllowUserToResizeRows = false;
            this.uGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.uGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.uGridView.BackgroundColor = System.Drawing.Color.White;
            this.uGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.uGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.uGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.uGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.uGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.uGridView.EnableHeadersVisualStyles = false;
            this.uGridView.Location = new System.Drawing.Point(12, 301);
            this.uGridView.Name = "uGridView";
            this.uGridView.ReadOnly = true;
            this.uGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.uGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.uGridView.Size = new System.Drawing.Size(834, 456);
            this.uGridView.TabIndex = 1;
            this.uGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tajawal ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label2.Location = new System.Drawing.Point(44, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "اضافة مستخدم جديد";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(229, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "اسم المستخدم";
            // 
            // uNameTx
            // 
            this.uNameTx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uNameTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.uNameTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uNameTx.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNameTx.Location = new System.Drawing.Point(52, 356);
            this.uNameTx.Name = "uNameTx";
            this.uNameTx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uNameTx.Size = new System.Drawing.Size(300, 34);
            this.uNameTx.TabIndex = 5;
            this.uNameTx.TextChanged += new System.EventHandler(this.uNameTx_TextChanged);
            // 
            // uPwdTx
            // 
            this.uPwdTx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uPwdTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.uPwdTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uPwdTx.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPwdTx.Location = new System.Drawing.Point(52, 432);
            this.uPwdTx.Name = "uPwdTx";
            this.uPwdTx.PasswordChar = '*';
            this.uPwdTx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uPwdTx.Size = new System.Drawing.Size(300, 34);
            this.uPwdTx.TabIndex = 7;
            this.uPwdTx.TextChanged += new System.EventHandler(this.uPwdTx_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(262, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "كلمة المرور";
            // 
            // uPwdCTx
            // 
            this.uPwdCTx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uPwdCTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.uPwdCTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uPwdCTx.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPwdCTx.Location = new System.Drawing.Point(52, 509);
            this.uPwdCTx.Name = "uPwdCTx";
            this.uPwdCTx.PasswordChar = '*';
            this.uPwdCTx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uPwdCTx.Size = new System.Drawing.Size(300, 34);
            this.uPwdCTx.TabIndex = 9;
            this.uPwdCTx.TextChanged += new System.EventHandler(this.uPwdCTx_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(222, 481);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "تاكيد كلمة المرور";
            // 
            // showPwdCh
            // 
            this.showPwdCh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPwdCh.AutoSize = true;
            this.showPwdCh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPwdCh.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showPwdCh.Location = new System.Drawing.Point(227, 549);
            this.showPwdCh.Name = "showPwdCh";
            this.showPwdCh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showPwdCh.Size = new System.Drawing.Size(125, 23);
            this.showPwdCh.TabIndex = 10;
            this.showPwdCh.Text = "اظهار كلمة المرور";
            this.showPwdCh.UseVisualStyleBackColor = true;
            this.showPwdCh.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(243, 575);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "دور المستخدم";
            // 
            // uRole
            // 
            this.uRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.uRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.uRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uRole.Font = new System.Drawing.Font("Tajawal", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uRole.FormattingEnabled = true;
            this.uRole.Items.AddRange(new object[] {
            "مسؤول",
            "مدخل بيانات",
            "مسؤول تقني",
            "مسؤول المخزن",
            "admin"});
            this.uRole.Location = new System.Drawing.Point(52, 603);
            this.uRole.Name = "uRole";
            this.uRole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uRole.Size = new System.Drawing.Size(300, 37);
            this.uRole.TabIndex = 13;
            this.uRole.SelectedIndexChanged += new System.EventHandler(this.uRole_SelectedIndexChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.label7.Location = new System.Drawing.Point(35, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "_________________________________________________________________";
            // 
            // AddBt
            // 
            this.AddBt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.AddBt.FlatAppearance.BorderSize = 0;
            this.AddBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBt.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBt.ForeColor = System.Drawing.Color.White;
            this.AddBt.Location = new System.Drawing.Point(77, 670);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(250, 35);
            this.AddBt.TabIndex = 18;
            this.AddBt.Text = "أضافة";
            this.AddBt.UseVisualStyleBackColor = false;
            this.AddBt.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl1.Location = new System.Drawing.Point(852, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(412, 761);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.AddBt);
            this.tabPage1.Controls.Add(this.uPwdTx);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.uPwdCTx);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.uRole);
            this.tabPage1.Controls.Add(this.showPwdCh);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.uNameTx);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(404, 729);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "اضافة مستخدم";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.updateBt);
            this.tabPage2.Controls.Add(this.uPwdTx2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.uPwdCTx2);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.uRole2);
            this.tabPage2.Controls.Add(this.showPwdCh2);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.uNameTx2);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(404, 729);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "تحديث المستخدمين";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // updateBt
            // 
            this.updateBt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.updateBt.FlatAppearance.BorderSize = 0;
            this.updateBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBt.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBt.ForeColor = System.Drawing.Color.White;
            this.updateBt.Location = new System.Drawing.Point(77, 670);
            this.updateBt.Name = "updateBt";
            this.updateBt.Size = new System.Drawing.Size(250, 35);
            this.updateBt.TabIndex = 26;
            this.updateBt.Text = "تحديث";
            this.updateBt.UseVisualStyleBackColor = false;
            this.updateBt.Click += new System.EventHandler(this.updateBt_Click);
            // 
            // uPwdTx2
            // 
            this.uPwdTx2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uPwdTx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.uPwdTx2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uPwdTx2.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPwdTx2.Location = new System.Drawing.Point(52, 432);
            this.uPwdTx2.Name = "uPwdTx2";
            this.uPwdTx2.PasswordChar = '*';
            this.uPwdTx2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uPwdTx2.Size = new System.Drawing.Size(300, 34);
            this.uPwdTx2.TabIndex = 19;
            this.uPwdTx2.TextChanged += new System.EventHandler(this.uPwdTx2_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(222, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "تاكيد كلمة المرور";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.label9.Location = new System.Drawing.Point(35, 276);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "_________________________________________________________________";
            // 
            // uPwdCTx2
            // 
            this.uPwdCTx2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uPwdCTx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.uPwdCTx2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uPwdCTx2.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uPwdCTx2.Location = new System.Drawing.Point(52, 509);
            this.uPwdCTx2.Name = "uPwdCTx2";
            this.uPwdCTx2.PasswordChar = '*';
            this.uPwdCTx2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uPwdCTx2.Size = new System.Drawing.Size(300, 34);
            this.uPwdCTx2.TabIndex = 21;
            this.uPwdCTx2.TextChanged += new System.EventHandler(this.uPwdCTx2_TextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tajawal ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label10.Location = new System.Drawing.Point(18, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(369, 47);
            this.label10.TabIndex = 15;
            this.label10.Text = "تحديث بيانات المستخدم";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(262, 404);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "كلمة المرور";
            // 
            // uRole2
            // 
            this.uRole2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uRole2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.uRole2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.uRole2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uRole2.Font = new System.Drawing.Font("Tajawal", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uRole2.FormattingEnabled = true;
            this.uRole2.Items.AddRange(new object[] {
            "مسؤول",
            "مدخل بيانات",
            "مسؤول تقني",
            "مسؤول المخزن"});
            this.uRole2.Location = new System.Drawing.Point(52, 603);
            this.uRole2.Name = "uRole2";
            this.uRole2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uRole2.Size = new System.Drawing.Size(300, 37);
            this.uRole2.TabIndex = 24;
            this.uRole2.SelectedIndexChanged += new System.EventHandler(this.uRole2_SelectedIndexChanged);
            // 
            // showPwdCh2
            // 
            this.showPwdCh2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPwdCh2.AutoSize = true;
            this.showPwdCh2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPwdCh2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.showPwdCh2.Location = new System.Drawing.Point(227, 549);
            this.showPwdCh2.Name = "showPwdCh2";
            this.showPwdCh2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showPwdCh2.Size = new System.Drawing.Size(125, 23);
            this.showPwdCh2.TabIndex = 22;
            this.showPwdCh2.Text = "اظهار كلمة المرور";
            this.showPwdCh2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(229, 328);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(121, 24);
            this.label12.TabIndex = 16;
            this.label12.Text = "اسم المستخدم";
            // 
            // uNameTx2
            // 
            this.uNameTx2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uNameTx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.uNameTx2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uNameTx2.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uNameTx2.Location = new System.Drawing.Point(52, 356);
            this.uNameTx2.Name = "uNameTx2";
            this.uNameTx2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uNameTx2.Size = new System.Drawing.Size(300, 34);
            this.uNameTx2.TabIndex = 17;
            this.uNameTx2.TextChanged += new System.EventHandler(this.uNameTx2_TextChanged);
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(243, 575);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 24);
            this.label13.TabIndex = 23;
            this.label13.Text = "دور المستخدم";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37F));
            this.tableLayoutPanel1.Controls.Add(this.searchBt, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchTx, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(283, 238);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 35);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // searchBt
            // 
            this.searchBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.searchBt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBt.FlatAppearance.BorderSize = 0;
            this.searchBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBt.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBt.ForeColor = System.Drawing.Color.White;
            this.searchBt.Location = new System.Drawing.Point(357, 3);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(203, 29);
            this.searchBt.TabIndex = 27;
            this.searchBt.Text = "بحث";
            this.searchBt.UseVisualStyleBackColor = false;
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // searchTx
            // 
            this.searchTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.searchTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTx.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTx.Location = new System.Drawing.Point(3, 3);
            this.searchTx.Multiline = true;
            this.searchTx.Name = "searchTx";
            this.searchTx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchTx.Size = new System.Drawing.Size(348, 29);
            this.searchTx.TabIndex = 19;
            // 
            // addBtm
            // 
            this.addBtm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addBtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.addBtm.FlatAppearance.BorderSize = 0;
            this.addBtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtm.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtm.ForeColor = System.Drawing.Color.White;
            this.addBtm.Location = new System.Drawing.Point(195, 237);
            this.addBtm.Name = "addBtm";
            this.addBtm.Size = new System.Drawing.Size(82, 35);
            this.addBtm.TabIndex = 28;
            this.addBtm.Text = "اضافة";
            this.addBtm.UseVisualStyleBackColor = false;
            this.addBtm.Click += new System.EventHandler(this.addBtm_Click);
            // 
            // updateBtm
            // 
            this.updateBtm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateBtm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.updateBtm.FlatAppearance.BorderSize = 0;
            this.updateBtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtm.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtm.ForeColor = System.Drawing.Color.White;
            this.updateBtm.Location = new System.Drawing.Point(105, 237);
            this.updateBtm.Name = "updateBtm";
            this.updateBtm.Size = new System.Drawing.Size(82, 35);
            this.updateBtm.TabIndex = 29;
            this.updateBtm.Text = "تحديث";
            this.updateBtm.UseVisualStyleBackColor = false;
            this.updateBtm.Click += new System.EventHandler(this.updateBtm_Click);
            // 
            // deleteBt
            // 
            this.deleteBt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.deleteBt.FlatAppearance.BorderSize = 0;
            this.deleteBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBt.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBt.ForeColor = System.Drawing.Color.White;
            this.deleteBt.Location = new System.Drawing.Point(14, 237);
            this.deleteBt.Name = "deleteBt";
            this.deleteBt.Size = new System.Drawing.Size(82, 35);
            this.deleteBt.TabIndex = 30;
            this.deleteBt.Text = "حذف";
            this.deleteBt.UseVisualStyleBackColor = false;
            this.deleteBt.Click += new System.EventHandler(this.deleteBt_Click);
            // 
            // BackBt
            // 
            this.BackBt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBt.BackColor = System.Drawing.Color.Transparent;
            this.BackBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBt.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BackBt.Location = new System.Drawing.Point(12, 12);
            this.BackBt.Name = "BackBt";
            this.BackBt.Size = new System.Drawing.Size(82, 35);
            this.BackBt.TabIndex = 31;
            this.BackBt.Text = "< رجوع ";
            this.BackBt.UseVisualStyleBackColor = false;
            this.BackBt.Click += new System.EventHandler(this.BackBt_Click);
            // 
            // UsersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 761);
            this.Controls.Add(this.BackBt);
            this.Controls.Add(this.deleteBt);
            this.Controls.Add(this.updateBtm);
            this.Controls.Add(this.addBtm);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.uGridView);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UsersFrm";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersFrm";
            this.Load += new System.EventHandler(this.UsersFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView uGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uNameTx;
        private System.Windows.Forms.TextBox uPwdTx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uPwdCTx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox showPwdCh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox uRole;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button updateBt;
        private System.Windows.Forms.TextBox uPwdTx2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox uPwdCTx2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox uRole2;
        private System.Windows.Forms.CheckBox showPwdCh2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox uNameTx2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button deleteBt;
        private System.Windows.Forms.Button updateBtm;
        private System.Windows.Forms.Button addBtm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button searchBt;
        private System.Windows.Forms.TextBox searchTx;
        private System.Windows.Forms.Button BackBt;
    }
}