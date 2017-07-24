using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Macron.Entregas.Infra.Data.Context;

namespace Macron.Entregas.Infra.Data.Migrations
{
    [DbContext(typeof(EntregasContext))]
    partial class EntregasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Macron.Entregas.Domain.Models.Entregas.Entrega", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<string>("ChaveDeAcessoNota")
                        .IsRequired()
                        .HasColumnType("varchar(44)")
                        .HasMaxLength(44);

                    b.Property<DateTime?>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<DateTime>("DataEnvio");

                    b.Property<bool?>("Deletado");

                    b.Property<DateTime?>("DeletadoEm");

                    b.Property<string>("DeletadoPor");

                    b.Property<double?>("Latitude");

                    b.Property<string>("Local")
                        .HasColumnType("varchar(300)")
                        .HasMaxLength(300);

                    b.Property<double?>("Longitude");

                    b.Property<string>("NomeColaborador")
                        .IsRequired()
                        .HasColumnType("varchar(150)")
                        .HasMaxLength(150);

                    b.Property<string>("RGColaborador")
                        .IsRequired()
                        .HasColumnType("varchar(9)")
                        .HasMaxLength(9);

                    b.Property<bool?>("Sincronizado");

                    b.Property<DateTime?>("SincronizadoEm");

                    b.HasKey("Id");

                    b.ToTable("entrega");
                });
        }
    }
}
