using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokemon.TheBestTeam.Domain.Entities;

namespace Pokemon.TheBestTeam.Infrastructure.Repositories.Relational.Configurations;

public sealed class PokedexConfiguration : IEntityTypeConfiguration<Pokedex>
{
    public void Configure(EntityTypeBuilder<Pokedex> builder)
    {
        builder.ToTable("pokedex", "api");

        builder.HasKey(p => p.Id);

        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("id");

        builder.Property(e => e.Nickname).HasColumnName("nickname").HasColumnType("VARCHAR").HasMaxLength(150).IsRequired();
        builder.Property(e => e.PrimaryType).HasColumnName("primary_type").HasColumnType("VARCHAR").HasMaxLength(50).IsRequired();
        builder.Property(e => e.SecondaryType).HasColumnName("secondary_type").HasColumnType("VARCHAR").HasMaxLength(50);
        builder.Property(e => e.Height).HasColumnName("height").HasColumnType("FLOAT");
        builder.Property(e => e.Weight).HasColumnName("weight").HasColumnType("INT");
        builder.Property(e => e.BaseExp).HasColumnName("base_exp").HasColumnType("INT");
        builder.Property(e => e.Hp).HasColumnName("hp").HasColumnType("INT");
        builder.Property(e => e.Attack).HasColumnName("attack").HasColumnType("INT");
        builder.Property(e => e.Defense).HasColumnName("defense").HasColumnType("INT");
        builder.Property(e => e.SpecialAtack).HasColumnName("special_atk").HasColumnType("INT");
        builder.Property(e => e.SpecialDefense).HasColumnName("special_def").HasColumnType("INT");
        builder.Property(e => e.Speed).HasColumnName("speed").HasColumnType("INT");
        builder.Property(e => e.Artwork).HasColumnName("artwork").HasColumnType("VARCHAR").HasMaxLength(50);
    }
}
