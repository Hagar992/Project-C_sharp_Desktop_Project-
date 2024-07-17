namespace First_Project
{
    partial class AddMember
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
            cb_Gender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            Member_Name = new TextBox();
            Phone_Number = new TextBox();
            Age = new NumericUpDown();
            cb_time = new ComboBox();
            Amount = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label9 = new Label();
            label10 = new Label();
            textBox3 = new Label();
            ((System.ComponentModel.ISupportInitialize)Age).BeginInit();
            SuspendLayout();
            // 
            // cb_Gender
            // 
            cb_Gender.BackColor = SystemColors.InactiveBorder;
            cb_Gender.DisplayMember = " ";
            cb_Gender.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Gender.FormattingEnabled = true;
            cb_Gender.Items.AddRange(new object[] { "Female", "Male" });
            cb_Gender.Location = new Point(5, 264);
            cb_Gender.Name = "cb_Gender";
            cb_Gender.Size = new Size(142, 29);
            cb_Gender.Sorted = true;
            cb_Gender.TabIndex = 15;
            cb_Gender.TabStop = false;
            cb_Gender.ValueMember = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(747, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 36);
            label1.TabIndex = 3;
            label1.Text = "x";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Old Antic Outline Shaded", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(255, 45);
            label2.Name = "label2";
            label2.Size = new Size(243, 39);
            label2.TabIndex = 4;
            label2.Text = "Add New Member";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Elephant", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(5, 133);
            label3.Name = "label3";
            label3.Size = new Size(120, 20);
            label3.TabIndex = 5;
            label3.Text = "Member Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Elephant", 11.25F);
            label4.Location = new Point(266, 133);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 6;
            label4.Text = "Phone Number";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Elephant", 11.25F);
            label5.Location = new Point(563, 133);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 7;
            label5.Text = "Age";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Elephant", 11.25F);
            label6.Location = new Point(5, 241);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 8;
            label6.Text = "Gender";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Elephant", 11.25F);
            label7.Location = new Point(260, 241);
            label7.Name = "label7";
            label7.Size = new Size(137, 20);
            label7.TabIndex = 9;
            label7.Text = "Monthly Amount";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Elephant", 11.25F);
            label8.Location = new Point(550, 241);
            label8.Name = "label8";
            label8.Size = new Size(63, 20);
            label8.TabIndex = 10;
            label8.Text = "Timing";
            // 
            // Member_Name
            // 
            Member_Name.BackColor = SystemColors.InactiveBorder;
            Member_Name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Member_Name.Location = new Point(3, 156);
            Member_Name.MaxLength = 20;
            Member_Name.Name = "Member_Name";
            Member_Name.Size = new Size(193, 29);
            Member_Name.TabIndex = 11;
            // 
            // Phone_Number
            // 
            Phone_Number.BackColor = SystemColors.InactiveBorder;
            Phone_Number.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Phone_Number.Location = new Point(266, 156);
            Phone_Number.MaxLength = 11;
            Phone_Number.Name = "Phone_Number";
            Phone_Number.Size = new Size(193, 29);
            Phone_Number.TabIndex = 12;
            // 
            // Age
            // 
            Age.BackColor = SystemColors.InactiveBorder;
            Age.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Age.Location = new Point(563, 157);
            Age.Maximum = new decimal(new int[] { 35, 0, 0, 0 });
            Age.Minimum = new decimal(new int[] { 18, 0, 0, 0 });
            Age.Name = "Age";
            Age.Size = new Size(179, 29);
            Age.TabIndex = 14;
            Age.Value = new decimal(new int[] { 18, 0, 0, 0 });
            // 
            // cb_time
            // 
            cb_time.BackColor = SystemColors.InactiveBorder;
            cb_time.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_time.FormattingEnabled = true;
            cb_time.Items.AddRange(new object[] { "6am   : 10am", "10am : 1pm", "1pm   : 4pm", "4pm   : 7pm", "7pm   : 10pm" });
            cb_time.Location = new Point(563, 264);
            cb_time.Name = "cb_time";
            cb_time.Size = new Size(142, 29);
            cb_time.TabIndex = 16;
            // 
            // Amount
            // 
            Amount.BackColor = SystemColors.InactiveBorder;
            Amount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Amount.Location = new Point(266, 264);
            Amount.MaxLength = 11;
            Amount.Name = "Amount";
            Amount.Size = new Size(193, 29);
            Amount.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Font = new Font("PT Bold Heading", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 178);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(443, 345);
            button1.Name = "button1";
            button1.Size = new Size(95, 40);
            button1.TabIndex = 18;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MintCream;
            button2.Font = new Font("PT Bold Heading", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 178);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(679, 345);
            button2.Name = "button2";
            button2.Size = new Size(95, 40);
            button2.TabIndex = 19;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MintCream;
            button3.Font = new Font("PT Bold Heading", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 178);
            button3.ForeColor = SystemColors.MenuHighlight;
            button3.Location = new Point(561, 345);
            button3.Name = "button3";
            button3.Size = new Size(95, 40);
            button3.TabIndex = 20;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(3, 451);
            label9.Name = "label9";
            label9.Size = new Size(242, 18);
            label9.TabIndex = 21;
            label9.Text = "Contact:shamsatia96@gmail.com";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Flat;
            label10.Font = new Font("Georgia", 12F);
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(12, 433);
            label10.Name = "label10";
            label10.Size = new Size(187, 18);
            label10.TabIndex = 22;
            label10.Text = "DeveloppedBy:HagarAtia";
            // 
            // textBox3
            // 
            textBox3.AutoSize = true;
            textBox3.FlatStyle = FlatStyle.Flat;
            textBox3.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.MenuHighlight;
            textBox3.Location = new Point(242, 9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 36);
            textBox3.TabIndex = 2;
            textBox3.Text = "Fitness Center";
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 478);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Amount);
            Controls.Add(cb_time);
            Controls.Add(cb_Gender);
            Controls.Add(Age);
            Controls.Add(Phone_Number);
            Controls.Add(Member_Name);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMember";
            Text = "AddMember";
            ((System.ComponentModel.ISupportInitialize)Age).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox Member_Name;
        private TextBox Phone_Number;
        private NumericUpDown Age;
        private ComboBox cb_Gender;
        private ComboBox cb_time;
        private TextBox Amount;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label9;
        private Label label10;
        private Label textBox3;
    }
}