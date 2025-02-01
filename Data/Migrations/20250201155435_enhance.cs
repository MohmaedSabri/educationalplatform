using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class enhance : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("0737dc88-4f26-4f63-a97c-43861a4e1663"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a080ec18-cb7e-4ca5-ac27-2ace4bdeecf3"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c5bbf96a-91a3-4400-9e5c-0d9e55c32fb1"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 17, 54, 34, 640, DateTimeKind.Local).AddTicks(2420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 13, 52, 59, 908, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.AddColumn<int>(
                name: "Year",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("43bd31f2-c6ac-45f1-b146-e77bb78bd5a9"), null, "Teacher", "TEACHER" },
                    { new Guid("7289b0aa-3d55-4434-b784-43ea8864311d"), null, "Assistant", "ASSISTANT" },
                    { new Guid("a4bd7781-7bb6-4c83-9484-6b43a86ee009"), null, "Student", "STUDENT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("43bd31f2-c6ac-45f1-b146-e77bb78bd5a9"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("7289b0aa-3d55-4434-b784-43ea8864311d"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a4bd7781-7bb6-4c83-9484-6b43a86ee009"));

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Courses");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Lessons",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2025, 2, 1, 13, 52, 59, 908, DateTimeKind.Local).AddTicks(5305),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2025, 2, 1, 17, 54, 34, 640, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0737dc88-4f26-4f63-a97c-43861a4e1663"), null, "Teacher", "TEACHER" },
                    { new Guid("a080ec18-cb7e-4ca5-ac27-2ace4bdeecf3"), null, "Assistant", "ASSISTANT" },
                    { new Guid("c5bbf96a-91a3-4400-9e5c-0d9e55c32fb1"), null, "Student", "STUDENT" }
                });
        }
    }
}
