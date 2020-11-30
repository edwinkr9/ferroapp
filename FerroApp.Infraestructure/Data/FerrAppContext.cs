using System;
using Microsoft.EntityFrameworkCore;
using FerroApp.Domain.Entities;

using Microsoft.EntityFrameworkCore.Metadata;
using FerroApp.Infraestructure.Data.Configuration;

#nullable disable

namespace FerroApp.Infraestructure.Data
{
    public partial class FerrAppContext : DbContext
    {
        public FerrAppContext()
        {
        }

        public FerrAppContext(DbContextOptions<FerrAppContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Administrador> Administradors { get; set; }
        public virtual DbSet<CarritoCompra> CarritoCompras { get; set; }
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Gerente> Gerentes { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Producto>(new ProductoConfiguration());
            modelBuilder.ApplyConfiguration<Gerente>(new GerenteConfiguration());
            modelBuilder.ApplyConfiguration<Cliente>(new ClienteConfiguration());


            modelBuilder.Entity<Administrador>(entity =>
            {
                entity.HasKey(e => e.IdAdministrador)
                    .HasName("PK__Administ__2B3E34A885B45DD3");

                entity.ToTable("Administrador");

                entity.Property(e => e.IdAdministrador).ValueGeneratedNever();

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.Administradors)
                    .HasForeignKey(d => d.IdUsuario)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Administr__IdUsu__6754599E");
            });

            modelBuilder.Entity<CarritoCompra>(entity =>
            {
                entity.HasKey(e => e.IdCarrito)
                    .HasName("PK__CarritoC__8B4A618C5E1FA6C1");

                entity.Property(e => e.IdCarrito).ValueGeneratedNever();

                entity.Property(e => e.ApellidoMaterno)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionCliente)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PagoTotal)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.CarritoCompras)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CarritoCo__PagoT__787EE5A0");

                //entity.HasOne(d => d.IdProductoNavigation)
                //    .WithMany(p => p.CarritoCompras)
                //    .HasForeignKey(d => d.IdProducto)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__CarritoCo__IdPro__797309D9");
            });

            //modelBuilder.Entity<Cliente>(entity =>
            //{
            //    entity.HasKey(e => e.IdCliente)
            //        .HasName("PK__Cliente__D59466427D4792F0");

            //    entity.ToTable("Cliente");

            //    entity.Property(e => e.IdCliente).ValueGeneratedNever();

            //    entity.Property(e => e.ApellidoMaterno)
            //        .IsRequired()
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.ApellidoPaterno)
            //        .IsRequired()
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Cp)
            //        .IsRequired()
            //        .HasMaxLength(200)
            //        .IsUnicode(false)
            //        .HasColumnName("CP");

            //    entity.Property(e => e.Direccion)
            //        .IsRequired()
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.Property(e => e.Nombres)
            //        .IsRequired()
            //        .HasMaxLength(200)
            //        .IsUnicode(false);

            //    entity.HasOne(d => d.IdUsuarioNavigation)
            //        .WithMany(p => p.Clientes)
            //        .HasForeignKey(d => d.IdUsuario)
            //        .OnDelete(DeleteBehavior.ClientSetNull)
            //        .HasConstraintName("FK__Cliente__IdUsuar__6477ECF3");
            //});

            //modelBuilder.Entity<Gerente>(entity =>
            //{
                //entity.HasKey(e => e.IdGerente)
                //    .HasName("PK__Gerente__06016C453906755A");

                //entity.ToTable("Gerente");

                //entity.Property(e => e.IdGerente).ValueGeneratedNever();

                //entity.Property(e => e.ApellidoMaterno)
                //    .IsRequired()
                //    .HasMaxLength(200)
                //    .IsUnicode(false);

                //entity.Property(e => e.ApellidoPaterno)
                //    .IsRequired()
                //    .HasMaxLength(200)
                //    .IsUnicode(false);

                //entity.Property(e => e.Nombres)
                //    .IsRequired()
                //    .HasMaxLength(200)
                //    .IsUnicode(false);

                //entity.HasOne(d => d.IdUsuarioNavigation)
                //    .WithMany(p => p.Gerentes)
                //    .HasForeignKey(d => d.IdUsuario)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Gerente__Apellid__619B8048");
            //});

            //modelBuilder.Entity<Producto>(entity =>
            //{
                //entity.HasKey(e => e.Codigo)
                //    .HasName("PK__Producto__06370DADE507358B");

                //entity.ToTable("Producto");

                //entity.Property(e => e.Codigo).ValueGeneratedNever();

                //entity.Property(e => e.Categoria)
                //    .IsRequired()
                //    .HasMaxLength(200)
                //    .IsUnicode(false);

                //entity.Property(e => e.Marca)
                //    .IsRequired()
                //    .HasMaxLength(200)
                //    .IsUnicode(false);

                //entity.Property(e => e.Nombre)
                //    .IsRequired()
                //    .HasMaxLength(200)
                //    .IsUnicode(false);

                //entity.Property(e => e.Precio)
                //    .IsRequired()
                //    .HasMaxLength(200)
                //    .IsUnicode(false);
            //});

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF977993E95A");

                entity.ToTable("Usuario");

                entity.Property(e => e.IdUsuario).ValueGeneratedNever();

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            
        }

        
    }
}
