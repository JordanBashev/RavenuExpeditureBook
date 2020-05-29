using System.Collections.Generic;
using System.Linq;
using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    /// <summary>
    /// Controller PersonRegister class
    /// Countains methods used to work with database
    /// </summary>
    /// <remarks>
    /// This class can add, check if the given username exists,getall method and delete from database
    /// </remarks>
    public class PersonRegisterController
    {
        private ApplicationContexts context;

        /// <summary>
        /// Uses the same Dbcontext so we are not forced to call it everywhere
        /// </summary>
        /// <param name="cont"></param>
        public PersonRegisterController(ApplicationContexts cont)
        {
            this.context = cont;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public PersonRegisterController()
        {

        }

        //Checks if the given username exists and returns string
        /// <summary>
        /// Checks if the given username exists and returns string
        /// </summary>
        /// <param name="name"></param>
        /// <returns>
        /// if true returns emptry string
        /// if false returns the username
        /// </returns>
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

        //Method that takes all objects from database and parse to list
        /// <summary>
        /// Method that takes all objects from database and parse to list
        /// </summary>
        /// <returns>
        /// All objects 
        /// </returns>
        public List<PersonRegister> GetAll()
        {
            var getId = context.PersonRegisters.ToList();
            return getId;
        }

        //Adds in database
        /// <summary>
        /// Adds in database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="password"></param>
        public void Add(string name, string password)
        {
            PersonRegister UserAdding = new PersonRegister() { Username = name, Password = password };

            context.PersonRegisters.Add(UserAdding);
            context.SaveChanges();
        }

        //Deletes from database by given id
        /// <summary>
        /// Deletes from database by given id
        /// </summary>
        /// <param name="id"></param>
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
