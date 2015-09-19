using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimmingCenter2.Models.Info.MedicalInfo
{
    public class HealthIssues
    {
        public Int32 HealthIssuesId { get; set; }
        public Int32? MedicalDataMedicalDataId { get; set; }
        public String health { get; set; }
    }
}