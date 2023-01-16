using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace warehouseManagement.Migrations
{
    /// <inheritdoc />
    public partial class TestDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Suppliers_SupplierId",
                table: "Inventory");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Suppliers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "StockLevels",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Shipments",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ShipmentItem",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Receivings",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ReceivingItem",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "OrderItem",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Locations",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "SupplierId",
                table: "Inventory",
                newName: "SupplierID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Inventory",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_SupplierId",
                table: "Inventory",
                newName: "IX_Inventory_SupplierID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Suppliers_SupplierID",
                table: "Inventory",
                column: "SupplierID",
                principalTable: "Suppliers",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Inventory_Suppliers_SupplierID",
                table: "Inventory");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Suppliers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "StockLevels",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Shipments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ShipmentItem",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Receivings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ReceivingItem",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "OrderItem",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Locations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SupplierID",
                table: "Inventory",
                newName: "SupplierId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Inventory",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Inventory_SupplierID",
                table: "Inventory",
                newName: "IX_Inventory_SupplierId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customers",
                newName: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Inventory_Suppliers_SupplierId",
                table: "Inventory",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");
        }
    }
}
