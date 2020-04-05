using System;
using System.Collections.Generic;
using System.ComponentModel;
using WindowsFormsApp1.Data;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Data.Models;
using WindowsFormsApp1.Bussiness;
using WindowsFormsApp1;
using WindowsFormsApp1.View;

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
            if (txtUsernameRegisterForm.Text == "" || txtPasswordRegisterForm.Text == "" || txtConfirmPasswordRegisterForm.Text == "" || Bookstypes.Text == "")
            {
                MessageBox.Show("Please fill the rows to register");
            }  
            else
            {
                if (Bookstypes.Text == "Business")
                {
                    if (txtPasswordRegisterForm.Text == txtConfirmPasswordRegisterForm.Text && txtPasswordRegisterForm.Text.Length != 0)
                    {
                        var CheckIfExists = User.CheckIfUsernameExists(txtUsernameRegisterForm.Text);
                        if (!(CheckIfExists == txtUsernameRegisterForm.Text))
                        {
                            User.Add(txtUsernameRegisterForm.Text, txtPasswordRegisterForm.Text);
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
                else
                {
                    MessageBox.Show("Passwords doesn't match");

                }
            }       
        }

        public string GetBookType()
        {
            return Bookstypes.Text;
        }

        private void Return_Click(object sender, EventArgs e)
        {
            LoginPart login = new LoginPart();
            this.Hide();
            login.Show();
        }
    }
}
