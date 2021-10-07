using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChatting.Data.Services
{
    class MessageService : IMessageService
    {
        private readonly JustChattingDbContext _dbContext;
        public MessageService(JustChattingDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Message>> GetAllMessagesAsync()
        {
            return await _dbContext.Messages.ToListAsync();
        }
        public async Task<Message> GetMessageAsync(int Id)
        {
            return await _dbContext.Messages.FirstOrDefaultAsync(m => m.Id.Equals(Id));
        }
        public async Task<bool> CreateMessageAsync(Message message)
        {
            await _dbContext.Messages.AddAsync(message);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}