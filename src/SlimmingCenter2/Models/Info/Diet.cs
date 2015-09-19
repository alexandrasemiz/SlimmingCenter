using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SlimmingCenter2.Models.Info
{
    public class Diet
    {
        public Int32 DietId { get; set; }
        public Int32? ClientId { get; set; }
        public String dietRecommendation { get; set; }
    }
}