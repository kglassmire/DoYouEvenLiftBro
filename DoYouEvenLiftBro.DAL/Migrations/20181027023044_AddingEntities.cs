using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DoYouEvenLiftBro.DAL.Migrations
{
    public partial class AddingEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_exercises_asp_net_users_created_user_id",
                table: "exercises");

            migrationBuilder.DropForeignKey(
                name: "fk_muscle_groups_asp_net_users_created_user_id",
                table: "muscle_groups");

            migrationBuilder.RenameColumn(
                name: "created_user_id",
                table: "muscle_groups",
                newName: "user_id");

            migrationBuilder.RenameIndex(
                name: "ix_muscle_groups_created_user_id",
                table: "muscle_groups",
                newName: "ix_muscle_groups_user_id");

            migrationBuilder.RenameColumn(
                name: "created_user_id",
                table: "exercises",
                newName: "workout_id");

            migrationBuilder.RenameIndex(
                name: "ix_exercises_created_user_id",
                table: "exercises",
                newName: "ix_exercises_workout_id");

            migrationBuilder.AddColumn<long>(
                name: "user_id",
                table: "exercises",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "rep_types",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created = table.Column<DateTimeOffset>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    user = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_rep_types", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sets",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created = table.Column<DateTimeOffset>(nullable: false),
                    exercise_id = table.Column<long>(nullable: true),
                    user_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sets", x => x.id);
                    table.ForeignKey(
                        name: "fk_sets_exercises_exercise_id",
                        column: x => x.exercise_id,
                        principalTable: "exercises",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_sets_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "asp_net_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "workouts",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created = table.Column<DateTimeOffset>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    date = table.Column<DateTimeOffset>(nullable: false),
                    user_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_workouts", x => x.id);
                    table.ForeignKey(
                        name: "fk_workouts_asp_net_users_user_id",
                        column: x => x.user_id,
                        principalTable: "asp_net_users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "reps",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created = table.Column<DateTimeOffset>(nullable: false),
                    eccentric_duration = table.Column<int>(nullable: false),
                    concentric_duration = table.Column<int>(nullable: false),
                    type_id = table.Column<long>(nullable: true),
                    set_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_reps", x => x.id);
                    table.ForeignKey(
                        name: "fk_reps_sets_set_id",
                        column: x => x.set_id,
                        principalTable: "sets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_reps_rep_types_type_id",
                        column: x => x.type_id,
                        principalTable: "rep_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_exercises_user_id",
                table: "exercises",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_reps_set_id",
                table: "reps",
                column: "set_id");

            migrationBuilder.CreateIndex(
                name: "ix_reps_type_id",
                table: "reps",
                column: "type_id");

            migrationBuilder.CreateIndex(
                name: "ix_sets_exercise_id",
                table: "sets",
                column: "exercise_id");

            migrationBuilder.CreateIndex(
                name: "ix_sets_user_id",
                table: "sets",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_workouts_user_id",
                table: "workouts",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_exercises_asp_net_users_user_id",
                table: "exercises",
                column: "user_id",
                principalTable: "asp_net_users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_exercises_workouts_workout_id",
                table: "exercises",
                column: "workout_id",
                principalTable: "workouts",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_muscle_groups_asp_net_users_user_id",
                table: "muscle_groups",
                column: "user_id",
                principalTable: "asp_net_users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_exercises_asp_net_users_user_id",
                table: "exercises");

            migrationBuilder.DropForeignKey(
                name: "fk_exercises_workouts_workout_id",
                table: "exercises");

            migrationBuilder.DropForeignKey(
                name: "fk_muscle_groups_asp_net_users_user_id",
                table: "muscle_groups");

            migrationBuilder.DropTable(
                name: "reps");

            migrationBuilder.DropTable(
                name: "workouts");

            migrationBuilder.DropTable(
                name: "sets");

            migrationBuilder.DropTable(
                name: "rep_types");

            migrationBuilder.DropIndex(
                name: "ix_exercises_user_id",
                table: "exercises");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "exercises");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "muscle_groups",
                newName: "created_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_muscle_groups_user_id",
                table: "muscle_groups",
                newName: "ix_muscle_groups_created_user_id");

            migrationBuilder.RenameColumn(
                name: "workout_id",
                table: "exercises",
                newName: "created_user_id");

            migrationBuilder.RenameIndex(
                name: "ix_exercises_workout_id",
                table: "exercises",
                newName: "ix_exercises_created_user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_exercises_asp_net_users_created_user_id",
                table: "exercises",
                column: "created_user_id",
                principalTable: "asp_net_users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_muscle_groups_asp_net_users_created_user_id",
                table: "muscle_groups",
                column: "created_user_id",
                principalTable: "asp_net_users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
