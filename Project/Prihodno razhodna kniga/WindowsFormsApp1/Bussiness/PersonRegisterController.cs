using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    public class PersonRegisterController
    {
        public int GetAllIds()
        {
            ApplicationContexts contexts = new ApplicationContexts();

            var getId = contexts.PersonRegisters.Count();
            return getId;
        }
        public void Add(string name,string password)
        {
            ApplicationContexts context = new ApplicationContexts();
            using (context)
            {
                PersonLogin UserAdding = new PersonLogin() { Username = name, Password = password };

                context.PersonRegisters.Add(UserAdding);
                context.SaveChanges();
            }
        }
        public void LoginCheck(string name,string password)
        {

        }
    }
}
