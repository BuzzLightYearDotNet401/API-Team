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
        private HealthAtHomeAPIDbContext _context;
        private IExerciseManager _exercise;

        public RoutineNameService(HealthAtHomeAPIDbContext context, IExerciseManager exercise)
        {
            _context = context;
            _exercise = exercise;
        }


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

        public async Task<RoutineNamesDTO> GetRoutineById(int routineId)
        {
            RoutineName foundRoutine = await _context.RoutineNames.FindAsync(routineId);
            RoutineNamesDTO rnDto = new RoutineNamesDTO();
            rnDto.RoutineNameId = foundRoutine.RoutineNameId;
            rnDto.NameOfRoutine = foundRoutine.NameOfRoutine;

            rnDto.listOfExercises = await GetExercisesForRoutines(foundRoutine.RoutineNameId);
            return rnDto;
        }

        public async Task<List<ExerciseDTO>> GetExercisesForRoutines(int routineId)
        {
            var exerciseList = await _context.RoutineNames.Where(x => x.RoutineNameId == routineId).ToListAsync();

            List<ExerciseDTO> exercisesInRoutine = new List<ExerciseDTO>();

            foreach (var item in exerciseList)
            {
                ExerciseDTO exercise = await _exercise.GetExercisesById(item.RoutineNameId);
                exercisesInRoutine.Add(exercise);
            }
            return exercisesInRoutine;
        }

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
