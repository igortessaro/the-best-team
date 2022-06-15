namespace Pokemon.TheBestTeam.Domain.Entities;

public sealed class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int Number { get; set; }
}
