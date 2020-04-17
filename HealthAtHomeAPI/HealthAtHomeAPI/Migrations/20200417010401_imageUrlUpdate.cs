using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAtHomeAPI.Migrations
{
    public partial class imageUrlUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 1,
                columns: new[] { "ExerciseName", "Image" },
                values: new object[] { "Bicep Curl", "/Assets/Poses/Curl.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 1,
                columns: new[] { "ExerciseName", "Image" },
                values: new object[] { "Bicep Curls", "/Assets/Poses/Curls.jpg" });
        }
    }
}
