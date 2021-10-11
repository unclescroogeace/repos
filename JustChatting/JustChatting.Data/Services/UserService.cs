using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChatting.Data
{
    public class UserService
    {
        //private readonly JustChattingDbContext _dbContext;
        //public UserService(JustChattingDbContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}
        //public async Task<List<User>> GetAllUsersAsync()
        //{
        //    return await _dbContext.Users.ToListAsync();
        //}
        //public async Task<User> GetUserAsync(int Id)
        //{
        //    return await _dbContext.Users.FirstOrDefaultAsync(u => u.Id.Equals(Id));
        //}
        //public async Task<bool> CreateUserAsync(User user)
        //{
        //    await _dbContext.Users.AddAsync(user);
        //    await _dbContext.SaveChangesAsync();
        //    return true;
        //}

        //public bool CreateUser(User user)
        //{
        //    _dbContext.Users.Add(user);
        //    if (_dbContext.SaveChanges() > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}

        private readonly JustChattingDbContext _dbContext;
        public UserService()
        {
            _dbContext = new JustChattingDbContext();
        }

        public bool CreateUser(User user)
        {
            _dbContext.Users.Add(user);
            if (_dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AuthenticateUser(string Username, string Password)
        {
            if(_dbContext.Users.FirstOrDefault(u => u.Username == Username && u.Password == Password) != null)
            {
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}