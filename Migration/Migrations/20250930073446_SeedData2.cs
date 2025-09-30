using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MigrationAssignment.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Department", "Name", "Salary" },
                values: new object[] { "IT", "Amit", 60000m });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Name", "Salary" },
                values: new object[] { 3, "HR", "Priya", 45000m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Department", "Name", "Salary" },
                values: new object[] { "HR", "Priya", 45000m });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Department", "Name", "Salary" },
                values: new object[] { 1, "IT", "Amit", 60000m });
        }
    }
}
