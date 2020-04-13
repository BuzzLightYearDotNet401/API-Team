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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Routine>().HasKey(x => new { x.ExerciseID });
            //modelBuilder.Entity<HotelRoom>().HasKey(x => new { x.HotelID, x.RoomID });

            modelBuilder.Entity<Exercises>().HasData(
                new Exercises
                {
                    ID = 1,
                    ExerciseName = "Bicep Curls",
                    Sets = 3,
                    Reps = 5,
                    Image = "test",
                    Description = "Bring hand to shoulder"
                }
                );

            modelBuilder.Entity<Routine>().HasData(
                 new Routine
                 {
                     ExerciseID = 1,
                     RoutineNameID = 1
                 }
                 );
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
