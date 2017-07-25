using System;

namespace Macron.Entregas.Domain.Core.Events
{
    public abstract class Message
    {
        public Guid AggregateId { get; set; }

        public string MessageType { get; set; }

        protected Message()
        {
            this.MessageType = GetType().Name;

        }
    }
}
