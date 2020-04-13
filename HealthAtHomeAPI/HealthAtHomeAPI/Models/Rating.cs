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
        public int StarRating { get; set; }
        public bool IsCurrent { get; set; }


    }
}
