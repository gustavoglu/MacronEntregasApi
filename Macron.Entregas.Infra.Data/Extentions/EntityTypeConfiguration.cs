using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Macron.Entregas.Infra.Data.Extentions
{
    public abstract class EntityTypeConfiguration<T> where T : class
    {
        public abstract void Map(EntityTypeBuilder<T> builder);
    }
}
