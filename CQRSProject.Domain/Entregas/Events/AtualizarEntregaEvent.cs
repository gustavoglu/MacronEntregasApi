using CQRSProject.Domain.Core.Events;
using System;

namespace CQRSProject.Domain.Entregas.Events
{
    public class AtualizarEntregaEvent : Event
    {
        public Guid? Id { get; set; }

        public string NomeColaborador { get; protected set; } = null;

        public string RGColaborador { get; protected set; } = null;

        public DateTime? DataEnvio { get; protected set; }

        public string ChaveDeAcessoNota { get; protected set; } = null;

        public double? Latitude { get; protected set; }

        public double? Longitude { get; protected set; }

        public string Local { get; protected set; } = null;

        public DateTime DataSincronizacao { get; protected set; }

        public bool Sincronizado { get; protected set; }


        public AtualizarEntregaEvent(Guid? id, string nomeColaborador, string rgColaborador, DateTime dataEnvio, string chaveDeAcessoNota, double? latitude = null, double? longitude = null, string local = null, DateTime? dataSincronizacao = null, bool? sincronizado = false)
        {
            if (id.HasValue) this.Id = id.Value;
            NomeColaborador = nomeColaborador;
            RGColaborador = rgColaborador;
            DataEnvio = dataEnvio;
            ChaveDeAcessoNota = chaveDeAcessoNota;
            if (latitude.HasValue) this.Latitude = latitude.Value;
            if (longitude.HasValue) this.Longitude = longitude.Value;
            if (local != null && local != string.Empty) this.Local = local;
            if (dataSincronizacao.HasValue) DataSincronizacao = dataSincronizacao.Value;
            if (sincronizado.HasValue) Sincronizado = sincronizado.Value;
        }
    }
}
