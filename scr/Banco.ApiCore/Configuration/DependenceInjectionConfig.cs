using Business.Interfaces;
using Data.Repository;
using Data.Context;

namespace Banco.ApiCore.Configuration
{
    public static class DependenceInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IContaBancariaRepository, Repository>();
            return services;
        }
    }
}
