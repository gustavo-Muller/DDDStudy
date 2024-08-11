using DDDStudy.Domain.Core.Interface.Repositories;
using DDDStudy.Domain.Entities;
using DDDStudy.Infra.Data.Context;

namespace DDDStudy.Infra.Data.Repositories
{
    public class RepositoryExample : RepositoryBase<Example>, IRepositoryExample
    {
        private readonly SqlContext _sqlContext;

        public RepositoryExample(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}
