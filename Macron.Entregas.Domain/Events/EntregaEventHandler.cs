using Macron.Entregas.Domain.Core.Events;
using Macron.Entregas.Domain.Models.Entregas.Events;

namespace Macron.Entregas.Domain.Events
{
    public class EntregaEventHandler : IHandler<CriarEntregaEvent>, IHandler<AtualizarEntregaEvent>, IHandler<DeletarEntregaEvent>, IHandler<ReativarEntregaEvent>
    {
        public void Handler(ReativarEntregaEvent message)
        {
            //throw new NotImplementedException();
        }

        public void Handler(DeletarEntregaEvent message)
        {
            //throw new NotImplementedException();
        }

        public void Handler(AtualizarEntregaEvent message)
        {
            //throw new NotImplementedException();
        }

        public void Handler(CriarEntregaEvent message)
        {
            //throw new NotImplementedException();
        }
    }
}
