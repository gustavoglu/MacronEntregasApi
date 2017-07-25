using Macron.Entregas.Domain.Models.Entregas.Validations;
using System;

namespace Macron.Entregas.Domain.Models.Entregas.Commands
{
    public class ReativarEntregaCommand : BaseEntregaCommand
    {
        public ReativarEntregaCommand(Guid id)
        {
            this.Id = id;
            this.AggregateId = id;
        }
        public override bool IsValid()
        {
            var resultValidation = new ReativarEntregaValidation().Validate(this);
            return resultValidation.IsValid;
        }
    }
}
