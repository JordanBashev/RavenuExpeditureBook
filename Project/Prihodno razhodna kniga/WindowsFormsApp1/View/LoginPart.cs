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

        //hides the login form and shows register form
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
            //returns the password if it exists if not ,returns null
            var Checkpass = contexts.PersonRegisters.FirstOrDefault(x => x.Password == pass);
            //returns the username if it exists if not ,returns null 
            var CheckUsername = contexts.PersonRegisters.FirstOrDefault(x => x.Username == username);

            //returns the Booktype if it exists if not ,returns null
            var checkforBook = contexts.PersonBookTypes.FirstOrDefault(x => x.BookType == business);

            try
            {
                //this if statement checks if the password and the username exist
                if (Checkpass.Password == txtPassword.Text && CheckUsername.Username == txtUsername.Text)
                {
                    //this if statement checks if the booktype exists 
                    if (checkforBook.BookType == "Business")
                    {
                        this.Hide();
                        RevenueExpediture.Show();
                        //Takes the username so it can be used later for the update method
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
