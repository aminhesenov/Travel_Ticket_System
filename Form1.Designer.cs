namespace Travel
{
    partial class Form1
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
            panel1 = new Panel();
            label9 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            maskedTextBox2 = new MaskedTextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            button3 = new Button();
            textBox4 = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label9);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 73);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(308, 9);
            label9.Name = "label9";
            label9.Size = new Size(163, 32);
            label9.TabIndex = 1;
            label9.Text = "BMU TRAVEL";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(22, 79);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 270);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Travel info";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(64, 64, 64);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(256, 35);
            button4.Name = "button4";
            button4.Size = new Size(45, 79);
            button4.TabIndex = 10;
            button4.Text = "<\r\n>";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bakı", "Gəncə", "Lənkəran", "Şəki", "Naxçıvan", "Xankəndi" });
            comboBox2.Location = new Point(92, 86);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(158, 28);
            comboBox2.TabIndex = 7;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bakı", "Gəncə", "Lənkəran", "Şəki", "Naxçıvan", "Xankəndi" });
            comboBox1.Location = new Point(92, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(158, 28);
            comboBox1.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(92, 134);
            maskedTextBox2.Mask = "00/00/0000 90:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(158, 27);
            maskedTextBox2.TabIndex = 5;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(92, 193);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(158, 27);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 193);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "Yer:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 134);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 2;
            label3.Text = "Tarix:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 86);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 1;
            label2.Text = "Haraya:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 38);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Haradan:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(maskedTextBox1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(455, 79);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(314, 270);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Travel info";
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(64, 64, 64);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(108, 219);
            button3.Name = "button3";
            button3.Size = new Size(158, 34);
            button3.TabIndex = 9;
            button3.Text = "Bilet al";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(108, 176);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(158, 27);
            textBox4.TabIndex = 8;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(108, 127);
            maskedTextBox1.Mask = "(994) 00-000-00-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(158, 27);
            maskedTextBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(108, 79);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 27);
            textBox3.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 27);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 176);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 3;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 127);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 2;
            label6.Text = "Telefon:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 79);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 1;
            label7.Text = "FIN";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(8, 41);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 0;
            label8.Text = "Ad ve soyad:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 374);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(800, 109);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(22, 507);
            button1.Name = "button1";
            button1.Size = new Size(116, 34);
            button1.TabIndex = 4;
            button1.Text = "Siyahidan sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(653, 507);
            button2.Name = "button2";
            button2.Size = new Size(116, 34);
            button2.TabIndex = 5;
            button2.Text = "Çıxış";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(800, 553);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Label label9;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox2;
        private TextBox textBox1;
        private Button button3;
        private TextBox textBox4;
        private MaskedTextBox maskedTextBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button4;
    }
}
