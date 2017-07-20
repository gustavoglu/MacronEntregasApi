using CQRSProject.Domain.Entregas.Commands;

namespace CQRSProject.Domain.Entregas.Validations
{
    public class DeletarEntregaValidation : EntregaValidation<DeletarEntregaCommand>
    {
        public DeletarEntregaValidation()
        {
            ValidaId();
        }
    }
}
