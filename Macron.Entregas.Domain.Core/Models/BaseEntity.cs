using System;

namespace Macron.Entregas.Domain.Core.Models
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime? CriadoEm { get; set; }

        public DateTime? AtualizadoEm { get; set; }

        public DateTime? DeletadoEm { get; set; }

        public string CriadoPor { get; set; } = null;

        public string AtualizadoPor { get; set; } = null;

        public string DeletadoPor { get; set; } = null;

        public bool? Deletado { get; set; }

        protected BaseEntity()
        {
            this.Id = Guid.NewGuid();
        }

    }
}
