using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SlimmingCenter2.Models.Info
{
    public class Schedule
    {
        public Int32 ScheduleId { get; set; }
        public Int32? ClientId { get; set; }
        public DateTime time { get; set; }
        public String job { get; set; }
    }
}