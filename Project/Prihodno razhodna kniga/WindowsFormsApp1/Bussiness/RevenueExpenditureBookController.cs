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
        RevenueExpenditureBook update = new RevenueExpenditureBook();
        ApplicationContexts contexts = new ApplicationContexts();
        public RevenueExpenditureBook Get(int id)
        {
            var FindId = contexts.RevenueExpenditureBooks.FirstOrDefault(x => x.Id == id);
            return FindId;
        }
        public void Add(int id, DateTime date, decimal income, decimal rawmaterials, decimal expenses, decimal balance, decimal counted, decimal checkout)
        {
            using (contexts)
            {
                RevenueExpenditureBook BookCreation = new RevenueExpenditureBook() {Id = id, Date = date, Income = income, RawMaterials = rawmaterials, Expense = expenses, Balance = balance, Counted = counted, CheckOutPlusAndMinus = checkout };

                contexts.RevenueExpenditureBooks.Add(BookCreation);
                contexts.SaveChanges();
            }
        }
        public void Update(int id, DateTime date, decimal income, decimal rawmaterials, decimal expenses, decimal balance, decimal counted, decimal checkout)
        {
            using (contexts)
            {
                RevenueExpenditureBook BookCreation = new RevenueExpenditureBook() { Date = date, Income = income, RawMaterials = rawmaterials, Expense = expenses, Balance = balance, Counted = counted, CheckOutPlusAndMinus = checkout };
                //var a = contexts.RevenueExpenditureBooks.Find(date);
                var GetId = contexts.RevenueExpenditureBooks.FirstOrDefault(x => x.Id == id);
                var Id = this.Get(GetId.Id);
                update = BookCreation;
                update.Id = GetId.Id;
                contexts.Entry(Id).CurrentValues.SetValues(update);
                contexts.SaveChanges();
            }
        }
    }
}
