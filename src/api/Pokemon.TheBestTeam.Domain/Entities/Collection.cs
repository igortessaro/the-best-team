namespace Pokemon.TheBestTeam.Domain.Entities;

public sealed class Collection
{
    public int Id { get; set; }
    public int PokemonId { get; set; }
    public int TrainerId { get; set; }
    public DateTime AquisitionDate { get; set; }
    public bool IsFavorite { get; set; }
}