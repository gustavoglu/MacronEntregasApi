using Macron.Entregas.Domain.Models.Entregas.Commands;

namespace Macron.Entregas.Domain.Models.Entregas.Validations
{
    public class ReativarEntregaValidation : EntregaValidation<ReativarEntregaCommand>
    {
        public ReativarEntregaValidation()
        {
            ValidaId();
        }
    }
}
