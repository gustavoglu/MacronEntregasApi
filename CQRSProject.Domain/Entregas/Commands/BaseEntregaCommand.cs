using CQRSProject.Domain.Core.Commands;
using System;

namespace CQRSProject.Domain.Entregas.Commands
{
    public abstract class BaseEntregaCommand : Command
    {
        public Guid Id { get; set; }

        public string NomeColaborador { get; protected set; } = null;

        public string RGColaborador { get; protected set; } = null;

        public DateTime? DataEnvio { get; protected set; }

        public string ChaveDeAcessoNota { get; protected set; } = null;

        public double? Latitude { get; protected  set; }

        public double? Longitude { get; protected set; }

        public string Local { get; protected set; } = null;

        public DateTime DataSincronizacao { get; protected set; }

        public bool Sincronizado { get; protected set; }

    }
}
