namespace Pokemon.TheBestTeam.Domain.Entities;

public sealed class Pokemons
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Abilities { get; set; } = string.Empty;
    public string Height { get; set; } =  string.Empty;
    public string Weight { get; set; } =  string.Empty;

}
