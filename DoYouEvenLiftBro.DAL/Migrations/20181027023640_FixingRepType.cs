using Microsoft.EntityFrameworkCore.Migrations;

namespace DoYouEvenLiftBro.DAL.Migrations
{
    public partial class FixingRepType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "user",
                table: "rep_types");

            migrationBuilder.AddColumn<long>(
                name: "user_id",
                table: "rep_types",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_rep_types_user_id",
                table: "rep_types",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "fk_rep_types_asp_net_users_user_id",
                table: "rep_types",
                column: "user_id",
                principalTable: "asp_net_users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_rep_types_asp_net_users_user_id",
                table: "rep_types");

            migrationBuilder.DropIndex(
                name: "ix_rep_types_user_id",
                table: "rep_types");

            migrationBuilder.DropColumn(
                name: "user_id",
                table: "rep_types");

            migrationBuilder.AddColumn<string>(
                name: "user",
                table: "rep_types",
                nullable: true);
        }
    }
}
