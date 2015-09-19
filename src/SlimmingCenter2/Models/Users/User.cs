using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SlimmingCenter2.Models.ClientModel;


namespace SlimmingCenter2.Models.Users
{
    public class User
    {
        public Int32 UserId { get; set; }
        public String name { get; set; }
        public virtual ICollection<Client> clients{get;set;}
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Position> Positions { get; set; }
        public User()
        {
            clients = new List<Client>();
            Roles = new List<Role>();
            Positions = new List<Position>();
        }
    }
}