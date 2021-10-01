using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystem.Data
{
    public class TicketService : ITicketService
    {
        private readonly ApplicationDbContext _dbContext;
        public TicketService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Ticket>> GetAllTicketsAsync()
        {
            return await _dbContext.Tickets.ToListAsync();
        }
        public async Task<Ticket> GetTicketAsync(int Id)
        {
            return await _dbContext.Tickets.FirstOrDefaultAsync(t => t.TicketId.Equals(Id));
        }
        public Ticket GetTicket(int Id)
        {
            return _dbContext.Tickets.FirstOrDefault(t => t.TicketId.Equals(Id));
        }
        public async Task<bool> CreateTicket(Ticket ticket)
        {
            await _dbContext.Tickets.AddAsync(ticket);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> UpdateTicket(Ticket ticket)
        {
            _dbContext.Tickets.Update(ticket);
            await _dbContext.SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteTicket(Ticket ticket)
        {
            _dbContext.Remove(ticket);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}