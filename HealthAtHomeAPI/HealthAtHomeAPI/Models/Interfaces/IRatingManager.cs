using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models.Interfaces
{
    public interface IRatingManager
    {
        //get all routineNames where rating >=3

        Task<List<RoutineName>> GetFavoriteRoutines(User user);


        //update rating for a routine
        Task UpdateRating(int starRating, Rating rating);

    }
}
