using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimmingCenter2.Models.Info.MedicalInfo
{
    public class BloodTest
    {
        public Int32 BloodTestId { get; set; }
        public Int32? MedicalDataMedicalDataId { get; set; }
        public String blood { get; set; }
        
    }
}