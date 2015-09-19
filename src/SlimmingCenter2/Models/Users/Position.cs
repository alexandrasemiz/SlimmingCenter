using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimmingCenter2.Models.Users
{
    public class Position
    {
        public Int32 PositionId { get; set; }
        public String name { get; set; }
        public virtual ICollection<User> users{get;set;}
        public Position()
        {
            users = new List<User>();
        }
    }
}