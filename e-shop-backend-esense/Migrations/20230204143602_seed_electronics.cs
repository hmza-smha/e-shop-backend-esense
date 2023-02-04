using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop_backend_esense.Migrations
{
    public partial class seed_electronics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { false, 7270m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { false, true, 6770m, 8119m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 6770m, 8466m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, 6770m, 5037m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 6770m, 7640m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 6770m, 8527m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, 6770m, 9314m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, 6770m, 8715m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 6325m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 5825m, 5638m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 5825m, 7634m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, 5825m, 9735m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, 5825m, 8938m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, 5825m, 6821m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, 5825m, 7739m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 5825m, 8421m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 9495m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 8995m, 9047m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { true, true, 8995m, 5310m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8995m, 9865m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8995m, 6766m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 8995m, 9572m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8995m, 7491m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8995m, 6399m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 9233m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8733m, 6806m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8733m, 9808m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8733m, 6524m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, 8733m, 8818m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 8733m, 7629m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { 8733m, 5099m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 8733m, 7896m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 8931m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 8431m, 9830m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8431m, 7269m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8431m, 9048m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8431m, 7381m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8431m, 6779m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8431m, 6582m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8431m, 8628m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 8099m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 7599m, 8400m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { true, 7599m, 7409m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 7599m, 6395m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 7599m, 8830m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 7599m, 8165m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 7599m, 5378m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 7599m, 9720m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 8633m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8133m, 6099m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8133m, 9992m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8133m, 7962m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, 8133m, 9183m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8133m, 5447m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 8133m, 5702m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8133m, 6797m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "Price",
                value: 8715m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, 8215m, 8631m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8215m, 7281m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, 8215m, 6644m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8215m, 6958m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8215m, 6288m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 8215m, 7295m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 8215m, 7958m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 6548m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 6048m, 6971m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 6048m, 7860m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 6048m, 8768m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 6048m, 9602m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 6048m, 5558m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 6048m, 8507m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 6048m, 8092m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 6169m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 5669m, 9194m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 5669m, 7015m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 5669m, 9588m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 5669m, 9821m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 5669m, 9848m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, 5669m, 6818m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { 5669m, 7516m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdditionalInfo", "Available", "CategoryId", "Description", "ImageURL", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[,]
                {
                    { 91, "{}", false, 15, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "laptops 0", -500m, 8899m, 3 },
                    { 92, "{}", false, 16, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "pc 0", -500m, 9019m, 0 },
                    { 93, "{}", false, 17, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "monitors 0", -500m, 6562m, 5 },
                    { 94, "{}", false, 29, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "dell 0", -500m, 6207m, 3 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AdditionalInfo", "Available", "CategoryId", "Description", "ImageURL", "InStuck", "Name", "OldPrice", "Price", "Rate" },
                values: new object[,]
                {
                    { 95, "{}", false, 27, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "hp 0", -500m, 8852m, 3 },
                    { 96, "{}", false, 28, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "maybach 0", -500m, 5964m, 1 },
                    { 97, "{}", false, 30, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "benz 0", -500m, 6010m, 4 },
                    { 98, "{}", false, 31, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "samsung 0", -500m, 6585m, 5 },
                    { 99, "{}", false, 15, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "laptops 1", -500m, 7157m, 3 },
                    { 100, "{}", false, 16, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "pc 1", -500m, 7123m, 0 },
                    { 101, "{}", false, 17, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "monitors 1", -500m, 5599m, 0 },
                    { 102, "{}", false, 29, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "dell 1", -500m, 5838m, 5 },
                    { 103, "{}", false, 27, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "hp 1", -500m, 8750m, 1 },
                    { 104, "{}", false, 28, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "maybach 1", -500m, 9049m, 4 },
                    { 105, "{}", false, 30, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "benz 1", -500m, 8541m, 2 },
                    { 106, "{}", false, 31, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "samsung 1", -500m, 6805m, 0 },
                    { 107, "{}", false, 15, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "laptops 2", -500m, 5460m, 2 },
                    { 108, "{}", false, 16, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "pc 2", -500m, 9970m, 3 },
                    { 109, "{}", false, 17, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "monitors 2", -500m, 8000m, 3 },
                    { 110, "{}", false, 29, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "dell 2", -500m, 5396m, 1 },
                    { 111, "{}", false, 27, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "hp 2", -500m, 8594m, 3 },
                    { 112, "{}", false, 28, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "maybach 2", -500m, 7230m, 2 },
                    { 113, "{}", false, 30, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "benz 2", -500m, 9977m, 5 },
                    { 114, "{}", false, 31, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "samsung 2", -500m, 9010m, 1 },
                    { 115, "{}", false, 15, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "laptops 3", -500m, 9079m, 3 },
                    { 116, "{}", false, 16, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "pc 3", -500m, 7152m, 0 },
                    { 117, "{}", false, 17, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "monitors 3", -500m, 5953m, 4 },
                    { 118, "{}", false, 29, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "dell 3", -500m, 5432m, 5 },
                    { 119, "{}", false, 27, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "hp 3", -500m, 8967m, 5 },
                    { 120, "{}", false, 28, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "maybach 3", -500m, 8109m, 3 },
                    { 121, "{}", false, 30, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "benz 3", -500m, 9197m, 3 },
                    { 122, "{}", false, 31, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "samsung 3", -500m, 5435m, 4 },
                    { 123, "{}", false, 15, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "laptops 4", -500m, 6509m, 4 },
                    { 124, "{}", false, 16, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "pc 4", -500m, 5331m, 1 },
                    { 125, "{}", false, 17, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "monitors 4", -500m, 6445m, 1 },
                    { 126, "{}", false, 29, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "dell 4", -500m, 7764m, 4 },
                    { 127, "{}", false, 27, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "hp 4", -500m, 7822m, 5 },
                    { 128, "{}", false, 28, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "maybach 4", -500m, 6673m, 2 },
                    { 129, "{}", false, 30, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", false, "benz 4", -500m, 6702m, 4 },
                    { 130, "{}", false, 31, "Lorem ipsum dolor ut sit ame dolore adipiscing elit, sed nonumy nibh sed euismod laoreet dolore magna aliquarm erat volutpat Nostrud duis molestie at dolore.", "https://via.placeholder.com/600x800", true, "samsung 4", -500m, 8659m, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { true, 9030m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { true, false, 8530m, 7349m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8530m, 9717m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8530m, 5357m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8530m, 8885m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8530m, 9655m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 8530m, 7271m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8530m, 7951m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 5308m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 4808m, 9742m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 4808m, 9918m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 4808m, 8967m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 4808m, 7029m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 4808m, 8762m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 4808m, 5009m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 4808m, 8968m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 7514m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, 7014m, 9214m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { false, false, 7014m, 9028m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, 7014m, 9760m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 7014m, 5079m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, 7014m, 7698m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 7014m, 8909m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, 7014m, 7209m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "Price",
                value: 5262m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 4762m, 7007m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 4762m, 7484m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 4762m, 6096m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, 4762m, 9959m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 4762m, 9445m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { 4762m, 6859m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 4762m, 5889m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 7439m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, 6939m, 5434m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 6939m, 5552m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 6939m, 6014m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 6939m, 8257m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 6939m, 6358m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 6939m, 8064m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 6939m, 7175m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 9175m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8675m, 7032m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { false, 8675m, 9167m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8675m, 6081m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, 8675m, 8694m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8675m, 6376m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8675m, 8845m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, 8675m, 7504m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 9339m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8839m, 6648m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8839m, 7512m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8839m, 9172m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, 8839m, 7349m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 8839m, 6236m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 8839m, 6284m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8839m, 6055m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                column: "Price",
                value: 9789m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, 9289m, 6494m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 9289m, 5739m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, 9289m, 7077m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 9289m, 5178m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 9289m, 9912m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 9289m, 8115m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 9289m, 8190m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 6171m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 5671m, 6750m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, 5671m, 9182m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 5671m, 7223m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 5671m, 8586m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, 5671m, 8096m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, 5671m, 5156m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, 5671m, 9977m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 7991m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 7491m, 5993m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 7491m, 5857m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 7491m, 5929m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 7491m, 6485m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 7491m, 5417m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, 7491m, 5904m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { 7491m, 9437m });
        }
    }
}
