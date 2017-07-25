using System;

namespace Macron.Entregas.Domain.Core.Events
{
    public abstract class Event : Message
    {

        public DateTime Timestamp { get; set; }

        protected Event()
        {
            this.Timestamp = DateTime.Now;
        }
    }
}
