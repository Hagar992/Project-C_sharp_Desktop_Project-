namespace First_Project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Name_txt.Text == "" || Password_txt.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else 
            {
                MessageBox.Show($"Name: {Name_txt.Text}\n" +
                   $"Password: {Password_txt.Text}\n");

            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMember addMember = new AddMember();
            addMember.Show();
            this.Hide();
        }
    }
}
