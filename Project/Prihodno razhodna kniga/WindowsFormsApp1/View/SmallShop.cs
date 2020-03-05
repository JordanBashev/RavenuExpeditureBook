using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Bussiness;

namespace WindowsFormsApp1.View
{
    public partial class SmallShop : Form
    {
        RevenueExpenditureBookController BookForUser = new RevenueExpenditureBookController();
        ApplicationContext context = new ApplicationContext();


        public SmallShop()
        {
            InitializeComponent();
            DatetimeLabel.Text = DateTime.Today.ToShortDateString();
        }

        public string GetIncomeValue()
        {
            decimal incomeresult = decimal.Parse(Income1.Text) + decimal.Parse(Income2.Text) + decimal.Parse(Income3.Text) + decimal.Parse(Income4.Text) + decimal.Parse(Income5.Text) + decimal.Parse(Income6.Text) + decimal.Parse(Income7.Text) + decimal.Parse(Income8.Text) + decimal.Parse(Income9.Text) + decimal.Parse(Income10.Text) + decimal.Parse(Income11.Text);
            return IncomeResult.Text = incomeresult.ToString();
        }

        public string GetRawMaterialsValue()
        {
            decimal RawMaterialsresult = decimal.Parse(RamMat1.Text) + decimal.Parse(RamMat2.Text) + decimal.Parse(RamMat3.Text) + decimal.Parse(RamMat4.Text) + decimal.Parse(RamMat5.Text) + decimal.Parse(RamMat6.Text) + decimal.Parse(RamMat7.Text) + decimal.Parse(RamMat8.Text) + decimal.Parse(RamMat9.Text) + decimal.Parse(RamMat10.Text) + decimal.Parse(RamMat11.Text);
            return RamMatResult.Text = RawMaterialsresult.ToString();
        }

        public string GetExpensesValue()
        {
            decimal Expensesresult = decimal.Parse(Expense1.Text) + decimal.Parse(Expense2.Text) + decimal.Parse(Expense3.Text) + decimal.Parse(Expense4.Text) + decimal.Parse(Expense5.Text) + decimal.Parse(Expense6.Text) + decimal.Parse(Expense7.Text) + decimal.Parse(Expense8.Text) + decimal.Parse(Expense9.Text) + decimal.Parse(Expense10.Text) + decimal.Parse(Expense11.Text);
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
            decimal FinalResult = decimal.Parse(Allbalance.Text) - decimal.Parse(CountedCash.Text);
           return CheckOut.Text = FinalResult.ToString();
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
            MessageBox.Show("To get started this is a simple RavenueExpeditureBook that will allow to easly calculate your expenses and income so u dont get lost in tons of paper and a few calculators." + Environment.NewLine + "1 - This only work for the data of the day u are using it and u can't rewrite old ones(yet)" + Environment.NewLine + "2 - Income is where you put the ammount of cash you got today" + Environment.NewLine + "3 - Raw Material is where you put the ammount of cash you have for supplies" + Environment.NewLine + "4 - Expenses is where you put the ammount of cash spended for you");
        }

        private void UpdateDB_Click(object sender, EventArgs e)
        {
            var Income = decimal.Parse(GetIncomeValue());
            var RawMaterial = decimal.Parse(GetRawMaterialsValue());
            var Expenses = decimal.Parse(GetExpensesValue());
            var Balance = decimal.Parse(GetBalanceValue());
            var Counted = decimal.Parse(GetCountedValue());
            var CheckOut = decimal.Parse(GetCheckoutValue());
            var date = GetTime();
            if(date != GetTime())
            {
                BookForUser.Add(2, GetTime(), Income, RawMaterial, Expenses, Balance, Counted, CheckOut);
            }
            else
            {
                BookForUser.Update(1,GetTime(),Income, RawMaterial, Expenses, Balance, Counted, CheckOut);
                MessageBox.Show("Database updated succssefully");
            }
        }
    }
}
