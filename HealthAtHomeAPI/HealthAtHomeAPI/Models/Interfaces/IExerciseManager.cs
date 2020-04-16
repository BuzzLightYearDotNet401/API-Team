using HealthAtHomeAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models.Interfaces
{
    public interface IExerciseManager
    {
        // READ - get exercises, all and by ID
        Task<List<ExerciseDTO>> GetAllExercises();
        Task<ExerciseDTO> GetExercisesById(int id);


    }
}
