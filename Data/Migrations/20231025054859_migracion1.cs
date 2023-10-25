using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIProductos.Migrations
{
    /// <inheritdoc />
    public partial class migracion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Valor",
                table: "Productos",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1,
                column: "Valor",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 2,
                column: "Valor",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3,
                column: "Valor",
                value: 6);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Valor",
                table: "Productos",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1,
                column: "Valor",
                value: "4");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 2,
                column: "Valor",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3,
                column: "Valor",
                value: "8");
        }
    }
}
