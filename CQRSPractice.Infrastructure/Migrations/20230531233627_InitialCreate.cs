using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CQRSPractice.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Production = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AlcoholPercentage = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Beers",
                columns: new[] { "Id", "AlcoholPercentage", "Country", "Name", "Price", "Production" },
                values: new object[] { new Guid("28b4b937-f45e-46af-8e65-576769a79aec"), 4.5f, "Slovakia", "Chernihivske", 25m, "Svatove" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beers");
        }
    }
}
