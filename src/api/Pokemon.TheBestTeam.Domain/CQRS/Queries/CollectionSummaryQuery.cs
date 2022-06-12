namespace Pokemon.TheBestTeam.Domain.CQRS.Queries;

public sealed class CollectionSummaryQuery
{
    public int PokemonId { get; set; }
    public int TrainerId { get; set; }
    public DateTime AquisitionDate { get; set; }
    public bool IsFavorite { get; set; }
}
