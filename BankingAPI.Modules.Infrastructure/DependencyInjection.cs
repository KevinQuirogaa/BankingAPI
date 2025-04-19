using BankingAPI.Modules.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BankingAPI.Modules.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyI(this IServiceCollection services, IConfiguration configuration)
        {
            // Variable para acceder a la cadena de conexion -> appsetings.json
            // utilizando IConfiguration
            var ConnectionDbString = configuration["ConnectionStrings:BankingDbString"];


            // Registra el contexto de la base de datos 
            // Configura el proveedor de SQL SERVER
            // Habilita qie se genere las migraciones automaticas por comandos
            services.AddDbContext<BankingDbContext>(o =>
                o.UseSqlServer(ConnectionDbString, option =>
                    option.MigrationsAssembly(typeof(BankingDbContext)
                    .Assembly.GetName().Name)
                )
            );

            // Retorna la collecion de servicios
            return services;

        }

    }
}
