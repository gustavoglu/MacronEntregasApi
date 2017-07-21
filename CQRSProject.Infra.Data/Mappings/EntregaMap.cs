using CQRSProject.Domain.Entregas;
using CQRSProject.Infra.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CQRSProject.Infra.Data.Mappings
{
    public class EntregaMap : EntityTypeConfiguration<Entrega>
    {
        public override void Map(EntityTypeBuilder<Entrega> builder)
        {
            builder.ToTable("entregas");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.NomeColaborador)
                .HasColumnType("varchar(150)")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(e => e.ChaveDeAcessoNota)
                .HasColumnType("varchar(44)")
                .HasMaxLength(44)
                .IsRequired();

            builder.Property(e => e.RGColaborador)
                .IsRequired()
                .HasColumnType("varchar(9)")
                .HasMaxLength(9);

            builder.Property(e => e.Local)
                .HasColumnType("varchar(300)")
                .HasMaxLength(300);
        }
    }
}
