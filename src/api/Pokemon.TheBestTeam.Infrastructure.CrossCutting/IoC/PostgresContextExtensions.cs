using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pokemon.TheBestTeam.Infrastructure.Repositories.Relational;

namespace Microsoft.Extensions.DependencyInjection;

public static class PostgresContextExtensions
{
    public static IServiceCollection AddPostgresDbContext(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("TheBestTeamDb");

        _ = services.AddDbContext<TheBestTeamContext>(options =>
        {
            _ = options.UseNpgsql(connectionString);
        });

        return services;
    }
}
