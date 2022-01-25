using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class brandnew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tickeId",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<Guid>(
                name: "assignUserId",
                table: "tickets",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "assignUserId",
                table: "tickets");

            migrationBuilder.AddColumn<int>(
                name: "tickeId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);
        }
    }
}
