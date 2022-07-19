namespace Pokemon.TheBestTeam.Domain.Entities;

public sealed class Pokedex
{
    public int Id { get; set; }
    public string Nickname { get; set; } = string.Empty;
    public string PrimaryType { get; set; } = string.Empty;
    public string SecondaryType { get; set; } = string.Empty;
    public float Height { get; set; }
    public int Weight { get; set; }
    public int BaseExp { get; set; }
    public int Hp { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int SpecialAtack { get; set; }
    public int SpecialDefense { get; set; }
    public int Speed { get; set; }
    public string Artwork { get; set; } = string.Empty;

    public IList<Pokemon> Pokemons { get; set; }
}
