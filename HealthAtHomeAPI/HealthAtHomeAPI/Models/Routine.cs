using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models
{
    //pure join table
    public class Routine
    {
        public int RoutineNameId { get; set; }
        public int ExerciseId { get; set; }

        // Nav props

        public RoutineName RoutineName { get; set; }
        public List<Exercises> Exercises { get; set; }

    }
}
