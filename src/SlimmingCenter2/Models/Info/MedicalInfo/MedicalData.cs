using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimmingCenter2.Models.Info.MedicalInfo
{
    public class MedicalData
    {
        public Int32 MedicalDataId { get; set; }
        public DateTime time { get; set; }
        public Cardiogram cardiogram { get; set; }
        public Sonography sonography { get; set; }
        public BloodTest bloodtest { get; set; }
        public HealthIssues healthissues { get; set; }
        public ICollection<Measurement> Measurements { get; set; }
        public MakeupBody makeupbody { get; set; }

        public Int32? ClientId { get; set; }
    }
}