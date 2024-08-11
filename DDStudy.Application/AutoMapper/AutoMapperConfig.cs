using AutoMapper;
using DDDStudy.Domain.Entities;
using DDStudy.Application.Dtos;
using Microsoft.Extensions.DependencyInjection;

namespace DDStudy.Application.AutoMapper
{
    //TODO
    public class AutoMapperConfig
    {
        public AutoMapperConfig(IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ExampleDTO, Example>().ReverseMap();
            });

            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
