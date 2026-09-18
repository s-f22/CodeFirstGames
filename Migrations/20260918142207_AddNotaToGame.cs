using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstGames.Migrations
{
    /// <inheritdoc />
    public partial class AddNotaToGame : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Nota",
                table: "Games",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nota",
                table: "Games");
        }
    }
}
