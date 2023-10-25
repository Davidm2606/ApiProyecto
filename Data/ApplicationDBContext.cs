using APIProductos.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace APIProductos.Data
{
    public class ApplicationDBContext : DbContext
    {

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        { 


        
        }


        public DbSet<Producto> Productos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>().HasData(

                new Producto
                {
                    IdProducto = 1,
                    Nombre = "Producto 1",
                    Valor = 6,
                    Cantidad = 10
                },

                new Producto
                {
                    IdProducto = 2,
                    Nombre = "Producto 2",
                    Valor = 6,
                    Cantidad = 20
                },

                new Producto
                {
                    IdProducto = 3,
                    Nombre = "Producto 3",
                    Valor = 6,
                    Cantidad = 30
                }

                );
        }

    }
}
