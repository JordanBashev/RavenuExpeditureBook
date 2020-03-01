using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.View
{
    public partial class SmallShop : Form
    {
        public SmallShop()
        {
            InitializeComponent();
            DatetimeLabel.Text = DateTime.Today.ToShortDateString();
        }

        public void GetValuesForCheckout()
        {
            decimal incomeresult = decimal.Parse(Income1.Text) + decimal.Parse(Income2.Text) + decimal.Parse(Income3.Text) + decimal.Parse(Income4.Text) + decimal.Parse(Income5.Text) + decimal.Parse(Income6.Text) + decimal.Parse(Income7.Text) + decimal.Parse(Income8.Text) + decimal.Parse(Income9.Text) + decimal.Parse(Income10.Text) + decimal.Parse(Income11.Text);
           IncomeResult.Text = incomeresult.ToString();
            decimal RawMaterialsresult = decimal.Parse(RamMat1.Text) + decimal.Parse(RamMat2.Text) + decimal.Parse(RamMat3.Text) + decimal.Parse(RamMat4.Text) + decimal.Parse(RamMat5.Text) + decimal.Parse(RamMat6.Text) + decimal.Parse(RamMat7.Text) + decimal.Parse(RamMat8.Text) + decimal.Parse(RamMat9.Text) + decimal.Parse(RamMat10.Text) + decimal.Parse(RamMat11.Text);
            RamMatResult.Text = RawMaterialsresult.ToString();
            decimal Expensesresult = decimal.Parse(Expense1.Text) + decimal.Parse(Expense2.Text) + decimal.Parse(Expense3.Text) + decimal.Parse(Expense4.Text) + decimal.Parse(Expense5.Text) + decimal.Parse(Expense6.Text) + decimal.Parse(Expense7.Text) + decimal.Parse(Expense8.Text) + decimal.Parse(Expense9.Text) + decimal.Parse(Expense10.Text) + decimal.Parse(Expense11.Text);
            ExpenseResult.Text = Expensesresult.ToString();
            decimal PreFinalResults = decimal.Parse(IncomeResult.Text) - decimal.Parse(RamMatResult.Text) - decimal.Parse(ExpenseResult.Text);
            Allbalance.Text = PreFinalResults.ToString();
            decimal FinalResult = decimal.Parse(Allbalance.Text) - decimal.Parse(CountedCash.Text);
            CheckOut.Text = FinalResult.ToString();
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
    }
}
