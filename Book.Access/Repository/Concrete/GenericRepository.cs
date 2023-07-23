using System.Linq.Expressions;
using Book.Access.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Book.Access.Repository.Concrete;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly Context _context;
    private readonly DbSet<T> _dbContext;

    public GenericRepository(Context context)
    {
        _context = context;
        _dbContext = context.Set<T>();
    }
    
    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _context.FindAsync<T>(id);
    }

    public async Task<EntityEntry<T>> AddAsync(T entity)
    {
        return await _context.AddAsync<T>(entity);
    }

    public EntityEntry<T> Update(T entity)
    {
        return _context.Update<T>(entity);
    }

    public EntityEntry<T> Remove(T entity)
    {
        return _context.Remove<T>(entity);
    }

    public async Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate)
    {
        return await _dbContext.Where(predicate).ToListAsync();
    }
    
    public Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
    {
        return _dbContext.SingleOrDefaultAsync(predicate);
    }
}