using Macron.Entregas.Domain.Core.Events;
using System;

namespace Macron.Entregas.Domain.Models.Entregas.Events
{
    public class DeletarEntregaEvent : Event
    {
        public DeletarEntregaEvent(Guid id)
        {
            this.Id = id;
            this.AggregateId = id;
        }

        public Guid? Id { get; set; }
    }
}
