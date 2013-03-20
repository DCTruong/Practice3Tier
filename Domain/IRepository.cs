using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain
{
    public interface IRepository<TEntity> : IDisposable where TEntity : IEntity
    {
        IQueryable<TEntity> GetAll();
        void Delete(TEntity entity);
        void Add(TEntity entity);
    }
    public interface IEntity
    {
        int Id { get; set; }
    }
}
