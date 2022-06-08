namespace Pokemon.TheBestTeam.Api.Models;
public class TrainerPokemonCollection
{
    public int PokemonId { get; set; }
    public int TrainerId { get; set; }
    public int AquisitionDate { get; set; }
    public bool IsFavorite { get; set; }
}