using AutoMapper;
using Macron.Entregas.Application.ViewModels;
using Macron.Entregas.Domain.Models.Entregas;

namespace Macron.Entregas.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Entrega, EntregaViewModel>();
        }
    }
}
