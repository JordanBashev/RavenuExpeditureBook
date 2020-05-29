using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    /// <summary>
    /// Controller PersonBookType class
    /// Countains methods used to work with database
    /// </summary>
    /// <remarks>
    /// This class can add and check if the given booktype exists
    /// </remarks>
    public class PersonBookTypeController
    {
        private ApplicationContexts context;

        /// <summary>
        /// Uses the same Dbcontext so we are not forced to call it everywhere
        /// </summary>
        /// <param name="contex"></param>
        public PersonBookTypeController(ApplicationContexts contex)
        {
            this.context = contex;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public PersonBookTypeController()
        {

        }

        //Check's if The given bookType exists and returns true
        /// <summary>
        /// Checks if the given BookType exists and returns true
        /// </summary>
        /// <returns>
        /// True 
        /// </returns>
        public bool CheckIfExsist()
        {
            var a = context.PersonBookTypes.Count().Equals(1);
            return a;
        }

        //Adds in Database
        /// <summary>
        /// Adds in Database
        /// </summary>
        /// <param name="Booktype"></param>
        /// <param name="id"></param>
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
