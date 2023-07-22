using System.Linq.Expressions;
using Book.Access.Repository.Abstract;

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

    public Task AddAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public T Update(T entity)
    {
        throw new NotImplementedException();
    }

    public void Remove(T entity)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }

    public Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
    {
        throw new NotImplementedException();
    }
}