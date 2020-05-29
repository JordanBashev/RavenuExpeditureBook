using System;
using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    /// <summary>
    /// Controller RevenueExpeditureBook class
    /// Countains methods used to work with database
    /// </summary>
    /// <remarks>
    /// This class can add,get obeject by given id,update and delete from database
    /// </remarks>
    public class RevenueExpenditureBookController
    {
        //The variable is used to get the values so we can update the database
        RevenueExpenditureBook update = new RevenueExpenditureBook();

        private ApplicationContexts contexts;

        /// <summary>
        /// Uses the same Dbcontext so we are not forced to call it everywhere
        /// </summary>
        /// <param name="contex"></param>
        public RevenueExpenditureBookController(ApplicationContexts contex)
        {
            this.contexts = contex;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public RevenueExpenditureBookController()
        {

        }

        //Takes id and returns the object by the given id
        /// <summary>
        /// Takes id and returns the object by the given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>
        /// object with the given id
        /// </returns>
        public RevenueExpenditureBook Get(int id)
        {
            var FindId = contexts.RevenueExpenditureBooks.FirstOrDefault(x => x.Id == id);
            return FindId;
        }

        //Adds in database
        /// <summary>
        /// Adds in database
        /// </summary>
        /// <param name="date"></param>
        /// <param name="income"></param>
        /// <param name="rawmaterials"></param>
        /// <param name="expenses"></param>
        /// <param name="balance"></param>
        /// <param name="counted"></param>
        /// <param name="checkout"></param>
        /// <param name="accountId"></param>
        /// <param name="Userid"></param>
        public void Add(DateTime date, decimal income, decimal rawmaterials, decimal expenses, decimal balance, decimal counted, decimal checkout, int accountId, int Userid)
        {

            RevenueExpenditureBook BookCreation = new RevenueExpenditureBook() { Date = date, Income = income, RawMaterials = rawmaterials, Expense = expenses, Balance = balance, Counted = counted, CheckOutPlusAndMinus = checkout, AccountRavenueBookId = accountId, UserRegisteredId = Userid };

            contexts.RevenueExpenditureBooks.Add(BookCreation);
            contexts.SaveChanges();

        }


        //Updates the database
        /// <summary>
        /// Updates Database
        /// </summary>
        /// <param name="date"></param>
        /// <param name="income"></param>
        /// <param name="rawmaterials"></param>
        /// <param name="expenses"></param>
        /// <param name="balance"></param>
        /// <param name="counted"></param>
        /// <param name="checkout"></param>
        /// <param name="accountid"></param>
        /// <param name="userid"></param>
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

        //Deletes from database by given id
        /// <summary>
        /// Deletes from database by given id
        /// </summary>
        /// <param name="deletebyuserid"></param>
        public void Delete(int deletebyuserid)
        {
            var getuserid = contexts.PersonRegisters.FirstOrDefault(x => x.Id == deletebyuserid);
            var Deleted = contexts.RevenueExpenditureBooks.Where(x => x.UserRegisteredId == getuserid.Id).AsEnumerable();
            contexts.RemoveRange(Deleted);
            contexts.SaveChanges();
        }
    }
}