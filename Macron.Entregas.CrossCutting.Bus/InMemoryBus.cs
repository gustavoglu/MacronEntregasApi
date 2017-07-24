using Macron.Entregas.Domain.Core.Bus;
using System;
using Macron.Entregas.Domain.Core.Commands;
using Macron.Entregas.Domain.Core.Events;
using Macron.Entregas.Domain.Core.Notifications;

namespace Macron.Entregas.CrossCutting.Bus
{
    public class InMemoryBus : IBus
    {
        public static Func<IServiceProvider> ContainerAccessor { get; set; }
        private static IServiceProvider Container => ContainerAccessor();

        public void RaizeEvent<T>(T Event) where T : Event
        {
            Publish(Event);
        }

        public void SendCommand<T>(T Command) where T : Command
        {
            Publish(Command);
        }

        private static void Publish<T>(T message) where T : Message
        {
            if (Container == null) return;

            var typeService = message.MessageType.Equals("DomainNotification") ? 
                typeof(IDomainNotificationHandler<T>) :
                typeof(IHandler<T>);

            var obj = Container.GetService(typeService);

            ((IHandler<T>)obj).Handler(message);
        }

        private object GetService(Type servicetype)
        {
            return Container.GetService(servicetype);
        }

        private T GetService<T>()
        {
            return (T)Container.GetService(typeof(T));
        }
    }
}
