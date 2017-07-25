using Macron.Entregas.Domain.Models.Entregas.Commands;

namespace Macron.Entregas.Domain.Models.Entregas.Validations
{
    public class CriarEntregaValidation : EntregaValidation<CriarEntregaCommand>
    {
        public CriarEntregaValidation()
        {
            ValidaNomeColaborador();
            ValidaRGColaborador();
            ValidaChaveDeAcessoNota();
            ValidaDataEnvio();
        }
    }
}
