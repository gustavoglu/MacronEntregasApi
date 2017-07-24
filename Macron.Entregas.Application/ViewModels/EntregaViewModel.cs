using System;
using System.ComponentModel.DataAnnotations;

namespace Macron.Entregas.Application.ViewModels
{
    public class EntregaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o Nome do Colaborador")]
        [MaxLength(150,ErrorMessage = "")]
        public string NomeColaborador { get; private set; }

        [Required(ErrorMessage = "Obrigatório informar o RG do Colaborador")]
        [MaxLength(9, ErrorMessage = "Um RG tem 9 Digitos")]
        [MinLength(9, ErrorMessage = "Um RG tem 9 Digitos")]
        public string RGColaborador { get; private set; }

        [Required(ErrorMessage = "Obrigatório informar a Chave de Acesso da Nota Fiscal")]
        [MaxLength(44, ErrorMessage = "Uma Chave de Acesso tem 44 Digitos")]
        [MinLength(44, ErrorMessage = "Uma Chave de Acesso tem 44 Digitos")]
        public string ChaveDeAcessoNota { get; private set; }

        public DateTime DataEnvio { get; private set; }

        public string Local { get; private set; } = null;

        public double? Latitude { get; private set; }

        public double? Longitude { get; private set; }

        public bool? Sincronizado { get; private set; }

        public DateTime? SincronizadoEm { get; private set; }
    }
}
