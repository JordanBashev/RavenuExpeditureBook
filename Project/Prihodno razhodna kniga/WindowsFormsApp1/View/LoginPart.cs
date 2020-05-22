using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.View
{
    public partial class LoginPart : Form
    {
        public LoginPart()
        {
            InitializeComponent();
        }

        ApplicationContexts contexts = new ApplicationContexts();
        RegisterPart register = new RegisterPart();
        RevenueExpeditureBook RevenueExpediture = new RevenueExpeditureBook();

        public void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            register.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            
            var business = "Business";
            var pass = txtPassword.Text;
            var username = txtUsername.Text;
            var Checkpass = contexts.PersonRegisters.FirstOrDefault(x => x.Password == pass);
            var CheckUsername = contexts.PersonRegisters.FirstOrDefault(x => x.Username == username);

            var checkforBook = contexts.PersonBookTypes.FirstOrDefault(x => x.BookType == business);

            try
            {
                if (Checkpass.Password == txtPassword.Text && CheckUsername.Username == txtUsername.Text)
                {
                    if (checkforBook.BookType == "Business")
                    {
                        this.Hide();
                        RevenueExpediture.Show();
                        RevenueExpediture.label14.Text = txtUsername.Text;
                    }
                }
            } 
            catch (Exception)
            {
                MessageBox.Show("Invalid Password or Username!");
            }
        }
    }
}
