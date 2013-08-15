namespace MergeTable
{
    partial class Form1
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
            this.cmbLeft = new System.Windows.Forms.ComboBox();
            this.btnGoRight = new System.Windows.Forms.Button();
            this.btnGoLeft = new System.Windows.Forms.Button();
            this.lstLeft = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbRight = new System.Windows.Forms.ComboBox();
            this.btnRefLeft = new System.Windows.Forms.Button();
            this.btnRefRight = new System.Windows.Forms.Button();
            this.lblYolo = new System.Windows.Forms.Label();
            this.cmbDatabaseLeft = new System.Windows.Forms.ComboBox();
            this.btnDBConnectLeft = new System.Windows.Forms.Button();
            this.btnDBConnectRight = new System.Windows.Forms.Button();
            this.cmbDatabaseRight = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstRight = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbLeft
            // 
            this.cmbLeft.Enabled = false;
            this.cmbLeft.FormattingEnabled = true;
            this.cmbLeft.Location = new System.Drawing.Point(72, 43);
            this.cmbLeft.Name = "cmbLeft";
            this.cmbLeft.Size = new System.Drawing.Size(245, 21);
            this.cmbLeft.TabIndex = 0;
            // 
            // btnGoRight
            // 
            this.btnGoRight.Enabled = false;
            this.btnGoRight.Location = new System.Drawing.Point(395, 229);
            this.btnGoRight.Name = "btnGoRight";
            this.btnGoRight.Size = new System.Drawing.Size(75, 23);
            this.btnGoRight.TabIndex = 1;
            this.btnGoRight.Text = ">>";
            this.btnGoRight.UseVisualStyleBackColor = true;
            this.btnGoRight.Click += new System.EventHandler(this.btnGoRight_Click);
            // 
            // btnGoLeft
            // 
            this.btnGoLeft.Enabled = false;
            this.btnGoLeft.Location = new System.Drawing.Point(395, 278);
            this.btnGoLeft.Name = "btnGoLeft";
            this.btnGoLeft.Size = new System.Drawing.Size(75, 23);
            this.btnGoLeft.TabIndex = 2;
            this.btnGoLeft.Text = "<<";
            this.btnGoLeft.UseVisualStyleBackColor = true;
            this.btnGoLeft.Click += new System.EventHandler(this.btnGoLeft_Click);
            // 
            // lstLeft
            // 
            this.lstLeft.AutoArrange = false;
            this.lstLeft.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstLeft.Enabled = false;
            this.lstLeft.FullRowSelect = true;
            this.lstLeft.GridLines = true;
            this.lstLeft.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstLeft.Location = new System.Drawing.Point(14, 70);
            this.lstLeft.MultiSelect = false;
            this.lstLeft.Name = "lstLeft";
            this.lstLeft.Size = new System.Drawing.Size(375, 459);
            this.lstLeft.TabIndex = 3;
            this.lstLeft.UseCompatibleStateImageBehavior = false;
            this.lstLeft.View = System.Windows.Forms.View.Details;
            this.lstLeft.SelectedIndexChanged += new System.EventHandler(this.lstLeft_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 371;
            // 
            // cmbRight
            // 
            this.cmbRight.Enabled = false;
            this.cmbRight.FormattingEnabled = true;
            this.cmbRight.Location = new System.Drawing.Point(532, 43);
            this.cmbRight.Name = "cmbRight";
            this.cmbRight.Size = new System.Drawing.Size(247, 21);
            this.cmbRight.TabIndex = 4;
            // 
            // btnRefLeft
            // 
            this.btnRefLeft.Enabled = false;
            this.btnRefLeft.Location = new System.Drawing.Point(323, 42);
            this.btnRefLeft.Name = "btnRefLeft";
            this.btnRefLeft.Size = new System.Drawing.Size(66, 23);
            this.btnRefLeft.TabIndex = 6;
            this.btnRefLeft.Text = "Refresh";
            this.btnRefLeft.UseVisualStyleBackColor = true;
            this.btnRefLeft.Click += new System.EventHandler(this.btnRefLeft_Click);
            // 
            // btnRefRight
            // 
            this.btnRefRight.Enabled = false;
            this.btnRefRight.Location = new System.Drawing.Point(785, 42);
            this.btnRefRight.Name = "btnRefRight";
            this.btnRefRight.Size = new System.Drawing.Size(66, 23);
            this.btnRefRight.TabIndex = 7;
            this.btnRefRight.Text = "Refresh";
            this.btnRefRight.UseVisualStyleBackColor = true;
            this.btnRefRight.Click += new System.EventHandler(this.btnRefRight_Click);
            // 
            // lblYolo
            // 
            this.lblYolo.AutoSize = true;
            this.lblYolo.Location = new System.Drawing.Point(13, 16);
            this.lblYolo.Name = "lblYolo";
            this.lblYolo.Size = new System.Drawing.Size(53, 13);
            this.lblYolo.TabIndex = 8;
            this.lblYolo.Text = "Database";
            // 
            // cmbDatabaseLeft
            // 
            this.cmbDatabaseLeft.FormattingEnabled = true;
            this.cmbDatabaseLeft.Location = new System.Drawing.Point(72, 12);
            this.cmbDatabaseLeft.Name = "cmbDatabaseLeft";
            this.cmbDatabaseLeft.Size = new System.Drawing.Size(245, 21);
            this.cmbDatabaseLeft.TabIndex = 9;
            // 
            // btnDBConnectLeft
            // 
            this.btnDBConnectLeft.Location = new System.Drawing.Point(323, 10);
            this.btnDBConnectLeft.Name = "btnDBConnectLeft";
            this.btnDBConnectLeft.Size = new System.Drawing.Size(66, 23);
            this.btnDBConnectLeft.TabIndex = 10;
            this.btnDBConnectLeft.Text = "Connect";
            this.btnDBConnectLeft.UseVisualStyleBackColor = true;
            this.btnDBConnectLeft.Click += new System.EventHandler(this.btnDBConnectLeft_Click);
            // 
            // btnDBConnectRight
            // 
            this.btnDBConnectRight.Location = new System.Drawing.Point(785, 9);
            this.btnDBConnectRight.Name = "btnDBConnectRight";
            this.btnDBConnectRight.Size = new System.Drawing.Size(66, 23);
            this.btnDBConnectRight.TabIndex = 13;
            this.btnDBConnectRight.Text = "Connect";
            this.btnDBConnectRight.UseVisualStyleBackColor = true;
            this.btnDBConnectRight.Click += new System.EventHandler(this.btnDBConnectRight_Click);
            // 
            // cmbDatabaseRight
            // 
            this.cmbDatabaseRight.FormattingEnabled = true;
            this.cmbDatabaseRight.Location = new System.Drawing.Point(532, 11);
            this.cmbDatabaseRight.Name = "cmbDatabaseRight";
            this.cmbDatabaseRight.Size = new System.Drawing.Size(247, 21);
            this.cmbDatabaseRight.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Database";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tables";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(487, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tables";
            // 
            // lstRight
            // 
            this.lstRight.AutoArrange = false;
            this.lstRight.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lstRight.Enabled = false;
            this.lstRight.FullRowSelect = true;
            this.lstRight.GridLines = true;
            this.lstRight.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstRight.Location = new System.Drawing.Point(479, 70);
            this.lstRight.MultiSelect = false;
            this.lstRight.Name = "lstRight";
            this.lstRight.Size = new System.Drawing.Size(375, 459);
            this.lstRight.TabIndex = 16;
            this.lstRight.UseCompatibleStateImageBehavior = false;
            this.lstRight.View = System.Windows.Forms.View.Details;
            this.lstRight.SelectedIndexChanged += new System.EventHandler(this.lstRight_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "";
            this.columnHeader2.Width = 371;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(6, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 23);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Column doesn\'t have the same casing.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Column is missing from this side";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(271, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 23);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(14, 535);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(840, 66);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Legend";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(757, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Match found";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Location = new System.Drawing.Point(726, 25);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 23);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(534, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "No column found on other side.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(503, 25);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 613);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstRight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDBConnectRight);
            this.Controls.Add(this.cmbDatabaseRight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDBConnectLeft);
            this.Controls.Add(this.cmbDatabaseLeft);
            this.Controls.Add(this.lblYolo);
            this.Controls.Add(this.btnRefRight);
            this.Controls.Add(this.btnRefLeft);
            this.Controls.Add(this.cmbRight);
            this.Controls.Add(this.lstLeft);
            this.Controls.Add(this.btnGoLeft);
            this.Controls.Add(this.btnGoRight);
            this.Controls.Add(this.cmbLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "MergeTool";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLeft;
        private System.Windows.Forms.Button btnGoRight;
        private System.Windows.Forms.Button btnGoLeft;
        private System.Windows.Forms.ListView lstLeft;
        private System.Windows.Forms.ComboBox cmbRight;
        private System.Windows.Forms.Button btnRefLeft;
        private System.Windows.Forms.Button btnRefRight;
        private System.Windows.Forms.Label lblYolo;
        private System.Windows.Forms.ComboBox cmbDatabaseLeft;
        private System.Windows.Forms.Button btnDBConnectLeft;
        private System.Windows.Forms.Button btnDBConnectRight;
        private System.Windows.Forms.ComboBox cmbDatabaseRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lstRight;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

