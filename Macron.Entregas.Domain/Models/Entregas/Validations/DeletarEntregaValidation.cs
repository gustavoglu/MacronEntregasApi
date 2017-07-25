using Macron.Entregas.Domain.Models.Entregas.Commands;

namespace Macron.Entregas.Domain.Models.Entregas.Validations
{
    public class DeletarEntregaValidation : EntregaValidation<DeletarEntregaCommand>
    {
        public DeletarEntregaValidation()
        {
            ValidaId();
        }
    }
}
