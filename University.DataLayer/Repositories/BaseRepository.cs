using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using University.DomainLayer.Entities;
using University.DomainLayer.Repositories;


namespace University.DataLayer.Repositories
{
    internal abstract class BaseRepository<TKey, TEntity> : IBaseRepository<TKey, TEntity>
        where TEntity : BaseEntity<TKey>
    {
        protected DbSet<TEntity> Data { get; }

        public BaseRepository(VuDbContext dbContext)
        {
            Data = dbContext.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            this.Data.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            this.Data.Remove(entity);
        }

        public virtual IQueryable<TEntity> FindByConditionAsync(Expression<Func<TEntity, bool>> expression)
        {
            return this.Data.AsNoTracking().Where(expression);
        }

        public void Update(TEntity entity)
        {
            this.Data.Update(entity);
        }

        public void CommitChanges()
        {
            throw new NotImplementedException();
        }
    }
}
