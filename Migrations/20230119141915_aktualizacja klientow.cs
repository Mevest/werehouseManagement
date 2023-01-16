using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace warehouseManagement.Migrations
{
    /// <inheritdoc />
    public partial class aktualizacjaklientow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Customers");
        }
    }
}
