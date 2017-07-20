using System;

namespace CQRSProject.Domain.Entregas.Events
{
    public class CriarEntregaEvent
    {
        public Guid? Id { get; protected set; }

        public string NomeColaborador { get; protected set; } = null;

        public string RGColaborador { get; protected set; } = null;

        public DateTime? DataEnvio { get; protected set; }

        public string ChaveDeAcessoNota { get; protected set; } = null;

        public double? Latitude { get; protected set; }

        public double? Longitude { get; protected set; }

        public string Local { get; protected set; } = null;

        public CriarEntregaEvent(Guid id,string nomeColaborador, string rgColaborador, DateTime dataEnvio, string chaveDeAcessoNota, double? latitude = null, double? longitude = null, string local = null)
        {
            Id = id;
            NomeColaborador = nomeColaborador;
            RGColaborador = rgColaborador;
            DataEnvio = dataEnvio;
            ChaveDeAcessoNota = chaveDeAcessoNota;
            if (latitude.HasValue) this.Latitude = latitude.Value;
            if (longitude.HasValue) this.Longitude = longitude.Value;
            if (local != null && local != string.Empty) this.Local = local;
        }

    }
}
