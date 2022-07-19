using Microsoft.EntityFrameworkCore;
using Pokemon.TheBestTeam.Domain.Entities;
using Pokemon.TheBestTeam.Infrastructure.Repositories.Relational.Configurations;
using System.Diagnostics;

namespace Pokemon.TheBestTeam.Infrastructure.Repositories.Relational;

public sealed class TheBestTeamContext : DbContext
{
    public TheBestTeamContext()
    {
    }

    public TheBestTeamContext(DbContextOptions<TheBestTeamContext> options)
        : base(options)
    {
    }

    public DbSet<Domain.Entities.Pokemon>? Pokemons { get; set; }
    public DbSet<Pokedex>? Pokedexs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.LogTo(message => Debug.WriteLine(message));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PokedexConfiguration());
        modelBuilder.ApplyConfiguration(new PokemonConfiguration());
    }
}
