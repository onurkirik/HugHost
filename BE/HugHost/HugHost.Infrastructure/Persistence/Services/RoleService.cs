using System.Linq.Expressions;
using HugHost.Application.Common.Interfaces.Repositories;
using HugHost.Application.Common.Interfaces.Services;
using HugHost.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace HugHost.Infrastructure.Persistence.Services;

public class RoleService : IRoleService
{
    private readonly IGenericRepository<Role> _roleRepository;
    private readonly RoleManager<Role> _roleManager;

    public RoleService(IGenericRepository<Role> roleRepository, RoleManager<Role> roleManager)
    {
        _roleRepository = roleRepository;
        _roleManager = roleManager;
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
        await _roleManager.CreateAsync(role);

        return role;
    }

    public async Task<Role> UpdateAsync(Role role)
    {
        await _roleManager.UpdateAsync(role);

        return role;
    }

    public async Task DeleteAsync(Role role)
    {
        await _roleManager.DeleteAsync(role);
    }
}