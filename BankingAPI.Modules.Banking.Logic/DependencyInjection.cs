using BankingAPI.Modules.Banking.Logic.Interfaces;
using BankingAPI.Modules.Banking.Logic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BankingAPI.Modules.Banking.Logic
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyL(this IServiceCollection services)
        {
            // Agregar la instancia en el contenedor de servicios
            services.AddScoped<ICustomerService, CustomerService>();

            // Retornar los servicios
            return services;
        }
    }
}
