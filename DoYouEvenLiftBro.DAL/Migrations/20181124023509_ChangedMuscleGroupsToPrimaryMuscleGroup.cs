using Microsoft.EntityFrameworkCore.Migrations;

namespace DoYouEvenLiftBro.DAL.Migrations
{
    public partial class ChangedMuscleGroupsToPrimaryMuscleGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_muscle_groups_exercises_exercise_id",
                table: "muscle_groups");

            migrationBuilder.DropIndex(
                name: "ix_muscle_groups_exercise_id",
                table: "muscle_groups");

            migrationBuilder.DropColumn(
                name: "exercise_id",
                table: "muscle_groups");

            migrationBuilder.AddColumn<long>(
                name: "primary_muscle_group_id",
                table: "exercises",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_exercises_primary_muscle_group_id",
                table: "exercises",
                column: "primary_muscle_group_id");

            migrationBuilder.AddForeignKey(
                name: "fk_exercises_muscle_groups_primary_muscle_group_id",
                table: "exercises",
                column: "primary_muscle_group_id",
                principalTable: "muscle_groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_exercises_muscle_groups_primary_muscle_group_id",
                table: "exercises");

            migrationBuilder.DropIndex(
                name: "ix_exercises_primary_muscle_group_id",
                table: "exercises");

            migrationBuilder.DropColumn(
                name: "primary_muscle_group_id",
                table: "exercises");

            migrationBuilder.AddColumn<long>(
                name: "exercise_id",
                table: "muscle_groups",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_muscle_groups_exercise_id",
                table: "muscle_groups",
                column: "exercise_id");

            migrationBuilder.AddForeignKey(
                name: "fk_muscle_groups_exercises_exercise_id",
                table: "muscle_groups",
                column: "exercise_id",
                principalTable: "exercises",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
