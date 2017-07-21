using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CQRSProject.Infra.Data.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "entregas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtualizadoEm = table.Column<DateTime>(nullable: true),
                    AtualizadoPor = table.Column<string>(nullable: true),
                    ChaveDeAcessoNota = table.Column<string>(type: "varchar(44)", maxLength: 44, nullable: false),
                    CriadoEm = table.Column<DateTime>(nullable: true),
                    CriadoPor = table.Column<string>(nullable: true),
                    DataEnvio = table.Column<DateTime>(nullable: true),
                    DataSincronizacao = table.Column<DateTime>(nullable: true),
                    Deletado = table.Column<bool>(nullable: false),
                    DeletadoEm = table.Column<DateTime>(nullable: true),
                    DeletadoPor = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: true),
                    Local = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: true),
                    Longitude = table.Column<double>(nullable: true),
                    NomeColaborador = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    RGColaborador = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false),
                    Sincronizado = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_entregas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "entregas");
        }
    }
}
