using CQRSProject.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CQRSProject.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : BaseEntity<T>
    {
        T Criar(T entity);

        T Atualizar(T entity);

        T TrazerPorId(Guid id);

        T TrazerAtivoPorId(Guid id);

        T TrazerDeletadoPorId(Guid id);

        T Deletar(Guid id);

        T Reativar(Guid id);

        IEnumerable<T> PesquisarTodos(Expression<Func<T,bool>> predicate);

        IEnumerable<T> PesquisarEmAtivos(Expression<Func<T, bool>> predicate);

        IEnumerable<T> PesquisarEmDeletados(Expression<Func<T, bool>> predicate);

        IEnumerable<T> TrazerTodos();

        IEnumerable<T> TrazerTodosAtivos();

        IEnumerable<T> TrazerTodosDeletados();

    }
}
