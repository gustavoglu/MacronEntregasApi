using System.Collections.Generic;
using System.Linq;

namespace Macron.Entregas.Domain.Core.Notifications
{
    public class DomainNotificationHandler : IDomainNotificationHandler<DomainNotification>
    {

        private List<DomainNotification> _notifications;

        public DomainNotificationHandler()
        {
            this._notifications = new List<DomainNotification>();
        }

        public List<DomainNotification> GetNotifications()
        {
            return _notifications;
        }

        public void Handler(DomainNotification message)
        {
            _notifications.Add(message);
        }

        public bool HasNotifications()
        {
            return GetNotifications().Any();
        }

        public void Dispose()
        {
            this._notifications = new List<DomainNotification>();
        }
    }
}
