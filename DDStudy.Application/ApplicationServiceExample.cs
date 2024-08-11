using AutoMapper;
using DDDStudy.Domain.Core.Interface.Services;
using DDDStudy.Domain.Entities;
using DDStudy.Application.Dtos;
using DDStudy.Application.Interfaces;
using System.Linq.Expressions;

namespace DDStudy.Application
{
    public class ApplicationServiceExample : IApplicationServiceExample
    {
        private readonly IServiceExample _service;
        private readonly IMapper _mapper;

        public ApplicationServiceExample(
            IServiceExample service,
            IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public void Add(ExampleDTO obj) => _service.Add(_mapper.Map<Example>(obj));
        public void Update(ExampleDTO obj) => _service.Update(_mapper.Map<Example>(obj));
        public void Remove(ExampleDTO obj) => _service.Remove(_mapper.Map<Example>(obj));
        public IEnumerable<ExampleDTO> GetAll() => _mapper.Map<IEnumerable<ExampleDTO>>(_service.GetAll());
        public ExampleDTO GetById(Guid id)=> _mapper.Map<ExampleDTO>(_service.GetById(id));


        //TODO - Predicate mapper
        public IEnumerable<ExampleDTO> Search(Expression<Func<ExampleDTO, bool>> predicate)
        {
            throw new NotImplementedException();
            //return _mapper.Map<IEnumerable<ExampleDTO>>(_service.Search(predicate));
        }

    }
}
