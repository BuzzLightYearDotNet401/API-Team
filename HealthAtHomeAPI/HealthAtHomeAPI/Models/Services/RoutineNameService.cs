using HealthAtHomeAPI.Data;
using HealthAtHomeAPI.Models.DTO;
using HealthAtHomeAPI.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models.Services
{
    public class RoutineNameService : IRoutineNameManager
    {
        /// <summary>
        /// We are injecting the dbcontext and the IExerciseManager interface to use a method from that interface
        /// </summary>
        private HealthAtHomeAPIDbContext _context;
        private IExerciseManager _exercise;

        public RoutineNameService(HealthAtHomeAPIDbContext context, IExerciseManager exercise)
        {
            _context = context;
            _exercise = exercise;
        }

        /// <summary>
        /// This grabs all our routine names, converts it to a DTO list and is returned
        /// </summary>
        /// <returns>All of the routine names</returns>
        public async Task<List<RoutineNamesDTO>> GetAllRoutineNames()
        {
             var routineName = await _context.RoutineNames.ToListAsync();
            List<RoutineNamesDTO> routineNamesDTO = new List<RoutineNamesDTO>();
            foreach (var item in routineName)
            {
                routineNamesDTO.Add(RnDTO(item)); 
            }
            return routineNamesDTO;
            
        }

        /// <summary>
        /// Grabs our routine specifically by ID. It also calls out GetExercisesForRoutines method so that when quering the id, we can see all the exercises within that ID as well.
        /// </summary>
        /// <param name="routineId">The routine id</param>
        /// <returns>The specific routine ID that is called for and the list of exercises that is related to it.</returns>
        public async Task<RoutineNamesDTO> GetRoutineById(int routineId)
        {
            RoutineName foundRoutine = await _context.RoutineNames.FindAsync(routineId);
            RoutineNamesDTO rnDto = new RoutineNamesDTO();
            rnDto.RoutineNameId = foundRoutine.RoutineNameId;
            rnDto.NameOfRoutine = foundRoutine.NameOfRoutine;

            rnDto.listOfExercises = await GetExercisesForRoutines(foundRoutine.RoutineNameId);
            return rnDto;
        }

        /// <summary>
        /// Gets all the exercises associated with that specific routine ID.
        /// </summary>
        /// <param name="routineId">The routine id</param>
        /// <returns>The list of exercises for that routine</returns>
        public async Task<List<ExerciseDTO>> GetExercisesForRoutines(int routineId)
        {
            var exerciseList = await _context.Routines.Where(x => x.RoutineNameId == routineId).ToListAsync();

            List<ExerciseDTO> exercisesInRoutine = new List<ExerciseDTO>();

            foreach (var item in exerciseList)
            {
                ExerciseDTO exercise = await _exercise.GetExercisesById(item.ExerciseId);
                exercisesInRoutine.Add(exercise);
            }
            return exercisesInRoutine;
        }

        /// <summary>
        /// Normalizes the Routine Names data
        /// </summary>
        /// <param name="routineName">The Routine Name model</param>
        /// <returns>Returns as DTO</returns>
        private RoutineNamesDTO RnDTO(RoutineName routineName)
        {
            RoutineNamesDTO rnDTO = new RoutineNamesDTO()
            {
                RoutineNameId = routineName.RoutineNameId,
                NameOfRoutine = routineName.NameOfRoutine

            };
                return rnDTO;
    }
    
    }
}
