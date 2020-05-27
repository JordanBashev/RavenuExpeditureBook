using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    public class PersonAccountController
    {
        private ApplicationContexts context;

        public PersonAccountController(ApplicationContexts cont)
        {
            this.context = cont;
        }

        public PersonAccountController()
        {

        }

        //Adds in Database
        public void Add(int id)
        {
            using (context)
            {
                PersonAccount UserAccountBookAdding = new PersonAccount() { PersonBookTypesId = id };

                context.PersonAccounts.Add(UserAccountBookAdding);
                context.SaveChanges();
            }
        }
        
        //Deletes from Database by Id
        public void Delete(int id)
        {
            using (context)
            {
                 var getuserid = context.PersonRegisters.FirstOrDefault(x => x.Id == id);
                var Deleted = context.PersonAccounts.FirstOrDefault(x => x.PersonRegistersId == getuserid.Id);

                context.Remove(Deleted);
                context.SaveChanges();
            }
        }
    }
}
