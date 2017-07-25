using Macron.Entregas.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Macron.Entregas.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : BaseEntity
    {
        T Criar(T entity);

        T Atualizar(T entity);

        T TrazerPorId(Guid id);

        T TrazerAtivoPorId(Guid id);

        T TrazerDeletadoPorId(Guid id);

        T Deletar(Guid id);

        T Reativar(Guid id);

        IEnumerable<T> Pesquisar(Expression<Func<T,bool>> predicate);

        IEnumerable<T> TrazerTodos();

        IEnumerable<T> TrazerTodosAtivos();

        IEnumerable<T> TrazerTodosDeletados();

    }
}
