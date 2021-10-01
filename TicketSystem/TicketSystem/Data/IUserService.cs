using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Data
{
    public interface IUserService
    {
        Task<AspNetUser> GetUserAsync(string Id);
        AspNetUser GetUser(string Id);
    }
}
