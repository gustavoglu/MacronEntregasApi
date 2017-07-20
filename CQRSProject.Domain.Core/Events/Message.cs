using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSProject.Domain.Core.Events
{
    public abstract class Message
    {
        public string MessageType { get; set; }

        public Guid AggregateId { get; set; }

        protected Message()
        {
            MessageType = GetType().Name;
        }

    }
}
