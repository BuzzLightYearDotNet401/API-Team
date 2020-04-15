using HealthAtHomeAPI.Data;
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

        public async Task<List<Exercises>> GetAllExercises()
        {
            return await _context.Exercises.ToListAsync();
        }

        public async Task<Exercises> GetExercisesById(int id)
        {
            Exercises exercise = await _context.Exercises.FindAsync(id);
            return exercise;
        }
    }
}
