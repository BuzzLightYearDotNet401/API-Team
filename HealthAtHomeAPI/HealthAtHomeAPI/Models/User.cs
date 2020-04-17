using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }

        //Navigation prop

        public Rating RatingId { get; set; }
    }
}
