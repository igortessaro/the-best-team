namespace Pokemon.TheBestTeam.Domain.Repositories;

using Pokemon.TheBestTeam.Domain.Entities;

public interface ITrainerPokemonCollectionRepository {
    IEnumerable<TrainerPokemonCollection> GetAll();
    TrainerPokemonCollection GetAllPokemonsByTrainerId(int trainerId);
    TrainerPokemonCollection GetAllTrainersByPokemonId(int pokemonId);
    TrainerPokemonCollection Update(TrainerPokemonCollection collection);
    void Delete(int id);
}