using CQRSProject.Domain.Core.Models;
using System;

namespace CQRSProject.Domain.Entregas
{
    public class Entrega : BaseEntity<Entrega>
    {
        public string NomeColaborador { get; set; } = null;

        public string RGColaborador { get; set; } = null;

        public DateTime? DataEnvio { get; set; }

        public string ChaveDeAcessoNota { get; set; } = null;

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public string Local { get; set; } = null;

        public DateTime? DataSincronizacao { get; set; }

        public bool Sincronizado { get; set; }

        public Entrega()
        {

        }

        public Entrega(string nomeColaborador, string rgColaborador, DateTime dataEnvio, string chaveDeAcessoNota, double? latitude = null, double? longitude = null, string local = null)
        {
            NomeColaborador = nomeColaborador;
            RGColaborador = rgColaborador;
            DataEnvio = dataEnvio;
            ChaveDeAcessoNota = chaveDeAcessoNota;
            if (latitude.HasValue) this.Latitude = latitude.Value;
            if (longitude.HasValue) this.Longitude = longitude.Value;
            if (local != null && local != string.Empty) this.Local = local;
        }

        protected override bool IsValid()
        {
            return true;
        }

        public static class EntregaFactory
        {
            public static Entrega EntregaCompleta(Guid id, string nomeColaborador, string rgColaborador, DateTime? dataEnvio, string chaveDeAcessoNota, double? latitude = null, double? longitude = null, string local = null, DateTime? dataSincronizacao = null, bool? sincronizado = false)
            {
                return new Entrega()
                {
                    Id = id,
                    NomeColaborador = nomeColaborador,
                    RGColaborador = rgColaborador,
                    DataEnvio = dataEnvio.HasValue ? dataEnvio : null,
                    ChaveDeAcessoNota = chaveDeAcessoNota,
                    Latitude = latitude.HasValue ? latitude : null,
                    Longitude = longitude.HasValue ? longitude : null,
                    Local = local != null ? local : string.Empty,
                    DataSincronizacao = dataSincronizacao.HasValue ? dataSincronizacao : null,
                    Sincronizado = sincronizado.HasValue ? sincronizado.Value : false
                };
            }
        }

    }
}
