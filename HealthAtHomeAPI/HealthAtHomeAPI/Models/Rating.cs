using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models
{
    public class Rating
    {
       
        public int UserId { get; set; }
        public int RoutineNameId { get; set; }
        public StarRating StarRating { get; set; }

        // nav props
     //   public User Users { get; set; }
      //  public RoutineName RoutineNames { get; set; }
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
