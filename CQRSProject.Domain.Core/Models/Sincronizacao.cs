using System;

namespace CQRSProject.Domain.Core.Models
{
    public class Sincronizacao
    {
        public DateTime DataSincronizacao { get; set; }

        public bool Sincronizado { get; set; }
    }
}
