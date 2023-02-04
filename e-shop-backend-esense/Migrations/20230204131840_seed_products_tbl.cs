using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop_backend_esense.Migrations
{
    public partial class seed_products_tbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdditionalInfo", "Available", "CategoryId", "Description", "ImageURL", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { 1, "{}", true, 1, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "BMW", 500m, 9526m, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
