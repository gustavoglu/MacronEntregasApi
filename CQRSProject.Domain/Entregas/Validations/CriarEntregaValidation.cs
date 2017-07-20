using CQRSProject.Domain.Entregas.Commands;

namespace CQRSProject.Domain.Entregas.Validations
{
    public class CriarEntregaValidation : EntregaValidation<CriarEntregaCommand>
    {
        public CriarEntregaValidation()
        {
            this.ValidaNomeColaborador();
            this.ValidaRGColaborador();
            this.ValidaChaveDeAcessoNota();
        }
    }
}
