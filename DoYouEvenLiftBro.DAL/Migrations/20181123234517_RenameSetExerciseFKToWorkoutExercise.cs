using Microsoft.EntityFrameworkCore.Migrations;

namespace DoYouEvenLiftBro.DAL.Migrations
{
    public partial class RenameSetExerciseFKToWorkoutExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sets_workout_exercises_exercise_id",
                table: "sets");

            migrationBuilder.RenameColumn(
                name: "exercise_id",
                table: "sets",
                newName: "workout_exercise_id");

            migrationBuilder.RenameIndex(
                name: "ix_sets_exercise_id",
                table: "sets",
                newName: "ix_sets_workout_exercise_id");

            migrationBuilder.AddForeignKey(
                name: "fk_sets_workout_exercises_workout_exercise_id",
                table: "sets",
                column: "workout_exercise_id",
                principalTable: "workout_exercises",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sets_workout_exercises_workout_exercise_id",
                table: "sets");

            migrationBuilder.RenameColumn(
                name: "workout_exercise_id",
                table: "sets",
                newName: "exercise_id");

            migrationBuilder.RenameIndex(
                name: "ix_sets_workout_exercise_id",
                table: "sets",
                newName: "ix_sets_exercise_id");

            migrationBuilder.AddForeignKey(
                name: "fk_sets_workout_exercises_exercise_id",
                table: "sets",
                column: "exercise_id",
                principalTable: "workout_exercises",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
