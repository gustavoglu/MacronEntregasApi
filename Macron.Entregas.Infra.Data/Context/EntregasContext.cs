using Macron.Entregas.Domain.Core.Models;
using Macron.Entregas.Domain.Models.Entregas;
using Macron.Entregas.Infra.Data.Extentions;
using Macron.Entregas.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Macron.Entregas.Infra.Data.Context
{
    public class EntregasContext : DbContext
    {
        public DbSet<Entrega> Entregas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new EntregaMap());

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            var adicionados = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && e.State == EntityState.Added);
            var atualizados = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && e.State == EntityState.Modified);
            var deletados = ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && e.State == EntityState.Deleted);

            if (adicionados.Any())
                AdicionaEntidades(adicionados);

            if (atualizados.Any())
                AtualizaEntidades(atualizados);

            if (deletados.Any())
                DeletaEntidades(deletados);

            return base.SaveChanges();
        }

        private void AdicionaEntidades(IEnumerable<EntityEntry> adicionados)
        {
            foreach (var entry in adicionados)
            {
                var entidade = ((BaseEntity)entry.Entity);
                entidade.CriadoEm = DateTime.Now;
            }
        }

        private void AtualizaEntidades(IEnumerable<EntityEntry> atualizados)
        {
            foreach (var entry in atualizados)
            {
                var entidade = ((BaseEntity)entry.Entity);
                entidade.AtualizadoEm = DateTime.Now;
            }
        }

        private void DeletaEntidades(IEnumerable<EntityEntry> deletados)
        {
            foreach (var entry in deletados)
            {
                var entidade = ((BaseEntity)entry.Entity);
                entidade.DeletadoEm = DateTime.Now;
                entidade.Deletado = true;
            }
        }
    }
}
