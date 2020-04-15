using HealthAtHomeAPI.Data;
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

        public RoutineNameService(HealthAtHomeAPIDbContext context)
        {
            _context = context;
        }

        public async Task<List<RoutineName>> GetAllRoutineNames()
        {
            return await _context.RoutineNames.ToListAsync();
           
        }

        public async Task<RoutineName> GetRoutineById(int routineId)
        {
            RoutineName foundRoutine = await _context.RoutineNames.FindAsync(routineId);
            return foundRoutine;
        }
    }
}
