using System.Linq.Expressions;

namespace HugHost.Application.Common.Interfaces.Repositories;

public interface IGenericRepository<T> where T : class
{
    Task<T?> GetAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);

    Task<IReadOnlyList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
        params Expression<Func<T, object>>[] includes);

    Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);

    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task SaveChangesAsync();
}