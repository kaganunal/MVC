using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCCategoriesandProductsSQL.Migrations
{
    public partial class migv2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PicturePath",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PicturePath",
                table: "Products");
        }
    }
}
