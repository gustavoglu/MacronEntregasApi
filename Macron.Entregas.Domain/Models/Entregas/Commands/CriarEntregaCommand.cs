using Macron.Entregas.Domain.Models.Entregas.Validations;
using System;

namespace Macron.Entregas.Domain.Models.Entregas.Commands
{
    public class CriarEntregaCommand : BaseEntregaCommand
    {
        public CriarEntregaCommand(string nomeColaborador, string rgColaborador, string chaveDeAcessoNota, DateTime dataEnvio, string local, double? latitude, double? longitude)
        {
            this.NomeColaborador = nomeColaborador;
            this.RGColaborador = rgColaborador;
            this.ChaveDeAcessoNota = chaveDeAcessoNota;
            this.DataEnvio = dataEnvio;
            this.Local = local ?? null;
            this.Latitude = latitude ?? null;
            this.Longitude = longitude ?? null;
        }

        public override bool IsValid()
        {
            var resultValidation = new CriarEntregaValidation().Validate(this);
            return resultValidation.IsValid;
        }
    }
}
