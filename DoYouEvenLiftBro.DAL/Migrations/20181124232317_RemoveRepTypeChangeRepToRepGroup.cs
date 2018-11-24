using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DoYouEvenLiftBro.DAL.Migrations
{
    public partial class RemoveRepTypeChangeRepToRepGroup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "reps");

            migrationBuilder.DropTable(
                name: "rep_types");

            migrationBuilder.CreateTable(
                name: "rep_group",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created = table.Column<DateTimeOffset>(nullable: false),
                    eccentric_duration = table.Column<int>(nullable: false),
                    concentric_duration = table.Column<int>(nullable: false),
                    count = table.Column<int>(nullable: false),
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "rep_group");

            migrationBuilder.CreateTable(
                name: "rep_types",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    created = table.Column<DateTimeOffset>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    user_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_rep_types", x => x.id);
                    table.ForeignKey(
                        name: "fk_rep_types_asp_net_users_user_id",
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
                    concentric_duration = table.Column<int>(nullable: false),
                    created = table.Column<DateTimeOffset>(nullable: false),
                    eccentric_duration = table.Column<int>(nullable: false),
                    rep_type_id = table.Column<long>(nullable: true),
                    set_id = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_reps", x => x.id);
                    table.ForeignKey(
                        name: "fk_reps_rep_types_rep_type_id",
                        column: x => x.rep_type_id,
                        principalTable: "rep_types",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_reps_sets_set_id",
                        column: x => x.set_id,
                        principalTable: "sets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_rep_types_user_id",
                table: "rep_types",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "ix_reps_rep_type_id",
                table: "reps",
                column: "rep_type_id");

            migrationBuilder.CreateIndex(
                name: "ix_reps_set_id",
                table: "reps",
                column: "set_id");
        }
    }
}
