namespace First_Project
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            pictureBox1 = new PictureBox();
            textBox3 = new Label();
            Name_txt = new TextBox();
            Password_txt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(401, 130);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(298, 186);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox3
            // 
            textBox3.AutoSize = true;
            textBox3.FlatStyle = FlatStyle.Flat;
            textBox3.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = SystemColors.MenuHighlight;
            textBox3.Location = new Point(217, 9);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 36);
            textBox3.TabIndex = 1;
            textBox3.Text = "Fitness Center";
            // 
            // Name_txt
            // 
            Name_txt.BackColor = SystemColors.InactiveBorder;
            Name_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name_txt.Location = new Point(129, 149);
            Name_txt.MaxLength = 20;
            Name_txt.Name = "Name_txt";
            Name_txt.Size = new Size(236, 29);
            Name_txt.TabIndex = 2;
            // 
            // Password_txt
            // 
            Password_txt.BackColor = SystemColors.InactiveBorder;
            Password_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_txt.Location = new Point(129, 226);
            Password_txt.MaxLength = 15;
            Password_txt.Name = "Password_txt";
            Password_txt.PasswordChar = '*';
            Password_txt.Size = new Size(236, 29);
            Password_txt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Farsi Simple Outline", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(19, 147);
            label1.Name = "label1";
            label1.Size = new Size(67, 33);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Farsi Simple Outline", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label2.ForeColor = SystemColors.InactiveCaptionText;
            label2.Location = new Point(2, 224);
            label2.Name = "label2";
            label2.Size = new Size(101, 33);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.MintCream;
            button1.Font = new Font("PT Bold Heading", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 178);
            button1.ForeColor = SystemColors.MenuHighlight;
            button1.Location = new Point(129, 335);
            button1.Name = "button1";
            button1.Size = new Size(95, 40);
            button1.TabIndex = 6;
            button1.Text = "login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MintCream;
            button2.Font = new Font("PT Bold Heading", 9.75F, FontStyle.Italic);
            button2.ForeColor = SystemColors.MenuHighlight;
            button2.Location = new Point(258, 335);
            button2.Name = "button2";
            button2.Size = new Size(95, 40);
            button2.TabIndex = 7;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(662, 9);
            label3.Name = "label3";
            label3.Size = new Size(37, 36);
            label3.TabIndex = 8;
            label3.Text = "x";
            label3.Click += label3_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(711, 433);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Password_txt);
            Controls.Add(Name_txt);
            Controls.Add(textBox3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "Fitness Center";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label textBox3;
        private TextBox Name_txt;
        private TextBox Password_txt;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Label label3;
    }
}
