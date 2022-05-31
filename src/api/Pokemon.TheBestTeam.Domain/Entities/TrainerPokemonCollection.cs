namespace Pokemon.TheBestTeam.Domain.Entities
{
    public class TrainerPokemonCollection
    {
        public TrainerPokemonCollection(int id, int pokemonId, int trainerId, int aquisitionDate)
        {
            this.Id = id;
            this.PokemonId = pokemonId;
            this.TrainerId = trainerId;
            this.AquisitionDate = aquisitionDate;
        }

        public TrainerPokemonCollection(int id)
        {
            this.Id = id;
        }

        public TrainerPokemonCollection() { }

        public int Id { get; set; }
        public int PokemonId { get; set; }
        public int TrainerId { get; set; }
        public int AquisitionDate { get; set; }
    }


}