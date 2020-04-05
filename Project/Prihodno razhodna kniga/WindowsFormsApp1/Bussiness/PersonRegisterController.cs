using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;
using WindowsFormsApp1.View;

namespace WindowsFormsApp1.Bussiness
{
    public class PersonRegisterController
    {
        private ApplicationContexts context;
        public PersonRegisterController(ApplicationContexts cont)
        {
            this.context = cont;
        }

        public PersonRegisterController()
        {

        }

        public string CheckIfUsernameExists(string name)
        {
            var check = context.PersonRegisters.FirstOrDefault(x => x.Username == name);
            if (check == null)
            {
                return "";
            }
            else
            {
                return check.Username;
            }
        }

        public List<PersonRegister> GetAll()
        {
            var getId = context.PersonRegisters.ToList();
            return getId;
        }

        public void Add(string name, string password)
        {
            PersonRegister UserAdding = new PersonRegister() { Username = name, Password = password };

            context.PersonRegisters.Add(UserAdding);
            context.SaveChanges();
        }
    }
}
