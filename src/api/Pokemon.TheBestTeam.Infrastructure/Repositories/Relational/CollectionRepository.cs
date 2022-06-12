using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pokemon.TheBestTeam.Domain.CQRS.Queries;
using Pokemon.TheBestTeam.Domain.Entities;
using Pokemon.TheBestTeam.Domain.Repositories;
using Pokemon.TheBestTeam.Infrastructure.Repositories.Relational.Core;
using System.Collections.ObjectModel;

namespace Pokemon.TheBestTeam.Infrastructure.Repositories.Relational;

public sealed class CollectionRepository : BaseRepository<Collection>, ICollectionRepository
{
    public CollectionRepository(TheBestTeamContext context, IMapper mapper)
        : base(context, mapper)
    {
    }

    public async Task<IReadOnlyCollection<CollectionSummaryQuery>> GetAllByTrainerIdAsync(int id)
    {
        var result = await this.Query<CollectionSummaryQuery>(collection => collection.TrainerId == id).Take(10).ToListAsync();

        return new ReadOnlyCollection<CollectionSummaryQuery>(result);
    }
}
