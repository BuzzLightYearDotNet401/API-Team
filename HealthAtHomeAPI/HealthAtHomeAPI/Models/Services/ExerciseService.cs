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
    public class ExerciseService : IExerciseManager
    {
        //injects our dbcontext
        private HealthAtHomeAPIDbContext _context;

        public ExerciseService(HealthAtHomeAPIDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This method creates a list of all of our exercises, converts it to DTO within our loop and returns that list
        /// </summary>
        /// <returns>Our list of Exercises</returns>
        public async Task<List<ExerciseDTO>> GetAllExercises()
        {
            var exercises = await _context.Exercises.ToListAsync();

            List<ExerciseDTO> eDto = new List<ExerciseDTO>();
            foreach (var item in exercises)
            {
                eDto.Add(ExerciseDTO(item));
            }
            return eDto;
        }

        /// <summary>
        /// Grabs our exercises specifically by their ID.
        /// </summary>
        /// <param name="id">the selected exercise ID</param>
        /// <returns>the exercise and it is normalized through the DTO</returns>
        public async Task<ExerciseDTO> GetExercisesById(int id)
        {
            Exercises exercise = await _context.Exercises.FindAsync(id);
            return ExerciseDTO(exercise);
        }

        /// <summary>
        /// Allows us to normalize our Exercise data
        /// </summary>
        /// <param name="exercise">Our exercise model</param>
        /// <returns>Returns the info as a DTO</returns>
        private ExerciseDTO ExerciseDTO(Exercises exercise)
        {
            ExerciseDTO eDto = new ExerciseDTO()
            {

                ExerciseId = exercise.ExerciseId,
                ExerciseName = exercise.ExerciseName,
                Sets = exercise.Sets,
                Reps = exercise.Reps,
                Image = exercise.Image,
                Description = exercise.Description

            };
            return eDto;
        }
    }
}
