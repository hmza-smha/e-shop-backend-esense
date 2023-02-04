using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_shop_backend_esense.Migrations
{
    public partial class update_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 50m, 6767m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 8951m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 8825m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 9024m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 500m, 8507m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 9748m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 8766m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { true, 500m, 7431m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 50m, 6871m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 8044m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { true, true, 500m, 6910m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 500m, 8970m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 500m, 6970m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 500m, 9605m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 6067m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 5901m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 50m, 5941m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, 500m, 7422m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 8972m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 9241m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 6206m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 5524m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { 500m, 6293m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 500m, 9179m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { true, true, 50m, 6307m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 8411m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 5468m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 8582m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 5533m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 7779m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 6508m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 5438m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 50m, 6349m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 500m, 7247m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { true, true, 500m, 5276m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { true, 500m, 9036m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 6720m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { true, false, 500m, 5724m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 500m, 5619m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 500m, 7867m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 50m, 7780m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 500m, 5791m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { true, false, 500m, 9006m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 6148m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 5209m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 9197m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 500m, 8436m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 5388m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 50m, 8960m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 5963m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 8398m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 9987m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 500m, 9616m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 9012m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 7074m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 7527m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 50m, 9669m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 7447m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 5156m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 6801m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 500m, 7262m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 8239m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 8568m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { 500m, 9946m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 50m, 6588m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 6429m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 9790m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 8361m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 500m, 6398m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 8992m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 6374m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 8048m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 50m, 6256m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 5327m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 5819m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 7329m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, 500m, 7473m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { 500m, 8714m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 500m, 9814m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 7870m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 500m, 7099m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 9888m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 200m, 9912m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 250m, 8816m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 400m, 5102m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 100m, 9666m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 1500m, 5626m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 1000m, 9859m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 500m, 8898m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { 500m, 6192m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, 200m, 9846m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 250m, 8124m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 400m, 6899m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 100m, 7959m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 1500m, 7429m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 1000m, 5560m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 9641m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, 500m, 9536m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 200m, 8893m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 250m, 5338m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 400m, 9155m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 100m, 9546m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 1500m, 6135m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { 1000m, 8544m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 500m, 5764m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 9461m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 200m, 6265m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 250m, 5762m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 400m, 9293m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, 100m, 7884m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 1500m, 7324m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { 1000m, 8010m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 9549m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { true, 500m, 9704m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, false, 200m, 7397m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 250m, 8400m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, 400m, 9826m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, true, 100m, 8110m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, 1500m, 9798m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { 1000m, 9271m, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 5353m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 7486m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 8773m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 5041m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 6876m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 7779m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 6925m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { false, -500m, 5456m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 7685m, 4 });

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
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { false, false, -500m, 6353m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 7822m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 5232m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 7247m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 6079m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 8227m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 6127m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, -500m, 5018m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 5501m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 8284m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
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
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { -500m, 5621m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 6680m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { false, false, -500m, 5570m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 5374m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 5056m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 9958m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 5995m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 7186m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 9985m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 8529m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 6997m, 2 });

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
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { false, false, -500m, 7677m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Available", "OldPrice", "Price" },
                values: new object[] { false, -500m, 6758m });

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
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { false, true, -500m, 6839m });

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
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 5798m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 5558m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price" },
                values: new object[] { false, true, -500m, 5324m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 7442m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 8109m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 6397m, 1 });

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
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 9594m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 8848m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 9202m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 6582m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 9993m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 7316m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 8100m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 6192m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 6114m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 8635m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 7027m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 9978m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 6697m, 4 });

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
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 7875m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { -500m, 7385m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 5945m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 6025m, 3 });

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
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
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
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 8646m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 8822m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 7535m, 1 });

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
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 7782m, 1 });

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
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, -500m, 7546m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { -500m, 6041m });

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
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 8697m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 9688m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 6737m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 9827m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 7340m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 5870m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 7486m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 5840m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 8079m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 7137m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { -500m, 7200m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, -500m, 9056m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 6927m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 9679m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 9908m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 9520m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 7526m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 9964m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { true, -500m, 8957m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 5195m, 5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 5162m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 6174m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 6879m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 6516m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { -500m, 6768m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 5040m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 9132m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 5340m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 7402m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 5052m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { true, -500m, 5284m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 9125m, 3 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "OldPrice", "Price" },
                values: new object[] { -500m, 8844m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 9580m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "Available", "OldPrice", "Price", "Rate" },
                values: new object[] { false, -500m, 7090m, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, true, -500m, 9479m, 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 7075m, 4 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, -500m, 6608m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "Available", "InStuck", "OldPrice", "Price", "Rate" },
                values: new object[] { false, false, -500m, 8328m, 2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "InStuck", "OldPrice", "Price" },
                values: new object[] { false, -500m, 7302m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "OldPrice", "Price", "Rate" },
                values: new object[] { -500m, 6963m, 4 });
        }
    }
}
