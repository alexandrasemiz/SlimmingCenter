using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SlimmingCenter2.Models.Info.MedicalInfo
{
    public class Cardiogram
    {
        public Int32 CardiogramId { get; set; }
        public String cardio { get; set; }
        public Int32? MedicalDataMedicalDataId { get; set; }
    }
}