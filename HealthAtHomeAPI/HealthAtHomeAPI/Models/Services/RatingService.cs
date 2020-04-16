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
        /// <summary>
        /// We are injecting our db and interface of IRoutineNameManager so we can access a method used by that interface
        /// </summary>
        private HealthAtHomeAPIDbContext _context;
        private IRoutineNameManager _routineName;

        public RatingService(HealthAtHomeAPIDbContext context, IRoutineNameManager routineName)
        {
            _context = context;
            _routineName = routineName;
        }

        /// <summary>
        /// This method grabs all of the users favorite routines. It is queried to grad only routines that are rated 3 stars and up. We add it to a list and it is returned
        /// </summary>
        /// <param name="user">The user of the ratings we want to see</param>
        /// <returns>The list of only the favorite routines</returns>
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

        /// <summary>
        /// This allows our user to update their rating. After updated, the changes should be saved
        /// </summary>
        /// <param name="starRating"></param>
        /// <param name="rating"></param>
        /// <returns>It returns the updated rating</returns>
        public async Task<RatingDTO>UpdateRating(int starRating, Rating rating)
        {
            var ratingDto = RatingDTO(rating);
            _context.Entry(rating).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return ratingDto;
        }

        /// <summary>
        /// Normalizes the Rating data
        /// </summary>
        /// <param name="rating">The Rating model</param>
        /// <returns>As a DTO</returns>
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
