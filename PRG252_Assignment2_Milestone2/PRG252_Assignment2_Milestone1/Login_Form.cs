using System;
using System.Windows.Forms;

namespace PRG252_Assignment2_Milestone1
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            UserCredentials myUserLogin = new UserCredentials();
            FileHandler myFileHandler = new FileHandler();
            DataHandler myDataHandler = new DataHandler();

            myUserLogin.UserDetails(username, password);

            string[] lines = myFileHandler.ReadFromFile();

            Login_Form form1 = new Login_Form();
            Main_Form form2 = new Main_Form();

            bool usernameExists = Array.Exists(lines, element => element == myUserLogin.Username);
            bool passwordExists = Array.Exists(lines, element => element == myUserLogin.Password);

            

            if (usernameExists && passwordExists)
            {
                form2.Show();
            }
            else if (!usernameExists || !passwordExists)
            {
                if (MessageBox.Show("User not found or password incorrect. Register new user?", "Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {                  
                }
                else{}
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        }
    }
}
