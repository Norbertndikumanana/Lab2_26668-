namespace Lab2_Norbert_NDIKUMANA_26668
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtusername.Text) ||
        string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Username and Password cannot be empty.",
                    "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Login successful!", "Login",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtpassword.Clear();
            ChooseForm choose = new ChooseForm(this);
            choose.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
