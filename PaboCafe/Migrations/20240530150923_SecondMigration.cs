using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PaboCafe.Migrations
{
    /// <inheritdoc />
    public partial class SecondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "102bfa86-ef8a-4ab3-870f-f4e6dc49fbbd", null, "admin", "admin" },
                    { "10a74b06-73ac-4d69-b1cf-38cfd251b669", null, "client", "client" },
                    { "488b46d6-77dd-4f9c-8113-2907681846ad", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "102bfa86-ef8a-4ab3-870f-f4e6dc49fbbd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10a74b06-73ac-4d69-b1cf-38cfd251b669");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "488b46d6-77dd-4f9c-8113-2907681846ad");
        }
    }
}
