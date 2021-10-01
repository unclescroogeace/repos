using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Data
{
    public class MessageService : IMessageService
    {
        private readonly ApplicationDbContext _dbContext;
        public MessageService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Message GetMessage(int Id)
        {
            return _dbContext.Messages.FirstOrDefault(m => m.MessageId.Equals(Id));
        }
        public List<Message> GetAllMessages()
        {
            return _dbContext.Messages.ToList();
        }
    }
}
