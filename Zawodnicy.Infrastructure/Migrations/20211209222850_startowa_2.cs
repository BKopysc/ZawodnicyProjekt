using Microsoft.EntityFrameworkCore.Migrations;

namespace Zawodnicy.Infrastructure.Migrations
{
    public partial class startowa_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkiJumper_Coach_CouchId",
                table: "SkiJumper");

            migrationBuilder.RenameColumn(
                name: "CouchId",
                table: "SkiJumper",
                newName: "CoachId");

            migrationBuilder.RenameIndex(
                name: "IX_SkiJumper_CouchId",
                table: "SkiJumper",
                newName: "IX_SkiJumper_CoachId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkiJumper_Coach_CoachId",
                table: "SkiJumper",
                column: "CoachId",
                principalTable: "Coach",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SkiJumper_Coach_CoachId",
                table: "SkiJumper");

            migrationBuilder.RenameColumn(
                name: "CoachId",
                table: "SkiJumper",
                newName: "CouchId");

            migrationBuilder.RenameIndex(
                name: "IX_SkiJumper_CoachId",
                table: "SkiJumper",
                newName: "IX_SkiJumper_CouchId");

            migrationBuilder.AddForeignKey(
                name: "FK_SkiJumper_Coach_CouchId",
                table: "SkiJumper",
                column: "CouchId",
                principalTable: "Coach",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
