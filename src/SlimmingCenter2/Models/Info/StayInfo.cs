using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SlimmingCenter2.Models.Info
{
    public class StayInfo
    {
        public Int32 StayInfoId { get; set; }
        public Int32? ClientId { get; set; }
        public Int32 age { get; set; }
        public String problem { get; set; }
        public DateTime days { get; set; }
    }
}