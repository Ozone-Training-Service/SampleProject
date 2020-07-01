using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleProject.Migrations
{
    public partial class Ab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Message = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Registers",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Birth_date = table.Column<string>(nullable: true),
                    Course = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registers", x => x.StudentId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Registers");
        }
    }
}
