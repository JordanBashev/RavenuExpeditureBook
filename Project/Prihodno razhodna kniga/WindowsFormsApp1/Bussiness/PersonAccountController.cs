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
        public void Add(int Rid,int id)
        {
            ApplicationContexts context = new ApplicationContexts();
            using (context)
            {
                PersonAccount UserAccountBookAdding = new PersonAccount(){ PersonRegistersId = Rid,PersonBookTypesId = id };

                context.PersonAccounts.Add(UserAccountBookAdding);
                context.SaveChanges();
            }
        }
    }
}
