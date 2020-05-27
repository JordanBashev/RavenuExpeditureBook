using System;
using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    public class RevenueExpenditureBookController
    {
        //The Object is used to get the values so we can change(update) the database
        RevenueExpenditureBook update = new RevenueExpenditureBook();

        private ApplicationContexts contexts;
        public RevenueExpenditureBookController(ApplicationContexts contex)
        {
            this.contexts = contex;
        }

        public RevenueExpenditureBookController()
        {

        }

        //Returns the value with the given id
        public RevenueExpenditureBook Get(int id)
        {
            var FindId = contexts.RevenueExpenditureBooks.FirstOrDefault(x => x.Id == id);
            return FindId;
        }

        //Adds in database
        public void Add(DateTime date, decimal income, decimal rawmaterials, decimal expenses, decimal balance, decimal counted, decimal checkout, int accountId, int Userid)
        {

            RevenueExpenditureBook BookCreation = new RevenueExpenditureBook() { Date = date, Income = income, RawMaterials = rawmaterials, Expense = expenses, Balance = balance, Counted = counted, CheckOutPlusAndMinus = checkout, AccountRavenueBookId = accountId, UserRegisteredId = Userid };

            contexts.RevenueExpenditureBooks.Add(BookCreation);
            contexts.SaveChanges();

        }


        //Updates the database
        public void Update(DateTime date, decimal income, decimal rawmaterials, decimal expenses, decimal balance, decimal counted, decimal checkout, int accountid, int userid)
        {

            RevenueExpenditureBook BookCreation = new RevenueExpenditureBook() { Date = date, Income = income, RawMaterials = rawmaterials, Expense = expenses, Balance = balance, Counted = counted, CheckOutPlusAndMinus = checkout, AccountRavenueBookId = accountid, UserRegisteredId = userid };

            var getuserid = contexts.RevenueExpenditureBooks.OrderByDescending(x => x.Date).FirstOrDefault(x => x.UserRegisteredId == userid);

            var Id = this.Get(getuserid.Id);
            update = BookCreation;
            update.Id = Id.Id;

            contexts.Entry(Id).CurrentValues.SetValues(update);
            contexts.SaveChanges();
        }

        //Deletes from database by id
        public void Delete(int deletebyuserid)
        {
            var getuserid = contexts.PersonRegisters.FirstOrDefault(x => x.Id == deletebyuserid);
            var Deleted = contexts.RevenueExpenditureBooks.Where(x => x.UserRegisteredId == getuserid.Id).AsEnumerable();
            contexts.RemoveRange(Deleted);
            contexts.SaveChanges();
        }
    }
}