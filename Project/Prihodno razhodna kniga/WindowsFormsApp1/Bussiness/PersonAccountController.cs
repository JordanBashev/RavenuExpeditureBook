using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    public class PersonAccountController
    {
        public void Add(string Booktype,int id)
        {
            ApplicationContexts context = new ApplicationContexts();
            using (context)
            {
                PersonAccount UserAccountBookAdding = new PersonAccount() {BookType = Booktype, PersonLoginId = id};

                context.PersonAccounts.Add(UserAccountBookAdding);
                context.SaveChanges();
            }
        }
    }
}
