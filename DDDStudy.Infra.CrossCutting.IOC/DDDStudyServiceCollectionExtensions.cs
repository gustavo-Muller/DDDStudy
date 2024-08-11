using DDDStudy.Domain.Core.Interface.Repositories;
using DDDStudy.Domain.Core.Interface.Services;
using DDDStudy.Domain.Services;
using DDDStudy.Infra.Data.Context;
using DDDStudy.Infra.Data.Repositories;
using DDStudy.Application;
using DDStudy.Application.AutoMapper;
using DDStudy.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DDDStudy.Infra.CrossCutting.IOC
{
    public static class DDDStudyServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryExample, RepositoryExample>();

            return services;
        }

        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<IApplicationServiceExample, ApplicationServiceExample>();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IServiceExample, ServiceExample>();

            return services;
        }


        //TODO - NullException
        public static IServiceCollection AddContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<SqlContext>(options => options.UseSqlServer(connectionString));

            new AutoMapperConfig(services);

            return services;
        }
    }
}
