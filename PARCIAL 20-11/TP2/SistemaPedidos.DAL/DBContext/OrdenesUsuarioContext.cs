using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SistemaPedidos.Model.Models;

namespace SistemaPedidos.DAL.DBContext
{

    public partial class OrdenesUsuarioContext : DbContext
    {
        public OrdenesUsuarioContext()
        {
        }

        public OrdenesUsuarioContext(DbContextOptions<OrdenesUsuarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Orden> Ordens { get; set; }

        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Orden>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Orden__3214EC07C1280473");

                entity.ToTable("Orden");

                entity.Property(e => e.Descripcion).HasMaxLength(255);

                entity.HasOne(d => d.Usuario).WithMany(p => p.Ordens)
                    .HasForeignKey(d => d.UsuarioId)
                    .HasConstraintName("FK_Orden_Usuario");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC077B225B3E");

                entity.ToTable("Usuario");

                entity.Property(e => e.Nombre).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
