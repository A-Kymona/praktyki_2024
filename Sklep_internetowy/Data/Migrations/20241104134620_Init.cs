using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Sklep_internetowy.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Skladniki",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladniki", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Zamowienia",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Czas_zamowienia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UrzytkownikId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Kwota_zamowienia = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zamowienia", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Zamowienia_AspNetUsers_UrzytkownikId",
                        column: x => x.UrzytkownikId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produkty",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ilosc = table.Column<int>(type: "int", nullable: false),
                    Id_Kategoria = table.Column<int>(type: "int", nullable: false),
                    KategoriaCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produkty", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Produkty_Kategorie_KategoriaCategoryId",
                        column: x => x.KategoriaCategoryId,
                        principalTable: "Kategorie",
                        principalColumn: "CategoryId");
                });

            migrationBuilder.CreateTable(
                name: "PrzedmiotZamowienia",
                columns: table => new
                {
                    OrderItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ID_Zamowienie = table.Column<int>(type: "int", nullable: false),
                    ZamowienieOrderID = table.Column<int>(type: "int", nullable: true),
                    ProduktId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Cena = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrzedmiotZamowienia", x => x.OrderItemID);
                    table.ForeignKey(
                        name: "FK_PrzedmiotZamowienia_Produkty_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkty",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrzedmiotZamowienia_Zamowienia_ZamowienieOrderID",
                        column: x => x.ZamowienieOrderID,
                        principalTable: "Zamowienia",
                        principalColumn: "OrderID");
                });

            migrationBuilder.CreateTable(
                name: "Skladniki_Zamowienia",
                columns: table => new
                {
                    ProduktId = table.Column<int>(type: "int", nullable: false),
                    Id_skladnik = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladniki_Zamowienia", x => new { x.ProduktId, x.Id_skladnik });
                    table.ForeignKey(
                        name: "FK_Skladniki_Zamowienia_Produkty_ProduktId",
                        column: x => x.ProduktId,
                        principalTable: "Produkty",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Skladniki_Zamowienia_Skladniki_Id_skladnik",
                        column: x => x.Id_skladnik,
                        principalTable: "Skladniki",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "CategoryId", "Nazwa" },
                values: new object[,]
                {
                    { 1, "Zakąski" },
                    { 2, "Dania główne" },
                    { 3, "Przystawiki" },
                    { 4, "Desery" },
                    { 5, "Napoje" }
                });

            migrationBuilder.InsertData(
                table: "Produkty",
                columns: new[] { "ProductId", "Cena", "Id_Kategoria", "Ilosc", "KategoriaCategoryId", "Nazwa", "Opis" },
                values: new object[,]
                {
                    { 1, 10.50m, 2, 100, null, "Taco z wołowiną", "Smaczne taco z wołowiną" },
                    { 2, 8m, 2, 120, null, "Taco z kurczakiem", "Smaczne taco z kurczakiem" },
                    { 3, 12.50m, 2, 300, null, "Taco z rybą", "Smaczne taco z rybą" }
                });

            migrationBuilder.InsertData(
                table: "Skladniki",
                columns: new[] { "IngredientId", "Nazwa" },
                values: new object[,]
                {
                    { 1, "Wołowina" },
                    { 2, "Kurczak" },
                    { 3, "Ryba" },
                    { 4, "Tortilla" },
                    { 5, "Sałata" },
                    { 6, "Pomidor" }
                });

            migrationBuilder.InsertData(
                table: "Skladniki_Zamowienia",
                columns: new[] { "Id_skladnik", "ProduktId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 },
                    { 2, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 3, 3 },
                    { 4, 3 },
                    { 5, 3 },
                    { 6, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produkty_KategoriaCategoryId",
                table: "Produkty",
                column: "KategoriaCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PrzedmiotZamowienia_ProduktId",
                table: "PrzedmiotZamowienia",
                column: "ProduktId");

            migrationBuilder.CreateIndex(
                name: "IX_PrzedmiotZamowienia_ZamowienieOrderID",
                table: "PrzedmiotZamowienia",
                column: "ZamowienieOrderID");

            migrationBuilder.CreateIndex(
                name: "IX_Skladniki_Zamowienia_Id_skladnik",
                table: "Skladniki_Zamowienia",
                column: "Id_skladnik");

            migrationBuilder.CreateIndex(
                name: "IX_Zamowienia_UrzytkownikId",
                table: "Zamowienia",
                column: "UrzytkownikId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PrzedmiotZamowienia");

            migrationBuilder.DropTable(
                name: "Skladniki_Zamowienia");

            migrationBuilder.DropTable(
                name: "Zamowienia");

            migrationBuilder.DropTable(
                name: "Produkty");

            migrationBuilder.DropTable(
                name: "Skladniki");

            migrationBuilder.DropTable(
                name: "Kategorie");
        }
    }
}
