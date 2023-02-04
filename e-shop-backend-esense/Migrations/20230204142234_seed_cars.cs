using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop_backend_esense.Migrations
{
    public partial class seed_cars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Rate" },
                values: new object[] { "BMW 0", 9030m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Available", "CategoryId", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 12, false, "honda 0", 8530m, 7349m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price" },
                values: new object[] { true, 13, "toyota 0", 8530m, 9717m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price" },
                values: new object[] { true, 14, "mercedes 0", 8530m, 5357m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 23, "lexus 0", 8530m, 8885m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Available", "CategoryId", "InStuck", "Name", "OldPrice", "Price" },
                values: new object[] { true, 24, true, "maybach 0", 8530m, 9655m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 25, "benz 0", 8530m, 7271m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 26, "amg 0", 8530m, 7951m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InStuck", "Name", "Price", "Rate" },
                values: new object[] { true, "BMW 1", 5308m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price" },
                values: new object[] { true, 12, "honda 1", 4808m, 9742m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Available", "CategoryId", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 13, true, "toyota 1", 4808m, 9918m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 14, "mercedes 1", 4808m, 8967m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 23, "lexus 1", 4808m, 7029m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 24, "maybach 1", 4808m, 8762m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Available", "CategoryId", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 25, true, "benz 1", 4808m, 5009m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 26, "amg 1", 4808m, 8968m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "InStuck", "Name", "Price" },
                values: new object[] { false, "BMW 2", 7514m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { 12, false, "honda 2", 7014m, 9214m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { 13, "toyota 2", 7014m, 9028m, 4 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdditionalInfo", "Available", "CategoryId", "Description", "ImageURL", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[,]
                {
                    { 21, "{}", false, 14, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "mercedes 2", 7014m, 9760m, 1 },
                    { 22, "{}", false, 23, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "lexus 2", 7014m, 5079m, 4 },
                    { 23, "{}", false, 24, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "maybach 2", 7014m, 7698m, 5 },
                    { 24, "{}", false, 25, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "benz 2", 7014m, 8909m, 2 },
                    { 25, "{}", false, 26, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "amg 2", 7014m, 7209m, 0 },
                    { 26, "{}", false, 11, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "BMW 3", -500m, 5262m, 5 },
                    { 27, "{}", true, 12, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "honda 3", 4762m, 7007m, 3 },
                    { 28, "{}", true, 13, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "toyota 3", 4762m, 7484m, 1 },
                    { 29, "{}", true, 14, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "mercedes 3", 4762m, 6096m, 2 },
                    { 30, "{}", true, 23, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "lexus 3", 4762m, 9959m, 5 },
                    { 31, "{}", true, 24, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "maybach 3", 4762m, 9445m, 5 },
                    { 32, "{}", true, 25, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "benz 3", 4762m, 6859m, 5 },
                    { 33, "{}", true, 26, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "amg 3", 4762m, 5889m, 5 },
                    { 34, "{}", false, 11, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "BMW 4", -500m, 7439m, 0 },
                    { 35, "{}", false, 12, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "honda 4", 6939m, 5434m, 5 },
                    { 36, "{}", false, 13, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "toyota 4", 6939m, 5552m, 1 },
                    { 37, "{}", false, 14, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "mercedes 4", 6939m, 6014m, 3 },
                    { 38, "{}", false, 23, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "lexus 4", 6939m, 8257m, 2 },
                    { 39, "{}", false, 24, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "maybach 4", 6939m, 6358m, 1 },
                    { 40, "{}", false, 25, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "benz 4", 6939m, 8064m, 2 },
                    { 41, "{}", false, 26, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "amg 4", 6939m, 7175m, 1 },
                    { 42, "{}", false, 11, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "BMW 5", -500m, 9175m, 0 },
                    { 43, "{}", false, 12, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "honda 5", 8675m, 7032m, 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdditionalInfo", "Available", "CategoryId", "Description", "ImageURL", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[,]
                {
                    { 44, "{}", false, 13, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "toyota 5", 8675m, 9167m, 0 },
                    { 45, "{}", false, 14, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "mercedes 5", 8675m, 6081m, 3 },
                    { 46, "{}", false, 23, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "lexus 5", 8675m, 8694m, 1 },
                    { 47, "{}", false, 24, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "maybach 5", 8675m, 6376m, 2 },
                    { 48, "{}", false, 25, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "benz 5", 8675m, 8845m, 5 },
                    { 49, "{}", false, 26, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "amg 5", 8675m, 7504m, 3 },
                    { 50, "{}", false, 11, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "BMW 6", -500m, 9339m, 3 },
                    { 51, "{}", true, 12, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "honda 6", 8839m, 6648m, 1 },
                    { 52, "{}", true, 13, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "toyota 6", 8839m, 7512m, 1 },
                    { 53, "{}", true, 14, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "mercedes 6", 8839m, 9172m, 5 },
                    { 54, "{}", true, 23, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "lexus 6", 8839m, 7349m, 2 },
                    { 55, "{}", true, 24, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "maybach 6", 8839m, 6236m, 0 },
                    { 56, "{}", true, 25, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "benz 6", 8839m, 6284m, 4 },
                    { 57, "{}", true, 26, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "amg 6", 8839m, 6055m, 3 },
                    { 58, "{}", false, 11, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "BMW 7", -500m, 9789m, 4 },
                    { 59, "{}", true, 12, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "honda 7", 9289m, 6494m, 5 },
                    { 60, "{}", true, 13, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "toyota 7", 9289m, 5739m, 0 },
                    { 61, "{}", true, 14, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "mercedes 7", 9289m, 7077m, 5 },
                    { 62, "{}", true, 23, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "lexus 7", 9289m, 5178m, 3 },
                    { 63, "{}", true, 24, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "maybach 7", 9289m, 9912m, 5 },
                    { 64, "{}", true, 25, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "benz 7", 9289m, 8115m, 5 },
                    { 65, "{}", true, 26, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "amg 7", 9289m, 8190m, 0 },
                    { 66, "{}", false, 11, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "BMW 8", -500m, 6171m, 0 },
                    { 67, "{}", false, 12, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "honda 8", 5671m, 6750m, 2 },
                    { 68, "{}", false, 13, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "toyota 8", 5671m, 9182m, 5 },
                    { 69, "{}", false, 14, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "mercedes 8", 5671m, 7223m, 3 },
                    { 70, "{}", false, 23, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "lexus 8", 5671m, 8586m, 5 },
                    { 71, "{}", false, 24, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "maybach 8", 5671m, 8096m, 0 },
                    { 72, "{}", false, 25, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "benz 8", 5671m, 5156m, 4 },
                    { 73, "{}", false, 26, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "amg 8", 5671m, 9977m, 2 },
                    { 74, "{}", false, 11, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "BMW 9", -500m, 7991m, 2 },
                    { 75, "{}", true, 12, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "honda 9", 7491m, 5993m, 1 },
                    { 76, "{}", true, 13, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "toyota 9", 7491m, 5857m, 1 },
                    { 77, "{}", true, 14, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "mercedes 9", 7491m, 5929m, 5 },
                    { 78, "{}", true, 23, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "lexus 9", 7491m, 6485m, 5 },
                    { 79, "{}", true, 24, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "maybach 9", 7491m, 5417m, 3 },
                    { 80, "{}", true, 25, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "benz 9", 7491m, 5904m, 1 },
                    { 81, "{}", true, 26, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "amg 9", 7491m, 9437m, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price", "Rate" },
                values: new object[] { "BMW1", 6666m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Available", "CategoryId", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 11, true, "BMW2", -500m, 6417m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price" },
                values: new object[] { false, 11, "BMW3", -500m, 5683m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price" },
                values: new object[] { false, 11, "BMW4", -500m, 9611m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 11, "BMW5", -500m, 6974m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Available", "CategoryId", "InStuck", "Name", "OldPrice", "Price" },
                values: new object[] { false, 11, false, "BMW6", -500m, 7528m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 11, "BMW7", -500m, 5052m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 11, "BMW8", -500m, 8356m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InStuck", "Name", "Price", "Rate" },
                values: new object[] { false, "BMW9", 7580m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price" },
                values: new object[] { false, 11, "BMW10", -500m, 6905m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Available", "CategoryId", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 11, false, "BMW11", -500m, 5998m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 11, "BMW12", -500m, 5884m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 11, "BMW13", -500m, 6374m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 11, "BMW14", -500m, 7320m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Available", "CategoryId", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 11, false, "BMW15", -500m, 7252m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Available", "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 11, "BMW16", -500m, 7451m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "InStuck", "Name", "Price" },
                values: new object[] { true, "BMW17", 7559m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { 11, true, "BMW18", -500m, 6819m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { 11, "BMW19", -500m, 5339m, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdditionalInfo", "Available", "CategoryId", "Description", "ImageURL", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[] { 1, "{}", false, 11, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "BMW0", -500m, 5808m, 5 });
        }
    }
}
