using System.Linq.Expressions;
using HugHost.Application.Common.Interfaces.Repositories;
using HugHost.Application.Common.Interfaces.Services;
using HugHost.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace HugHost.Infrastructure.Persistence.Services;

public class UserService : IUserService
{
    private readonly IGenericRepository<User> _userRepository;

    public UserService(IGenericRepository<User> userRepository)
    {
        _userRepository = userRepository;
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

    public async Task AddAsync(User user)
    {
        await _userRepository.AddAsync(user);
    }

    public async Task UpdateAsync(User user)
    {
        var userToUpdate = new HugHost.Infrastructure.Identity.Entities.User
        {
            Id = user.Id,
            UserName = user.UserName,
            Email = user.Email,
            EmailConfirmed = true,
            FullName = user.FullName
        };

        _userRepository.Update(user);

        await _userRepository.SaveChangesAsync();
    }

    public async Task DeleteAsync(User user)
    {
        _userRepository.Delete(user);

        await _userRepository.SaveChangesAsync();
    }
}