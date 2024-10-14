using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_Técnica.Migrations
{
    /// <inheritdoc />
    public partial class v3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleFacturas_Facturas_FacturaId",
                table: "DetalleFacturas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetalleFacturas",
                table: "DetalleFacturas");

            migrationBuilder.RenameTable(
                name: "DetalleFacturas",
                newName: "DetallesFactura");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Facturas",
                newName: "TotalPagar");

            migrationBuilder.RenameColumn(
                name: "Cliente",
                table: "Facturas",
                newName: "Secuencial");

            migrationBuilder.RenameColumn(
                name: "BaseIVA12",
                table: "Facturas",
                newName: "BaseImponibleIVA12");

            migrationBuilder.RenameColumn(
                name: "BaseIVA0",
                table: "Facturas",
                newName: "BaseImponibleIVA0");

            migrationBuilder.RenameColumn(
                name: "FacturaId",
                table: "Facturas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Producto",
                table: "DetallesFactura",
                newName: "ProductoNombre");

            migrationBuilder.RenameColumn(
                name: "PrecioUnitario",
                table: "DetallesFactura",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "DetalleId",
                table: "DetallesFactura",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleFacturas_FacturaId",
                table: "DetallesFactura",
                newName: "IX_DetallesFactura_FacturaId");

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "DetallesFactura",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetallesFactura",
                table: "DetallesFactura",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesFactura_Facturas_FacturaId",
                table: "DetallesFactura",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesFactura_Facturas_FacturaId",
                table: "DetallesFactura");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetallesFactura",
                table: "DetallesFactura");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "DetallesFactura");

            migrationBuilder.RenameTable(
                name: "DetallesFactura",
                newName: "DetalleFacturas");

            migrationBuilder.RenameColumn(
                name: "TotalPagar",
                table: "Facturas",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "Secuencial",
                table: "Facturas",
                newName: "Cliente");

            migrationBuilder.RenameColumn(
                name: "BaseImponibleIVA12",
                table: "Facturas",
                newName: "BaseIVA12");

            migrationBuilder.RenameColumn(
                name: "BaseImponibleIVA0",
                table: "Facturas",
                newName: "BaseIVA0");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Facturas",
                newName: "FacturaId");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "DetalleFacturas",
                newName: "PrecioUnitario");

            migrationBuilder.RenameColumn(
                name: "ProductoNombre",
                table: "DetalleFacturas",
                newName: "Producto");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DetalleFacturas",
                newName: "DetalleId");

            migrationBuilder.RenameIndex(
                name: "IX_DetallesFactura_FacturaId",
                table: "DetalleFacturas",
                newName: "IX_DetalleFacturas_FacturaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetalleFacturas",
                table: "DetalleFacturas",
                column: "DetalleId");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleFacturas_Facturas_FacturaId",
                table: "DetalleFacturas",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "FacturaId");
        }
    }
}
