using Microsoft.Extensions.DependencyInjection;
using Pokemon.TheBestTeam.Domain.Repositories;
using Pokemon.TheBestTeam.Infrastructure.Repositories.Relational;

namespace Pokemon.TheBestTeam.Infrastructure.CrossCutting.IoC;

public static class RelationalRepositoryServiceColletionExtensions
{
    public static IServiceCollection AddRelationalRepository(this IServiceCollection services)
    {
        _ = services.AddScoped<ITrainerRepository, TrainerRepository>();
        _ = services.AddScoped<ICollectionRepository, CollectionRepository>();
        _ = services.AddScoped<IPokedexRepository, PokedexRepository>();

        return services;
    }
}
