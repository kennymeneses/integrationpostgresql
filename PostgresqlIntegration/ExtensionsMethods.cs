using DataAccess;
using Microsoft.EntityFrameworkCore;

namespace PostgresqlIntegration
{
    public static class ExtensionsMethods
    {
        public static IServiceCollection AddMyDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("PostgresqlConnection");
            services.AddDbContext<BetDbContext>(options =>
                options.UseNpgsql(connectionString));

            return services;
        }
    }
}
