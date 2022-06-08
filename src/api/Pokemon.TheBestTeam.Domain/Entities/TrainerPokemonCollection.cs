using System;
namespace Pokemon.TheBestTeam.Domain.Entities
{
    public class TrainerPokemonCollection
    {
        public TrainerPokemonCollection(int pokemonId, int trainerId)
        {
            this.Id = new Guid();
            this.PokemonId = pokemonId;
            this.TrainerId = trainerId;
            this.AquisitionDate = DateTime.Now;
            this.IsFavorite = false;
        }

        public TrainerPokemonCollection() { }

        public Guid Id { get; set; }
        public Pokemon Pokemon { get; set; }
        public Trainer Trainer { get; set; }
        public int PokemonId { get; set; }
        public int TrainerId { get; set; }
        public DateTime AquisitionDate { get; set; }
        public bool IsFavorite { get; set; }
    }
}