using HealthAtHomeAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthAtHomeAPI.Data
{
    public class HealthAtHomeAPIDbContext : DbContext
    {
        /// <summary>
        /// This is telling us that this is the database and this sets the structure of our database as well
        /// </summary>
        /// <param name="options"></param>
        public HealthAtHomeAPIDbContext(DbContextOptions<HealthAtHomeAPIDbContext> options): base(options)
        {

        }

        /// <summary>
        /// This tells what our structure and names of our tables are going to be in the database.
        /// </summary>
        public DbSet<User> Users { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<RoutineName> RoutineNames { get; set; }
        public DbSet<Exercises> Exercises { get; set; }
        public DbSet<Routine> Routines { get; set; }


    }
}
