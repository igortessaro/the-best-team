using Microsoft.Extensions.DependencyInjection;
using Pokemon.TheBestTeam.Infrastructure.Profiles;

namespace Pokemon.TheBestTeam.Infrastructure.CrossCutting.IoC;

public static class AutoMapperServiceColletionExtensions
{
    public static IServiceCollection AddInfrastructureAutoMapper(this IServiceCollection services)
    {
        _ = services.AddAutoMapper(x => x.AddProfile<TrainerProfile>());
        _ = services.AddAutoMapper(x => x.AddProfile<CollectionProfile>());
        _ = services.AddAutoMapper(x => x.AddProfile<PokedexProfile>());

        return services;
    }
}
