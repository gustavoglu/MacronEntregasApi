using Macron.Entregas.Domain.Models.Entregas.Commands;

namespace Macron.Entregas.Domain.Models.Entregas.Validations
{
    public class AtualizarEntregaValidation : EntregaValidation<AtualizarEntregaCommand>
    {
        public AtualizarEntregaValidation()
        {
            ValidaId();
            ValidaRGColaborador();
            ValidaNomeColaborador();
            ValidaDataEnvio();
            ValidaChaveDeAcessoNota();
        }
    }
}
