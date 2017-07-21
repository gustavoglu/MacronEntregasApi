using CQRSProject.Domain.Core.Commands;

namespace CQRSProject.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        CommandResponse Commit();
    }
}
