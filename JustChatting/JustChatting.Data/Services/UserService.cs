using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChatting.Data
{
    public class UserService : IUserService
    {
        private readonly JustChattingDbContext _dbContext;
        public UserService(JustChattingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _dbContext.Users.ToListAsync();
        }
        public async Task<User> GetUserAsync(int Id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id.Equals(Id));
        }
        public async Task<bool> CreateUserAsync(User user)
        {
            await _dbContext.Users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}