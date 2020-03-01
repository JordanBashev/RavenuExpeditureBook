using WindowsFormsApp1.Data;
using WindowsFormsApp1.Data.Models;

namespace WindowsFormsApp1.Bussiness
{
    public class PersonRegisterController
    {
        public void Add(string name,string password,int foreignkeyid)
        {
            ApplicationContexts context = new ApplicationContexts();
            using (context)
            {
                PersonLoginContexts UserAdding = new PersonLoginContexts() { Username = name, Password = password,PersonAccountId = foreignkeyid };

                context.PersonRegisters.Add(UserAdding);
                context.SaveChanges();
            }
        }
        public void LoginCheck(string name,string password)
        {

        }
    }
}
