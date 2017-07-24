using Macron.Entregas.Application.ViewModels;
using System;
using System.Collections.Generic;

namespace Macron.Entregas.Application.Interfaces
{
    public interface IEntregaAppService
    {
        void Criar(EntregaViewModel entregaViewModel);
        void Atualizar(EntregaViewModel entregaViewModel);
        EntregaViewModel TrazerPorId(Guid id);
        EntregaViewModel TrazerAtivoPorId(Guid id);
        EntregaViewModel TrazerDeletadoPorId(Guid id);
        void Deletar(Guid id);
        void Reativar(Guid id);
        IEnumerable<EntregaViewModel> TrazerTodos();
        IEnumerable<EntregaViewModel> TrazerTodosAtivos();
        IEnumerable<EntregaViewModel> TrazerTodosDeletados();
        IEnumerable<EntregaViewModel> TrazerPorColaborador(string nomeColagorador);
        IEnumerable<EntregaViewModel> TrazerPorRGColaborador(string rgColaborador);
        IEnumerable<EntregaViewModel> TrazerPorChaveDeAcessoNota(string chaveDeAcessoNota);
        IEnumerable<EntregaViewModel> TrazerPorData(DateTime Data);
        IEnumerable<EntregaViewModel> TrazerPorData(DateTime DataMaior, DateTime DataMenor);
    }
}
