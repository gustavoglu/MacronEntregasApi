using Macron.Entregas.Domain.Core.Events;
using System;

namespace Macron.Entregas.Domain.Models.Entregas.Events
{
    public class ReativarEntregaEvent : Event
    {
        public ReativarEntregaEvent(Guid id)
        {
            this.Id = id;
            this.AggregateId = id;
        }

        public Guid? Id { get; set; }

    }

}
