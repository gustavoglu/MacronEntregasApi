using CQRSProject.Domain.Entregas.Commands;
using FluentValidation;
using System;

namespace CQRSProject.Domain.Entregas.Validations
{
    public abstract class EntregaValidation<T> : AbstractValidator<T> where T : BaseEntregaCommand
    {
        protected void ValidaNomeColaborador()
        {
            RuleFor(e => e.NomeColaborador)
                .NotEmpty().WithMessage("")
                .Length(2, 150).WithMessage("");

        }

        protected void ValidaRGColaborador()
        {
            RuleFor(e => e.RGColaborador)
                .NotEmpty().WithMessage("")
                .Length(9).WithMessage("");

        }

        protected void ValidaChaveDeAcessoNota()
        {
            RuleFor(e => e.ChaveDeAcessoNota)
                .NotEmpty().WithMessage("")
                .Length(44).WithMessage("");
        }

        protected void ValidaId()
        {
            RuleFor(e => e.Id)
                .NotEqual(Guid.Empty).WithMessage("")
                .NotNull().WithMessage("");
        }
    }
}
