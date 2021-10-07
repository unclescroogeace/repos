using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustChatting.Data
{
    public interface IMessageService
    {
        Task<List<Message>> GetAllMessagesAsync();
        Task<Message> GetMessageAsync(int Id);
        Task<bool> CreateMessageAsync(Message message);
    }
}