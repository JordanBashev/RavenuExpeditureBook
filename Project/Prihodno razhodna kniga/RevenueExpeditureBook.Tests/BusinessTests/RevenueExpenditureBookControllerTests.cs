using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Bussiness;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace RevenueExpeditureBook.Tests
{
    public class RevenueExpenditureBookControllerTests
    {
        [Test]
        public void Does_It_Add_In_Database_in_RevenueExpeditureBook()
        {
            var data = new List<RevenueExpenditureBook>()
            {
                new RevenueExpenditureBook() { Date = DateTime.Today,Income = 100,Expense = 100,RawMaterials = 100, Counted = 100, Balance = 100, CheckOutPlusAndMinus = 100, AccountRavenueBookId = 1, UserRegisteredId = 1 }

            }.AsQueryable();

            var MockSet = new Mock<DbSet<RevenueExpenditureBook>>();
            MockSet.As<IQueryable<RevenueExpenditureBook>>().Setup(x => x.Provider).Returns(data.Provider);
            MockSet.As<IQueryable<RevenueExpenditureBook>>().Setup(x => x.Expression).Returns(data.Expression);
            MockSet.As<IQueryable<RevenueExpenditureBook>>().Setup(x => x.ElementType).Returns(data.ElementType);
            MockSet.As<IQueryable<RevenueExpenditureBook>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.RevenueExpenditureBooks).Returns(MockSet.Object);

            var service = new RevenueExpenditureBookController(MockContext.Object);
            data.ToList().ForEach(x => service.Add(x.Date,x.Income,x.RawMaterials,x.Expense,x.Balance,x.Counted,x.CheckOutPlusAndMinus,x.AccountRavenueBookId,x.UserRegisteredId));
        }
        
        [Test]
        public void Does_Get_Method_Return_the_Data_of_the_given_id()
        {
            var data = new List<RevenueExpenditureBook>()
            {
                new RevenueExpenditureBook() {Id = 1, Date = DateTime.Today,Income = 100,Expense = 100,RawMaterials = 100, Counted = 100, Balance = 100, CheckOutPlusAndMinus = 100, AccountRavenueBookId = 1, UserRegisteredId = 1 }

            }.AsQueryable();

            var MockSet = new Mock<DbSet<RevenueExpenditureBook>>();
            MockSet.As<IQueryable<RevenueExpenditureBook>>().Setup(x => x.Provider).Returns(data.Provider);
            MockSet.As<IQueryable<RevenueExpenditureBook>>().Setup(x => x.Expression).Returns(data.Expression);
            MockSet.As<IQueryable<RevenueExpenditureBook>>().Setup(x => x.ElementType).Returns(data.ElementType);
            MockSet.As<IQueryable<RevenueExpenditureBook>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.RevenueExpenditureBooks).Returns(MockSet.Object);

            var service = new RevenueExpenditureBookController(MockContext.Object);
            data.ToList().ForEach(x => service.Add(x.Date, x.Income, x.RawMaterials, x.Expense, x.Balance, x.Counted, x.CheckOutPlusAndMinus, x.AccountRavenueBookId, x.UserRegisteredId));

            var Result = service.Get(1);

            Assert.AreEqual(1, Result.Id, "Get Method Doesn't Return the data on the specified id");
        }

        [Test]
        public void CreateRevenueExpeditureBook_Saves_in_database()
        {
            var data = new RevenueExpenditureBook() { Id = 1, Date = DateTime.Today, Income = 100, Expense = 100, RawMaterials = 100, Counted = 100, Balance = 100, CheckOutPlusAndMinus = 100, AccountRavenueBookId = 1, UserRegisteredId = 1 };

            var MockSet = new Mock<DbSet<RevenueExpenditureBook>>();

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.RevenueExpenditureBooks).Returns(MockSet.Object);

            var service = new RevenueExpenditureBookController(MockContext.Object);
            service.Add(data.Date, data.Income, data.RawMaterials, data.Expense, data.Balance, data.Counted, data.CheckOutPlusAndMinus, data.AccountRavenueBookId, data.UserRegisteredId);

            MockSet.Verify(x => x.Add(It.IsAny<RevenueExpenditureBook>()), Times.Once());
            MockContext.Verify(x => x.SaveChanges(), Times.Once());
        }
    }
}
