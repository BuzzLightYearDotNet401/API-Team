using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAtHomeAPI.Migrations
{
    public partial class updatedImageFilepaths : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 16,
                column: "Image",
                value: "./assets/Yoga2.JPEG");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 17,
                column: "Image",
                value: "./assets/Yoga3.JPEG");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 18,
                column: "Image",
                value: "./assets/Yoga6.JPEG");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 19,
                column: "Image",
                value: "./assets/Yoga5.JPEG");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 20,
                column: "Image",
                value: "./assets/Yoga7.JPEG");

            migrationBuilder.UpdateData(
                table: "Exercises",
                keyColumn: "ExerciseId",
                keyValue: 21,
                column: "Image",
                value: "./assets/Yoga4.JPEG");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
