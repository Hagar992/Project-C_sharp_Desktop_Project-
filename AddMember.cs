using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Project
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Member_Name.Text == "" || Phone_Number.Text == "" || Amount.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                MessageBox.Show($"Member Name: {Member_Name.Text}\n" + $"Phone Number: {Phone_Number.Text}\n" + $"Age: {Age.Value}\n" + $"Gender: {cb_Gender.Text}\n" + $"Amount: {Amount.Text}\n" +
                    $"Time: {cb_time.Text}\n");
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Member_Name.Text = "";
            Phone_Number.Text = "";
            Amount.Text = "";
            Age.Text = "18";
            cb_Gender.Text = "";
            cb_time.Text = "";

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login login = new login();
            login.Show();
            this.Hide();
        }
    }
}
