using System.Linq.Expressions;

namespace Pokemon.TheBestTeam.Domain.Repositories.Core;

public interface IBaseRepository<TEntity> where TEntity : class
{
    IQueryable<TEntity> Query(int take = 100);
    IQueryable<TProjetion> Query<TProjetion>(Expression<Func<TEntity, bool>> predicate) where TProjetion : class;
    IQueryable<TProjetion> Query<TProjetion>() where TProjetion : class;
}
