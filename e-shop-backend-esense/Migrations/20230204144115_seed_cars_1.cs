using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop_backend_esense.Migrations
{
    public partial class seed_cars_1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { true, 5353m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 7486m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 8773m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, -500m, 5041m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, -500m, 6876m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 7779m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, -500m, 6925m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 5456m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 7685m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 6530m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 6353m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 7822m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 5232m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 7247m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, -500m, 6079m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 8227m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 6127m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 5018m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 5501m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 8284m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 6642m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 6262m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 5621m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 6680m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 5570m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 5374m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { false, -500m, 5056m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 9958m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { false, -500m, 5995m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 7186m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 9985m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 8529m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 6997m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 9847m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 7677m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 6758m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 9301m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 6839m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 8004m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 5566m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { false, 5798m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 5558m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 5324m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 7442m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 8109m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 6397m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 5067m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 9594m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "Price",
                value: 8848m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { false, -500m, 9202m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { false, -500m, 6582m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 9993m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { false, -500m, 7316m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 8100m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 6192m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { false, -500m, 6114m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 8635m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 7027m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 9978m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 6697m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 8704m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 7474m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 7875m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 7385m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 5945m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 6025m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 8361m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 9084m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 8594m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 5021m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 8646m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 8822m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 7535m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 7450m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 7782m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 5440m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 7546m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 6041m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 7901m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 8697m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 9688m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 6737m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { true, 9827m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 7340m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 5870m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "Price",
                value: 7486m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 5840m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 8079m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 7137m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 7200m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 9056m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { false, 6927m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 9679m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 9908m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 9520m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "Price",
                value: 7526m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 9964m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 8957m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 5195m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 5162m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 6174m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 6879m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 6516m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 6768m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 5040m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { true, 9132m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 5340m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 7402m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 5052m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "Price",
                value: 5284m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { false, 9125m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { false, 8844m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { true, 9580m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 7090m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { true, 9479m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { false, 7075m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 6608m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "Price",
                value: 8328m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "Price",
                value: 7302m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 6963m, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 6770m, 8119m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 6770m, 8466m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, 6770m, 5037m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, 6770m, 7640m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 6770m, 8527m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, 6770m, 9314m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 6770m, 8715m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 6325m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 5825m, 5638m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 5825m, 7634m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 5825m, 9735m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 5825m, 8938m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 5825m, 6821m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, 5825m, 7739m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 5825m, 8421m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 9495m, 5 });

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
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8995m, 5310m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8995m, 9865m, 4 });

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
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8995m, 9572m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 8995m, 7491m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8995m, 6399m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 9233m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8733m, 6806m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { true, 8733m, 9808m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8733m, 6524m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { true, 8733m, 8818m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8733m, 7629m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8733m, 5099m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8733m, 7896m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 8931m, 5 });

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
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 8431m, 7269m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 8431m, 9048m, 1 });

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
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8431m, 6779m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8431m, 6582m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8431m, 8628m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { true, 8099m });

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
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 7599m, 7409m, 0 });

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
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 7599m, 8830m, 5 });

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
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 7599m, 5378m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 7599m, 9720m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                column: "Price",
                value: 8633m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { true, 8133m, 6099m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { true, 8133m, 9992m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 8133m, 7962m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { true, 8133m, 9183m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 8133m, 5447m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8133m, 5702m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { true, 8133m, 6797m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 8715m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8215m, 8631m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 8215m, 7281m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8215m, 6644m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8215m, 6958m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 8215m, 6288m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8215m, 7295m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 8215m, 7958m, 3 });

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
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 6048m, 7860m, 4 });

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
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 6048m, 9602m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 6048m, 5558m, 5 });

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
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 6048m, 8092m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 6169m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 5669m, 9194m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 5669m, 7015m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 5669m, 9588m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 5669m, 9821m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 5669m, 9848m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 5669m, 6818m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 5669m, 7516m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 8899m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 9019m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { false, 6562m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 6207m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 8852m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                column: "Price",
                value: 5964m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 6010m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 6585m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 7157m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 7123m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 5599m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { true, 5838m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 8750m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 9049m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 8541m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                column: "Price",
                value: 6805m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 5460m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 9970m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 8000m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 5396m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 8594m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 7230m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { false, 9977m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 9010m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 9079m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { false, 7152m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 5953m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 5432m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 8967m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                column: "Price",
                value: 8109m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { true, 9197m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { true, 5435m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { false, 6509m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 5331m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { false, 6445m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "InStuck", "Price" },
                values: new object[] { true, 7764m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "Price", "Rate" },
                values: new object[] { 7822m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                column: "Price",
                value: 6673m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                column: "Price",
                value: 6702m);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "InStuck", "Price", "Rate" },
                values: new object[] { true, 8659m, 1 });
        }
    }
}
