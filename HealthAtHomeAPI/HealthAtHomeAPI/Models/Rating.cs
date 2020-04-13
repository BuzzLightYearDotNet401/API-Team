using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models
{
    public class Rating
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int RoutineID { get; set; }
        public StarRating StarRating { get; set; }
        public bool IsCurrent { get; set; }

        // nav props
        public User Users { get; set; }
        public Routine Routines { get; set; }
    }

    public enum StarRating
    {
        OneStar = 1,
        TwoStar = 2,
        ThreeStar = 3,
        FourStar = 4,
        FiveStar = 5
    }
}
