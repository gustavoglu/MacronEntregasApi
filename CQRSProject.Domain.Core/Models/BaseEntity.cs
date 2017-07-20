using System;

namespace CQRSProject.Domain.Core.Models
{
    public abstract class BaseEntity<T>
    {
        public Guid? Id { get; set; }

        public string CriadoPor { get; set; } = null;

        public string AtualizadoPor { get; set; } = null;

        public string DeletadoPor { get; set; } = null;

        public DateTime? CriadoEm { get; set; }

        public DateTime? AtualizadoEm { get; set; }

        public DateTime? DeletadoEm { get; set; }

        public bool Deletado { get; set; }

        protected abstract bool IsValid();
    }
}
