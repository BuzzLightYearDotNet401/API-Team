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
        /// this method seeds data into our database. 
        /// </summary>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Routine>().HasKey(x => new { x.ExerciseId, x.RoutineNameId });
            modelBuilder.Entity<Rating>().HasKey(x => new { x.UserId, x.RoutineNameId });
            modelBuilder.Entity<Exercises>().HasKey(x => x.ExerciseId);


            modelBuilder.Entity<RoutineName>().HasData(
                new RoutineName
                {
                    RoutineNameId = 1,
                    NameOfRoutine = "Upper Body Workout"
                },
                new RoutineName
                {
                    RoutineNameId = 2,
                    NameOfRoutine = "Lower Body Workout"
                },
                new RoutineName
                {
                    RoutineNameId = 3,
                    NameOfRoutine = "Glutes"
                },
                new RoutineName
                {
                    RoutineNameId = 4,
                    NameOfRoutine = "Abs"
                },
                new RoutineName
                {
                    RoutineNameId = 5,
                    NameOfRoutine = "Stretching"
                },
                 new RoutineName
                {
                     RoutineNameId = 6,
                    NameOfRoutine = "Yoga"
                }
                );

            modelBuilder.Entity<Exercises>().HasData(
                new Exercises
                {
                    ExerciseId = 1,
                    ExerciseName = "Bicep Curls",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Hold a gallon of milk at your side with arms straight and palm forward, bend your elbow bring the weight toward your shoulder. Repeat."
                },
                new Exercises
                {
                    ExerciseId = 2,
                    ExerciseName = "Tricep Extensions",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Pose at a partial squat bending the waist, pin your elbow at you side, straighten your arm with your weight in hand."
                },
                new Exercises
                {
                   ExerciseId= 3,
                    ExerciseName = "Push Ups",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Begin in a plank position with hands slightly wider than shoulder width apart, keeping your core straight, bend your elbows to your sides, lowering yourself to the floor and push up."
                },
                new Exercises
                {
                   ExerciseId= 4,
                    ExerciseName = "Dips",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "On either a bed or a couch, place hands on the edge, bend your elbows, lowering yourself toward the floor in a reverse plank position. Press into your hands to return to a neutral position."
                },
                new Exercises
                {
                   ExerciseId= 5,
                    ExerciseName = "Over Head Press",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Bring weight shoulders, straighten arms pressing weight over head."
                },



                new Exercises
                {
                   ExerciseId= 6,
                    ExerciseName = "Squat",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Stand with feet slightly wider than shoulder width apart, sit back in an imaginary chair. Press feet into the ground to stand back up."
                },
                new Exercises
                {
                   ExerciseId= 7,
                    ExerciseName = "Lunges",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Stand in good posture. Step forward and bend both knees to 90 degrees, keeping trunk upright."
                },
                new Exercises
                {
                   ExerciseId= 8,
                    ExerciseName = "Sidelying Leg lifts",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Begin lying on your side with bottom knee bent and top leg straight in line with your trunk. Hold a weight on the outside of your thigh. Lift your top leg up and back, keeping your knee straight."
                },
                new Exercises
                {
                   ExerciseId= 9,
                    ExerciseName = "Calf Raises",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Place the balls of your feet at the edge of a stair step. Lower your heels below the plane of the step, then push into the balls of your feet to rise back up."
                },
                new Exercises
                {
                   ExerciseId= 10,
                    ExerciseName = "Good Mornings",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Stand in good posture, weight optional. Bend forward, keeping knees straight and back flat. Return to standing, keeping your knees straight."
                },

                new Exercises
                {
                   ExerciseId= 11,
                    ExerciseName = "Bridging with leg extensions",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Lie on your back with knees bent and feet flat. Lift glutes off floor and keeping hips square, straighten one leg. Lower back down and repeat on the other side."
                },
                new Exercises
                {
                   ExerciseId= 12,
                    ExerciseName = "Arm and Leg Extension on All Fours",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Begin on hands and knees, hands underneath shoulders, knees underneath hips. Lift opposite arm and leg. Hold for 3 seconds, then lower back down."
                },
                new Exercises
                {
                   ExerciseId= 13,
                    ExerciseName = "Plank",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Begin on hands and knees, straighten one leg onto the ball of your foot, then the other. Squeeze gluteals and press hands into the floor, keeping your trunk and pelvis in neutral. Hold for up to 1 minute."
                },
                new Exercises
                {
                   ExerciseId= 14,
                    ExerciseName = "Pilates March",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Lie on your back and alternate lifting your legs to hip height. Keep your knees bent."
                },
                new Exercises
                {
                   ExerciseId= 15,
                    ExerciseName = "Trunk Twists",
                    Sets = 3,
                    Reps = 10,
                    Image = "test",
                    Description = "Sit with trunk straight and feet flat on the floor. Lean back slightly, holding a weight (optional). Move the weight from the left side of your body to the right side of your body back and forth."
                },

                new Exercises
                {
                   ExerciseId= 16,
                    ExerciseName = "Cat & Cow",
                    Sets = 1,
                    Reps = 10,
                    Image = "~/Assets/Yoga2.JPEG",
                    Description = "Begin on hands and knees. Lower your belly and lift your head, then reverse the motion by rounding your back towards the ceiling and dropping your head. Repeat back and forth."
                },
                new Exercises
                {
                   ExerciseId= 17,
                    ExerciseName = "Downward Dog",
                    Sets = 1,
                    Reps = 3,
                    Image = "~/Assets/Yoga3.JPEG",
                    Description = "Begin on hands and knees. Push down into your hands and knees, lifting your trunk into the air. Breathe deeply."
                },
                new Exercises
                {
                   ExerciseId= 18,
                    ExerciseName = "Chattaranga",
                    Sets = 3,
                    Reps = 1,
                    Image = "~/Assets/Yoga6.JPEG",
                    Description = "Begin in a plank position with hands slightly wider than shoulder width apart, keeping your core straight, bend your elbows to your sides, lowering yourself to the floor."
                },
                new Exercises
                {
                   ExerciseId= 19,
                    ExerciseName = "Cobra",
                    Sets = 3,
                    Reps = 1,
                    Image = "~/Assets/Yoga5.JPEG",
                    Description = "Begin lying on your stomach with hands at your shoulders. Press into your hands and lift your trunk off the floor."
                },
                new Exercises
                {
                   ExerciseId= 20,
                    ExerciseName = "Warrior I",
                    Sets = 3,
                    Reps = 1,
                    Image = "~/Assets/Yoga7.JPEG",
                    Description = "From a downward dog position, bring one foot between your hands and stand into a lunge."
                },

                new Exercises
                {
                   ExerciseId= 21,
                    ExerciseName = "Boat Pose",
                    Sets = 3,
                    Reps = 1,
                    Image = "~/Assets/Yoga4.JPEG",
                    Description = "Sit with trunk straight and feet flat on the floor. Lean back slightly, and lift legs off the floor."
                },

                new Exercises
                {
                   ExerciseId= 22,
                    ExerciseName = "Quad Stretch",
                    Sets = 3,
                    Reps = 1,
                    Image = "test",
                    Description = "Stand in good posture. Using your hand, bring your foot towards your gluteals, keeping knees together."
                },

                new Exercises
                {
                   ExerciseId= 23,
                    ExerciseName = "Adductor Stretch",
                    Sets = 3,
                    Reps = 1,
                    Image = "test",
                    Description = "Perform a side lunge and allow the muscles on your inner thigh to stretch."
                }
                );


            modelBuilder.Entity<Routine>().HasData(
                 new Routine
                 {
                     ExerciseId = 1,
                     RoutineNameId = 1
                 },
                new Routine
                {
                    ExerciseId = 2,
                    RoutineNameId = 1
                },
                new Routine
                {
                    ExerciseId = 3,
                    RoutineNameId = 1
                },
                new Routine
                {
                    ExerciseId = 4,
                    RoutineNameId = 1
                },
                new Routine
                {
                    ExerciseId = 5,
                    RoutineNameId = 1
                },
                new Routine
                {
                    ExerciseId = 6,
                    RoutineNameId = 2
                },
                new Routine
                {
                    ExerciseId = 7,
                    RoutineNameId = 2
                },
                new Routine
                {
                    ExerciseId = 8,
                    RoutineNameId = 2
                },
                new Routine
                {
                    ExerciseId = 9,
                    RoutineNameId = 2
                },
                new Routine
                {
                    ExerciseId = 10,
                    RoutineNameId = 2
                },
                new Routine
                {
                    ExerciseId = 8,
                    RoutineNameId = 3
                },
                new Routine
                {
                    ExerciseId = 10,
                    RoutineNameId = 3
                },
                new Routine
                {
                    ExerciseId = 11,
                    RoutineNameId = 3
                },
                new Routine
                {
                    ExerciseId = 12,
                    RoutineNameId = 3
                },
                new Routine
                {
                    ExerciseId = 11,
                    RoutineNameId = 4
                },
                new Routine
                {
                    ExerciseId = 12,
                    RoutineNameId = 4
                },
                new Routine
                {
                    ExerciseId = 13,
                    RoutineNameId = 4
                },
                new Routine
                {
                    ExerciseId = 14,
                    RoutineNameId = 4
                },
                new Routine
                {
                    ExerciseId = 15,
                    RoutineNameId = 4
                },
                new Routine
                {
                    ExerciseId = 21,
                    RoutineNameId = 4
                },
                new Routine
                {
                    ExerciseId = 17,
                    RoutineNameId = 5
                },
                new Routine
                {
                    ExerciseId = 19,
                    RoutineNameId = 5
                },
                new Routine
                {
                    ExerciseId = 22,
                    RoutineNameId = 5
                },
                new Routine
                {
                    ExerciseId = 23,
                    RoutineNameId = 5
                },
                new Routine
                {
                    ExerciseId = 16,
                    RoutineNameId = 6
                },
                new Routine
                {
                    ExerciseId = 17,
                    RoutineNameId = 6
                },
                new Routine
                {
                    ExerciseId = 18,
                    RoutineNameId = 6
                },
                new Routine
                {
                    ExerciseId = 19,
                    RoutineNameId = 6
                },
                new Routine
                {
                    ExerciseId = 20,
                    RoutineNameId = 6
                },
                new Routine
                {
                    ExerciseId = 21,
                    RoutineNameId = 6
                }
                 );




            // Brandon - please seed data for Rating
            modelBuilder.Entity<Rating>().HasData(
                 new Rating
                 {
                       RatingId = 1,
                       UserId = 1,
                       RoutineNameId = 1,
                       StarRating = StarRating.FourStar
                 }
                 );

            // Brandon - please seed data for User
            modelBuilder.Entity<User>().HasData(
                 new User
                 {
                     UserId = 1,
                     Name = "test"
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
