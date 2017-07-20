using CQRSProject.Domain.Core.Events;
using FluentValidation.Results;
using System;

namespace CQRSProject.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; set; }

        public ValidationResult ValidationResult { get; set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }

        public abstract bool IsValid();

    }
}
