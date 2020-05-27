using System;
using WindowsFormsApp1.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1.Bussiness;

namespace WindowsFormsApp1.View
{
    public partial class RegisterPart : Form
    {
        PersonRegisterController User = new PersonRegisterController(new ApplicationContexts());
        PersonBookTypeController UserBookType = new PersonBookTypeController(new ApplicationContexts());
        RevenueExpenditureBookController BookForUser = new RevenueExpenditureBookController(new ApplicationContexts());
        PersonAccountController UserAccount = new PersonAccountController(new ApplicationContexts());
        RevenueExpeditureBook smallshop = new RevenueExpeditureBook();
        public RegisterPart()
        {
            InitializeComponent();
        }

        public void Register_Click(object sender, EventArgs e)
        {
            LoginPart login = new LoginPart();
            //Check's is everything filled
            if (txtUsernameRegisterForm.Text == "" || txtPasswordRegisterForm.Text == "" || txtConfirmPasswordRegisterForm.Text == "" || Bookstypes.Text == "")
            {
                MessageBox.Show("Please fill the rows to register");
            }  
            else
            {
                if (Bookstypes.Text == "Business")
                {
                    //Check's is the password textbox and Confirmpassword texbox are equal and not equal to zero
                    if (txtPasswordRegisterForm.Text == txtConfirmPasswordRegisterForm.Text && txtPasswordRegisterForm.Text.Length != 0)
                    {
                        //this variable returns true if the name exists or false if no
                        var CheckIfExists = User.CheckIfUsernameExists(txtUsernameRegisterForm.Text);
                        //this if statement checks if the names are equal or no
                        if (!(CheckIfExists == txtUsernameRegisterForm.Text))
                        {
                            User.Add(txtUsernameRegisterForm.Text, txtPasswordRegisterForm.Text);
                            //this if will happen only once per creation of a new account 
                            if (!(UserBookType.CheckIfExsist()))
                            {
                                var business = "Business";
                                UserBookType.Add(business, 1);
                            }
                            var a = User.GetAll();
                            UserAccount.Add(1);
                            BookForUser.Add(smallshop.GetTime(), 0, 0, 0, 0, 0, 0, 1, a.Count());
                            this.Hide();
                            login.Show();
                            MessageBox.Show("Succsessfully registered");
                        }
                        else
                        {
                            MessageBox.Show("This Username is taken");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passswords doesn't match");
                    }
                }
            }       
        }

        private void Return_Click(object sender, EventArgs e)
        {
            LoginPart login = new LoginPart();
            this.Hide();
            login.Show();
        }
    }
}
