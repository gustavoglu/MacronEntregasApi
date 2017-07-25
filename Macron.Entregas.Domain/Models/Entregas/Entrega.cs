using Macron.Entregas.Domain.Core.Models;
using System;

namespace Macron.Entregas.Domain.Models.Entregas
{
    public class Entrega : BaseEntity
    {
        public string NomeColaborador { get; private set; }

        public string RGColaborador { get; private set; }

        public string ChaveDeAcessoNota { get; private set; }

        public DateTime DataEnvio { get; private set; }

        public string Local { get; private set; } = null;

        public double? Latitude { get; private set; }

        public double? Longitude { get; private set; }

        public bool? Sincronizado { get; private set; }

        public DateTime? SincronizadoEm { get; private set; }

        public Entrega(){}

        public Entrega(string nomeColaborador,string rgColaborador,string chaveDeAcessoNota,DateTime dataEnvio,string local,double? latitude,double? longitude)
        {
            this.Id = Guid.NewGuid();
            this.NomeColaborador = nomeColaborador;
            this.RGColaborador = rgColaborador;
            this.ChaveDeAcessoNota = chaveDeAcessoNota;
            this.DataEnvio = dataEnvio;
            this.Local = local ?? local;
            this.Latitude = latitude ?? latitude;
            this.Longitude= longitude ?? longitude;
        }

        public static class EntregaFactory
        {
            public static Entrega EntregaCompleta(Guid id,string nomeColaborador, string rgColaborador, string chaveDeAcessoNota,DateTime dataEnvio, string local, double? latitude, double? longitude,DateTime? sincronizadoEm,bool? sincronizado)
            {
                return new Entrega()
                {
                    Id = id,
                    NomeColaborador = nomeColaborador,
                    RGColaborador = rgColaborador,
                    ChaveDeAcessoNota = chaveDeAcessoNota,
                    DataEnvio = dataEnvio,
                    Local = local ?? local,
                    Latitude = latitude ?? latitude,
                    Longitude = longitude ?? longitude,
                    Sincronizado = sincronizado ?? sincronizado,
                    SincronizadoEm = sincronizadoEm ?? sincronizadoEm

                };
            }
        }

    }
}
