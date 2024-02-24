﻿namespace Melodiy.Features.User;

using Melodiy.Features.Common.Context;
using Melodiy.Features.User.Entities;

using Microsoft.EntityFrameworkCore;

public sealed class UserRepository(MelodiyDbContext context) : IUserRepository
{
    private readonly DbSet<User> _users = context.Set<User>();

    public async Task AddAsync(string username, string password)
    {
        var user = new User
        {
            Username = username,
            Password = password,
        };

        _users.Add(user);
        await context.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(string username)
    {
        return await _users.AnyAsync(user => user.Username == username);
    }

    public async Task<User?> GetByIdAsync(int id)
    {
        return await _users.FirstOrDefaultAsync(user => user.Id == id);
    }

    public async Task UpdateAsync(User user)
    {
        throw new NotImplementedException();
    }
}
