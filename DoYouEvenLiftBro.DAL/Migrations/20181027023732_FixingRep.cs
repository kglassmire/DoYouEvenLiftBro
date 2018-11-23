using Microsoft.EntityFrameworkCore.Migrations;

namespace DoYouEvenLiftBro.DAL.Migrations
{
    public partial class FixingRep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_reps_rep_types_type_id",
                table: "reps");

            migrationBuilder.RenameColumn(
                name: "type_id",
                table: "reps",
                newName: "rep_type_id");

            migrationBuilder.RenameIndex(
                name: "ix_reps_type_id",
                table: "reps",
                newName: "ix_reps_rep_type_id");

            migrationBuilder.AddForeignKey(
                name: "fk_reps_rep_types_rep_type_id",
                table: "reps",
                column: "rep_type_id",
                principalTable: "rep_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_reps_rep_types_rep_type_id",
                table: "reps");

            migrationBuilder.RenameColumn(
                name: "rep_type_id",
                table: "reps",
                newName: "type_id");

            migrationBuilder.RenameIndex(
                name: "ix_reps_rep_type_id",
                table: "reps",
                newName: "ix_reps_type_id");

            migrationBuilder.AddForeignKey(
                name: "fk_reps_rep_types_type_id",
                table: "reps",
                column: "type_id",
                principalTable: "rep_types",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
