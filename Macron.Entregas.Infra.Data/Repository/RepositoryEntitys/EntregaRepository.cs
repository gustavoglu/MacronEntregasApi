using Macron.Entregas.Domain.Interfaces.EntityRepository;
using Macron.Entregas.Domain.Models.Entregas;
using Macron.Entregas.Infra.Data.Context;

namespace Macron.Entregas.Infra.Data.Repository.RepositoryEntitys
{
    public class EntregaRepository : Repository<Entrega>, IEntregaRepository
    {
        public EntregaRepository(EntregasContext Db) : base(Db)
        {
        }
    }
}
