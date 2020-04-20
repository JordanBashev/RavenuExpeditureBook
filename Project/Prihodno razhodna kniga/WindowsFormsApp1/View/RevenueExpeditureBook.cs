﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Bussiness;
using WindowsFormsApp1.Data;

namespace WindowsFormsApp1.View
{
    public partial class RevenueExpeditureBook : Form
    {

        RevenueExpenditureBookController BookForUser = new RevenueExpenditureBookController(new ApplicationContexts());
        PersonAccountController PersonAccount = new PersonAccountController(new ApplicationContexts());
        PersonRegisterController PersonRegister = new PersonRegisterController(new ApplicationContexts());

        ApplicationContexts contexts = new ApplicationContexts();

        public RevenueExpeditureBook()
        {
            InitializeComponent();
            DatetimeLabel.Text = DateTime.Today.ToShortDateString();
            timer1.Enabled = true;
        }

        private string GetUserid()
        {
            var getusernameid = contexts.PersonRegisters.FirstOrDefault(x => x.Username == label14.Text);
            var getthisid = contexts.RevenueExpenditureBooks.FirstOrDefault(x => x.UserRegisteredId == getusernameid.Id);
            var GetCountedFromYesterday = contexts.RevenueExpenditureBooks.Where(x => x.UserRegisteredId == getthisid.Id).FirstOrDefault(x => x.Date == GetTime().AddDays(-1));
            if(GetCountedFromYesterday == null)
            {
                return Income1.Text = "0";
            }
            else
            {
                return Income1.Text = GetCountedFromYesterday.Counted.ToString();
            }
        }

        public string GetIncomeValue()
        {
            decimal incomeresult = 0;
            foreach(Control x in this.Controls)
            {
                if(x is TextBox && (string)x.Tag == "income")
                {
                    decimal calcul = decimal.Parse(x.Text);
                    decimal getval = calcul;
                    incomeresult += getval;
                }
            }
            return IncomeResult.Text = incomeresult.ToString();
        }

        public string GetRawMaterialsValue()
        {
            decimal RawMaterialsresult = 0;
            foreach (Control x in this.Controls)
            {
                if (x is TextBox && (string)x.Tag == "RawMat")
                {
                    decimal calcul = decimal.Parse(x.Text);
                    decimal getval = calcul;
                    RawMaterialsresult += getval;
                }
            }
            return RamMatResult.Text = RawMaterialsresult.ToString();
        }

        public string GetExpensesValue()
        {
            decimal Expensesresult = 0;
            foreach (Control x in this.Controls)
            {
                if (x is TextBox && (string)x.Tag == "Expenses")
                {
                    decimal calcul = decimal.Parse(x.Text);
                    decimal getval = calcul;
                    Expensesresult += getval;
                }
            }
            return ExpenseResult.Text = Expensesresult.ToString();
        }

        public string GetBalanceValue()
        {
            decimal PreFinalResults = decimal.Parse(GetIncomeValue()) - decimal.Parse(GetRawMaterialsValue()) - decimal.Parse(GetExpensesValue());
            return Allbalance.Text = PreFinalResults.ToString();
        }

        public string GetCountedValue()
        {
            return CountedCash.Text.ToString();
        }

        public string GetCheckoutValue()
        {
            decimal FinalResult;
            if (decimal.Parse(Allbalance.Text) < 0)
            {
               FinalResult = decimal.Parse(Allbalance.Text) + decimal.Parse(CountedCash.Text);

                return CheckOut.Text = FinalResult.ToString();
            }
            else
            {
                FinalResult = decimal.Parse(Allbalance.Text) - decimal.Parse(CountedCash.Text);

                return CheckOut.Text = FinalResult.ToString();
            }
        }

        public void GetValuesForCheckout()
        {
            GetBalanceValue();
            GetCheckoutValue();
        }

        public DateTime GetTime()
        {
            DatetimeLabel.Text = DateTime.Today.ToShortDateString();
            return DateTime.Parse(DatetimeLabel.Text);
        }

        private void Sum_Click(object sender, EventArgs e)
        {
            GetValuesForCheckout();
        }

        private void Info_Click(object sender, EventArgs e)
        {
            Information name = new Information();
            name.Show();
        }

        private void UpdateDB_Click(object sender, EventArgs e)
        {
            var getIdByUsername = contexts.PersonRegisters.FirstOrDefault(x => x.Username == label14.Text);
            var getThisId = contexts.RevenueExpenditureBooks.Where(x => x.Date == GetTime()).FirstOrDefault(x => x.UserRegisteredId == getIdByUsername.Id);
            var CheckForDateTrue = contexts.RevenueExpenditureBooks.FirstOrDefault(x => x.Date == GetTime());
            var Income = decimal.Parse(GetIncomeValue());
            var RawMaterial = decimal.Parse(GetRawMaterialsValue());
            var Expenses = decimal.Parse(GetExpensesValue());
            var Balance = decimal.Parse(GetBalanceValue());
            var Counted = decimal.Parse(GetCountedValue());
            var CheckOut = decimal.Parse(GetCheckoutValue());
            if (CheckForDateTrue == null || getThisId == null) 
            {
                BookForUser.Add(GetTime(), Income, RawMaterial, Expenses, Balance, Counted, CheckOut, 1, getIdByUsername.Id);
                MessageBox.Show("Database updated succsesfully");
            }
            else if (CheckForDateTrue.Date == GetTime() && getIdByUsername.Id == getThisId.UserRegisteredId)
            {
                BookForUser.Update(GetTime(), Income, RawMaterial, Expenses, Balance, Counted, CheckOut, 1, getIdByUsername.Id);
                MessageBox.Show("Database updated succsesfully");
            }
        }

        private void DeleteDB_Click(object sender, EventArgs e)
        {
            LoginPart login = new LoginPart();
            if (MessageBox.Show("Are you sure you want to delete your account", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var getIdByUsernameToDelete = contexts.PersonRegisters.FirstOrDefault(x => x.Username == label14.Text);
                BookForUser.Delete(getIdByUsernameToDelete.Id);
                PersonAccount.Delete(getIdByUsernameToDelete.Id);
                PersonRegister.Delete(getIdByUsernameToDelete.Id);
                MessageBox.Show("Account deleted succsesfully!");
                this.Hide();
                login.Show();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {          
            foreach (Control x in this.Controls)
            {
                if (x is TextBox && (string)x.Tag == "GenerWhenNeeded")
                {
                    if (x.Text.Length >= 2)
                    {
                        x.Tag = "RemoveWhenNotNeeded";
                        foreach (Control z in this.Controls)
                        {
                            if (z is PictureBox && (string)z.Tag == "AutoSizing")
                            {
                                z.Size = new Size(10, autosizer.Size.Height + (57 * 2));

                            }
                        }
                        foreach (Control g in this.Controls)
                        {
                            if (g is TextBox && (string)g.Tag == "LastRows")
                            {
                                g.Location = new Point(g.Location.X, g.Location.Y + (57 * 2));

                            }
                        }
                        foreach (Control q in this.Controls)
                        {
                            if (q is PictureBox && (string)q.Tag == "LastRows")
                            {
                                q.Location = new Point(q.Location.X, q.Location.Y + (57 * 2));
                            }
                        }
                        foreach (Control c in this.Controls)
                        {
                            if (c is Label && (string)c.Tag == "LastRows")
                            {
                                c.Location = new Point(c.Location.X, c.Location.Y + (57 * 2));
                            }
                        }
                        //Horizontal Black Lines
                        PictureBox pic1 = new PictureBox
                        {
                            Location = new Point(UsingForCreation.Location.X, UsingForCreation.Location.Y - 57),
                            Size = new Size(UsingForCreation.Size.Width, UsingForCreation.Size.Height),
                            BackColor = Color.Black
                        };
                        Controls.Owner.Controls.Add(pic1);
                        pic1.BringToFront();

                        PictureBox pic2 = new PictureBox
                        {
                            Location = new Point(UsingForCreation.Location.X, UsingForCreation.Location.Y),
                            Size = new Size(UsingForCreation.Size.Width, UsingForCreation.Size.Height),
                            BackColor = Color.Black
                        };
                        Controls.Owner.Controls.Add(pic2);
                        pic2.BringToFront();
                        //Horizontal Black Lines

                        GreenAutoSizer.Size = new Size(GreenAutoSizer.Size.Width, GreenAutoSizer.Size.Height + (57 * 2));
                        LightRedAutoSizer.Size = new Size(LightRedAutoSizer.Size.Width, LightRedAutoSizer.Size.Height + (57 * 2));
                        RedAutoSizer.Size = new Size(RedAutoSizer.Size.Width, RedAutoSizer.Size.Height + (57 * 2));


                        //TEXTBOXES Generetor
                        TextBox txtbox = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            Size = new Size(UsingForSizeAndLocation.Size.Width, UsingForSizeAndLocation.Size.Height),
                            Location = new Point(10, UsingForCreation.Location.Y - 41),
                            Font = new Font("Microsoft Sans Serif", 18),
                            Tag = "GenerWhenNeeded"
                        };
                        Controls.Owner.Controls.Add(txtbox);


                        TextBox txtbox1 = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            Size = new Size(UsingForSizeAndLocation.Size.Width, UsingForSizeAndLocation.Size.Height),
                            Location = new Point(10, UsingForCreation.Location.Y - (49 * 2)),
                            Font = new Font("Microsoft Sans Serif", 18)
                        };
                        Controls.Owner.Controls.Add(txtbox1);
                        //TEXTBOXES Generetor

                        //INCOME  Generetor
                        TextBox incomebox = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            BackColor = Color.LightGreen,
                            TextAlign = HorizontalAlignment.Center
                        };
                        incomebox.Text += "0";
                        incomebox.Size = new Size(Income11.Size.Width, Income11.Size.Height);
                        incomebox.Location = new Point(223, txtbox.Location.Y);
                        incomebox.Font = new Font("Microsoft Sans Serif", 18);
                        incomebox.Tag = "income";
                        Controls.Owner.Controls.Add(incomebox);


                        TextBox incomebox1 = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            BackColor = Color.LightGreen,
                            TextAlign = HorizontalAlignment.Center
                        };
                        incomebox1.Text += "0";
                        incomebox1.Size = new Size(Income11.Size.Width, Income11.Size.Height);
                        incomebox1.Location = new Point(223, txtbox1.Location.Y);
                        incomebox1.Font = new Font("Microsoft Sans Serif", 18);
                        incomebox1.Tag = "income";
                        Controls.Owner.Controls.Add(incomebox1);
                        //INCOME Generetor

                        //RAWMATERIALS Generetor
                        TextBox RawMatbox = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            BackColor = Color.LightCoral,
                            TextAlign = HorizontalAlignment.Center
                        };
                        RawMatbox.Text += "0";
                        RawMatbox.Size = new Size(RamMat11.Size.Width, RamMat11.Size.Height);
                        RawMatbox.Location = new Point(329, txtbox.Location.Y);
                        RawMatbox.Font = new Font("Microsoft Sans Serif", 18);
                        RawMatbox.Tag = "RawMat";
                        Controls.Owner.Controls.Add(RawMatbox);


                        TextBox RawMatbox1 = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            BackColor = Color.LightCoral,
                            TextAlign = HorizontalAlignment.Center
                        };
                        RawMatbox1.Text += "0";
                        RawMatbox1.Size = new Size(RamMat11.Size.Width, RamMat11.Size.Height);
                        RawMatbox1.Location = new Point(329, txtbox1.Location.Y);
                        RawMatbox1.Font = new Font("Microsoft Sans Serif", 18);
                        RawMatbox1.Tag = "RawMat";
                        Controls.Owner.Controls.Add(RawMatbox1);
                        //RAWMATERIALS Generetor

                        //EXPENSES Generetor
                        TextBox expensesbox = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            BackColor = Color.Red,
                            TextAlign = HorizontalAlignment.Center
                        };
                        expensesbox.Text += "0";
                        expensesbox.Size = new Size(Expense11.Size.Width, Expense11.Size.Height);
                        expensesbox.Location = new Point(467, txtbox.Location.Y);
                        expensesbox.Font = new Font("Microsoft Sans Serif", 18);
                        expensesbox.Tag = "Expenses";
                        Controls.Owner.Controls.Add(expensesbox);


                        TextBox expensesbox1 = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            BackColor = Color.Red,
                            TextAlign = HorizontalAlignment.Center
                        };
                        expensesbox1.Text += "0";
                        expensesbox1.Size = new Size(Expense11.Size.Width, Expense11.Size.Height);
                        expensesbox1.Location = new Point(467, txtbox1.Location.Y);
                        expensesbox1.Font = new Font("Microsoft Sans Serif", 18);
                        expensesbox1.Tag = "Expenses";
                        Controls.Owner.Controls.Add(expensesbox1);
                        //EXPENSES Generetor

                        //BALANCEBOXES Generetor
                        TextBox balancebox = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            TextAlign = HorizontalAlignment.Center
                        };
                        balancebox.Text += "0";
                        balancebox.Size = new Size(BalanseUsingForSize.Size.Width, BalanseUsingForSize.Size.Height);
                        balancebox.Location = new Point(579, txtbox.Location.Y);
                        balancebox.Font = new Font("Microsoft Sans Serif", 18);
                        Controls.Owner.Controls.Add(balancebox);

                        TextBox balancebox1 = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            TextAlign = HorizontalAlignment.Center
                        };
                        balancebox1.Text += "0";
                        balancebox1.Size = new Size(BalanseUsingForSize.Size.Width, BalanseUsingForSize.Size.Height);
                        balancebox1.Location = new Point(579, txtbox1.Location.Y);
                        balancebox1.Font = new Font("Microsoft Sans Serif", 18);
                        Controls.Owner.Controls.Add(balancebox1);
                        //(BALANCE)BOXES Generetor

                        //(COUNTED)BOXES Generetor
                        TextBox countedbox = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            TextAlign = HorizontalAlignment.Center,
                            Text = "0",
                            Size = new Size(CountedusingforSize.Size.Width, CountedusingforSize.Size.Height),
                            Location = new Point(679, txtbox.Location.Y),
                            Font = new Font("Microsoft Sans Serif", 18)
                        };
                        Controls.Owner.Controls.Add(countedbox);

                        TextBox countedbox1 = new TextBox
                        {
                            BorderStyle = new BorderStyle(),
                            TextAlign = HorizontalAlignment.Center,
                            Text = "0",
                            Size = new Size(CountedusingforSize.Size.Width, CountedusingforSize.Size.Height),
                            Location = new Point(679, txtbox1.Location.Y),
                            Font = new Font("Microsoft Sans Serif", 18)
                        };
                        Controls.Owner.Controls.Add(countedbox1);
                        //(COUNTED)BOXES Generetor

                        GreenAutoSizer.SendToBack();
                        LightRedAutoSizer.SendToBack();
                        RedAutoSizer.SendToBack();

                        break;
                    }
                }
            }
            //Foreach For UnGenaration
        }

        private void Sync_Click(object sender, EventArgs e)
        {
            GetUserid();
        }

        private void GridView_Click(object sender, EventArgs e)
        {
            GridView view = new GridView();
            view.Show();
        }

        private void English_Click(object sender, EventArgs e)
        {
            if(Namelbl.Text == "Name")
            {
                MessageBox.Show("Language is already in english");
            }
            else
            {
                Namelbl.Text = "Name";
                Checkout1.Text = "Funds In Checkout 1";
                Checkout2.Text = "Funds In Checkout 2";
                CheckoutPlusMinuslbl.Text = "Checkout+-";
                AvailableFundslbl.Text = "Available Funds";
                Earningslbl.Text = "Earnings";
                IncomeLabel.Text = "Income";
                RawMatLabel.Text = "Raw Materials";
                ExpenseLabel.Text = "Expense";
                CountedLbl.Text = "Counted";
                CountedLbl.Location = new Point(CountedLbl.Location.X + 10, CountedLbl.Location.Y);
                BalaanceLable.Text = "Balance";
                Datelbl.Text = "Date:  ";
                Datelbl.Location = new Point(Datelbl.Location.X + 5, Datelbl.Location.Y);
            }
        }

        private void Bulgarian_Click(object sender, EventArgs e)
        {
            if(Namelbl.Text == "Име")
            {
                MessageBox.Show("Езикът е на български");
            }
            else
            {
                Namelbl.Text = "Име";
                Checkout1.Text = "Пари в каса 1";
                Checkout2.Text = "Пари в каса 2";
                CheckoutPlusMinuslbl.Text = "Каса+-";
                AvailableFundslbl.Text = "Налични пари";
                Earningslbl.Text = "Оборот";
                IncomeLabel.Text = "Приход";
                RawMatLabel.Text = "  Суровини";
                ExpenseLabel.Text = "Разход";
                CountedLbl.Text = "Изброени";
                CountedLbl.Location = new Point(CountedLbl.Location.X - 10, CountedLbl.Location.Y);
                BalaanceLable.Text = "Салдо";
                Datelbl.Text = "Дата:  ";
                Datelbl.Location = new Point(Datelbl.Location.X - 5, Datelbl.Location.Y);
            }           
        }
    }
}
