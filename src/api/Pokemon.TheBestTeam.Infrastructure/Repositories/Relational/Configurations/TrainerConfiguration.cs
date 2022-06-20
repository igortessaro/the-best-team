using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokemon.TheBestTeam.Domain.Entities;

namespace Pokemon.TheBestTeam.Infrastructure.Repositories.Relational.Configurations;

public sealed class TrainerConfiguration : IEntityTypeConfiguration<Trainer>
{
    public void Configure(EntityTypeBuilder<Trainer> builder)
    {
        builder.ToTable("trainer", "api");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).ValueGeneratedOnAdd().HasColumnName("Id");

        builder.Property(e => e.Password).HasColumnName("password");
        builder.Property(e => e.Name).HasColumnName("name");
        builder.Property(e => e.NickName).HasColumnName("nickname");
        builder.Property(e => e.Email).HasColumnName("email");
    }
}
