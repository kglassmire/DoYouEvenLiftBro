using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DoYouEvenLiftBro.DAL.Migrations
{
    public partial class RemoveRepCountAddNotes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rep_group");

            migrationBuilder.AddColumn<string>(
                name: "notes",
                table: "workouts",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "notes",
                table: "sets",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "reps",
                table: "sets",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "notes",
                table: "workouts");

            migrationBuilder.DropColumn(
                name: "notes",
                table: "sets");

            migrationBuilder.DropColumn(
                name: "reps",
                table: "sets");

            migrationBuilder.CreateTable(
                name: "rep_group",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    concentric_duration = table.Column<int>(nullable: false),
                    count = table.Column<int>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false),
                    eccentric_duration = table.Column<int>(nullable: false),
                    set_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_rep_group", x => x.id);
                    table.ForeignKey(
                        name: "fk_rep_group_sets_set_id",
                        column: x => x.set_id,
                        principalTable: "sets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_rep_group_set_id",
                table: "rep_group",
                column: "set_id");
        }
    }
}
