using System.Linq.Expressions;
using HugHost.Domain.Entities;

namespace HugHost.Application.Common.Interfaces.Services;

public interface IUserService
{
    Task<User?> GetUserAsync(Expression<Func<User, bool>> predicate);
    Task<IReadOnlyList<User?>?> GetUsersAsync(Expression<Func<User, bool>> predicate);
    Task<bool> AnyAsync(Expression<Func<User, bool>> predicate);
    Task<User> AddAsync(User user);
    Task<User> UpdateAsync(User user);
    Task DeleteAsync(User user);
}