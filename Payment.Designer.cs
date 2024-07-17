namespace First_Project
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            textBox3 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Member_Name = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            Amont = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.AutoSize = true;
            textBox3.FlatStyle = FlatStyle.Flat;
            textBox3.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.MenuHighlight;
            textBox3.Location = new Point(79, 9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 36);
            textBox3.TabIndex = 3;
            textBox3.Text = "Fitness Center";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Old Antic Outline Shaded", 14.25F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(138, 45);
            label1.Name = "label1";
            label1.Size = new Size(132, 39);
            label1.TabIndex = 4;
            label1.Text = "Payment";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 135);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 5;
            label2.Text = "Member Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 6;
            label3.Text = "Payment  Month";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 249);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Amont";
            // 
            // Member_Name
            // 
            Member_Name.BackColor = SystemColors.InactiveBorder;
            Member_Name.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Member_Name.Location = new Point(182, 135);
            Member_Name.MaxLength = 20;
            Member_Name.Name = "Member_Name";
            Member_Name.Size = new Size(165, 27);
            Member_Name.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarMonthBackground = SystemColors.InactiveBorder;
            dateTimePicker1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(182, 190);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 27);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.Value = new DateTime(2024, 7, 1, 0, 0, 0, 0);
            // 
            // Amont
            // 
            Amont.BackColor = SystemColors.InactiveBorder;
            Amont.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amont.Location = new Point(182, 245);
            Amont.MaxLength = 20;
            Amont.Name = "Amont";
            Amont.Size = new Size(165, 27);
            Amont.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Font = new Font("PT Bold Heading", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 178);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(26, 318);
            button1.Name = "button1";
            button1.Size = new Size(95, 40);
            button1.TabIndex = 19;
            button1.Text = "Pay";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MintCream;
            button2.Font = new Font("PT Bold Heading", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 178);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(166, 318);
            button2.Name = "button2";
            button2.Size = new Size(95, 40);
            button2.TabIndex = 20;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MintCream;
            button3.Font = new Font("PT Bold Heading", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 178);
            button3.ForeColor = SystemColors.MenuHighlight;
            button3.Location = new Point(287, 318);
            button3.Name = "button3";
            button3.Size = new Size(95, 40);
            button3.TabIndex = 21;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(395, 9);
            label5.Name = "label5";
            label5.Size = new Size(37, 36);
            label5.TabIndex = 22;
            label5.Text = "x";
            label5.Click += label5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(267, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 416);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Amont);
            Controls.Add(dateTimePicker1);
            Controls.Add(Member_Name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Member_Name;
        private DateTimePicker dateTimePicker1;
        private TextBox Amont;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label5;
        private PictureBox pictureBox1;
    }
}