using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TicketSystem.Data
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext _dbContext;
        public UserService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<AspNetUser> GetUserAsync(string Id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id.Equals(Id));
        }
        public AspNetUser GetUser(string Id)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id.Equals(Id));
        }
    }
}
