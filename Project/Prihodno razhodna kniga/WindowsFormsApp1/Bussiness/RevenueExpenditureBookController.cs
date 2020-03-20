using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Bussiness
{
    public class RevenueExpenditureBookController
    {
        RevenueExpenditureBook update = new RevenueExpenditureBook();
        ApplicationContexts contexts = new ApplicationContexts();
        int counter = 0;

        public RevenueExpenditureBook Get(int id)
        {
            var FindId = contexts.RevenueExpenditureBooks.FirstOrDefault(x => x.Id == id);
            return FindId;
        }

        public void Add(DateTime date, decimal income, decimal rawmaterials, decimal expenses, decimal balance, decimal counted, decimal checkout, int accountId)
        {
            using (contexts)
            {
                RevenueExpenditureBook BookCreation = new RevenueExpenditureBook() { Date = date, Income = income, RawMaterials = rawmaterials, Expense = expenses, Balance = balance, Counted = counted, CheckOutPlusAndMinus = checkout, AccountRavenueBookId = accountId };

                contexts.RevenueExpenditureBooks.Add(BookCreation);
                contexts.SaveChanges();
            }
        }

        public void Update(DateTime date, decimal income, decimal rawmaterials, decimal expenses, decimal balance, decimal counted, decimal checkout, int accountid)
        {

            RevenueExpenditureBook BookCreation = new RevenueExpenditureBook() { Date = date, Income = income, RawMaterials = rawmaterials, Expense = expenses, Balance = balance, Counted = counted, CheckOutPlusAndMinus = checkout, AccountRavenueBookId = accountid };


            var GetId = contexts.RevenueExpenditureBooks.FirstOrDefault(x => x.Date == date);

            var Id = this.Get(GetId.Id);
            update = BookCreation;
            update.Id = Id.Id;

            contexts.Entry(Id).CurrentValues.SetValues(update);
            contexts.SaveChanges();

        }

        public void Delete()
        {
            counter = counter + 1;
            int counterino = counter;
            var Deleted = contexts.RevenueExpenditureBooks.FirstOrDefault(x => x.Id == counterino);
            contexts.Remove(Deleted);
            contexts.SaveChanges();
        }
    }
}