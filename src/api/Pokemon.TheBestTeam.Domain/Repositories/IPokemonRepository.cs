using Pokemon.TheBestTeam.Domain.CQRS.Queries;
using Pokemon.TheBestTeam.Domain.Entities;
using Pokemon.TheBestTeam.Domain.Repositories.Core;

namespace Pokemon.TheBestTeam.Domain.Repositories;

public interface IPokemonRepository : IBaseRepository<Pokemons>
{
    Task<IReadOnlyCollection<PokemonSummaryQuery>> GetAllByIdAsync(int id);
    Task<int> AddAsync(PokemonSummaryQuery pokemon);
}