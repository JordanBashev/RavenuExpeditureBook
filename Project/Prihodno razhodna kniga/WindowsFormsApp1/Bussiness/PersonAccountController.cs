using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    public class PersonAccountController
    {
        public void Add(string Booktype,int Id)
        {
            ApplicationContexts context = new ApplicationContexts();
            using (context)
            {
                PersonAccountContexts UserAccountBookAdding = new PersonAccountContexts() {BookType = Booktype,RavenueBookId = Id};

                context.PersonAccounts.Add(UserAccountBookAdding);
                context.SaveChanges();
            }
        }
    }
}
