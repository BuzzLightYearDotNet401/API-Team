using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models
{
    public class Exercises
    {
        public int ID { get; set; }
        public string ExerciseName { get; set; }
        public int Reps { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }


    }
}
