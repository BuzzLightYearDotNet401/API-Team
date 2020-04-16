using HealthAtHomeAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models.Interfaces
{
    public interface IRoutineNameManager
    {
        //get all routines
        Task<List<RoutineNamesDTO>> GetAllRoutineNames();

        //get routine by ID
        Task<RoutineNamesDTO> GetRoutineById(int routineId);

        //get all exercises in a given routine by Id
        Task<List<ExerciseDTO>> GetExercisesForRoutines(int routineId);
    }
}
