using FerroApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FerroApp.Infraestructure.Data.Configuration
{
    public class GerenteConfiguration : IEntityTypeConfiguration<Gerente>
    {
        public void Configure(EntityTypeBuilder<Gerente> builder)
        {


            builder.HasKey(e => e.IdGerente)
     .HasName("PK__Gerente__06016C4597FF6D12");

            builder.ToTable("Gerente");

            builder.Property(e => e.ApellidoMaterno)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.ApellidoPaterno)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.Property(e => e.Nombres)
                .IsRequired()
                .HasMaxLength(200)
                .IsUnicode(false);

            builder.HasOne(d => d.IdUsuarioNavigation)
                .WithMany(p => p.Gerentes)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Gerente__Apellid__33D4B598");
        }
    }
}
