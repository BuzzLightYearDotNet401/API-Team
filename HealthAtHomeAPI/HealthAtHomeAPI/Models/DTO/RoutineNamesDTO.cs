using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models.DTO
{
    public class RoutineNamesDTO 
    {

        public int RoutineNameId { get; set; }
        public string NameOfRoutine { get; set; }

        public List<ExerciseDTO> listOfExercises { get; set; }
    
    }
}
