using Macron.Entregas.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Macron.Entregas.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : BaseEntity
    {
        void Criar(T entity);

        void Atualizar(T entity);

        T TrazerPorId(Guid id);

        T TrazerAtivoPorId(Guid id);

        T TrazerDeletadoPorId(Guid id);

        void Deletar(Guid id);

        void Reativar(Guid id);

        IEnumerable<T> Pesquisar(Expression<Func<T,bool>> predicate);

        IEnumerable<T> TrazerTodos();

        IEnumerable<T> TrazerTodosAtivos();

        IEnumerable<T> TrazerTodosDeletados();

    }
}
