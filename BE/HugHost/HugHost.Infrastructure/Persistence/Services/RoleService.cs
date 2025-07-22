using System.Linq.Expressions;
using HugHost.Application.Common.Interfaces.Repositories;
using HugHost.Application.Common.Interfaces.Services;
using HugHost.Domain.Entities;

namespace HugHost.Infrastructure.Persistence.Services;

public class RoleService : IRoleService
{
    private readonly IGenericRepository<Role> _roleRepository;

    public RoleService(IGenericRepository<Role> roleRepository)
    {
        _roleRepository = roleRepository;
    }

    public async Task<Role?> GetRoleAsync(Expression<Func<Role, bool>> predicate)
    {
        return await _roleRepository.GetAsync(predicate);
    }

    public async Task<IReadOnlyList<Role?>?> GetRolesAsync(Expression<Func<Role, bool>> predicate)
    {
        return await _roleRepository.GetAllAsync(predicate);
    }

    public async Task<bool> AnyAsync(Expression<Func<Role, bool>> predicate)
    {
        return await _roleRepository.AnyAsync(predicate);
    }

    public async Task<Role> AddAsync(Role role)
    {
        await _roleRepository.AddAsync(role);

        await _roleRepository.SaveChangesAsync();

        return role;
    }

    public async Task<Role> UpdateAsync(Role role)
    {
        _roleRepository.Update(role);

        await _roleRepository.SaveChangesAsync();

        return role;
    }

    public async Task DeleteAsync(Role role)
    {
        _roleRepository.Delete(role);

        await _roleRepository.SaveChangesAsync();
    }
}