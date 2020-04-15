using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models.Interfaces
{
    public interface IRoutineNameManager
    {
        //get all routines
        Task<List<RoutineName>> GetAllRoutineNames();

        //get routine by ID
        Task<RoutineName> GetRoutineById(int routineId);
    }
}
