using AutoMapper;
using Pokemon.TheBestTeam.Domain.CQRS.Commands;
using Pokemon.TheBestTeam.Domain.Entities;

namespace Pokemon.TheBestTeam.Infrastructure.Profiles;

public sealed class PokedexProfile : Profile
{
    public PokedexProfile()
    {
        CreateMap<AddPokemonOnPokedexCommand, Pokedex>();
    }
}
