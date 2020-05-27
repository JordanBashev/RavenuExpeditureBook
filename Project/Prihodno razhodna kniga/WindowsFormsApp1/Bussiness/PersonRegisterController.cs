using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

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

        //Method that checks if a given name exist's. if true returns the name, if false returns empty string.The empty string is used so we dont encounter problems
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

        //Method that returns all of the elemenest in the table of registered people
        public List<PersonRegister> GetAll()
        {
            var getId = context.PersonRegisters.ToList();
            return getId;
        }

        //Adds in database
        public void Add(string name, string password)
        {
            PersonRegister UserAdding = new PersonRegister() { Username = name, Password = password };

            context.PersonRegisters.Add(UserAdding);
            context.SaveChanges();
        }

        //Deletes from database by id
        public void Delete(int id)
        {
            using (context)
            {
                var getuserid = context.PersonRegisters.FirstOrDefault(x => x.Id == id);
                context.Remove(getuserid);
                context.SaveChanges();
            }
        }
    }
}
