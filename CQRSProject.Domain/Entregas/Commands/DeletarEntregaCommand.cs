using CQRSProject.Domain.Entregas.Validations;
using System;

namespace CQRSProject.Domain.Entregas.Commands
{
    public class DeletarEntregaCommand : BaseEntregaCommand
    {
        public DeletarEntregaCommand(Guid id)
        {
            this.Id = id;
            this.AggregateId = id;
        }

        public override bool IsValid()
        {
            var validationResult = new DeletarEntregaValidation().Validate(this);
            return validationResult.IsValid;
        }
    }
}
