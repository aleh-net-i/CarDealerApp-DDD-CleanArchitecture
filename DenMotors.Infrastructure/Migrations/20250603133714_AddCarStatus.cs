using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DenMotors.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddCarStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarStatuses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CarStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Purchased" },
                    { 2, "In Transit" },
                    { 3, "In Port" },
                    { 4, "Ready for VRT" },
                    { 5, "Ready For Sale" },
                    { 6, "Deposit Taken" },
                    { 7, "Sold" },
                    { 8, "On Hold" }
                }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarStatuses");
        }
    }
}
