using System.Collections.ObjectModel;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Pokemon.TheBestTeam.Domain.CQRS.Queries;
using Pokemon.TheBestTeam.Domain.Entities;
using Pokemon.TheBestTeam.Domain.Repositories;
using Pokemon.TheBestTeam.Infrastructure.Repositories.Relational.Core;

namespace Pokemon.TheBestTeam.Infrastructure.Repositories.Relational;

public sealed class CollectionRepository : BaseRepository<Collection>, ICollectionRepository
{
    private TheBestTeamContext _context;
    public CollectionRepository(TheBestTeamContext context, IMapper mapper)
        : base(context, mapper)
    {
        _context = context;
    }

    public Task<int> AddAsync(CreateCollectionCommand command)
    {
        var collection = new Collection
        {
            TrainerId = command.TrainerId,
            PokemonId = command.PokemonId,
            AquisitionDate = DateTime.UtcNow,
            IsFavorite = false,
        };

        return this.AddAsync(collection);
    }

    public async Task<IReadOnlyCollection<CollectionSummaryQuery>> GetAllByTrainerIdAsync(int id)
    {
        var result = await this.Query<CollectionSummaryQuery>(collection => collection.TrainerId == id).Take(10).ToListAsync();

        return new ReadOnlyCollection<CollectionSummaryQuery>(result);
    }
}
