using AutoMapper;
using Pokemon.TheBestTeam.Domain.CQRS.Commands;
using Pokemon.TheBestTeam.Domain.Entities;
using Pokemon.TheBestTeam.Domain.Repositories;
using Pokemon.TheBestTeam.Infrastructure.Repositories.Relational.Core;

namespace Pokemon.TheBestTeam.Infrastructure.Repositories.Relational;

public sealed class PokedexRepository : BaseRepository<Pokedex>, IPokedexRepository
{
    public PokedexRepository(TheBestTeamContext context, IMapper mapper)
        : base(context, mapper)
    {
    }

    public Task<int> AddAsync(AddPokemonOnPokedexCommand pokemon)
    {
        var pokemonToCreate = base._mapper.Map<Pokedex>(pokemon);

        return this.AddAsync(pokemonToCreate);
    }
}
