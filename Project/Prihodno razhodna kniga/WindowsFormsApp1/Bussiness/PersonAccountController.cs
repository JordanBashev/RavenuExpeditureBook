using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void Add(int id)
        {
            using (context)
            {
                PersonAccount UserAccountBookAdding = new PersonAccount(){ PersonBookTypesId = id };

                context.PersonAccounts.Add(UserAccountBookAdding);
                context.SaveChanges();
            }
        }
    }
}
