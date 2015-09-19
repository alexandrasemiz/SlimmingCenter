using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimmingCenter2.Models.Users
{
    public class Role
    {
        public Int32 RoleId { get; set; }
        public String Name { get; set; }
        public ICollection<User> users { get; set; }
        public ICollection<Rule> Rules { get; set; }
        public Role()
        {
            users = new List<User>();
            Rules = new List<Rule>();
        }
    }
}