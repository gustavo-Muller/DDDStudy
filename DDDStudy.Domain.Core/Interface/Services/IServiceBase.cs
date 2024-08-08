using System.Linq.Expressions;

namespace DDDStudy.Domain.Core.Interface.Services
{
    public  interface IServiceBase<TEntity>
        where TEntity : class
    {
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
        TEntity GetById(Guid id);
    }
}
