using Macron.Entregas.Domain.Models.Entregas.Validations;
using System;

namespace Macron.Entregas.Domain.Models.Entregas.Commands
{
    public class AtualizarEntregaCommand : BaseEntregaCommand
    {
        public AtualizarEntregaCommand(Guid? id,string nomeColaborador, string rgColaborador, string chaveDeAcessoNota, DateTime dataEnvio, string local, double? latitude, double? longitude, DateTime? sincronizadoEm, bool? sincronizado)
        {
            this.Id = id ?? null;
            this.NomeColaborador = nomeColaborador;
            this.RGColaborador = rgColaborador;
            this.ChaveDeAcessoNota = chaveDeAcessoNota;
            this.DataEnvio = dataEnvio;
            this.Local = local ?? null;
            this.Latitude = latitude ?? null;
            this.Longitude = longitude ?? null;
            this.SincronizadoEm = sincronizadoEm ?? null;
            this.Sincronizado = sincronizado ?? null;
        }

        public override bool IsValid()
        {
            var resultValidation = new AtualizarEntregaValidation().Validate(this);
            return resultValidation.IsValid;
        }
    }
}
