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
        [Required(ErrorMessage = "Title is required")]
        [StringLength(256)]
        public string Title { get; set; }
        [StringLength(4096)]
        public string Content { get; set; }
        [StringLength(376)]
        public string ImageUrl { get; set; }
        public int Visibility { get; set; }
        [StringLength(128)]
        public string RefersTo { get; set; }
        [StringLength(128)]
        public string UserId { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
    }
}