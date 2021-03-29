using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blog.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "Content", "CreateDate", "Title" },
                values: new object[] { new Guid("4f141ebc-2961-44b4-99ab-30a95fc63117"), "Matrix is a rectangular two-dimensional array of numbers arranged in rows and columns. A matrix with m rows and n columns can be called an m × n matrix. Individual entries in the matrix are called elements and can be represented by a[i,j] which suggests that the element a is present in the ith row and jth column.", new DateTime(2021, 3, 28, 0, 0, 0, 0, DateTimeKind.Local), "What is 2D Array(Matrix)?" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: new Guid("4f141ebc-2961-44b4-99ab-30a95fc63117"));
        }
    }
}
