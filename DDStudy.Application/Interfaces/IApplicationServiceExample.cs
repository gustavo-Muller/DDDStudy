using DDStudy.Application.Dtos;
using System.Linq.Expressions;

namespace DDStudy.Application.Interfaces
{
    public interface IApplicationServiceExample
    {
        void Add(ExampleDTO obj);
        void Update(ExampleDTO obj);
        void Remove(ExampleDTO obj);
        IEnumerable<ExampleDTO> GetAll();
        ExampleDTO GetById(Guid id);
        IEnumerable<ExampleDTO> Search(Expression<Func<ExampleDTO, bool>> predicate);
    }
}
