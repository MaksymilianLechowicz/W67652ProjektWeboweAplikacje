using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W67652MaksymilianLechowiczProjektZAplikacjiWebowych.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Cross");

            migrationBuilder.CreateTable(
                name: "Plant",
                schema: "Cross",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileNameForImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plant",
                schema: "Cross");
        }
    }
}
