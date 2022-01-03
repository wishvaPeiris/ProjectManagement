using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class changesInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "companyId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "projectId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "userContactNo",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_companyId",
                table: "AspNetUsers",
                column: "companyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_companies_companyId",
                table: "AspNetUsers",
                column: "companyId",
                principalTable: "companies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_companies_companyId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_companyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "companyId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "projectId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "userAddress",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "userContactNo",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userContactNo = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    userEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    companyId = table.Column<int>(type: "int", nullable: true),
                    projectId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_users_companies_companyId",
                        column: x => x.companyId,
                        principalTable: "companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_projects_projectId",
                        column: x => x.projectId,
                        principalTable: "projects",
                        principalColumn: "projectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_users_companyId",
                table: "users",
                column: "companyId");

            migrationBuilder.CreateIndex(
                name: "IX_users_projectId",
                table: "users",
                column: "projectId");
        }
    }
}
