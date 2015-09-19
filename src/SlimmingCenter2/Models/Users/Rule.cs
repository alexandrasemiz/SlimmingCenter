using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimmingCenter2.Models.Users
{
    public class Rule
    {
        public Int32 RuleId { get; set; }
        public String Name { get; set; }
        public ICollection<Role> Roles{get;set;}
        public Rule()
        {
            Roles = new List<Role>();
        }
     
    }
}