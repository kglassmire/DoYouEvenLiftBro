using Microsoft.EntityFrameworkCore.Migrations;

namespace DoYouEvenLiftBro.DAL.Migrations
{
    public partial class AddCreatedUserToBaseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "created_user_id",
                table: "muscle_groups",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "created_user_id",
                table: "exercises",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_muscle_groups_created_user_id",
                table: "muscle_groups",
                column: "created_user_id");

            migrationBuilder.CreateIndex(
                name: "ix_exercises_created_user_id",
                table: "exercises",
                column: "created_user_id");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_exercises_asp_net_users_created_user_id",
                table: "exercises");

            migrationBuilder.DropForeignKey(
                name: "fk_muscle_groups_asp_net_users_created_user_id",
                table: "muscle_groups");

            migrationBuilder.DropIndex(
                name: "ix_muscle_groups_created_user_id",
                table: "muscle_groups");

            migrationBuilder.DropIndex(
                name: "ix_exercises_created_user_id",
                table: "exercises");

            migrationBuilder.DropColumn(
                name: "created_user_id",
                table: "muscle_groups");

            migrationBuilder.DropColumn(
                name: "created_user_id",
                table: "exercises");
        }
    }
}
