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
        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");

        builder.Property(e => e.TrainerId).HasColumnName("id_trainer");
        builder.Property(e => e.PokemonId).HasColumnName("id_pokemon");
        builder.Property(e => e.IsFavorite).HasColumnName("is_favorite");
        builder.Property(e => e.AquisitionDate).HasColumnName("aquisition_date");
    }
}
