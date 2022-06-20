using AutoMapper;
using Pokemon.TheBestTeam.Domain.CQRS.Queries;
using Pokemon.TheBestTeam.Domain.Entities;

namespace Pokemon.TheBestTeam.Infrastructure.Profiles;

public sealed class TrainerProfile : Profile
{
    public TrainerProfile()
    {
        CreateMap<Trainer, TrainerSummaryQuery>();
    }
}
