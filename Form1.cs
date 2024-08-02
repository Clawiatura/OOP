using System.Windows.Forms;



namespace PracticsDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            Form2 formRegister = new Form2();
            formRegister.ShowDialog();
        }

        private void btJoin_Click(object sender, EventArgs e)
        {
            //if (userRegistration.AuthenticateUser(tbLogin.Text, tbPassword.Text))
            {
                Form3 lCForm = new Form3();
                lCForm.Show();
                this.Hide();  
            }

        }

    }
}

