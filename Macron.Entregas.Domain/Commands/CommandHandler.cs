using Macron.Entregas.Domain.Core.Bus;
using Macron.Entregas.Domain.Core.Commands;
using Macron.Entregas.Domain.Core.Notifications;
using Macron.Entregas.Domain.Interfaces;

namespace Macron.Entregas.Domain.Commands
{
    public class CommandHandler
    {
        private readonly IUnitOfWork _uow;
        private readonly IBus _bus;
        private readonly IDomainNotificationHandler<DomainNotification> _notifications;

        public CommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications)
        {
            _uow = uow;
            _bus = bus;
            _notifications = notifications;
        }

        protected void NotifyValidationsErrors(Command message)
        {
            foreach (var erro in message.ValidationResult.Errors)
            {
                _bus.RaizeEvent(new DomainNotification(message.MessageType, erro.ErrorMessage));
            }
        }

        public bool Commit()
        {
            if (_notifications.HasNotifications()) return false;
            var commandResponse = _uow.Commit();
            if (commandResponse.Success) return true;

            _bus.RaizeEvent(new DomainNotification("Commit", "Algum erro ocorreu ao atualizar o banco de dados"));
            return false;
        }
    }
}
