using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokemon.TheBestTeam.Domain.Entities;

namespace Pokemon.TheBestTeam.Infrastructure.Repositories.Relational.Configurations;

public sealed class CollectionConfiguration : IEntityTypeConfiguration<Collection>
{
    public void Configure(EntityTypeBuilder<Collection> builder)
    {
        builder.ToTable("collection", "api");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("Id");

        builder.Property(e => e.TrainerId).HasColumnName("TRAINER_ID");
        builder.Property(e => e.PokemonId).HasColumnName("POKEMON_ID");
        builder.Property(e => e.AquisitionDate).HasColumnName("AQUISITION_DATE");
        builder.Property(e => e.IsFavorite).HasColumnName("IS_FAVORITE");
    }
}
