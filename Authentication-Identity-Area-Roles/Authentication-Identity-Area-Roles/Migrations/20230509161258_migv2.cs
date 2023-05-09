using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication_Identity_Area_Roles.Migrations
{
    public partial class migv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80077147-a1d0-42e4-8966-17d4ef3ec7e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "883864cd-3064-43a3-8013-5579a5a97866");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8dd2fe1c-be94-4882-b736-c787a3907e7f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "86ccb322-af28-4cfb-aed3-d5c597706ca3", "07dff542-e469-45b2-aa98-b485deb67ad5", "Normal Kullanıcı", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b158a9f9-a1bc-45e1-83ac-64b332645b2c", "879460c0-a9dd-4329-957e-37658ad43bbf", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e73b693c-554d-4fbe-9dba-d1b39e929b89", "88ec3566-fd50-46e1-b7ed-3f84fd06e2a1", "Editör", "EDITOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "86ccb322-af28-4cfb-aed3-d5c597706ca3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b158a9f9-a1bc-45e1-83ac-64b332645b2c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e73b693c-554d-4fbe-9dba-d1b39e929b89");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80077147-a1d0-42e4-8966-17d4ef3ec7e1", "0804cd7a-9b7b-4cb9-9153-712460ce54ec", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "883864cd-3064-43a3-8013-5579a5a97866", "b4032458-b803-4972-9fdd-834f74a8e75f", "Editör", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8dd2fe1c-be94-4882-b736-c787a3907e7f", "28d394e0-37ed-49fe-8aba-671adbbe78d3", "admin", "ADMIN" });
        }
    }
}
