using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Book.Access.Repository.Abstract;

public interface IGenericRepository<T> where T : class 
{
    
    Task<T> GetByIdAsync(Guid id);

    
    Task<EntityEntry<T>> AddAsync(T entity);
    EntityEntry<T> Update(T entity);
    EntityEntry<T> Remove(T entity);
    
    
}