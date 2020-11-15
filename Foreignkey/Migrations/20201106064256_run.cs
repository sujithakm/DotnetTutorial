using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Foreignkey.Migrations
{
    public partial class run : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Dob = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.CreateTable(
                name: "MarkLists",
                columns: table => new
                {
                    MarkId = table.Column<string>(nullable: false),
                    StudentId = table.Column<string>(nullable: true),
                    M1 = table.Column<int>(nullable: false),
                    M2 = table.Column<int>(nullable: false),
                    M3 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkLists", x => x.MarkId);
                    table.ForeignKey(
                        name: "FK_MarkLists_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MarkLists_StudentId",
                table: "MarkLists",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MarkLists");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
