using BankingAPI.Modules.Banking.BO.Contracts;
using BankingAPI.Modules.Banking.Infrastructure.Data;
using BankingAPI.Modules.Banking.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BankingAPI.Modules.Banking.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyI(this IServiceCollection services, IConfiguration configuration)
        {
            // Agrega la instancia al contenedor de servicios
            services.AddTransient<IUoWConfig, UnitOfWorkConfig>();

            // Acceder a la cadena de conexion utilizando IConfiguration
            var connectionString = configuration["ConnectionStrings:ConnectionDB"];

            // Configurar el DbContext con SQL Server
            services.AddDbContext<BankingDbContext>(o =>
                o.UseSqlServer(connectionString, option =>
                    option.MigrationsAssembly(typeof(BankingDbContext).Assembly.GetName().Name)
                )
            );

            // Retornar los servicios
            return services;
        }
    }
}
