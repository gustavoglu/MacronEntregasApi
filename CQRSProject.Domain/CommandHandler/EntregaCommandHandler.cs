using CQRSProject.Domain.Core.Bus;
using CQRSProject.Domain.Core.Events;
using CQRSProject.Domain.Core.Notifications;
using CQRSProject.Domain.Entregas;
using CQRSProject.Domain.Entregas.Commands;
using CQRSProject.Domain.Entregas.Events;
using CQRSProject.Domain.Interfaces;
using CQRSProject.Domain.Interfaces.RepositoryEntitys.Interfaces;
using static CQRSProject.Domain.Entregas.Entrega;

namespace CQRSProject.Domain.CommandHandler
{
    public class EntregaCommandHandler : CommandHandler, IHandler<CriarEntregaCommand>, IHandler<AtualizarEntregaCommand>, IHandler<DeletarEntregaCommand>
    {
        private readonly IEntregaRepository _entregaRepository;
        private readonly IBus _bus;


        public EntregaCommandHandler(IEntregaRepository entregaRepository, IBus bus, IDomainNotificationHandler<DomainNotification> notifications, IUnitOfWork uow) : base(uow, bus, notifications)
        {
            _entregaRepository = entregaRepository;
            _bus = bus;
        }

        public void Handle(CriarEntregaCommand message)
        {
            if (!message.IsValid())
            {
                NotifyValidationsErrors(message);
                return;
            }

            var entrega = new Entrega(message.NomeColaborador, message.RGColaborador, message.DataEnvio.Value, message.ChaveDeAcessoNota, message.Latitude, message.Longitude, message.Local);

            _entregaRepository.Criar(entrega);

            if (Commit())
            {
                _bus.RaiseEvent(new CriarEntregaEvent(entrega.Id.Value, message.NomeColaborador, message.RGColaborador, message.DataEnvio.Value, message.ChaveDeAcessoNota, message.Latitude, message.Longitude, message.Local));
            }

        }

        public void Handle(AtualizarEntregaCommand message)
        {
            if (!message.IsValid())
            {
                NotifyValidationsErrors(message);
            }

            var entrega = EntregaFactory.EntregaCompleta(message.Id, message.NomeColaborador, message.RGColaborador, message.DataEnvio, message.ChaveDeAcessoNota, message.Latitude, message.Longitude, message.Local, message.DataSincronizacao, message.Sincronizado);

            _entregaRepository.Atualizar(entrega);

            if (Commit())
            {
                _bus.RaiseEvent(new AtualizarEntregaEvent(entrega.Id, entrega.NomeColaborador, entrega.RGColaborador, entrega.DataEnvio.Value, entrega.ChaveDeAcessoNota, entrega.Latitude, entrega.Longitude, entrega.Local, entrega.DataSincronizacao, entrega.Sincronizado));
            }

        }

        public void Handle(DeletarEntregaCommand message)
        {
            if (!message.IsValid())
            {
                NotifyValidationsErrors(message);
                return;
            }

            _entregaRepository.Deletar(message.Id);

            if (Commit())
            {
                _bus.RaiseEvent(new DeletarEntregaEvent(message.Id));
            }

        }

        public void Dispose()
        {
            _entregaRepository.Dispose();
        }


    }
}
