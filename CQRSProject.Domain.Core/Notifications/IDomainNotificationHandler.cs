using CQRSProject.Domain.Core.Events;
using System.Collections.Generic;

namespace CQRSProject.Domain.Core.Notifications
{
    public interface IDomainNotificationHandler<T> : IHandler<T> where T : Message
    {
        bool HasNotifications();

        List<T> GetNotifications();
    }
}
