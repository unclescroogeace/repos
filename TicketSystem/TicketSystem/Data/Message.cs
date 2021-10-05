using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Data
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public int Type { get; set; }
        public string ImageUrl { get; set; } 
        public virtual Ticket Ticket { get; set; }
    }
}
