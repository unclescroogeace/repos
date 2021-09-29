using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Data
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public int Visibility { get; set; }
        public string RefersTo { get; set; }
        public string UserId { get; set; }
    }
}
