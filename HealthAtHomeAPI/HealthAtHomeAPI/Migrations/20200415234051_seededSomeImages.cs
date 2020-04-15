using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAtHomeAPI.Migrations
{
    public partial class seededSomeImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16,
                column: "Image",
                value: "./Assets/Yoga2.jpg");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17,
                column: "Image",
                value: "./Assets/Yoga3.jpg");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18,
                column: "Image",
                value: "./Assets/Yoga6.jpg");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 19,
                column: "Image",
                value: "./Assets/Yoga5.jpg");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20,
                column: "Image",
                value: "./Assets/Yoga7.jpg");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21,
                column: "Image",
                value: "./Assets/Yoga4.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16,
                column: "Image",
                value: "test");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17,
                column: "Image",
                value: "test");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18,
                column: "Image",
                value: "test");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 19,
                column: "Image",
                value: "test");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20,
                column: "Image",
                value: "test");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21,
                column: "Image",
                value: "test");
        }
    }
}
