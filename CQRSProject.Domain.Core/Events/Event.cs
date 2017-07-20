using System;
using System.Collections.Generic;
using System.Text;

namespace CQRSProject.Domain.Core.Events
{
    public abstract class Event : Message
    {
        public DateTime Timestamp { get; set; }

        protected Event()
        {
            Timestamp = DateTime.Now;
        }
    }
}
