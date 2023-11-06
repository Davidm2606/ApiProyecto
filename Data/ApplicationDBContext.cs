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

        public DbSet<Empleados> Empleados { get; set; }
        public DbSet<Platos> Platos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {



            modelBuilder.Entity<Empleados>().HasData(

            new Empleados
            {
                Cedula = "1721533980",
                Nombre = "David",
                Apellido = "Terán",
                Edad = 22,
            },

            new Empleados
            {
                Cedula = "1700154550",
                Nombre = "Katya",
                Apellido = "Molina",
                Edad = 43,
            },

            new Empleados
            {
                Cedula = "17154550",
                Nombre = "Cristian",
                Apellido = "Terán",
                Edad = 40,
            },

            new Empleados
            {
                Cedula = "1700377052",
                Nombre = "Carmen",
                Apellido = "Rea",
                Edad = 34,
            }

          );



            modelBuilder.Entity<Platos>().HasData(

               new Platos
               {
                   IdPlato = 1,
                   Nombre = "Salchipapa",
                   Ingredientes = "salchicha",
                   Cantidad = 1,
                   Precio = 3,
               },

           new Platos
           {
               IdPlato = 2,
               Nombre = "Hamburguesa",
               Ingredientes = "carne",
               Cantidad = 1,
               Precio = 4,
           },

            new Platos
            {
                IdPlato = 3,
                Nombre = "Papicarne",
                Ingredientes = "carne",
                Cantidad = 1,
                Precio = 3,
            },

           new Platos
           {
               IdPlato = 4,
               Nombre = "Alitas",
               Ingredientes = "4 alitas",
               Cantidad = 4,
               Precio = 5,
           }
             );

            modelBuilder.Entity<Producto>().HasData(

                new Producto
                {
                    IdProducto = 1,
                    Nombre = "Salchichas",
                    Valor = 6,
                    Cantidad = 10
                },

                new Producto
                {
                    IdProducto = 2,
                    Nombre = "carne",
                    Valor = 6,
                    Cantidad = 20
                },

                new Producto
                {
                    IdProducto = 3,
                    Nombre = "Alitas",
                    Valor = 6,
                    Cantidad = 30
                }

                );
        }

    }
}
