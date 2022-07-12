namespace Pokemon.TheBestTeam.Domain.Entities;

public sealed class Pokemon
{
    public int Id { get; set; }
    public string Nickname { get; set; } = string.Empty;
    public float Height { get; set; }
    public int Weight { get; set; }
    public int Level { get; set; }
    public int IdPokedex { get; set; }

    public Pokedex Pokedex { get; set; }
}
