using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Pokemon.TheBestTeam.Domain.Repositories.Core;
using System.Linq.Expressions;

namespace Pokemon.TheBestTeam.Infrastructure.Repositories.Relational.Core;

public abstract class BaseRepository<TEntity> : IDisposable, IBaseRepository<TEntity> where TEntity : class
{
    protected readonly IMapper _mapper;
    private bool _disposed = false;
    private readonly TheBestTeamContext _context;
    private readonly DbSet<TEntity> _dbSet;

    protected BaseRepository(TheBestTeamContext context, IMapper mapper)
    {
        this._context = context;
        this._dbSet = this._context.Set<TEntity>();
        this._mapper = mapper;
    }

    public IQueryable<TEntity> Query(int take = 100) => this._dbSet.AsNoTracking();

    public IQueryable<TProjetion> Query<TProjetion>(Expression<Func<TEntity, bool>> predicate) where TProjetion : class
    {
        return this.Query()
            .Where(predicate)
            .ProjectTo<TProjetion>(this._mapper.ConfigurationProvider);
    }

    public IQueryable<TProjetion> Query<TProjetion>() where TProjetion : class
    {
        return this.Query()
            .ProjectTo<TProjetion>(this._mapper.ConfigurationProvider);
    }

    public void Dispose()
    {
        this.Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (this._disposed)
        {
            return;
        }

        if (disposing)
        {
            this._context?.Dispose();
        }

        this._disposed = true;
    }
}
