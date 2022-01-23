using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class changesinuserandtickettable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tickeId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<int>(
                name: "assignUserId",
                table: "tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "developerId",
                table: "tickets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tickets_developerId",
                table: "tickets",
                column: "developerId");

            migrationBuilder.AddForeignKey(
                name: "FK_tickets_AspNetUsers_developerId",
                table: "tickets",
                column: "developerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tickets_AspNetUsers_developerId",
                table: "tickets");

            migrationBuilder.DropIndex(
                name: "IX_tickets_developerId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "assignUserId",
                table: "tickets");

            migrationBuilder.DropColumn(
                name: "developerId",
                table: "tickets");

            migrationBuilder.AddColumn<int>(
                name: "tickeId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }
    }
}
