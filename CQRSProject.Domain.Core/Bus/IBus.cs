using CQRSProject.Domain.Core.Commands;
using CQRSProject.Domain.Core.Events;

namespace CQRSProject.Domain.Core.Bus
{
    public interface IBus
    {
        void SendCommand<T>(T theCommand) where T : Command;

        void RaiseEvent<T>(T theEvent) where T : Event;
    }
}
