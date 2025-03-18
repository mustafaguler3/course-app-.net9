using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Course.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class seedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CoverUrl", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "/images/java.png", new DateTime(2025, 3, 18, 14, 47, 36, 28, DateTimeKind.Utc).AddTicks(870), "Java", null },
                    { 2, "/images/angular.png", new DateTime(2025, 3, 18, 14, 47, 36, 28, DateTimeKind.Utc).AddTicks(870), "Angular", null },
                    { 3, "/images/csharp.png", new DateTime(2025, 3, 18, 14, 47, 36, 28, DateTimeKind.Utc).AddTicks(870), "C#", null },
                    { 4, "/images/react.png", new DateTime(2025, 3, 18, 14, 47, 36, 28, DateTimeKind.Utc).AddTicks(870), "React", null },
                    { 5, "/images/spring-boot.png", new DateTime(2025, 3, 18, 14, 47, 36, 28, DateTimeKind.Utc).AddTicks(880), "Spring Boot", null },
                    { 6, "/images/docker.png", new DateTime(2025, 3, 18, 14, 47, 36, 28, DateTimeKind.Utc).AddTicks(880), "Docker", null },
                    { 7, "/images/swift.png", new DateTime(2025, 3, 18, 14, 47, 36, 28, DateTimeKind.Utc).AddTicks(880), "Swift", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
