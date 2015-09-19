using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using SlimmingCenter2.Models.ClientModel;

namespace SlimmingCenter2.Models.Context
{
    public class CenterInitialize : DropCreateDatabaseAlways<CenterContext>
    {
        protected override void Seed(CenterContext context)
        {
            Client c1 = new Client() { Id = 1, name = "Petr" };
            Client c2 = new Client() { Id = 2, name = "Anna" };
            Client c3 = new Client() { Id = 3, name = "Masha" };
            context.Clients.Add(c1);
            context.Clients.Add(c2);
            context.Clients.Add(c3);

            //User u1 = new User() { UserId = 1, name = "Fedor Dmitrievich", clients = new List<Client>() { c1, c2 } };
            //User u2 = new User() { UserId = 2, name = "Dmitrii Fedorovich", clients = new List<Client>() { c2, c3 } };
            //context.Users.Add(u1);
            //context.Users.Add(u2);

            base.Seed(context);
        }
    }
}