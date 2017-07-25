using Macron.Entregas.Domain.Core.Events;
using System;

namespace Macron.Entregas.Domain.Core.Notifications
{
    public class DomainNotification : Event
    {
        public Guid DomainNotificationId { get; set; }

        public string Key { get; set; }

        public string Value { get; set; }

        public int Version { get; set; }

        public DomainNotification(string key, string value)
        {
            this.Key = key;
            this.Value = value;
            DomainNotificationId = Guid.NewGuid();
            Version = 1;
        }
    }
}
