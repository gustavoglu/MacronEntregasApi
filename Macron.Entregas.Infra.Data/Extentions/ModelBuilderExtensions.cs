using Microsoft.EntityFrameworkCore;

namespace Macron.Entregas.Infra.Data.Extentions
{
    public static class ModelBuilderExtensions
    {
        public static void AddConfiguration<T>(this ModelBuilder modelBuilder,EntityTypeConfiguration<T> configuration) where T : class
        {
            configuration.Map(modelBuilder.Entity<T>());
        }
    }
}
