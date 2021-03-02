using FerroApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Infraestructure.Data.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {

            builder.HasKey(e => e.Codigo)
                .HasName("PK__Producto__06370DADE10ADC24");

            builder.ToTable("Producto");

            builder.Property(e => e.Categoria)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Clave)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);

            builder.Property(e => e.Image)
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Marca)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Precio)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Stock)
                .HasMaxLength(1000)
                .IsUnicode(false);

        }
    }
}
