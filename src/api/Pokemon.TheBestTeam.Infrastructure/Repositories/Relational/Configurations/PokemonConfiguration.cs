using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Pokemon.TheBestTeam.Infrastructure.Repositories.Relational.Configurations;

public sealed class PokemonConfiguration : IEntityTypeConfiguration<Domain.Entities.Pokemon>
{
    public void Configure(EntityTypeBuilder<Domain.Entities.Pokemon> builder)
    {
        builder.ToTable("pokemon", "api");

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");

        builder.Property(e => e.Nickname).HasColumnName("nickname").HasColumnType("VARCHAR").HasMaxLength(150).IsRequired();
        builder.Property(e => e.Height).HasColumnName("height").HasColumnType("FLOAT");
        builder.Property(e => e.Weight).HasColumnName("weight").HasColumnType("INT");
        builder.Property(e => e.Level).HasColumnName("level").HasColumnType("INT");
        builder.Property(e => e.IdPokedex).HasColumnName("id_pokedex").HasColumnType("INT");

        builder.HasOne(d => d.Pokedex)
            .WithMany(p => p.Pokemons)
            .HasForeignKey(d => d.IdPokedex)
            .OnDelete(DeleteBehavior.ClientSetNull);
    }
}
