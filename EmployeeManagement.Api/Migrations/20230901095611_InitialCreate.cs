using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagement.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 101, "IT" },
                    { 102, "HR" },
                    { 103, "Sales" },
                    { 104, "Marketing" },
                    { 105, "Payroll" },
                    { 106, "Business" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(1981, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, "Sam@Prag.com", "Sam", 0, "Galloway", "images/sam.jpg" },
                    { 2, new DateTime(1990, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 102, "david@ross.com", "David", 0, "Finch", "images/david.jpg" },
                    { 3, new DateTime(2000, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, "richard@b.com", "Richard", 0, "Branson", "images/riche.jpg" },
                    { 4, new DateTime(1999, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, "Folly@mike.com", "Folly", 0, "Mike", "images/folly.jpg" },
                    { 5, new DateTime(1994, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 104, "Lysander@c.com", "Lysander", 0, "Collins", "images/lysander.jpg" },
                    { 6, new DateTime(1997, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 103, "Reginald@a.com", "Reginald", 0, "Amgoth", "images/reginald.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
