using FluentValidation.Results;
using Macron.Entregas.Domain.Core.Events;
using System;

namespace Macron.Entregas.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; set; }

        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            this.Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();
    }
}
