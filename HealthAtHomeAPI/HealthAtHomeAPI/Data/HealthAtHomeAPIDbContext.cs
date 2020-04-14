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

            modelBuilder.Entity<RoutineName>().HasData(
                new RoutineName
                {
                    ID = 1,
                    NameOfRoutine = "Upper Body Workout"
                },
                new RoutineName
                {
                    ID = 2,
                    NameOfRoutine = "Lower Body Workout"
                },
                new RoutineName
                {
                    ID = 3,
                    NameOfRoutine = "Glutes"
                },
                new RoutineName
                {
                    ID = 4,
                    NameOfRoutine = "Abs"
                },
                new RoutineName
                {
                    ID = 5,
                    NameOfRoutine = "Stretching"
                },
                 new RoutineName
                {
                    ID = 6,
                    NameOfRoutine = "Yoga"
                }
                );



            modelBuilder.Entity<Exercises>().HasData(
                new Exercises
                {
                    ID = 1,
                    ExerciseName = "Bicep Curls",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Hold a gallon of milk at your side with arms straight and palm forward, bend your elbow bring the weight toward your shoulder. Repeat."
                },
                new Exercises
                {
                    ID = 2,
                    ExerciseName = "Tricep Extensions",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Pose at a partial squat bending the waist, pin your elbow at you side, straighten your arm with your weight in hand."
                },
                new Exercises
                {
                    ID = 3,
                    ExerciseName = "Push Ups",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Begin in a plank position with hands slightly wider than shoulder width apart, keeping your core straight, bend your elbows to your sides, lowering yourself to the floor and push up."
                },
                new Exercises
                {
                    ID = 4,
                    ExerciseName = "Dips",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "On either a bed or a couch, place hands on the edge, bend your elbows, lowering yourself toward the floor in a reverse plank position. Press into your hands to return to a neutral position."
                },
                new Exercises
                {
                    ID = 5,
                    ExerciseName = "Over Head Press",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Bring weight shoulders, straighten arms pressing weight over head."
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
