using Macron.Entregas.Application.Interfaces;
using System;
using System.Collections.Generic;
using Macron.Entregas.Application.ViewModels;
using Macron.Entregas.Domain.Interfaces.EntityRepository;
using AutoMapper;
using Macron.Entregas.Domain.Core.Bus;
using Macron.Entregas.Domain.Models.Entregas.Commands;

namespace Macron.Entregas.Application.Services
{
    public class EntregaAppService : IEntregaAppService
    {
        private readonly IEntregaRepository _entregaRepository;
        private readonly IMapper _mapper;
        private readonly IBus _bus;

        public EntregaAppService(IEntregaRepository entregaRepository, IMapper mapper, IBus bus)
        {
            _entregaRepository = entregaRepository;
            _mapper = mapper;
            _bus = bus;
        }

        public void Atualizar(EntregaViewModel entregaViewModel)
        {
            var atualizarCommand = _mapper.Map<AtualizarEntregaCommand>(entregaViewModel);
            _bus.SendCommand(atualizarCommand);
        }

        public void Criar(EntregaViewModel entregaViewModel)
        {
            var criarCommand = _mapper.Map<CriarEntregaCommand>(entregaViewModel);
            _bus.SendCommand(criarCommand);
        }

        public void Deletar(Guid id)
        {
            var deletarCommand = new DeletarEntregaCommand(id);
            _bus.SendCommand(deletarCommand);
        }

        public void Reativar(Guid id)
        {
             var reativarCommand = new ReativarEntregaCommand(id);
            _bus.SendCommand(reativarCommand);
        }

        public EntregaViewModel TrazerAtivoPorId(Guid id)
        {
            return _mapper.Map<EntregaViewModel>(_entregaRepository.TrazerAtivoPorId(id));
        }

        public EntregaViewModel TrazerDeletadoPorId(Guid id)
        {
            return _mapper.Map<EntregaViewModel>(_entregaRepository.TrazerDeletadoPorId(id));
        }

        public IEnumerable<EntregaViewModel> TrazerPorChaveDeAcessoNota(string chaveDeAcessoNota)
        {
            return _mapper.Map<IEnumerable<EntregaViewModel>>(_entregaRepository.Pesquisar(e => e.ChaveDeAcessoNota == chaveDeAcessoNota));
        }

        public IEnumerable<EntregaViewModel> TrazerPorColaborador(string nomeColagorador)
        {
            return _mapper.Map<IEnumerable<EntregaViewModel>>(_entregaRepository.Pesquisar(e => e.NomeColaborador == nomeColagorador));
        }

        public IEnumerable<EntregaViewModel> TrazerPorData(DateTime Data)
        {
            return _mapper.Map<IEnumerable<EntregaViewModel>>(_entregaRepository.Pesquisar(e => e.CriadoEm == Data));
        }

        public IEnumerable<EntregaViewModel> TrazerPorData(DateTime DataIni, DateTime DataFim)
        {
            return _mapper.Map<IEnumerable<EntregaViewModel>>(_entregaRepository.Pesquisar(e => e.CriadoEm >= DataIni && e.CriadoEm <= DataFim));
        }

        public EntregaViewModel TrazerPorId(Guid id)
        {
            return _mapper.Map<EntregaViewModel>(_entregaRepository.TrazerPorId(id));
        }

        public IEnumerable<EntregaViewModel> TrazerPorRGColaborador(string rgColaborador)
        {
            return _mapper.Map<IEnumerable<EntregaViewModel>>(_entregaRepository.Pesquisar(e => e.RGColaborador == rgColaborador));
        }

        public IEnumerable<EntregaViewModel> TrazerTodos()
        {
            return _mapper.Map<IEnumerable<EntregaViewModel>>(_entregaRepository.TrazerTodos());
        }

        public IEnumerable<EntregaViewModel> TrazerTodosAtivos()
        {
            return _mapper.Map<IEnumerable<EntregaViewModel>>(_entregaRepository.TrazerTodosAtivos());
        }

        public IEnumerable<EntregaViewModel> TrazerTodosDeletados()
        {
            return _mapper.Map<IEnumerable<EntregaViewModel>>(_entregaRepository.TrazerTodosDeletados());
        }
    }
}
