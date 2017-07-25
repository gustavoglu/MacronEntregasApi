using FluentValidation;
using Macron.Entregas.Domain.Models.Entregas.Commands;
using System;

namespace Macron.Entregas.Domain.Models.Entregas.Validations
{
    public class EntregaValidation<T> : AbstractValidator<T> where T : BaseEntregaCommand
    {
        protected void ValidaNomeColaborador()
        {

            RuleFor(e => e.NomeColaborador)
                .NotEmpty().WithMessage("Obrigatório informar o nome do Colaborador")
                .Length(2, 150).WithMessage("O nome do Colaborador precisa no minimo ter de 2 caracteres a 150 caracteres");

        }

        protected void ValidaRGColaborador()
        {

            RuleFor(e => e.RGColaborador)
                .NotEmpty().WithMessage("Obrigatório informar o RG do Colaborador")
                .Length(9,9).WithMessage("O RG deve ter 9 caracteres");

        }

        protected void ValidaChaveDeAcessoNota()
        {

            RuleFor(e => e.ChaveDeAcessoNota)
                .NotEmpty().WithMessage("Obrigatório informar a chave de acesso da Nota")
                .Length(44,44).WithMessage("A Chave de acesos deve ter 44 caracteres");

        }

        protected void ValidaDataEnvio()
        {
            RuleFor(e => e.DataEnvio)
                .NotEmpty().WithMessage("Obrigatório informar a Data de Envio");

        }

        protected void ValidaId()
        {

            RuleFor(e => e.Id)
                .NotEqual(Guid.Empty).WithMessage("Obrigatório informar o Id")
                .NotNull().WithMessage("Obrigatório informar o Id");

        }
    }
}
