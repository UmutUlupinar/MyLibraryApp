using System.Linq.Expressions;
using Book.Access.Repository.Abstract;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Book.Access.Repository.Concrete;

public class GenericRepository<T> : IGenericRepository<T> where T : class
{
    private readonly Context _context;

    public GenericRepository(Context context)
    {
        _context = context;
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
    
    
}