using System.Linq.Expressions;

namespace DDDStudy.Domain.Core.Interface.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(Guid id);
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
    }
}
