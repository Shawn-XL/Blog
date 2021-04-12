using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class RemovedDataSeedingFromContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("102fc28e-6565-4358-aa1c-46482f392880"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("94bb3b9a-6145-4a4f-833f-86c937c9df90"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("dfff1c6d-0f53-43e7-9d42-599b34adb261"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreateDate", "IsHide", "Title" },
                values: new object[] { new Guid("102fc28e-6565-4358-aa1c-46482f392880"), "Matrix is a rectangular two-dimensional array of numbers arranged in rows and columns. A matrix with m rows and n columns can be called an m × n matrix. Individual entries in the matrix are called elements and can be represented by a[i,j] which suggests that the element a is present in the ith row and jth column.", new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "What is 2D Array(Matrix)?" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreateDate", "IsHide", "Title" },
                values: new object[] { new Guid("dfff1c6d-0f53-43e7-9d42-599b34adb261"), "wo matrices X and Y can be added if and only if they have the same dimensions that are, the same number of rows and columns. It is not possible to add a 2 × 3 matrix with a 3 × 2 matrix. The addition of two matrices can be performed by adding their corresponding elements as", new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Addition of two matrices" });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreateDate", "IsHide", "Title" },
                values: new object[] { new Guid("94bb3b9a-6145-4a4f-833f-86c937c9df90"), "SOLID design principles in C# are basic design principles. SOLID stands for Single Responsibility Principle (SRP), Open closed Principle (OSP), Liskov substitution Principle (LSP), Interface Segregation Principle (ISP), and Dependency Inversion Principle (DIP). ", new DateTime(2021, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "SOLID Principles In C#" });
        }
    }
}
