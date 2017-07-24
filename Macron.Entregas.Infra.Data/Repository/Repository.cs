using Macron.Entregas.Domain.Core.Models;
using Macron.Entregas.Domain.Interfaces;
using Macron.Entregas.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Macron.Entregas.Infra.Data.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {

        protected readonly EntregasContext Db;
        protected readonly DbSet<T> DbSet;

        public Repository()
        {
            Db = new EntregasContext();
            DbSet = Db.Set<T>();
        }

        public virtual T Atualizar(T entity)
        {
            DbSet.Update(entity);
            return DbSet.Find(entity);
        }

        public virtual T Criar(T entity)
        {
            DbSet.Add(entity);
            return DbSet.Find(entity);

        }

        public virtual T Deletar(Guid id)
        {
            var entity = TrazerPorId(id);

            DbSet.Remove(entity);

            return DbSet.Find(id);
        }

        public virtual T Reativar(Guid id)
        {
            var entity = TrazerPorId(id);
            entity.Deletado = false;
            var entityAtualizada = Atualizar(entity);

            return entityAtualizada;
        }

        public virtual T TrazerAtivoPorId(Guid id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(e => e.Id == id && e.Deletado == false);
        }

        public virtual T TrazerDeletadoPorId(Guid id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(e => e.Id == id && e.Deletado == true);
        }

        public virtual T TrazerPorId(Guid id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(e => e.Id == id);
        }

        public virtual IEnumerable<T> TrazerTodos()
        {
            return DbSet.ToList();
        }

        public virtual IEnumerable<T> TrazerTodosAtivos()
        {
            return DbSet.Where(e => e.Deletado == false).ToList();
        }

        public virtual IEnumerable<T> TrazerTodosDeletados()
        {
            return DbSet.Where(e => e.Deletado == true).ToList();
        }

        public IEnumerable<T> Pesquisar(Expression<Func<T, bool>> predicate)
        {
            return DbSet.Where(predicate).ToList();
        }

        public virtual void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

 
    }
}
