using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SlimmingCenter2.Models.Info;
using SlimmingCenter2.Models.Info.MedicalInfo;
using SlimmingCenter2.Models.Users;


namespace SlimmingCenter2.Models.ClientModel
{
    public class Client
    {
        public Int32 Id { get; set; }
        public String name { get; set; }
        public StayInfo stayinfo { get; set; }
        public Schedule schedule { get; set; }
        public Diet diet { get; set; }
        public Fitness fitness { get; set; }
        public DModel dmodel { get; set; }
        public MedicalData medicaldata { get; set; }
        public virtual ICollection<User> users { get; set; }
        public Client()
        {
            users = new List<User>();
        }
    }
}