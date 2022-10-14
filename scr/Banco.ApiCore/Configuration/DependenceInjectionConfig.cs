using Business.Notificacoes;
using Business.Interfaces;
using Business.Services;
using Data.Context;
using Data.Repository;

namespace Banco.ApiCore.Configuration
{
    public static class DependenceInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IContaBancariaRepository, ContaBancariaRepository>();
            services.AddScoped<IContaBancariaService, ContaBancariaService>();
            services.AddScoped<INotificador, Notificador>();
            return services;
        }
    }
}
