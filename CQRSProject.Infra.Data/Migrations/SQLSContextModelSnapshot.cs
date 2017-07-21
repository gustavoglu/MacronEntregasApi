using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using CQRSProject.Infra.Data.Context;

namespace CQRSProject.Infra.Data.Migrations
{
    [DbContext(typeof(SQLSContext))]
    partial class SQLSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CQRSProject.Domain.Entregas.Entrega", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("AtualizadoEm");

                    b.Property<string>("AtualizadoPor");

                    b.Property<string>("ChaveDeAcessoNota")
                        .IsRequired()
                        .HasColumnType("varchar(44)")
                        .HasMaxLength(44);

                    b.Property<DateTime?>("CriadoEm");

                    b.Property<string>("CriadoPor");

                    b.Property<DateTime?>("DataEnvio");

                    b.Property<DateTime?>("DataSincronizacao");

                    b.Property<bool>("Deletado");

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

                    b.Property<bool>("Sincronizado");

                    b.HasKey("Id");

                    b.ToTable("entregas");
                });
        }
    }
}
