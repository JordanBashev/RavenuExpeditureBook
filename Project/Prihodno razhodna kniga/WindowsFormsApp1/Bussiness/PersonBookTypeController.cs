using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    public class PersonBookTypeController
    {
        ApplicationContexts context = new ApplicationContexts();
        public bool CheckIfExsist()
        {
            var a = context.PersonBookTypes.Count().Equals(1);
            return a;
        }
       
        public void Add(string Booktype,int id)
        {
            
            using (context)
            {
                PersonBookType UserAccountBookAdding = new PersonBookType() {BookType = Booktype, PersonAccountId = id};

                context.PersonBookTypes.Add(UserAccountBookAdding);
                context.SaveChanges();
            }
        }
    }
}
