using Macron.Entregas.Domain.Models.Entregas;
using Macron.Entregas.Infra.Data.Extentions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Macron.Entregas.Infra.Data.Mappings
{
    public class EntregaMap : EntityTypeConfiguration<Entrega>
    {
        public override void Map(EntityTypeBuilder<Entrega> builder)
        {
            builder.ToTable("entrega");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.NomeColaborador)
                .HasMaxLength(150)
                .HasColumnType("varchar(150)")
                .IsRequired();

            builder.Property(e => e.RGColaborador)
                .HasMaxLength(9)
                .HasColumnType("varchar(9)")
                .IsRequired();

            builder.Property(e => e.ChaveDeAcessoNota)
                .HasMaxLength(44)
                .HasColumnType("varchar(44)")
                .IsRequired();

            builder.Property(e => e.DataEnvio)
                .IsRequired();

            builder.Property(e => e.Local)
               .HasMaxLength(300)
               .HasColumnType("varchar(300)");

        }
    }
}
