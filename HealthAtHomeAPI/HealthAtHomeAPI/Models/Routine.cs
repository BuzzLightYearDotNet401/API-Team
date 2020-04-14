using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models
{
    public class Routine
    {
        public int RoutineNameID { get; set; }
        public int ExerciseID { get; set; }

        // Nav props

        public RoutineName RoutineNames { get; set; }
        public List<Exercises> Exercises { get; set; }

    }
}
