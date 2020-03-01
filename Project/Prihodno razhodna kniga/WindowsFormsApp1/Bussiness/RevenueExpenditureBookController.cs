using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    public class RevenueExpenditureBookController
    {
        public void Add(DateTime date,decimal income,decimal rawmaterials,decimal expenses,decimal balance,decimal counted,decimal checkout)
        {
            ApplicationContexts contexts = new ApplicationContexts();
            using (contexts)
            {
                RevenueExpenditureBookContexts BookCreation = new RevenueExpenditureBookContexts() { Date = date , Income = income, RawMaterials = rawmaterials, Expense = expenses, Balance = balance, Counted = counted,CheckOutPlusAndMinus = checkout};

                contexts.RevenueExpenditureBooks.Add(BookCreation);
                contexts.SaveChanges();
            }
        }
    }
}
