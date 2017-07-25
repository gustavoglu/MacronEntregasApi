using Macron.Entregas.Domain.Core.Commands;
using System;

namespace Macron.Entregas.Domain.Models.Entregas.Commands
{
    public abstract class BaseEntregaCommand : Command
    {
        public Guid? Id { get; protected set; }

        public string NomeColaborador { get; protected set; }

        public string RGColaborador { get; protected set; }

        public string ChaveDeAcessoNota { get; protected set; }

        public DateTime DataEnvio { get; protected set; }

        public string Local { get; protected set; } = null;

        public double? Latitude { get; protected set; }

        public double? Longitude { get; protected set; }

        public bool? Sincronizado { get; protected set; }

        public DateTime? SincronizadoEm { get; protected set; }
    }
}
