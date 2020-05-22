using NUnit.Framework;
using Moq;
using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Data.Models;
using WindowsFormsApp1.Data;
using Microsoft.EntityFrameworkCore;
using WindowsFormsApp1.Bussiness;

namespace RevenueExpeditureBook.Tests
{
    public class PersonRegisterControllerTests
    {
        [Test]
        public void Does_It_Add_In_Database_In_Table_PersonRegisters()
        {
            var data = new List<PersonRegister>()
            {
                new PersonRegister() { Id = 3, Username = "Goshko", Password = "100000" }

            }.AsQueryable();

            var MockSet = new Mock<DbSet<PersonRegister>>();
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.Provider).Returns(data.Provider);
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.Expression).Returns(data.Expression);
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.ElementType).Returns(data.ElementType);
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.PersonRegisters).Returns(MockSet.Object);

            var service = new PersonRegisterController(MockContext.Object);
            data.ToList().ForEach(x => service.Add(x.Username, x.Password));

        }

        [Test]
        public void GettAll_Method_Does_it_gets_all_Accounts()
        {
            var data = new List<PersonRegister>()
            {
                new PersonRegister() { Id = 1, Username = "Goshko1", Password = "1000001" },
                new PersonRegister() { Id = 2, Username = "Goshko2", Password = "1000002" },
                new PersonRegister() { Id = 3, Username = "Goshko3", Password = "1000003" }

            }.AsQueryable();

            var MockSet = new Mock<DbSet<PersonRegister>>();
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.Provider).Returns(data.Provider);
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.Expression).Returns(data.Expression);
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.ElementType).Returns(data.ElementType);
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.PersonRegisters).Returns(MockSet.Object);

            var service = new PersonRegisterController(MockContext.Object);
            data.ToList().ForEach(x => service.Add(x.Username, x.Password));

            var result = service.GetAll();

            Assert.AreEqual(3, result.Count(), "Incorrect Count");
        }

        [Test]
        public void CheckIfNameExists_Method_Does_it_finds_the_given_name()
        {
            var data = new List<PersonRegister>()
            {
                new PersonRegister() { Id = 1, Username = "Goshko1", Password = "1000001" },
                new PersonRegister() { Id = 2, Username = "Goshko2", Password = "1000002" },
                new PersonRegister() { Id = 3, Username = "Goshko3", Password = "1000003" }

            }.AsQueryable();

            var MockSet = new Mock<DbSet<PersonRegister>>();
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.Provider).Returns(data.Provider);
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.Expression).Returns(data.Expression);
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.ElementType).Returns(data.ElementType);
            MockSet.As<IQueryable<PersonRegister>>().Setup(x => x.GetEnumerator()).Returns(data.GetEnumerator());

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.PersonRegisters).Returns(MockSet.Object);

            var service = new PersonRegisterController(MockContext.Object);
            data.ToList().ForEach(x => service.Add(x.Username, x.Password));

            var a = service.CheckIfUsernameExists("Goshko2");

            Assert.AreEqual("Goshko2", a, "Doesn't return the given name while the name exists");
        }

        [Test]
        public void CreatPersonRegister_saves_in_database()
        {
            var personregister = new PersonRegister() { Id = 1, Username = "Goshko1", Password = "1000001" };

            var MockSet = new Mock<DbSet<PersonRegister>>();

            var MockContext = new Mock<ApplicationContexts>();
            MockContext.Setup(x => x.PersonRegisters).Returns(MockSet.Object);

            var service = new PersonRegisterController(MockContext.Object);
            service.Add(personregister.Username, personregister.Password);

            MockSet.Verify(x => x.Add(It.IsAny<PersonRegister>()), Times.Once());
            MockContext.Verify(x => x.SaveChanges(), Times.Once());
        }
    }
}
