using HealthAtHomeAPI.Data;
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

        public RatingService(HealthAtHomeAPIDbContext context)
        {
            _context = context;
        }
        public async Task<List<RoutineName>> GetFavoriteRoutines(User user)
        {
            var favoriteRoutines = await _context.Ratings.Where(x => x.StarRating >= StarRating.ThreeStar).ToListAsync();

            foreach (var item in favoriteRoutines)
            {
                item.RoutineNames = await _context.RoutineNames.FindAsync(item.RoutineNameId);
            }
            return null;
        }

        public async Task UpdateRating(int starRating, Rating rating)
        {
            _context.Entry(rating).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
