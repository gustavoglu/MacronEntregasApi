using CQRSProject.Domain.Core.Events;
using CQRSProject.Domain.Entregas.Events;
using System;

namespace CQRSProject.Domain.EventHandlers
{
    public class EntregaEventHandler : IHandler<CriarEntregaEvent>, IHandler<AtualizarEntregaEvent>, IHandler<DeletarEntregaEvent>
    {
        public void Handle(DeletarEntregaEvent message)
        {
            //
        }

        public void Handle(AtualizarEntregaEvent message)
        {
            //
        }

        public void Handle(CriarEntregaEvent message)
        {
            //
        }
    }
}
