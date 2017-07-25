using Macron.Entregas.Domain.Core.Events;
using System;

namespace Macron.Entregas.Domain.Models.Entregas.Events
{
    public class CriarEntregaEvent : Event
    {
        public string NomeColaborador { get; private set; }

        public string RGColaborador { get; private set; }

        public string ChaveDeAcessoNota { get; private set; }

        public DateTime DataEnvio { get; private set; }

        public string Local { get; private set; } = null;

        public double? Latitude { get; private set; }

        public double? Longitude { get; private set; }

        public CriarEntregaEvent(string nomeColaborador, string rgColaborador, string chaveDeAcessoNota, DateTime dataEnvio, string local, double? latitude, double? longitude)
        {
            this.NomeColaborador = nomeColaborador;
            this.RGColaborador = rgColaborador;
            this.ChaveDeAcessoNota = chaveDeAcessoNota;
            this.DataEnvio = dataEnvio;
            this.Local = local != null ? local : null;
            this.Latitude = latitude.HasValue ? latitude : null;
            this.Longitude = longitude.HasValue ? longitude : null;
        }
    }
}
