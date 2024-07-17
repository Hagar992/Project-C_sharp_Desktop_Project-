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
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Member_Name.Text == "" || Amont.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                MessageBox.Show($"Member_Name: {Member_Name.Text}\n" +
                    $"Month: {dateTimePicker1.Text}\n" +
                    $"Amont: {Amont.Text}\n");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Member_Name.Text = "";
            dateTimePicker1.Text = "";
            Amont.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }
    }
}
