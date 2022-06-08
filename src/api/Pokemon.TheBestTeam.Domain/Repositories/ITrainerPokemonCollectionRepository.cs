namespace Pokemon.TheBestTeam.Domain.Repositories;

using Pokemon.TheBestTeam.Domain.Entities;

public interface ITrainerPokemonCollectionRepository
{
    IEnumerable<TrainerPokemonCollection> Create(int pokemonId, int trainerId);
    IEnumerable<Pokemon> GetAllPokemonsByTrainerId(int trainerId);
    TrainerPokemonCollection Update(TrainerPokemonCollection collection);
    void Delete(int id);
}