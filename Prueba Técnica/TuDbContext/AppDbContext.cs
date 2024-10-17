using BackendProyecto.Entidades;
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

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Carrito> Carritos { get; set; }

        public DbSet<AutenticacionRespuesta> AutenticacionRespuestas { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         

            modelBuilder.Entity<Categoria>()
          .HasMany(p => p.Productos)
                .WithOne()
          .HasForeignKey(p => p.CategoriaId);

            modelBuilder.Ignore<AutenticacionRespuesta>();


            /*---------------------------------------------------*/
            modelBuilder.Entity<AutenticacionRespuesta>()
                .Property(s => s.nombre )
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<AutenticacionRespuesta>()
                .Property(s => s.contrasena)
                .IsRequired()
                .HasMaxLength(255);

            modelBuilder.Entity<AutenticacionRespuesta>()
                .Property(s => s.correo)
                .IsRequired()
                .HasMaxLength(255);


        }

    }
}
