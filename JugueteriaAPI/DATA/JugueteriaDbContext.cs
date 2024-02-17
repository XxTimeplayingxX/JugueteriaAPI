using JugueteriaAPI.MODELS;
using Microsoft.EntityFrameworkCore;

namespace JugueteriaAPI.DATA
{
    public class JugueteriaDbContext : DbContext
    {
        public JugueteriaDbContext(DbContextOptions<JugueteriaDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<JugueteDetalle> JugueteDetalles { get; set; }
        public DbSet<Juguete> Juguetes { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cliente1 = new Cliente() { ID = 1, NombreCompleto = "Juan Perez", Email = "juan@example.com", Direccion = "Calle 123" };
            var cliente2 = new Cliente() { ID = 2, NombreCompleto = "María García", Email = "maria@example.com", Direccion = "Avenida 456" };

            var juguete1 = new Juguete() { ID = 1, Nombre = "Muñeca", Descripcion = "Muñeca de porcelana", Precio = 25 };
            var juguete2 = new Juguete() { ID = 2, Nombre = "Carro de Juguete", Descripcion = "Carro a control remoto", Precio = 30 };

            var categoria1 = new Categoria() { ID = 1, Nombre = "Juguetes para niñas", JugueteID = 1 };
            var categoria2 = new Categoria() { ID = 2, Nombre = "Juguetes para niños", JugueteID = 2 };

            var jugueteDetalle1 = new JugueteDetalle() { ID = 1, ClienteID = 1 };
            var jugueteDetalle2 = new JugueteDetalle() { ID = 2, ClienteID = 2 };

            modelBuilder.Entity<Cliente>().HasData(new Cliente[] { cliente1, cliente2 });
            modelBuilder.Entity<Juguete>().HasData(new Juguete[] { juguete1, juguete2 });
            modelBuilder.Entity<Categoria>().HasData(new Categoria[] { categoria1, categoria2 });
            modelBuilder.Entity<JugueteDetalle>().HasData(new JugueteDetalle[] { jugueteDetalle1, jugueteDetalle2 });

            base.OnModelCreating(modelBuilder);
        }


    }
}
