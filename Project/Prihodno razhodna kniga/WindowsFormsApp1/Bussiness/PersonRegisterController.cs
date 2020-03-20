using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    public class PersonRegisterController
    {
        ApplicationContexts context = new ApplicationContexts();

        public int GetAllIds()
        {
            ApplicationContexts contexts = new ApplicationContexts();
            var getId = contexts.PersonRegisters.Count();
            return getId;
        }

        public void Add(string name,string password)
        {
            using (context)
            {
                PersonRegister UserAdding = new PersonRegister() { Username = name, Password = password };

                context.PersonRegisters.Add(UserAdding);
                context.SaveChanges();
            }
        }
    }
}
