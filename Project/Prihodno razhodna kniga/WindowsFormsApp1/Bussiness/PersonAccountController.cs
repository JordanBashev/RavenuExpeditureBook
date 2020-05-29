using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    /// <summary>
    /// Controller PersonAccount class
    /// Countains methods used to work with database
    /// </summary>
    /// <remarks>
    /// This class can add and delete from database
    /// </remarks>
    public class PersonAccountController
    {
        private ApplicationContexts context;

        /// <summary>
        /// Uses the same Dbcontext so we are not forced to call it everywhere
        /// </summary>
        /// <param name="cont"></param>
        public PersonAccountController(ApplicationContexts cont)
        {
            this.context = cont;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public PersonAccountController()
        {

        }

        //Adds in Database
        /// <summary>
        /// Adds in Database
        /// </summary>
        /// <param name="id"></param>
        public void Add(int id)
        {
            using (context)
            {
                PersonAccount UserAccountBookAdding = new PersonAccount() { PersonBookTypesId = id };

                context.PersonAccounts.Add(UserAccountBookAdding);
                context.SaveChanges();
            }
        }
        
        //Deletes from Database by given Id
        /// <summary>
        /// Deletes from Database by given id
        /// </summary>
        /// <param name="id"></param>
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
