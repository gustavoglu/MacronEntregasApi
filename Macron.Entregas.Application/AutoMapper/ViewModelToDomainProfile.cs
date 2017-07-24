using AutoMapper;
using Macron.Entregas.Application.ViewModels;
using Macron.Entregas.Domain.Models.Entregas.Commands;

namespace Macron.Entregas.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            #region Entregas

            CreateMap<EntregaViewModel, CriarEntregaCommand>()
                .ConstructUsing(e => new CriarEntregaCommand(e.NomeColaborador, e.RGColaborador, e.ChaveDeAcessoNota, e.DataEnvio, e.Local, e.Latitude, e.Longitude));
            CreateMap<EntregaViewModel, AtualizarEntregaCommand>()
                .ConstructUsing(e => new AtualizarEntregaCommand(e.Id, e.NomeColaborador, e.RGColaborador, e.ChaveDeAcessoNota, e.DataEnvio, e.Local, e.Latitude, e.Longitude, e.SincronizadoEm, e.Sincronizado));
            CreateMap<EntregaViewModel, DeletarEntregaCommand>()
               .ConstructUsing(e => new DeletarEntregaCommand(e.Id));
            CreateMap<EntregaViewModel, ReativarEntregaCommand>()
               .ConstructUsing(e => new ReativarEntregaCommand(e.Id));

            #endregion
        }
    }
}
