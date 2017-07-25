using Macron.Entregas.Domain.Core.Events;
using System;

namespace Macron.Entregas.Domain.Models.Entregas.Events
{
    public class AtualizarEntregaEvent : Event
    {
        public Guid? Id { get; set; }

        public string NomeColaborador { get; private set; }

        public string RGColaborador { get; private set; }

        public string ChaveDeAcessoNota { get; private set; }

        public DateTime DataEnvio { get; private set; }

        public string Local { get; private set; } = null;

        public double? Latitude { get; private set; }

        public double? Longitude { get; private set; }

        public bool? Sincronizado { get; private set; }

        public DateTime? SincronizadoEm { get; private set; }

        public AtualizarEntregaEvent(Guid? id, string nomeColaborador, string rgColaborador, string chaveDeAcessoNota, DateTime dataEnvio, string local, double? latitude, double? longitude, DateTime? sincronizadoEm, bool? sincronizado)
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
    }
}
