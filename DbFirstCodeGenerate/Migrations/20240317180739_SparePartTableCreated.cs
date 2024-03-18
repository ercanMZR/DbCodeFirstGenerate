using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbFirstCodeGenerate.Migrations
{
    /// <inheritdoc />
    public partial class SparePartTableCreated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SpareParts",
                columns: table => new
                {
                    SpareID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SpareName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpareBrand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpareModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AmountOfStock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpareParts", x => x.SpareID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpareParts");
        }
    }
}
