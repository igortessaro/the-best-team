using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pokemon.TheBestTeam.Domain.CQRS.Queries;
using Pokemon.TheBestTeam.Domain.Entities;
using Pokemon.TheBestTeam.Domain.Repositories;
using Pokemon.TheBestTeam.Infrastructure.Repositories.Relational.Core;
using System.Collections.ObjectModel;

namespace Pokemon.TheBestTeam.Infrastructure.Repositories.Relational;

public sealed class TrainerRepository : BaseRepository<Trainer>, ITrainerRepository
{
    public TrainerRepository(TheBestTeamContext context, IMapper mapper)
        : base(context, mapper)
    {
    }

    public async Task<IReadOnlyCollection<TrainerSummaryQuery>> GetAllAsync()
    {
        var result = await this.Query<TrainerSummaryQuery>().Take(10).ToListAsync();

        return new ReadOnlyCollection<TrainerSummaryQuery>(result);
    }
}
