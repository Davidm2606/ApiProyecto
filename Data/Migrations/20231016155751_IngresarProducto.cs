using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIProductos.Migrations
{
    /// <inheritdoc />
    public partial class IngresarProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Cantidad", "Valor", "Nombre" },
                values: new object[] { 1, 34, 2, "Salchipapa" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1);
        }
    }
}
