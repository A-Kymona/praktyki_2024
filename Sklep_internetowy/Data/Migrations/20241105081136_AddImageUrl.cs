using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sklep_internetowy.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddImageUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url_zdj",
                table: "Produkty",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Produkty",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "Url_zdj",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Produkty",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "Url_zdj",
                value: "https://via.placeholder.com/150");

            migrationBuilder.UpdateData(
                table: "Produkty",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Url_zdj",
                value: "https://via.placeholder.com/150");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url_zdj",
                table: "Produkty");
        }
    }
}
