using DDDStudy.Domain.Core.Interface.Repositories;
using DDDStudy.Domain.Core.Interface.Services;
using System.Linq.Expressions;

namespace DDDStudy.Domain.Services
{
    public class ServiceBase<TEntity>(IRepositoryBase<TEntity> repository) : IServiceBase<TEntity>
        where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository = repository;

        public void Add(TEntity entity) => _repository.Add(entity);

        public IEnumerable<TEntity> GetAll() => _repository.GetAll();

        public TEntity GetById(Guid id) => _repository.GetById(id);

        public void Remove(TEntity entity) => _repository.Remove(entity);

        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate) 
            => _repository.Search(predicate);

        public void Update(TEntity entity) => _repository.Update(entity);
    }
}
