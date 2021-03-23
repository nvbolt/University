using System;
using System.Linq;
using System.Linq.Expressions;
using University.DomainLayer.Entities;

namespace University.DomainLayer.Repositories
{
    public interface IBaseRepository<in TKey, TEntity>
        where TEntity : BaseEntity<TKey>
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

        IQueryable<TEntity> FindByConditionAsync(
            Expression<Func<TEntity, bool>> expression);

        void CommitChanges();
    }
}
