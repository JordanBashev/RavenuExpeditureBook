using Moq;
using System.Collections.Generic;
using NUnit.Framework;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using WindowsFormsApp1.Bussiness;

namespace RevenueExpeditureBook.Tests
{
    public class PersonAccountControllerTests
    {
        [Test]
        public void Does_It_Add_In_Database_in_Table_PersonAccounts()
        {
            var data = new List<PersonAccount>()
            {
                new PersonAccount() { PersonBookTypesId = 1, PersonRegistersId = 1 }

            }.AsQueryable();

            var MockSet = new Mock<DbSet<PersonAccount>>();
            MockSet.As<IQueryable<PersonAccount>>().Setup(x => x.Provider).Returns(data.Provider);
            MockSet.As<IQueryable<PersonAccount>>().Setup(x => x.Expression).Returns(data.Expression);
            MockSet.As<IQueryable<PersonAccount>>().Setup(x => x.ElementType).Returns(data.ElementType);
            MockSet.As<IQueryable<PersonAccount>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.PersonAccounts).Returns(MockSet.Object);

            var service = new PersonAccountController(MockContext.Object);
            data.ToList().ForEach(x => service.Add(x.PersonBookTypesId));
        }

        [Test]
        public void CreatePersonAccount_Saves_In_Database()
        {
            var PersonAccount = new PersonAccount() { PersonBookTypesId = 1, PersonRegistersId = 1 };

            var MockSet = new Mock<DbSet<PersonAccount>>();

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.PersonAccounts).Returns(MockSet.Object);

            var service = new PersonAccountController(MockContext.Object);
            service.Add(PersonAccount.PersonBookTypesId);

            MockSet.Verify(x => x.Add(It.IsAny<PersonAccount>()), Times.Once());
            MockContext.Verify(x => x.SaveChanges(), Times.Once());
        }
    }
}
