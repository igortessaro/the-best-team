namespace Pokemon.TheBestTeam.Domain.CQRS.Queries;

public sealed class CreateCollectionCommand
{
    public int PokemonId { get; set; }
    public int TrainerId { get; set; }
}
