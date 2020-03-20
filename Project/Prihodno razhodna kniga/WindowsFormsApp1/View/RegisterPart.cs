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
        PersonRegisterController User = new PersonRegisterController();
        PersonBookTypeController UserBookType = new PersonBookTypeController();
        RevenueExpenditureBookController BookForUser = new RevenueExpenditureBookController();
        PersonAccountController UserAccount = new PersonAccountController();
        ApplicationContext context = new ApplicationContext();
        RevenueExpeditureBook smallshop = new RevenueExpeditureBook();
        public RegisterPart()
        {
            InitializeComponent();
        }

        public void Register_Click(object sender, EventArgs e)
        {
            LoginPart login = new LoginPart();
            try
            {
                if (txtUsernameRegisterForm.Text == "" || txtPasswordRegisterForm.Text == "" || txtConfirmPasswordRegisterForm.Text == "" || Bookstypes.Text == "")
                {
                    MessageBox.Show("Please fill the froms to register");
                }
                if (Bookstypes.Text == "Small Shop")
                {
                    if (txtPasswordRegisterForm.Text == txtConfirmPasswordRegisterForm.Text)
                    {
                        User.Add(txtUsernameRegisterForm.Text, txtPasswordRegisterForm.Text);
                        if(!(UserBookType.CheckIfExsist()))
                        {
                            var small = "Small Shop";
                            //var medeum = "Medium Shop";
                            //var Large = "Large Shop";
                            UserBookType.Add(small, 1);
                            //UserBookType.Add(medeum, 2);
                            //UserBookType.Add(Large, 3);                          
                        }
                        var a = User.GetAllIds();
                        UserAccount.Add(a, 1);
                        BookForUser.Add(smallshop.GetTime(),0, 0, 0, 0, 0, 0,1);
                        this.Hide();
                        login.Show();
                        MessageBox.Show("Succsessfully registered");
                    }
                    else
                    {
                        MessageBox.Show("Passswords doesn't match");
                    }
                }
                else if (Bookstypes.Text == "Medium Shop")
                {

                }
                else if (Bookstypes.Text == "Large Shop")
                {

                }
                else
                {
                    MessageBox.Show("Passwords doesn't match");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message);
            }
        }

        public string GetBookType()
        {
            return Bookstypes.Text;
        }
        private void Message(object sender, EventArgs e)
        {
            MessageBox.Show("Small Shop - 2 checkouts" + Environment.NewLine + "Medium Shop - 4 checkouts" + Environment.NewLine + "Large Shop - 6 checkouts");
        }

        private void Return_Click(object sender, EventArgs e)
        {
            LoginPart login = new LoginPart();
            this.Hide();
            login.Show();
        }
    }
}
