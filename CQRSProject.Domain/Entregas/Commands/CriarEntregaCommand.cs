using CQRSProject.Domain.Entregas.Validations;
using System;

namespace CQRSProject.Domain.Entregas.Commands
{
    public class CriarEntregaCommand : BaseEntregaCommand
    {
        public CriarEntregaCommand(string nomeColaborador, string rgColaborador, DateTime dataEnvio, string chaveDeAcessoNota, double? latitude = null, double? longitude = null, string local = null)
        {
            NomeColaborador = nomeColaborador;
            RGColaborador = rgColaborador;
            DataEnvio = dataEnvio;
            ChaveDeAcessoNota = chaveDeAcessoNota;
            if (latitude.HasValue) this.Latitude = latitude.Value;
            if (longitude.HasValue) this.Longitude = longitude.Value;
            if (local != null && local != string.Empty) this.Local = local;
        }

        public override bool IsValid()
        {
            var validationResult = new CriarEntregaValidation().Validate(this);
            return validationResult.IsValid;
        }
    }
}
