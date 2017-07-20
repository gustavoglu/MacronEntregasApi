using CQRSProject.Domain.Entregas.Validations;
using System;

namespace CQRSProject.Domain.Entregas.Commands
{
    public class AtualizarEntregaCommand : BaseEntregaCommand
    {
        public AtualizarEntregaCommand(Guid? id, string nomeColaborador, string rgColaborador, DateTime dataEnvio, string chaveDeAcessoNota, double? latitude = null, double? longitude = null, string local = null, DateTime? dataSincronizacao = null, bool? sincronizado = false)
        {
            if (id.HasValue) this.Id = id.Value;
            this.NomeColaborador = nomeColaborador;
            this.RGColaborador = rgColaborador;
            this.DataEnvio = dataEnvio;
            this.ChaveDeAcessoNota = chaveDeAcessoNota;
            if (latitude.HasValue) this.Latitude = latitude.Value;
            if (longitude.HasValue) this.Longitude = longitude.Value;
            if (local != null && local != string.Empty) this.Local = local;
        }

        public override bool IsValid()
        {
            var validationResult = new AtualizarEntregaValidation().Validate(this);
            return validationResult.IsValid;
        }
    }
}
