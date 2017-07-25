using Macron.Entregas.Domain.Core.Commands;

namespace Macron.Entregas.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        CommandResponse Commit();
    }
}
