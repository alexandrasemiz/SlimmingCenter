using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimmingCenter2.Models.Info.MedicalInfo
{
    public class MakeupBody
    {
        public Int32 MakeupBodyId { get; set; }
        public String muscle { get; set; }
        public String fat { get; set; }
        public String visceralFat { get; set; }
        public Int32 procentBoneWater { get; set; }
        public Int32 weight { get; set; }
        public Int32 metabolicAge { get; set; }
        public Int32? MedicalDataMedicalDataId { get; set; }
    }
}