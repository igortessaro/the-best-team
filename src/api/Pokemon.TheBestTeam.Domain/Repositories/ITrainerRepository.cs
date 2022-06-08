using Pokemon.TheBestTeam.Domain.CQRS.Queries;
using Pokemon.TheBestTeam.Domain.Entities;
using Pokemon.TheBestTeam.Domain.Repositories.Core;

namespace Pokemon.TheBestTeam.Domain.Repositories;

public interface ITrainerRepository : IBaseRepository<Trainer>
{
    Task<IReadOnlyCollection<TrainerSummaryQuery>> GetAllAsync();
}
