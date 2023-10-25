using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIProductos.Migrations
{
    /// <inheritdoc />
    public partial class produto2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1,
                columns: new[] { "Cantidad", "Valor" },
                values: new object[] { 10, 4 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 2,
                columns: new[] { "Cantidad", "Valor" },
                values: new object[] { 20, 2 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3,
                columns: new[] { "Cantidad", "Valor" },
                values: new object[] { 30, 6 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1,
                columns: new[] { "Cantidad", "Valor" },
                values: new object[] { 34, 4});

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 2,
                columns: new[] { "Cantidad", "Valor" },
                values: new object[] { 34, 4 });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3,
                columns: new[] { "Cantidad", "Valor" },
                values: new object[] { 3, 2 });
        }
    }
}
