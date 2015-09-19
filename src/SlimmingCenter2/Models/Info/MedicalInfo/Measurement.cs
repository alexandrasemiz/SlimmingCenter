using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimmingCenter2.Models.Info.MedicalInfo
{
    public class Measurement
    {
        public Int32 MeasurementId { get; set; }
        public String bodyPart { get; set; }
        public Int32 value { get; set; }
        public MedicalData MedicalData { get; set; }
        public Int32? MedicalDataMedicalDataId { get; set; }        
    }
}