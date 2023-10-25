using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIProductos.Migrations
{
    /// <inheritdoc />
    public partial class IngresarProducto3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Cantidad", "Valor", "Nombre" },
                values: new object[] { 3, 3, 10, "Parrillada" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3);
        }
    }
}
