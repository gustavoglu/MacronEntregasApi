using Macron.Entregas.Domain.Models.Entregas.Validations;
using System;

namespace Macron.Entregas.Domain.Models.Entregas.Commands
{
    public class DeletarEntregaCommand : BaseEntregaCommand
    {
        public DeletarEntregaCommand(Guid id)
        {
            this.AggregateId = id;
        }

        public override bool IsValid()
        {
            var resultValidation = new DeletarEntregaValidation().Validate(this);
            return resultValidation.IsValid;
        }
    }
}
