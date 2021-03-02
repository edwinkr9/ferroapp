using FerroApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Infraestructure.Data.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            //modelBuilder.Entity<Usuario>(entity =>
            {
                builder.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF97247E4B1F");

                builder.ToTable("Usuario");

                builder.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                builder.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            }
        }
    }
}
