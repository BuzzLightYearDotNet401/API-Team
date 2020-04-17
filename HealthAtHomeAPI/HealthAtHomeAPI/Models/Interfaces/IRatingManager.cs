using HealthAtHomeAPI.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models.Interfaces
{
    public interface IRatingManager
    {

        // create a rating 
        Task<RatingDTO> CreateRating(RatingDTO rating);


        //get all routineNames where rating >=3

        Task<List<RoutineNamesDTO>> GetFavoriteRoutines(User user);


        //update rating for a routine
        Task <RatingDTO>UpdateRating(Rating rating);

    }
}
