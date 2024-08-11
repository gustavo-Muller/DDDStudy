using DDDStudy.Domain.Core.Interface.Repositories;
using DDDStudy.Domain.Core.Interface.Services;
using DDDStudy.Domain.Entities;

namespace DDDStudy.Domain.Services
{
    public class ServiceExample : ServiceBase<Example>, IServiceExample
    {
        private readonly IRepositoryExample _repository;

        public ServiceExample(IRepositoryExample repository) 
            : base(repository)
        {
            _repository = repository;
        }
    }
}
