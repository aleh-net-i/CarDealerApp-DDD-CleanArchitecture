using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DenMotors.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddCarMake : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarMakes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarMakes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CarMakes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Toyota" },
                    { 2, "Ford" },
                    { 3, "Honda" },
                    { 4, "BMW" },
                    { 5, "Mercedes-Benz" },
                    { 6, "Volkswagen" },
                    { 7, "Audi" },
                    { 8, "Chevrolet" },
                    { 9, "Nissan" },
                    { 10, "Hyundai" },
                    { 11, "Kia" },
                    { 12, "Subaru" },
                    { 13, "Mazda" },
                    { 14, "Tesla" },
                    { 15, "Volvo" },
                    { 16, "Jeep" },
                    { 17, "Land Rover" },
                    { 18, "Porsche" },
                    { 19, "Lexus" },
                    { 20, "Acura" },
                    { 21, "Infiniti" }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarMakes");
        }
    }
}
