using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatWebApp.Models;

namespace ChatWebApp.Interfaces
{
    public interface IAuthRepository
    {
        public Task<User?> GetUserAsync(int userId);

        public Task<int?> CreateUserAsync(User user);

    }
}