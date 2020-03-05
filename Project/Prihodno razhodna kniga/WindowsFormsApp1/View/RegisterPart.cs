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
        PersonAccountController UserAccount = new PersonAccountController();
        RevenueExpenditureBookController BookForUser = new RevenueExpenditureBookController();
        SmallShop smallshop = new SmallShop();
        public RegisterPart()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
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
                    
                    //in number 6 goes checkout with all the summed up numbers
                    // decimal checkout = smallshop.GetValuesForCheckout();
                    if (txtPasswordRegisterForm.Text == txtConfirmPasswordRegisterForm.Text)
                    {
                        //BookForUser.Add(1,smallshop.GetTime(),0, 0, 0, 0, 0, 0);
                        User.Add(txtUsernameRegisterForm.Text,  txtPasswordRegisterForm.Text);
                        var a = User.GetAllIds();
                        UserAccount.Add(Bookstypes.Text,a);
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
        private void message(object sender, EventArgs e)
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
