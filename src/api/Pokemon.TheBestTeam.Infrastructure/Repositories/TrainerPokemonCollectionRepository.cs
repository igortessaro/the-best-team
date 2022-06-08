using Pokemon.TheBestTeam.Domain.Entities;
using Pokemon.TheBestTeam.Domain.Repositories;

namespace Pokemon.TheBestTeam.Infrastructure.Repositories
{
    public class TrainerPokemonCollectionRepository : ITrainerPokemonCollectionRepository
    {
        private readonly PokemonContext _context;

        public TrainerPokemonCollectionRepository(PokemonContext context)
        {
            _context = context;
        }

        public IEnumerable<TrainerPokemonCollection> Create(int pokemonId, int trainerId)
        {
            var collection = new TrainerPokemonCollection(pokemonId, trainerId);
            _context.TrainerPokemonCollections.Add(collection);
            _context.SaveChanges();
            return _context.TrainerPokemonCollections.Where(x => x.TrainerId == trainerId);
        }

        public TrainerPokemonCollection GetAllPokemonsByTrainerId(int trainerId)
        {
            return _context.TrainerPokemonCollections.Where(x => x.TrainerId == trainerId);
        }

        public TrainerPokemonCollection Update(TrainerPokemonCollection collection)
        {
            _context.TrainerPokemonCollections.Update(collection);
            _context.SaveChanges();
            return collection;
        }

        public void Delete(int id)
        {
            var collection = _context.TrainerPokemonCollections.Find(id);
            _context.TrainerPokemonCollections.Remove(collection);
            _context.SaveChanges();
        }

        IEnumerable<TrainerPokemonCollection> ITrainerPokemonCollectionRepository.Create(int pokemonId, int trainerId)
        {
            throw new NotImplementedException();
        }

        TrainerPokemonCollection ITrainerPokemonCollectionRepository.GetAllPokemonsByTrainerId(int trainerId)
        {
            throw new NotImplementedException();
        }

        public TrainerPokemonCollection Update(TrainerPokemonCollection collection)
        {
            throw new NotImplementedException();
        }
    }
}