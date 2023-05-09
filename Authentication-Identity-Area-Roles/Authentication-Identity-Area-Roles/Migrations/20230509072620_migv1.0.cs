using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Authentication_Identity_Area_Roles.Migrations
{
    public partial class migv10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
