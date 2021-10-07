using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustChatting.Data;

namespace JustChatting.Client.Models
{
    public class MessageClient : Message
    {
        public byte[] Image { get; set; }
    }
}
