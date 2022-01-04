using DataAccess.Model;
using System.Collections.Generic;

namespace ProjectManagementApp.Services
{
    public interface ITaskService
    {
        bool createTicket(Ticket ticket);
        Ticket Get(int id);
        List<Ticket> listOfTicketsForProject(int projectID);
        bool Upate(Ticket ticket);
        bool Delete(int ticketID);
    }
}
