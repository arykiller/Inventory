namespace inventory
{
    partial class InventoryFrm
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
            this.BackBt = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.searchTx = new System.Windows.Forms.TextBox();
            this.searchBt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.aGridView = new ADGV.AdvancedDataGridView();
            this.totalItem = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.itemSum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBt
            // 
            this.BackBt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackBt.BackColor = System.Drawing.Color.Transparent;
            this.BackBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackBt.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.BackBt.Location = new System.Drawing.Point(17, 20);
            this.BackBt.Name = "BackBt";
            this.BackBt.Size = new System.Drawing.Size(82, 35);
            this.BackBt.TabIndex = 7;
            this.BackBt.Text = "< رجوع ";
            this.BackBt.UseVisualStyleBackColor = false;
            this.BackBt.Click += new System.EventHandler(this.button7_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tajawal", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(1170, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 43);
            this.label1.TabIndex = 60;
            this.label1.Text = "الجرد";
            // 
            // searchTx
            // 
            this.searchTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.searchTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTx.Font = new System.Drawing.Font("Tajawal", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTx.Location = new System.Drawing.Point(157, 271);
            this.searchTx.Multiline = true;
            this.searchTx.Name = "searchTx";
            this.searchTx.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchTx.Size = new System.Drawing.Size(844, 36);
            this.searchTx.TabIndex = 2;
            this.searchTx.TextChanged += new System.EventHandler(this.searchTx_TextChanged);
            // 
            // searchBt
            // 
            this.searchBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.searchBt.FlatAppearance.BorderSize = 0;
            this.searchBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBt.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBt.ForeColor = System.Drawing.Color.White;
            this.searchBt.Location = new System.Drawing.Point(1007, 272);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(245, 36);
            this.searchBt.TabIndex = 1;
            this.searchBt.Text = "بحث";
            this.searchBt.UseVisualStyleBackColor = false;
            this.searchBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.panel1.Location = new System.Drawing.Point(32, 236);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 1);
            this.panel1.TabIndex = 64;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(929, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 63;
            this.label3.Text = "اسم المادة";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tajawal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 271);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(139, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "تصدير الى Excel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // aGridView
            // 
            this.aGridView.AllowUserToAddRows = false;
            this.aGridView.AllowUserToDeleteRows = false;
            this.aGridView.AutoGenerateContextFilters = true;
            this.aGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.aGridView.BackgroundColor = System.Drawing.Color.White;
            this.aGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aGridView.DateWithTime = false;
            this.aGridView.Location = new System.Drawing.Point(18, 336);
            this.aGridView.Name = "aGridView";
            this.aGridView.ReadOnly = true;
            this.aGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aGridView.Size = new System.Drawing.Size(1234, 420);
            this.aGridView.TabIndex = 68;
            this.aGridView.TimeFilter = false;
            this.aGridView.SortStringChanged += new System.EventHandler(this.aGridView_SortStringChanged);
            this.aGridView.FilterStringChanged += new System.EventHandler(this.aGridView_FilterStringChanged);
            // 
            // totalItem
            // 
            this.totalItem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.totalItem.BackColor = System.Drawing.Color.Transparent;
            this.totalItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalItem.Font = new System.Drawing.Font("Tajawal ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.totalItem.Location = new System.Drawing.Point(19, 59);
            this.totalItem.Name = "totalItem";
            this.totalItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.totalItem.Size = new System.Drawing.Size(131, 42);
            this.totalItem.TabIndex = 2;
            this.totalItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalItem.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(29, 21);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(121, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "عدد المواد االكلي";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.totalItem);
            this.panel2.Controls.Add(this.label4);
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel2.Location = new System.Drawing.Point(982, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 119);
            this.panel2.TabIndex = 69;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.itemSum);
            this.panel3.Controls.Add(this.label6);
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.panel3.Location = new System.Drawing.Point(701, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 119);
            this.panel3.TabIndex = 69;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // itemSum
            // 
            this.itemSum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.itemSum.BackColor = System.Drawing.Color.Transparent;
            this.itemSum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemSum.Font = new System.Drawing.Font("Tajawal ExtraBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemSum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.itemSum.Location = new System.Drawing.Point(21, 59);
            this.itemSum.Name = "itemSum";
            this.itemSum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemSum.Size = new System.Drawing.Size(131, 42);
            this.itemSum.TabIndex = 2;
            this.itemSum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.itemSum.Click += new System.EventHandler(this.label2_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Tajawal", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(58, 21);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(94, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "الكمية الكلية";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = global::inventory.Properties.Resources.Reading_list_amico1;
            this.pictureBox2.Location = new System.Drawing.Point(158, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(78, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::inventory.Properties.Resources.Reading_list_rafiki;
            this.pictureBox1.Location = new System.Drawing.Point(158, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // InventoryFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1274, 776);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.aGridView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.searchTx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBt);
            this.Font = new System.Drawing.Font("Tajawal", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InventoryFrm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryFrm";
            this.Load += new System.EventHandler(this.InventoryFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBt;
        private System.Windows.Forms.TextBox searchTx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private ADGV.AdvancedDataGridView aGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn depIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label totalItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label itemSum;
        private System.Windows.Forms.Label label6;
    }
}