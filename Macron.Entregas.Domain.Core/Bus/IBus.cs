using Macron.Entregas.Domain.Core.Commands;
using Macron.Entregas.Domain.Core.Events;

namespace Macron.Entregas.Domain.Core.Bus
{
    public interface IBus
    {
        void SendCommand<T>(T Command) where T : Command;

        void RaizeEvent<T>(T Event) where T : Event;
    }
}
