namespace latihan1
{
    partial class titleApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNama = new Label();
            txtNama = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            txtHobi = new TextBox();
            lblHobi = new Label();
            groupBox3 = new GroupBox();
            txtAsal = new TextBox();
            lblAsal = new Label();
            btnSubmit = new Button();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            lblTampilkanData = new Label();
            headerDataTampilkan = new Label();
            btnReset = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // lblNama
            // 
            lblNama.AutoSize = true;
            lblNama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNama.Location = new Point(6, 22);
            lblNama.Name = "lblNama";
            lblNama.Size = new Size(127, 21);
            lblNama.TabIndex = 0;
            lblNama.Text = "Masukkan Nama";
            // 
            // txtNama
            // 
            txtNama.Location = new Point(193, 22);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(283, 23);
            txtNama.TabIndex = 1;
            txtNama.TextChanged += textBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNama);
            groupBox1.Controls.Add(lblNama);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(493, 60);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtHobi);
            groupBox2.Controls.Add(lblHobi);
            groupBox2.Location = new Point(21, 78);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(493, 60);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // txtHobi
            // 
            txtHobi.Location = new Point(193, 22);
            txtHobi.Name = "txtHobi";
            txtHobi.Size = new Size(283, 23);
            txtHobi.TabIndex = 1;
            // 
            // lblHobi
            // 
            lblHobi.AutoSize = true;
            lblHobi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblHobi.Location = new Point(6, 22);
            lblHobi.Name = "lblHobi";
            lblHobi.Size = new Size(118, 21);
            lblHobi.TabIndex = 0;
            lblHobi.Text = "Masukkan Hobi";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtAsal);
            groupBox3.Controls.Add(lblAsal);
            groupBox3.Location = new Point(21, 144);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(493, 60);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            // 
            // txtAsal
            // 
            txtAsal.Location = new Point(193, 22);
            txtAsal.Name = "txtAsal";
            txtAsal.Size = new Size(283, 23);
            txtAsal.TabIndex = 1;
            // 
            // lblAsal
            // 
            lblAsal.AutoSize = true;
            lblAsal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAsal.Location = new Point(6, 22);
            lblAsal.Name = "lblAsal";
            lblAsal.Size = new Size(114, 21);
            lblAsal.TabIndex = 0;
            lblAsal.Text = "Masukkan Asal";
            lblAsal.Click += label1_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.ForestGreen;
            btnSubmit.ForeColor = SystemColors.Control;
            btnSubmit.Location = new Point(6, 22);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(470, 32);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += button1_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnReset);
            groupBox4.Controls.Add(btnSubmit);
            groupBox4.Location = new Point(21, 210);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(493, 108);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(lblTampilkanData);
            groupBox5.Controls.Add(headerDataTampilkan);
            groupBox5.Location = new Point(21, 324);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(493, 107);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Enter += groupBox5_Enter;
            // 
            // lblTampilkanData
            // 
            lblTampilkanData.AutoSize = true;
            lblTampilkanData.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTampilkanData.Location = new Point(6, 42);
            lblTampilkanData.Name = "lblTampilkanData";
            lblTampilkanData.Size = new Size(0, 21);
            lblTampilkanData.TabIndex = 2;
            // 
            // headerDataTampilkan
            // 
            headerDataTampilkan.AutoSize = true;
            headerDataTampilkan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            headerDataTampilkan.Location = new Point(6, 10);
            headerDataTampilkan.Name = "headerDataTampilkan";
            headerDataTampilkan.Size = new Size(137, 21);
            headerDataTampilkan.TabIndex = 1;
            headerDataTampilkan.Text = "Data Ditampilkan :";
            headerDataTampilkan.Visible = false;
            headerDataTampilkan.Click += label1_Click_1;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.ForeColor = SystemColors.Control;
            btnReset.Location = new Point(6, 60);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(470, 32);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // titleApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 442);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "titleApp";
            Text = "Aplikasi Menampilkan Data";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblNama;
        private TextBox txtNama;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtHobi;
        private Label lblHobi;
        private GroupBox groupBox3;
        private TextBox txtAsal;
        private Label lblAsal;
        private Button btnSubmit;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private Label headerDataTampilkan;
        private Label lblTampilkanData;
        private Button btnReset;
    }
}