using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustChatting.Data;

namespace JustChatting.Server.Models
{
    public class Message : Data.Message
    {
        public byte[] Image { get; set; }
    }
}
