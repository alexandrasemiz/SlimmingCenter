using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimmingCenter2.Models.Info
{
    public class FitnessLesson
    {
        public Int32 FitnessLessonId { get; set; }
        public DateTime time { get; set; }
        public String fitnessType { get; set; }

        public virtual ICollection<Fitness> Fitnesses { get; set; }
        public FitnessLesson()
        {
            Fitnesses = new List<Fitness>();
        }        
    }
}