using Moq;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WindowsFormsApp1.Data.Models;
using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Bussiness;

namespace RevenueExpeditureBook.Tests
{
    public class PersonBookTypeControllerTests
    {
        [Test]
        public void Does_It_Add_in_Database_in_Table_PersonBookType()
        {
            var data = new List<PersonBookType>()
            {
                new PersonBookType() { Id = 1, BookType = "Business", PersonAccountId = 1 }

            }.AsQueryable();

            var MockSet = new Mock<DbSet<PersonBookType>>();
            MockSet.As<IQueryable<PersonBookType>>().Setup(x => x.Provider).Returns(data.Provider);
            MockSet.As<IQueryable<PersonBookType>>().Setup(x => x.Expression).Returns(data.Expression);
            MockSet.As<IQueryable<PersonBookType>>().Setup(x => x.ElementType).Returns(data.ElementType);
            MockSet.As<IQueryable<PersonBookType>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.PersonBookTypes).Returns(MockSet.Object);

            var service = new PersonBookTypeController(MockContext.Object);
            data.ToList().ForEach(x => service.Add(x.BookType, x.PersonAccountId));
        }

        [Test]
        public void CheckIfExists_Method_Does_It_Return_True()
        {
            var data = new List<PersonBookType>()
            {
                new PersonBookType() { Id = 1, BookType = "Business", PersonAccountId = 1 }

            }.AsQueryable();

            var MockSet = new Mock<DbSet<PersonBookType>>();
            MockSet.As<IQueryable<PersonBookType>>().Setup(x => x.Provider).Returns(data.Provider);
            MockSet.As<IQueryable<PersonBookType>>().Setup(x => x.Expression).Returns(data.Expression);
            MockSet.As<IQueryable<PersonBookType>>().Setup(x => x.ElementType).Returns(data.ElementType);
            MockSet.As<IQueryable<PersonBookType>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.PersonBookTypes).Returns(MockSet.Object);

            var service = new PersonBookTypeController(MockContext.Object);
            data.ToList().ForEach(x => service.Add(x.BookType, x.PersonAccountId));

            var Checker = service.CheckIfExsist();

            Assert.AreEqual(true, Checker, "Method Does not Return true");
        }

        [Test]
        public void CreatePersonBookType_Saves_In_Database()
        {
            var Personbook = new PersonBookType() { BookType = "Goshko", PersonAccountId = 1 };
            var MockSet = new Mock<DbSet<PersonBookType>>();

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.PersonBookTypes).Returns(MockSet.Object);

            var service = new PersonBookTypeController(MockContext.Object);
            service.Add(Personbook.BookType,Personbook.PersonAccountId);

            MockSet.Verify(x => x.Add(It.IsAny<PersonBookType>()), Times.Once());
            MockContext.Verify(x => x.SaveChanges(), Times.Once());
        }
    }
}
