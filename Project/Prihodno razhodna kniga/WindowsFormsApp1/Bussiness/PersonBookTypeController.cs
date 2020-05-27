using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    public class PersonBookTypeController
    {
        private ApplicationContexts context;
        public PersonBookTypeController(ApplicationContexts contex)
        {
            this.context = contex;
        }

        public PersonBookTypeController()
        {

        }

        //Check's if The given bookType exist's in this case it's only "Buissines" and returns true or false
        public bool CheckIfExsist()
        {
            var a = context.PersonBookTypes.Count().Equals(1);
            return a;
        }
       
        //Adds in Database
        public void Add(string Booktype,int id)
        {            
            using (context)
            {
                PersonBookType UserAccountBookAdding = new PersonBookType() {BookType = Booktype, PersonAccountId = id};

                context.PersonBookTypes.Add(UserAccountBookAdding);
                context.SaveChanges();
            }
        }

        //We don't delete nor update methos since this is only used for bussines and nothin else
    }
}
