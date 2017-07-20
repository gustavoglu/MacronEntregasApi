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

        public DateTime DataSincronizacao { get; set; }

        public bool Sincronizado { get; set; }

        protected override bool IsValid()
        {
            return true;
        }
    }
}
