using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace APIProductos.Migrations
{
    /// <inheritdoc />
    public partial class mi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Cedula = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Edad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Cedula);
                });

            migrationBuilder.CreateTable(
                name: "Platos",
                columns: table => new
                {
                    IdPlato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ingredientes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Precio = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platos", x => x.IdPlato);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    IdProducto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.IdProducto);
                });

            migrationBuilder.InsertData(
                table: "Empleados",
                columns: new[] { "Cedula", "Apellido", "Edad", "Nombre" },
                values: new object[,]
                {
                    { "1700154550", "Molina", 43, "Katya" },
                    { "1700377052", "Rea", 34, "Carmen" },
                    { "17154550", "Terán", 40, "Cristian" },
                    { "1721533980", "Terán", 22, "David" }
                });

            migrationBuilder.InsertData(
                table: "Platos",
                columns: new[] { "IdPlato", "Cantidad", "Ingredientes", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, 1, "salchicha", "Salchipapa", 3 },
                    { 2, 1, "carne", "Hamburguesa", 4 },
                    { 3, 1, "carne", "Papicarne", 3 },
                    { 4, 4, "4 alitas", "Alitas", 5 }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Cantidad", "Nombre", "Valor" },
                values: new object[,]
                {
                    { 1, 10, "Salchichas", 6 },
                    { 2, 20, "carne", 6 },
                    { 3, 30, "Alitas", 6 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");

            migrationBuilder.DropTable(
                name: "Platos");

            migrationBuilder.DropTable(
                name: "Productos");
        }
    }
}
