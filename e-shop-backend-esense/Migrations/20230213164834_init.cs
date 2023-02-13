using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop_backend_esense.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_ParentCategoryId",
                        column: x => x.ParentCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OldPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    IsInStock = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rate = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentCategoryId" },
                values: new object[] { 1, "Cars", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentCategoryId" },
                values: new object[] { 2, "Electronics", null });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 11, "BMW", 1 },
                    { 12, "Honda", 1 },
                    { 13, "Toyouta", 1 },
                    { 14, "Mercedes", 1 },
                    { 15, "Laptops", 2 },
                    { 16, "PC", 2 },
                    { 17, "Monitors", 2 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "ParentCategoryId" },
                values: new object[,]
                {
                    { 23, "Lexus", 13 },
                    { 24, "Maybach", 14 },
                    { 25, "Benz", 14 },
                    { 26, "AMG", 14 },
                    { 27, "HP", 15 },
                    { 28, "Acer", 15 },
                    { 29, "Dell", 15 },
                    { 30, "LG", 17 },
                    { 31, "Samsung", 17 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdditionalInfo", "CategoryId", "Description", "ImageUrl", "IsAvailable", "IsInStock", "Name", "OldPrice", "Price", "Rate" },
                values: new object[,]
                {
                    { 2, "{}", 11, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "BMW 0", 50m, 228m, 5 },
                    { 3, "{}", 12, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "honda 0", 500m, 463m, 1 },
                    { 4, "{}", 13, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "toyota 0", 500m, 54m, 4 },
                    { 5, "{}", 14, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "mercedes 0", 500m, 222m, 1 },
                    { 10, "{}", 11, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "BMW 1", 50m, 463m, 2 },
                    { 11, "{}", 12, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "honda 1", 500m, 204m, 2 },
                    { 12, "{}", 13, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "toyota 1", 500m, 287m, 0 },
                    { 13, "{}", 14, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "mercedes 1", 500m, 90m, 4 },
                    { 18, "{}", 11, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "BMW 2", 50m, 378m, 1 },
                    { 19, "{}", 12, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, true, "honda 2", 500m, 178m, 0 },
                    { 20, "{}", 13, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "toyota 2", 500m, 339m, 4 },
                    { 21, "{}", 14, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, true, "mercedes 2", 500m, 444m, 3 },
                    { 91, "{}", 15, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "laptops 0", 500m, 495m, 3 },
                    { 92, "{}", 16, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "pc 0", 500m, 451m, 1 },
                    { 93, "{}", 17, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "monitors 0", 200m, 269m, 0 },
                    { 99, "{}", 15, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, true, "laptops 1", 500m, 132m, 1 },
                    { 100, "{}", 16, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, true, "pc 1", 500m, 434m, 2 },
                    { 101, "{}", 17, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, true, "monitors 1", 200m, 423m, 5 },
                    { 107, "{}", 15, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "laptops 2", 500m, 70m, 2 },
                    { 108, "{}", 16, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "pc 2", 500m, 451m, 5 },
                    { 109, "{}", 17, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "monitors 2", 200m, 69m, 5 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdditionalInfo", "CategoryId", "Description", "ImageUrl", "IsAvailable", "IsInStock", "Name", "OldPrice", "Price", "Rate" },
                values: new object[,]
                {
                    { 6, "{}", 23, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "lexus 0", 500m, 294m, 1 },
                    { 7, "{}", 24, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "maybach 0", 500m, 71m, 2 },
                    { 8, "{}", 25, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "benz 0", 500m, 121m, 3 },
                    { 9, "{}", 26, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "amg 0", 500m, 354m, 3 },
                    { 14, "{}", 23, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "lexus 1", 500m, 117m, 1 },
                    { 15, "{}", 24, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, true, "maybach 1", 500m, 405m, 1 },
                    { 16, "{}", 25, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "benz 1", 500m, 440m, 0 },
                    { 17, "{}", 26, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "amg 1", 500m, 69m, 1 },
                    { 22, "{}", 23, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "lexus 2", 500m, 76m, 5 },
                    { 23, "{}", 24, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "maybach 2", 500m, 303m, 0 },
                    { 24, "{}", 25, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "benz 2", 500m, 401m, 4 },
                    { 25, "{}", 26, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "amg 2", 500m, 290m, 1 },
                    { 94, "{}", 29, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "dell 0", 250m, 249m, 0 },
                    { 95, "{}", 27, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "hp 0", 400m, 442m, 2 },
                    { 96, "{}", 28, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "maybach 0", 100m, 199m, 1 },
                    { 97, "{}", 30, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, true, "lg 0", 1500m, 71m, 4 },
                    { 98, "{}", 31, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "samsung 0", 1000m, 497m, 5 },
                    { 102, "{}", 29, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "dell 1", 250m, 146m, 5 },
                    { 103, "{}", 27, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "hp 1", 400m, 307m, 2 },
                    { 104, "{}", 28, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, true, "maybach 1", 100m, 138m, 1 },
                    { 105, "{}", 30, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "lg 1", 1500m, 125m, 2 },
                    { 106, "{}", 31, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "samsung 1", 1000m, 71m, 0 },
                    { 110, "{}", 29, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "dell 2", 250m, 314m, 2 },
                    { 111, "{}", 27, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, false, "hp 2", 400m, 147m, 4 },
                    { 112, "{}", 28, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, false, "maybach 2", 100m, 239m, 1 },
                    { 113, "{}", 30, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, true, "lg 2", 1500m, 219m, 2 },
                    { 114, "{}", 31, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, true, "samsung 2", 1000m, 230m, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
