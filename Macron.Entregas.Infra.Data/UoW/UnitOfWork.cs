using Macron.Entregas.Domain.Interfaces;
using Macron.Entregas.Domain.Core.Commands;
using Macron.Entregas.Infra.Data.Context;

namespace Macron.Entregas.Infra.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EntregasContext _context;

        public UnitOfWork(EntregasContext context)
        {
            this._context = context;
        }

        public CommandResponse Commit()
        {
            var rowsAffected = _context.SaveChanges();
            return new CommandResponse(rowsAffected > 0);
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
