using System.Linq.Expressions;
using HugHost.Domain.Entities;

namespace HugHost.Application.Common.Interfaces.Services;

public interface IRoleService
{
    Task<Role?> GetRoleAsync(Expression<Func<Role, bool>> predicate);
    Task<IReadOnlyList<Role?>?> GetRolesAsync(Expression<Func<Role, bool>> predicate);
    Task<bool> AnyAsync(Expression<Func<Role, bool>> predicate);
    Task<Role> AddAsync(Role role);
    Task<Role> UpdateAsync(Role role);
    Task DeleteAsync(Role role);
}