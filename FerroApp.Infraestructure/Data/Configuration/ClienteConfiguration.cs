using FerroApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Infraestructure.Data.Configuration
{
  public  class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(e => e.IdCliente);

            builder.ToTable("Cliente");

            builder.Property(e => e.ApellidoMaterno)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.ApellidoPaterno)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(e => e.Cp)
                .IsRequired()
                .HasMaxLength(10)
                .HasColumnName("CP")
                .IsFixedLength(true);

            builder.Property(e => e.Direccion)
                .IsRequired()
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(e => e.Nombres)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Cliente__IdUsuar__71D1E811");
        }
    }
}


//modelBuilder.Entity<Cliente>(entity =>
//{
//    entity.HasKey(e => e.IdCliente);

//    entity.ToTable("Cliente");

//    entity.Property(e => e.IdCliente).ValueGeneratedNever();

//    entity.Property(e => e.ApellidoMaterno)
//        .IsRequired()
//        .HasMaxLength(50)
//        .IsUnicode(false);

//    entity.Property(e => e.ApellidoPaterno)
//        .IsRequired()
//        .HasMaxLength(50)
//        .IsUnicode(false);

//    entity.Property(e => e.Cp)
//        .IsRequired()
//        .HasMaxLength(10)
//        .HasColumnName("CP")
//        .IsFixedLength(true);

//    entity.Property(e => e.Direccion)
//        .IsRequired()
//        .HasMaxLength(100)
//        .IsUnicode(false);

//    entity.Property(e => e.Nombres)
//        .IsRequired()
//        .HasMaxLength(50)
//        .IsUnicode(false);
//});
