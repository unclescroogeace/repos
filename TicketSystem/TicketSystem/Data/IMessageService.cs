using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Data
{
    public interface IMessageService
    {
        List<Message> GetAllMessages();
        Message GetMessage(int Id);
        Task<bool> CreateMessageAsync(Message message);
        bool CreateMessage(Message message);
    }
}
