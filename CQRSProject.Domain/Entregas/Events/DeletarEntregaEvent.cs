using CQRSProject.Domain.Core.Events;
using System;

namespace CQRSProject.Domain.Entregas.Events
{
    public class DeletarEntregaEvent : Event
    {
        public Guid Id { get; set; }

        public DeletarEntregaEvent(Guid id)
        {
            this.Id = id;
            this.AggregateId = id;
        }
    }
}
