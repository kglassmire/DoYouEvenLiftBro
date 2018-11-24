using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DoYouEvenLiftBro.DAL.Migrations
{
    public partial class ReorganizeDataModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_exercises_workouts_workout_id",
                table: "exercises");

            migrationBuilder.DropForeignKey(
                name: "fk_sets_exercises_exercise_id",
                table: "sets");

            migrationBuilder.DropForeignKey(
                name: "fk_sets_asp_net_users_user_id",
                table: "sets");

            migrationBuilder.DropIndex(
                name: "ix_sets_user_id",
                table: "sets");

            migrationBuilder.DropIndex(
                name: "ix_exercises_workout_id",
                table: "exercises");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "sets");

            migrationBuilder.DropColumn(
                name: "workout_id",
                table: "exercises");

            migrationBuilder.CreateTable(
                name: "workout_exercises",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created = table.Column<DateTimeOffset>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    exercise_id = table.Column<long>(nullable: true),
                    workout_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_workout_exercises", x => x.id);
                    table.ForeignKey(
                        name: "fk_workout_exercises_exercises_exercise_id",
                        column: x => x.exercise_id,
                        principalTable: "exercises",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_workout_exercises_workouts_workout_id",
                        column: x => x.workout_id,
                        principalTable: "workouts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercises_exercise_id",
                table: "workout_exercises",
                column: "exercise_id");

            migrationBuilder.CreateIndex(
                name: "ix_workout_exercises_workout_id",
                table: "workout_exercises",
                column: "workout_id");

            migrationBuilder.AddForeignKey(
                name: "fk_sets_workout_exercises_exercise_id",
                table: "sets",
                column: "exercise_id",
                principalTable: "workout_exercises",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_sets_workout_exercises_exercise_id",
                table: "sets");

            migrationBuilder.DropTable(
                name: "workout_exercises");

            migrationBuilder.AddColumn<long>(
                name: "user_id",
                table: "sets",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "workout_id",
                table: "exercises",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_sets_user_id",
                table: "sets",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_exercises_workout_id",
                table: "exercises",
                column: "workout_id");

            migrationBuilder.AddForeignKey(
                name: "fk_exercises_workouts_workout_id",
                table: "exercises",
                column: "workout_id",
                principalTable: "workouts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_sets_exercises_exercise_id",
                table: "sets",
                column: "exercise_id",
                principalTable: "exercises",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_sets_asp_net_users_user_id",
                table: "sets",
                column: "user_id",
                principalTable: "asp_net_users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
