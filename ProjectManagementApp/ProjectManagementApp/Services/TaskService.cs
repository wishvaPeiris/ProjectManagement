using DataAccess;
using DataAccess.Model;
using System.Collections.Generic;

namespace ProjectManagementApp.Services
{
    public class TaskService : ITaskService
    {
        private readonly ApplicationDbContext _db;

        public TaskService(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool createTicket(Ticket ticket)
        {
            if (ticket != null)
            {
                _db.tickets.Add(ticket);
                _db.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Delete(int ticketID)
        {
            var dbTicket = _db.tickets.Find(ticketID);

            if (dbTicket != null)
            {
                _db.Remove(dbTicket);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public Ticket Get(int id)
        {
            return _db.tickets.Find(id);
        }

        public List<Ticket> listOfTicketsForProject(int projectID)
        {
            List<Ticket> list = new List<Ticket>();

            foreach (var ticket in _db.tickets)
            {
                if (ticket.projectId == projectID)
                {
                    list.Add(ticket);
                }
            }

            return list;
        }

        public bool Upate(Ticket ticket)
        {
            var dbTicket = _db.tickets.Find(ticket.ticketId);
            if (dbTicket != null)
            {
                dbTicket = ticket;
                _db.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
