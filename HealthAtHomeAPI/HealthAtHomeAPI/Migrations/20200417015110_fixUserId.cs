using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAtHomeAPI.Migrations
{
    public partial class fixUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RoutineNames",
                columns: table => new
                {
                    RoutineNameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfRoutine = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoutineNames", x => x.RoutineNameId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Routines",
                columns: table => new
                {
                    RoutineNameId = table.Column<int>(nullable: false),
                    ExerciseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routines", x => new { x.ExerciseId, x.RoutineNameId });
                    table.ForeignKey(
                        name: "FK_Routines_RoutineNames_RoutineNameId",
                        column: x => x.RoutineNameId,
                        principalTable: "RoutineNames",
                        principalColumn: "RoutineNameId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoutineNameId = table.Column<int>(nullable: false),
                    StarRating = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => new { x.UserId, x.RoutineNameId });
                    table.ForeignKey(
                        name: "FK_Ratings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    ExerciseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseName = table.Column<string>(nullable: true),
                    Sets = table.Column<int>(nullable: false),
                    Reps = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    RoutineExerciseId = table.Column<int>(nullable: true),
                    RoutineNameId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.ExerciseId);
                    table.ForeignKey(
                        name: "FK_Exercises_Routines_RoutineExerciseId_RoutineNameId",
                        columns: x => new { x.RoutineExerciseId, x.RoutineNameId },
                        principalTable: "Routines",
                        principalColumns: new[] { "ExerciseId", "RoutineNameId" },
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "ExerciseId", "Description", "ExerciseName", "Image", "Reps", "RoutineExerciseId", "RoutineNameId", "Sets" },
                values: new object[,]
                {
                    { 1, "Hold a gallon of milk at your side with arms straight and palm forward, bend your elbow bring the weight toward your shoulder. Repeat.", "Bicep Curls", "test", 10, null, null, 3 },
                    { 23, "Perform a side lunge and allow the muscles on your inner thigh to stretch.", "Adductor Stretch", "test", 1, null, null, 3 },
                    { 22, "Stand in good posture. Using your hand, bring your foot towards your gluteals, keeping knees together.", "Quad Stretch", "test", 1, null, null, 3 },
                    { 21, "Sit with trunk straight and feet flat on the floor. Lean back slightly, and lift legs off the floor.", "Boat Pose", "/Assets/Poses/Yoga4.JPEG", 1, null, null, 3 },
                    { 20, "From a downward dog position, bring one foot between your hands and stand into a lunge.", "Warrior I", "/Assets/Poses/Yoga7.JPEG", 1, null, null, 3 },
                    { 19, "Begin lying on your stomach with hands at your shoulders. Press into your hands and lift your trunk off the floor.", "Cobra", "/Assets/Poses/Yoga5.JPEG", 1, null, null, 3 },
                    { 18, "Begin in a plank position with hands slightly wider than shoulder width apart, keeping your core straight, bend your elbows to your sides, lowering yourself to the floor.", "Chattaranga", "/Assets/Poses/Yoga6.JPEG", 1, null, null, 3 },
                    { 17, "Begin on hands and knees. Push down into your hands and knees, lifting your trunk into the air. Breathe deeply.", "Downward Dog", "/Assets/Poses/Yoga3.JPEG", 3, null, null, 1 },
                    { 16, "Begin on hands and knees. Lower your belly and lift your head, then reverse the motion by rounding your back towards the ceiling and dropping your head. Repeat back and forth.", "Cat & Cow", "/Assets/Poses/Yoga2.JPEG", 10, null, null, 1 },
                    { 14, "Lie on your back and alternate lifting your legs to hip height. Keep your knees bent.", "Pilates March", "test", 10, null, null, 3 },
                    { 13, "Begin on hands and knees, straighten one leg onto the ball of your foot, then the other. Squeeze gluteals and press hands into the floor, keeping your trunk and pelvis in neutral. Hold for up to 1 minute.", "Plank", "test", 10, null, null, 3 },
                    { 15, "Sit with trunk straight and feet flat on the floor. Lean back slightly, holding a weight (optional). Move the weight from the left side of your body to the right side of your body back and forth.", "Trunk Twists", "test", 10, null, null, 3 },
                    { 11, "Lie on your back with knees bent and feet flat. Lift glutes off floor and keeping hips square, straighten one leg. Lower back down and repeat on the other side.", "Bridging with leg extensions", "test", 10, null, null, 3 },
                    { 2, "Pose at a partial squat bending the waist, pin your elbow at you side, straighten your arm with your weight in hand.", "Tricep Extensions", "test", 10, null, null, 3 },
                    { 3, "Begin in a plank position with hands slightly wider than shoulder width apart, keeping your core straight, bend your elbows to your sides, lowering yourself to the floor and push up.", "Push Ups", "test", 10, null, null, 3 },
                    { 12, "Begin on hands and knees, hands underneath shoulders, knees underneath hips. Lift opposite arm and leg. Hold for 3 seconds, then lower back down.", "Arm and Leg Extension on All Fours", "test", 10, null, null, 3 },
                    { 5, "Bring weight shoulders, straighten arms pressing weight over head.", "Over Head Press", "test", 10, null, null, 3 },
                    { 6, "Stand with feet slightly wider than shoulder width apart, sit back in an imaginary chair. Press feet into the ground to stand back up.", "Squat", "test", 10, null, null, 3 },
                    { 4, "On either a bed or a couch, place hands on the edge, bend your elbows, lowering yourself toward the floor in a reverse plank position. Press into your hands to return to a neutral position.", "Dips", "test", 10, null, null, 3 },
                    { 8, "Begin lying on your side with bottom knee bent and top leg straight in line with your trunk. Hold a weight on the outside of your thigh. Lift your top leg up and back, keeping your knee straight.", "Sidelying Leg lifts", "test", 10, null, null, 3 },
                    { 9, "Place the balls of your feet at the edge of a stair step. Lower your heels below the plane of the step, then push into the balls of your feet to rise back up.", "Calf Raises", "test", 10, null, null, 3 },
                    { 10, "Stand in good posture, weight optional. Bend forward, keeping knees straight and back flat. Return to standing, keeping your knees straight.", "Good Mornings", "test", 10, null, null, 3 },
                    { 7, "Stand in good posture. Step forward and bend both knees to 90 degrees, keeping trunk upright.", "Lunges", "test", 10, null, null, 3 }
                });

            migrationBuilder.InsertData(
                table: "RoutineNames",
                columns: new[] { "RoutineNameId", "NameOfRoutine" },
                values: new object[,]
                {
                    { 6, "Yoga" },
                    { 1, "Upper Body Workout" },
                    { 2, "Lower Body Workout" },
                    { 3, "Glutes" },
                    { 4, "Abs" },
                    { 5, "Stretching" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "test" });

            migrationBuilder.InsertData(
                table: "Routines",
                columns: new[] { "ExerciseId", "RoutineNameId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 19, 6 },
                    { 18, 6 },
                    { 17, 6 },
                    { 16, 6 },
                    { 23, 5 },
                    { 22, 5 },
                    { 19, 5 },
                    { 17, 5 },
                    { 21, 4 },
                    { 15, 4 },
                    { 14, 4 },
                    { 13, 4 },
                    { 12, 4 },
                    { 11, 4 },
                    { 12, 3 },
                    { 11, 3 },
                    { 10, 3 },
                    { 8, 3 },
                    { 10, 2 },
                    { 9, 2 },
                    { 8, 2 },
                    { 7, 2 },
                    { 6, 2 },
                    { 5, 1 },
                    { 4, 1 },
                    { 3, 1 },
                    { 2, 1 },
                    { 20, 6 },
                    { 21, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_RoutineExerciseId_RoutineNameId",
                table: "Exercises",
                columns: new[] { "RoutineExerciseId", "RoutineNameId" });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_UserId",
                table: "Ratings",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Routines_RoutineNameId",
                table: "Routines",
                column: "RoutineNameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Routines");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "RoutineNames");
        }
    }
}
