using CQRSProject.Domain.Entregas.Commands;

namespace CQRSProject.Domain.Entregas.Validations
{
    public class AtualizarEntregaValidation : EntregaValidation<AtualizarEntregaCommand>
    {
        public AtualizarEntregaValidation()
        {
            ValidaId();
            ValidaNomeColaborador();
            ValidaRGColaborador();
            ValidaChaveDeAcessoNota();
        }
    }
}
