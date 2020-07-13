using Microsoft.EntityFrameworkCore.Migrations;

namespace SnusSmartAPI.Migrations
{
    public partial class AddedTestData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "ID", "Name" },
                values: new object[] { 1, "Swedish Match" });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "ID", "PouchSize" },
                values: new object[] { 1, "Normal" });

            migrationBuilder.InsertData(
                table: "Snuff",
                columns: new[] { "ID", "BrandID", "Name", "PouchTypeID", "Price", "SizeID" },
                values: new object[] { 1, 1, "General", 1, 49, 1 });

            migrationBuilder.InsertData(
                table: "Variations",
                columns: new[] { "ID", "Variation" },
                values: new object[] { 1, "White" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sizes",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Snuff",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Variations",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
