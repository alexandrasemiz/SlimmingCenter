using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimmingCenter2.Models.Info.MedicalInfo
{
    public class Sonography
    {
        public Int32 SonographyId { get; set; }
        public Int32? MedicalDataMedicalDataId { get; set; }
        public String sono { get; set; }
    }
}