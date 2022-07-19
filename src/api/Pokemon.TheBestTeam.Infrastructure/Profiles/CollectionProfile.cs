using System.Collections.ObjectModel;
using AutoMapper;
using Pokemon.TheBestTeam.Domain.CQRS.Queries;
using Pokemon.TheBestTeam.Domain.Entities;

namespace Pokemon.TheBestTeam.Infrastructure.Profiles;

public sealed class CollectionProfile : Profile
{
    public CollectionProfile()
    {
        CreateMap<Collection, CollectionSummaryQuery>();
        CreateMap<CreateCollectionCommand, Collection>();
    }
}
