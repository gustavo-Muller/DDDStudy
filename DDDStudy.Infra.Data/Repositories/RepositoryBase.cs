using DDDStudy.Domain.Core.Interface.Repositories;
using DDDStudy.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DDDStudy.Infra.Data.Repositories
{
    //TODO - There is a better way to do all this thing!!
    public class RepositoryBase<TEntity>(SqlContext sqlContext) : IRepositoryBase<TEntity>
        where TEntity : class
    {

        private readonly SqlContext _sqlContext = sqlContext;

        public void Add(TEntity entity)
        {
            try
            {
                _sqlContext.Set<TEntity>().Add(entity);
                _sqlContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TEntity> GetAll() => _sqlContext.Set<TEntity>().Take(100).ToList();

        //TODO - NullException
        public TEntity GetById(Guid id) => _sqlContext.Set<TEntity>().Find(id);

        public void Remove(TEntity entity)
        {
            try
            {
                _sqlContext.Set<TEntity>().Remove(entity);
                _sqlContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate) 
            => _sqlContext.Set<TEntity>().Where(predicate);

        public void Update(TEntity entity)
        {
            try
            {
                _sqlContext.Entry(entity).State = EntityState.Modified;
                _sqlContext.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
