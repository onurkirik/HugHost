using System.Linq.Expressions;
using HugHost.Application.Common.Interfaces.Repositories;
using HugHost.Application.Common.Interfaces.Services;
using HugHost.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace HugHost.Infrastructure.Persistence.Services;

public class UserService : IUserService
{
    private readonly IGenericRepository<User> _userRepository;
    private readonly UserManager<User> _userManager;

    public UserService(IGenericRepository<User> userRepository, UserManager<User> userManager)
    {
        _userRepository = userRepository;
        _userManager = userManager;
    }

    public async Task<User?> GetUserAsync(Expression<Func<User, bool>> predicate)
    {
        return await _userRepository.GetAsync(predicate);
    }

    public async Task<IReadOnlyList<User?>?> GetUsersAsync(Expression<Func<User, bool>> predicate)
    {
        return await _userRepository.GetAllAsync(predicate);
    }

    public async Task<bool> AnyAsync(Expression<Func<User, bool>> predicate)
    {
        return await _userRepository.AnyAsync(predicate);
    }

    public async Task<User> AddAsync(User user)
    {
        await _userManager.CreateAsync(user, "Qwq1234.");

        return user;
    }

    public async Task<User> UpdateAsync(User user)
    {
        await _userManager.UpdateAsync(user);
        
        await _userRepository.SaveChangesAsync();

        return user;
    }

    public async Task DeleteAsync(User user)
    {
        _userRepository.Delete(user);

        await _userRepository.SaveChangesAsync();
    }
}