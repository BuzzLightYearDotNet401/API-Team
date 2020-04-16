﻿// <auto-generated />
using System;
using HealthAtHomeAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HealthAtHomeAPI.Migrations
{
    [DbContext(typeof(HealthAtHomeAPIDbContext))]
    partial class HealthAtHomeAPIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HealthAtHomeAPI.Models.Exercises", b =>
                {
                    b.Property<int>("ExerciseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExerciseName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Reps")
                        .HasColumnType("int");

                    b.Property<int?>("RoutineExerciseId")
                        .HasColumnType("int");

                    b.Property<int?>("RoutineNameId")
                        .HasColumnType("int");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId");

                    b.HasIndex("RoutineExerciseId", "RoutineNameId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            ExerciseId = 1,
                            Description = "Hold a gallon of milk at your side with arms straight and palm forward, bend your elbow bring the weight toward your shoulder. Repeat.",
                            ExerciseName = "Bicep Curls",
                            Image = "/Assets/Poses/Curls.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 2,
                            Description = "Pose at a partial squat bending the waist, pin your elbow at you side, straighten your arm with your weight in hand.",
                            ExerciseName = "Tricep Extensions",
                            Image = "/Assets/Poses/TricepExtension.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 3,
                            Description = "Begin in a plank position with hands slightly wider than shoulder width apart, keeping your core straight, bend your elbows to your sides, lowering yourself to the floor and push up.",
                            ExerciseName = "Push Ups",
                            Image = "/Assets/Poses/PushUp.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 4,
                            Description = "On either a bed or a couch, place hands on the edge, bend your elbows, lowering yourself toward the floor in a reverse plank position. Press into your hands to return to a neutral position.",
                            ExerciseName = "Dips",
                            Image = "/Assets/Poses/Dips.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 5,
                            Description = "Bring weight shoulders, straighten arms pressing weight over head.",
                            ExerciseName = "Over Head Press",
                            Image = "/Assets/Poses/OverHeadPress.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 6,
                            Description = "Stand with feet slightly wider than shoulder width apart, sit back in an imaginary chair. Press feet into the ground to stand back up.",
                            ExerciseName = "Squat",
                            Image = "/Assets/Poses/Squat.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 7,
                            Description = "Stand in good posture. Step forward and bend both knees to 90 degrees, keeping trunk upright.",
                            ExerciseName = "Lunges",
                            Image = "/Assets/Poses/Lunge.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 8,
                            Description = "Begin lying on your side with bottom knee bent and top leg straight in line with your trunk. Hold a weight on the outside of your thigh. Lift your top leg up and back, keeping your knee straight.",
                            ExerciseName = "Sidelying Leg lifts",
                            Image = "/Assets/Poses/SidelyingLegLift.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 9,
                            Description = "Place the balls of your feet at the edge of a stair step. Lower your heels below the plane of the step, then push into the balls of your feet to rise back up.",
                            ExerciseName = "Calf Raises",
                            Image = "/Assets/Poses/CalfRaise.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 10,
                            Description = "Stand in good posture, weight optional. Bend forward, keeping knees straight and back flat. Return to standing, keeping your knees straight.",
                            ExerciseName = "Good Mornings",
                            Image = "/Assets/Poses/GoodMorning.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 11,
                            Description = "Lie on your back with knees bent and feet flat. Lift glutes off floor and keeping hips square, straighten one leg. Lower back down and repeat on the other side.",
                            ExerciseName = "Bridging with leg extensions",
                            Image = "/Assets/Poses/BridgeLegExtension.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 12,
                            Description = "Begin on hands and knees, hands underneath shoulders, knees underneath hips. Lift opposite arm and leg. Hold for 3 seconds, then lower back down.",
                            ExerciseName = "Arm and Leg Extension on All Fours",
                            Image = "/Assets/Poses/ArmLegExtension.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 13,
                            Description = "Begin on hands and knees, straighten one leg onto the ball of your foot, then the other. Squeeze gluteals and press hands into the floor, keeping your trunk and pelvis in neutral. Hold for up to 1 minute.",
                            ExerciseName = "Plank",
                            Image = "/Assets/Poses/Plank.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 14,
                            Description = "Lie on your back and alternate lifting your legs to hip height. Keep your knees bent.",
                            ExerciseName = "Pilates March",
                            Image = "/Assets/Poses/PilatesRun.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 15,
                            Description = "Sit with trunk straight and feet flat on the floor. Lean back slightly, holding a weight (optional). Move the weight from the left side of your body to the right side of your body back and forth.",
                            ExerciseName = "Trunk Twists",
                            Image = "/Assets/Poses/TrunkTwist.jpg",
                            Reps = 10,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 16,
                            Description = "Begin on hands and knees. Lower your belly and lift your head, then reverse the motion by rounding your back towards the ceiling and dropping your head. Repeat back and forth.",
                            ExerciseName = "Cat & Cow",
                            Image = "/Assets/Poses/Yoga2.JPEG",
                            Reps = 10,
                            Sets = 1
                        },
                        new
                        {
                            ExerciseId = 17,
                            Description = "Begin on hands and knees. Push down into your hands and knees, lifting your trunk into the air. Breathe deeply.",
                            ExerciseName = "Downward Dog",
                            Image = "/Assets/Poses/Yoga3.JPEG",
                            Reps = 3,
                            Sets = 1
                        },
                        new
                        {
                            ExerciseId = 18,
                            Description = "Begin in a plank position with hands slightly wider than shoulder width apart, keeping your core straight, bend your elbows to your sides, lowering yourself to the floor.",
                            ExerciseName = "Chattaranga",
                            Image = "/Assets/Poses/Yoga6.JPEG",
                            Reps = 1,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 19,
                            Description = "Begin lying on your stomach with hands at your shoulders. Press into your hands and lift your trunk off the floor.",
                            ExerciseName = "Cobra",
                            Image = "/Assets/Poses/Yoga5.JPEG",
                            Reps = 1,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 20,
                            Description = "From a downward dog position, bring one foot between your hands and stand into a lunge.",
                            ExerciseName = "Warrior I",
                            Image = "/Assets/Poses/Yoga7.JPEG",
                            Reps = 1,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 21,
                            Description = "Sit with trunk straight and feet flat on the floor. Lean back slightly, and lift legs off the floor.",
                            ExerciseName = "Boat Pose",
                            Image = "/Assets/Poses/Yoga4.JPEG",
                            Reps = 1,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 22,
                            Description = "Stand in good posture. Using your hand, bring your foot towards your gluteals, keeping knees together.",
                            ExerciseName = "Quad Stretch",
                            Image = "/Assets/Poses/QuadStretch.jpg",
                            Reps = 1,
                            Sets = 3
                        },
                        new
                        {
                            ExerciseId = 23,
                            Description = "Perform a side lunge and allow the muscles on your inner thigh to stretch.",
                            ExerciseName = "Adductor Stretch",
                            Image = "/Assets/Poses/AdductorStretch.jpg",
                            Reps = 1,
                            Sets = 3
                        });
                });

            modelBuilder.Entity("HealthAtHomeAPI.Models.Rating", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoutineNameId")
                        .HasColumnType("int");

                    b.Property<int>("RatingId")
                        .HasColumnType("int");

                    b.Property<int>("StarRating")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoutineNameId");

                    b.HasIndex("RoutineNameId");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoutineNameId = 1,
                            RatingId = 1,
                            StarRating = 4
                        });
                });

            modelBuilder.Entity("HealthAtHomeAPI.Models.Routine", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<int>("RoutineNameId")
                        .HasColumnType("int");

                    b.HasKey("ExerciseId", "RoutineNameId");

                    b.HasIndex("RoutineNameId");

                    b.ToTable("Routines");

                    b.HasData(
                        new
                        {
                            ExerciseId = 1,
                            RoutineNameId = 1
                        },
                        new
                        {
                            ExerciseId = 2,
                            RoutineNameId = 1
                        },
                        new
                        {
                            ExerciseId = 3,
                            RoutineNameId = 1
                        },
                        new
                        {
                            ExerciseId = 4,
                            RoutineNameId = 1
                        },
                        new
                        {
                            ExerciseId = 5,
                            RoutineNameId = 1
                        },
                        new
                        {
                            ExerciseId = 6,
                            RoutineNameId = 2
                        },
                        new
                        {
                            ExerciseId = 7,
                            RoutineNameId = 2
                        },
                        new
                        {
                            ExerciseId = 8,
                            RoutineNameId = 2
                        },
                        new
                        {
                            ExerciseId = 9,
                            RoutineNameId = 2
                        },
                        new
                        {
                            ExerciseId = 10,
                            RoutineNameId = 2
                        },
                        new
                        {
                            ExerciseId = 8,
                            RoutineNameId = 3
                        },
                        new
                        {
                            ExerciseId = 10,
                            RoutineNameId = 3
                        },
                        new
                        {
                            ExerciseId = 11,
                            RoutineNameId = 3
                        },
                        new
                        {
                            ExerciseId = 12,
                            RoutineNameId = 3
                        },
                        new
                        {
                            ExerciseId = 11,
                            RoutineNameId = 4
                        },
                        new
                        {
                            ExerciseId = 12,
                            RoutineNameId = 4
                        },
                        new
                        {
                            ExerciseId = 13,
                            RoutineNameId = 4
                        },
                        new
                        {
                            ExerciseId = 14,
                            RoutineNameId = 4
                        },
                        new
                        {
                            ExerciseId = 15,
                            RoutineNameId = 4
                        },
                        new
                        {
                            ExerciseId = 21,
                            RoutineNameId = 4
                        },
                        new
                        {
                            ExerciseId = 17,
                            RoutineNameId = 5
                        },
                        new
                        {
                            ExerciseId = 19,
                            RoutineNameId = 5
                        },
                        new
                        {
                            ExerciseId = 22,
                            RoutineNameId = 5
                        },
                        new
                        {
                            ExerciseId = 23,
                            RoutineNameId = 5
                        },
                        new
                        {
                            ExerciseId = 16,
                            RoutineNameId = 6
                        },
                        new
                        {
                            ExerciseId = 17,
                            RoutineNameId = 6
                        },
                        new
                        {
                            ExerciseId = 18,
                            RoutineNameId = 6
                        },
                        new
                        {
                            ExerciseId = 19,
                            RoutineNameId = 6
                        },
                        new
                        {
                            ExerciseId = 20,
                            RoutineNameId = 6
                        },
                        new
                        {
                            ExerciseId = 21,
                            RoutineNameId = 6
                        });
                });

            modelBuilder.Entity("HealthAtHomeAPI.Models.RoutineName", b =>
                {
                    b.Property<int>("RoutineNameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfRoutine")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoutineNameId");

                    b.ToTable("RoutineNames");

                    b.HasData(
                        new
                        {
                            RoutineNameId = 1,
                            NameOfRoutine = "Upper Body Workout"
                        },
                        new
                        {
                            RoutineNameId = 2,
                            NameOfRoutine = "Lower Body Workout"
                        },
                        new
                        {
                            RoutineNameId = 3,
                            NameOfRoutine = "Glutes"
                        },
                        new
                        {
                            RoutineNameId = 4,
                            NameOfRoutine = "Abs"
                        },
                        new
                        {
                            RoutineNameId = 5,
                            NameOfRoutine = "Stretching"
                        },
                        new
                        {
                            RoutineNameId = 6,
                            NameOfRoutine = "Yoga"
                        });
                });

            modelBuilder.Entity("HealthAtHomeAPI.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Name = "test"
                        });
                });

            modelBuilder.Entity("HealthAtHomeAPI.Models.Exercises", b =>
                {
                    b.HasOne("HealthAtHomeAPI.Models.Routine", null)
                        .WithMany("Exercises")
                        .HasForeignKey("RoutineExerciseId", "RoutineNameId");
                });

            modelBuilder.Entity("HealthAtHomeAPI.Models.Rating", b =>
                {
                    b.HasOne("HealthAtHomeAPI.Models.RoutineName", "RoutineNames")
                        .WithMany()
                        .HasForeignKey("RoutineNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HealthAtHomeAPI.Models.User", "Users")
                        .WithOne("RatingId")
                        .HasForeignKey("HealthAtHomeAPI.Models.Rating", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HealthAtHomeAPI.Models.Routine", b =>
                {
                    b.HasOne("HealthAtHomeAPI.Models.RoutineName", "RoutineName")
                        .WithMany()
                        .HasForeignKey("RoutineNameId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
