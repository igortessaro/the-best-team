using Pokemon.TheBestTeam.Domain.CQRS.Commands;

namespace Pokemon.TheBestTeam.Domain.Repositories;

public interface IPokedexRepository
{
    Task<int> AddAsync(AddPokemonOnPokedexCommand pokemon);
}
