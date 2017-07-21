using CQRSProject.Domain.Core.Bus;
using CQRSProject.Domain.Core.Commands;
using CQRSProject.Domain.Core.Notifications;
using CQRSProject.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSProject.Domain.CommandHandler
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
            foreach (var error in message.ValidationResult.Errors)
            {
                _bus.RaiseEvent(new DomainNotification(message.MessageType, error.ErrorMessage));
            }
        }

        public bool Commit()
        {
            if (_notifications.HasNotifications()) return false;
            var commandResponse = _uow.Commit();
            if (commandResponse.Success) return true;

            _bus.RaiseEvent(new DomainNotification("Commit", "Algum erro ocorreu ao atualizar o banco de dados"));
            return false;
        }

    }
}
