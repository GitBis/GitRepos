using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcial2.Migrations
{
    public partial class change02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "speciality",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "user",
                table: "Reservations");

            migrationBuilder.AddColumn<int>(
                name: "specialityid",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "userid",
                table: "Reservations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_specialityid",
                table: "Reservations",
                column: "specialityid");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_userid",
                table: "Reservations",
                column: "userid");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Specialties_specialityid",
                table: "Reservations",
                column: "specialityid",
                principalTable: "Specialties",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reservations_Users_userid",
                table: "Reservations",
                column: "userid",
                principalTable: "Users",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Specialties_specialityid",
                table: "Reservations");

            migrationBuilder.DropForeignKey(
                name: "FK_Reservations_Users_userid",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_specialityid",
                table: "Reservations");

            migrationBuilder.DropIndex(
                name: "IX_Reservations_userid",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "specialityid",
                table: "Reservations");

            migrationBuilder.DropColumn(
                name: "userid",
                table: "Reservations");

            migrationBuilder.AddColumn<string>(
                name: "speciality",
                table: "Reservations",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "user",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
