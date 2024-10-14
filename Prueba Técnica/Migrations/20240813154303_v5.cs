using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prueba_Técnica.Migrations
{
    /// <inheritdoc />
    public partial class v5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesFactura_Facturas_FacturaId",
                table: "DetallesFactura");

            migrationBuilder.DropColumn(
                name: "Fecha",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "Secuencial",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "DetallesFactura");

            migrationBuilder.DropColumn(
                name: "ProductoNombre",
                table: "DetallesFactura");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "DetallesFactura");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Facturas",
                newName: "FacturaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DetallesFactura",
                newName: "DetalleId");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPagar",
                table: "Facturas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "IVA",
                table: "Facturas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BaseImponibleIVA12",
                table: "Facturas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "BaseImponibleIVA0",
                table: "Facturas",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ClienteNombre",
                table: "Facturas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "IVA",
                table: "DetallesFactura",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "FacturaId",
                table: "DetallesFactura",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "DetallesFactura",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Descripcion",
                table: "DetallesFactura",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "PrecioUnitario",
                table: "DetallesFactura",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Subtotal",
                table: "DetallesFactura",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesFactura_Facturas_FacturaId",
                table: "DetallesFactura",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "FacturaId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallesFactura_Facturas_FacturaId",
                table: "DetallesFactura");

            migrationBuilder.DropColumn(
                name: "ClienteNombre",
                table: "Facturas");

            migrationBuilder.DropColumn(
                name: "Descripcion",
                table: "DetallesFactura");

            migrationBuilder.DropColumn(
                name: "PrecioUnitario",
                table: "DetallesFactura");

            migrationBuilder.DropColumn(
                name: "Subtotal",
                table: "DetallesFactura");

            migrationBuilder.RenameColumn(
                name: "FacturaId",
                table: "Facturas",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DetalleId",
                table: "DetallesFactura",
                newName: "Id");

            migrationBuilder.AlterColumn<decimal>(
                name: "TotalPagar",
                table: "Facturas",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "IVA",
                table: "Facturas",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BaseImponibleIVA12",
                table: "Facturas",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "BaseImponibleIVA0",
                table: "Facturas",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<DateTime>(
                name: "Fecha",
                table: "Facturas",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Secuencial",
                table: "Facturas",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "IVA",
                table: "DetallesFactura",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "FacturaId",
                table: "DetallesFactura",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Cantidad",
                table: "DetallesFactura",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "Precio",
                table: "DetallesFactura",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductoNombre",
                table: "DetallesFactura",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "DetallesFactura",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallesFactura_Facturas_FacturaId",
                table: "DetallesFactura",
                column: "FacturaId",
                principalTable: "Facturas",
                principalColumn: "Id");
        }
    }
}
