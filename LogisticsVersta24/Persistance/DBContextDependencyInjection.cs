using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace LogisticsVersta24.Persistance
{
    public static class DBContextDependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configration)
        {
            var connectionString = configration["DbConnection"];
            services.AddDbContext<ApplicationDBcontext, ApplicationDBcontext>(
                options =>
                    {
                        options.UseSqlite(connectionString);
                    },
                ServiceLifetime.Scoped);
            return services;
        }
    }
}
