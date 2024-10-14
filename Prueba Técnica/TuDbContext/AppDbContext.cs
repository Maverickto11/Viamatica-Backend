using Microsoft.EntityFrameworkCore;
using Prueba_Técnica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Técnica.TuDbContex
{
    public class AppDbContext : DbContext
    {
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetallesFactura { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Carrito> Carritos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Factura>()
                .HasMany(f => f.Detalles)
                .WithOne()
                .HasForeignKey(d => d.FacturaId);

            modelBuilder.Entity<Categoria>()
          .HasMany(p => p.Productos)
                .WithOne()
          .HasForeignKey(p => p.CategoriaId);
        }
    }
}
