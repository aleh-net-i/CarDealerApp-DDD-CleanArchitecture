using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DenMotors.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddCarModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarModels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CarMakeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarModels_CarMakes_CarMakeId",
                        column: x => x.CarMakeId,
                        principalTable: "CarMakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarModels_CarMakeId",
                table: "CarModels",
                column: "CarMakeId");

            // Seed popular car models for each make
            migrationBuilder.InsertData(
                table: "CarModels",
                columns: new[] { "Id", "Name", "CarMakeId" },
                values: new object[,]
                {
                    { 1, "Corolla", 1 },
                    { 2, "Camry", 1 },
                    { 3, "RAV4", 1 },
                    { 4, "F-150", 2 },
                    { 5, "Mustang", 2 },
                    { 6, "Civic", 3 },
                    { 7, "Accord", 3 },
                    { 8, "CR-V", 3 },
                    { 9, "3 Series", 4 },
                    { 10, "X5", 4 },
                    { 11, "C-Class", 5 },
                    { 12, "E-Class", 5 },
                    { 13, "Golf", 6 },
                    { 14, "Passat", 6 },
                    { 15, "A4", 7 },
                    { 16, "Q5", 7 },
                    { 17, "Silverado", 8 },
                    { 18, "Malibu", 8 },
                    { 19, "Altima", 9 },
                    { 20, "Rogue", 9 },
                    { 21, "Elantra", 10 },
                    { 22, "Sonata", 10 },
                    { 23, "Sportage", 11 },
                    { 24, "Sorento", 11 },
                    { 25, "Outback", 12 },
                    { 26, "Forester", 12 },
                    { 27, "CX-5", 13 },
                    { 28, "Mazda3", 13 },
                    { 29, "Model 3", 14 },
                    { 30, "Model S", 14 },
                    { 31, "XC90", 15 },
                    { 32, "S60", 15 },
                    { 33, "Wrangler", 16 },
                    { 34, "Grand Cherokee", 16 },
                    { 35, "Range Rover", 17 },
                    { 36, "Discovery", 17 },
                    { 37, "911", 18 },
                    { 38, "Cayenne", 18 },
                    { 39, "RX", 19 },
                    { 40, "ES", 19 },
                    { 41, "MDX", 20 },
                    { 42, "RDX", 20 },
                    { 43, "Q50", 21 },
                    { 44, "QX60", 21 }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarModels");
        }
    }
}
