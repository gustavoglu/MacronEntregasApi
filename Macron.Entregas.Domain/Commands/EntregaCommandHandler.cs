using Macron.Entregas.Domain.Core.Events;
using Macron.Entregas.Domain.Models.Entregas.Commands;
using Macron.Entregas.Domain.Core.Bus;
using Macron.Entregas.Domain.Core.Notifications;
using Macron.Entregas.Domain.Interfaces;
using Macron.Entregas.Domain.Interfaces.EntityRepository;
using Macron.Entregas.Domain.Models.Entregas;
using static Macron.Entregas.Domain.Models.Entregas.Entrega;

namespace Macron.Entregas.Domain.Commands
{
    public class EntregaCommandHandler : CommandHandler, IHandler<CriarEntregaCommand>, IHandler<AtualizarEntregaCommand>, IHandler<DeletarEntregaCommand>, IHandler<ReativarEntregaCommand>
    {
        IBus Bus;
        IEntregaRepository _entregaRepository;

        public EntregaCommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications, IEntregaRepository entregaRepository) : base(uow, bus, notifications)
        {
            Bus = bus;
            _entregaRepository = entregaRepository;
        }

        public void Handler(DeletarEntregaCommand message)
        {
            if (!ValidaMessage(message)) return;

            _entregaRepository.Deletar(message.Id.Value);

            ValidaCommitError();
        }

        public void Handler(AtualizarEntregaCommand message)
        {
            if (!ValidaMessage(message)) return;

            Entrega entraga = EntregaFactory.EntregaCompleta(message.Id.Value, message.NomeColaborador, message.RGColaborador, message.ChaveDeAcessoNota, message.DataEnvio, message.Local, message.Latitude, message.Longitude, message.SincronizadoEm, message.Sincronizado);

            ValidaCommitError();
        }

        public void Handler(CriarEntregaCommand message)
        {

            if (!ValidaMessage(message)) return;

            Entrega entrega = new Entrega(message.NomeColaborador, message.RGColaborador, message.ChaveDeAcessoNota, message.DataEnvio, message.Local, message.Latitude, message.Longitude);

            _entregaRepository.Criar(entrega);

            ValidaCommitError();
        }

        public void Handler(ReativarEntregaCommand message)
        {
            if (!ValidaMessage(message)) return;

            _entregaRepository.Reativar(message.Id.Value);

            ValidaCommitError();

        }

        private void ValidaCommitError()
        {
            if (!Commit()) { Bus.RaizeEvent(new DomainNotification("Commit", "Ocorreu algum erro ao atualizar o banco de dados")); return; };
        }

        private bool ValidaMessage(BaseEntregaCommand message)
        {
            if (!message.IsValid()) { NotifyValidationsErrors(message); return false; }
            return true;
        }

    }
}
