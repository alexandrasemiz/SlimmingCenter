using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SlimmingCenter2.Models.Info
{
    public class DModel
    {
        public Int32 DModelId { get; set; }       
        public Int32? ClientId { get; set; }
        public String model { get; set; }
    }
}