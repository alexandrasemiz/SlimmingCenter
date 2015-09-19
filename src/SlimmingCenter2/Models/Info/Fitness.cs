using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlimmingCenter2.Models.Info
{
    public class Fitness
    {
        public Int32 FitnessId { get; set; }
        public Int32? ClientId { get; set; }
        public virtual ICollection<FitnessLesson> FitnessLessons{get;set;}      
        public Fitness()
        {
            FitnessLessons = new List<FitnessLesson>();
        }
    }
}