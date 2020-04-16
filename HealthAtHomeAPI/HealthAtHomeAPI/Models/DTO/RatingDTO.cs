using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models.DTO
{
    public class RatingDTO
    {
        public int RatingId { get; set; }
        public int UserId { get; set; }
        public int RoutineNameId { get; set; }
        public StarRating StarRating { get; set; } 
    }
}
