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
    public class RatingService : IRatingManager
    {
        private HealthAtHomeAPIDbContext _context;
        private IRoutineNameManager _routineName;

        public RatingService(HealthAtHomeAPIDbContext context, IRoutineNameManager routineName)
        {
            _context = context;
            _routineName = routineName;
        }

        public async Task<List<RoutineNamesDTO>> GetFavoriteRoutines(User user)
        {
            var favoriteRoutines = await _context.Ratings.Where(x => x.StarRating >= StarRating.ThreeStar).ToListAsync();

            List<RoutineNamesDTO> routineNamesList = new List<RoutineNamesDTO>();

            foreach (var item in favoriteRoutines)
            {
                var routine = await _routineName.GetRoutineById(item.RoutineNameId);
                routineNamesList.Add(routine);
            }
            return routineNamesList;
        }

        public async Task<RatingDTO>UpdateRating(int starRating, Rating rating)
        {
            var ratingDto = RatingDTO(rating);
            _context.Entry(rating).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return ratingDto;
        }

        private RatingDTO RatingDTO(Rating rating)
        {
            RatingDTO rDto = new RatingDTO()
            {
                RatingId = rating.RatingId,
                UserId = rating.UserId,
                RoutineNameId = rating.RoutineNameId,
                StarRating = rating.StarRating
            };
            return rDto;
        }
    }
}
