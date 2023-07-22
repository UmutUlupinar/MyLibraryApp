using System.Linq.Expressions;

namespace Book.Access.Repository.Abstract;

public interface IGenericRepository<T> where T : class 
{
    
    Task<T> GetByIdAsync(Guid id);

    
    Task AddAsync(T entity);
    T Update(T entity);
    void Remove(T entity);
    
    Task<IEnumerable<T>> Where(Expression<Func<T, bool>> predicate);
    Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate);
    
}